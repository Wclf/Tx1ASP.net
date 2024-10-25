using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KT1_BuiQuangThang_2021600262.Models
{
    public class Nhanvien
    {
        public string manv { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public int songaylam { get; set; }  
        public int luongngay { get; set; }
        public int tienluong { get; set; }

        public Nhanvien()
        {

        }
        public Nhanvien(string manv, string hoten, string diachi, int songaylam, int luongngay, int tienluong)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.songaylam = songaylam;
            this.luongngay = luongngay;
            this.tienluong = tienluong;
        }
    }
}