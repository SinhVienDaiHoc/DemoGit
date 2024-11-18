using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHACNHOUONGNUOC
{
    internal class NguoiDung
    {
        private string ten;
        private int tuoi;
        private double canNang;
        private double chieuCao;
        private double litNuoc;
        private DateTime thoiGian;
        private double luongNuocDaUong;

        public NguoiDung()
        {
            this.ten = null;
            this.tuoi = 0;
            this.canNang = 0.0;
            this.chieuCao = 0.0;
            this.litNuoc = 0.0;
            thoiGian = DateTime.Now;
            this.luongNuocDaUong = 0.0;

        }
        public NguoiDung(string ten, int tuoi, double canNang, double chieuCao, double litNuoc, double luongNuocDaUong)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.canNang = canNang;
            this.chieuCao = chieuCao;
            this.litNuoc = litNuoc;
            this.thoiGian = DateTime.Now;
            this.luongNuocDaUong = luongNuocDaUong;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double CanNang { get => canNang; set => canNang = value; }
        public double ChieuCao { get => chieuCao; set => chieuCao = value; }
        public double LitNuoc { get => LitNuoc; set => LitNuoc = value; }
        public DateTime DateTime { get => DateTime.Now; set => DateTime = value; }
        public double LuongNuocDaUong { get => luongNuocDaUong; set => luongNuocDaUong = value; }
        public string NhacNhoUongNuoc()
        {
            if (luongNuocDaUong < litNuoc)
            {
                double conThieu = litNuoc - luongNuocDaUong;
                return $"Bạn cần uống thêm {conThieu} lít nước để đạt mục tiêu hôm nay!";
            }
            else
            {
                return "Chúc mừng! Bạn đã uống đủ lượng nước cần thiết trong ngày.";
            }
        }

    }
}
