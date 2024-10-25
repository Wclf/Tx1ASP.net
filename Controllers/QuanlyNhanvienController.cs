using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KT1_BuiQuangThang_2021600262.Models;

namespace KT1_BuiQuangThang_2021600262.Controllers
{
    public class QuanlyNhanvienController : Controller
    {
        // GET: QuanlyNhanvien



        public ActionResult Index()
        {
            return View();
        }

        //List<Nhanvien> danhsach = new List<Nhanvien>();

        public ActionResult xuatList(FormCollection f)
        {
            if(Session["danhsach"]== null)
            {
                Session["danhsach"] = new List<Nhanvien>
                {
                new Nhanvien("Nv01", "Nguyen Van Anh", "Ha Noi", 15, 200000, 15 * 200000),
                new Nhanvien("Nv02", "Le Thu Ha", "Hai Phong", 27, 250000, 27 * 250000),
                new Nhanvien("Nv03", "Nguyen Van Hoang", "Ha Noi", 18, 250000, 18 * 250000),
                new Nhanvien("Nv04", "Tran Thu Huong", "Hai Phong", 25, 190000, 25 * 190000),
                new Nhanvien("Nv05", "Ngo Phuong Thao", "Quang Ninh", 20, 180000, 20 * 180000)
            };
            }

        var danhsach = (List<Nhanvien>)Session["danhsach"];

            try
            {
                Nhanvien n = new Nhanvien
                {
                    manv = f["manv"],
                    hoten = f["hoten"],
                    diachi = f["ddldiachi"],
                    songaylam = int.Parse(f["songaylam"]),
                    luongngay = int.Parse(f["luongngay"]),
                    tienluong = int.Parse(f["songaylam"]) * int.Parse(f["luongngay"])
                };
                danhsach.Add(n);


            }
            catch
            {

            }
            Session["danhsach"] = danhsach;
            return View(danhsach);
        }

        public ActionResult Nhap()
        {

            return View();
        }

    }
}