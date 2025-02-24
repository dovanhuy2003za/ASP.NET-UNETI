using btTuan1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace btTuan1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            string ketQua=" ";

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                ketQua = $"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0 có 2 nghiệm phân biệt x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                ketQua = $"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0 có 1 nghiệm kép x1 = x2 = {x}";
            }
            else
            {
                ketQua = $"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0 vô nghiệm";
            }

            ViewBag.KetQua = ketQua;
            return View();
        }

        public IActionResult Ucln(int a, int b)
        {
            int TimUcln(int x, int y)
            {
                while (y != 0)
                {
                    int temp = y;
                    y = x % y;
                    x = temp;
                }
                return x;
            }

            int ucln = TimUcln(a, b);
            ViewBag.KetQua = $"UCLN của {a} và {b} là {ucln}";
            return View();
        }

        public IActionResult SoNgayTrongThang(int thang, int nam)
        {
            int soNgay = DateTime.DaysInMonth(nam, thang);
            ViewBag.KetQua = $"Tháng {thang} năm {nam} có {soNgay} ngày";
            return View();
        }

        public IActionResult TongSoNguyenTo(string mang)
        {
            bool LaSoNguyenTo(int so)
            {
                if (so <= 1) return false;
                if (so == 2) return true;
                if (so % 2 == 0) return false;
                for (int i = 3; i <= Math.Sqrt(so); i += 2)
                {
                    if (so % i == 0) return false;
                }
                return true;
            }

            int[] numbers = mang.Split(',').Select(int.Parse).ToArray();
            int tong = numbers.Where(LaSoNguyenTo).Sum();
            ViewBag.KetQua = $"Tổng các phần tử của mảng là số nguyên tố: {tong}";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
