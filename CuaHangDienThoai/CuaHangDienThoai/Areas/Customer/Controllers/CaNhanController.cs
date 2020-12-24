using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CuaHangDienThoai.Models;
using CuaHangDienThoai.Models.View;
using CuaHangDienThoai.Data;
using CuaHangDienThoai.Extensions;
using CuaHangDienThoai.Areas.Customer.Identity;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Http;

namespace CuaHangDienThoai.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CaNhanController : Controller
    {
        private readonly MobileContext _db;
        [BindProperty]
        public GioHangViewModel GioHangVM { get; set; }
        public CaNhanController(MobileContext db)
        {
            _db = db;
            GioHangVM = new GioHangViewModel()
            {
                DanhSachGH = new List<GioHang>(),
                DanhSachPost = new List<DanhSachPost>()
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThongTin()
        {
            if (HttpContext.Session.GetObject<DangNhap>("DangNhap") == null)
            {
                return RedirectToAction("Index", "DangNhap");
            }
            var khachHang = _db.KhachHang.Include(kh => kh.TaiKhoan).Where(kh => kh.MaKH == HttpContext.Session.GetObject<KhachHang>("DangNhap").MaKH).FirstOrDefault();
            return View(khachHang);
        }

        public IActionResult SuaThongTin()
        {
            if (HttpContext.Session.GetObject<DangNhap>("DangNhap") == null)
            {
                return RedirectToAction("Index", "DangNhap");
            }
            var khachHang = _db.KhachHang.Include(kh => kh.TaiKhoan).Where(kh => kh.MaKH == HttpContext.Session.GetObject<KhachHang>("DangNhap").MaKH).FirstOrDefault();
            khachHang.TaiKhoan.TenTK = "";
            khachHang.TaiKhoan.MatKhau = "";
            return View(khachHang);
        }

        [HttpPost, ActionName("SuaThongTin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaThongTin(KhachHang khachHang)
        {
            if (!ModelState.IsValid)
                return View(khachHang);
            var taiKhoan = _db.TaiKhoan.Where(tk => tk.MaKH == HttpContext.Session.GetObject<DangNhap>("DangNhap").MaKH).FirstOrDefault();
            if (taiKhoan.MaKH == khachHang.MaKH && taiKhoan.MatKhau == MD5.GetMD5(khachHang.TaiKhoan.MatKhau))
            {
                KhachHang khachHangFromDb = await _db.KhachHang.Where(kh => kh.MaKH == khachHang.MaKH).FirstOrDefaultAsync();
                khachHangFromDb.DiaChi = khachHang.DiaChi;
                khachHangFromDb.GioiTinh = khachHang.GioiTinh;
                khachHangFromDb.TenKH = khachHang.TenKH;
                khachHangFromDb.SoDienThoai = khachHang.SoDienThoai;                   
                //khachHang.TaiKhoan = null;
                //_db.KhachHang.Update(khachHang);
                await _db.SaveChangesAsync();
                TempData["SuaThongTin"] = "Sửa thông tin thành công";
                return RedirectToAction("ThongTin");
            }
            TempData["SuaThongTin"] = "Sai mật khẩu";
            return View(khachHang);
        }

        public IActionResult SuaTaiKhoan()
        {
            if (HttpContext.Session.GetObject<DangNhap>("DangNhap") == null)
            {
                return RedirectToAction("Index", "DangNhap");
            }
            var suaTaiKhoan = new SuaTaiKhoanViewModel()
            {
                TenTaiKhoan = _db.TaiKhoan.Where(tk => tk.MaKH == HttpContext.Session.GetObject<DangNhap>("DangNhap").MaKH).FirstOrDefault().TenTK
            };
            return View(suaTaiKhoan);
        }

        [HttpPost, ActionName("SuaTaiKhoan")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaTaiKhoan(SuaTaiKhoanViewModel suaTaiKhoan)
        {
            if (!ModelState.IsValid)
                return View(suaTaiKhoan);
            if(suaTaiKhoan.MatKhauMoi.Length<6 || suaTaiKhoan.MatKhauMoi.Length>20)
            {
                TempData["SuaTaiKhoan"] = "Vui lòng nhập mật khẩu từ 6-20 ký tự";
                return View(suaTaiKhoan);
            }
            var taiKhoan = _db.TaiKhoan.Where(tk => tk.MaKH == HttpContext.Session.GetObject<DangNhap>("DangNhap").MaKH).FirstOrDefault();
            if (taiKhoan.TenTK == suaTaiKhoan.TenTaiKhoan && taiKhoan.MatKhau == MD5.GetMD5(suaTaiKhoan.MatKhau))
            {
                taiKhoan.MatKhau = MD5.GetMD5(suaTaiKhoan.MatKhauMoi);
                _db.TaiKhoan.Update(taiKhoan);
                await _db.SaveChangesAsync();
                TempData["SuaTaiKhoan"] = "Đổi mật khẩu thành công";
                return RedirectToAction("ThongTin");
            }
            TempData["SuaTaiKhoan"] = "Sai mật khẩu";
            return View(suaTaiKhoan);
        }
    }
}
