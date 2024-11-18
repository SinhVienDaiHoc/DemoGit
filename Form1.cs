using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHACNHOUONGNUOC
{
    public partial class Form1 : Form
    {
        private Timer nhacNhoTimer;
        private NguoiDung user;
        public Form1()
        {

            InitializeComponent();
            user = new NguoiDung("Nguyen Van A", 25, 60, 170, 2.0,3.0);
            nhacNhoTimer = new Timer
            {
                Interval = 3600000 // 1 giờ = 3600000 ms
            };
            nhacNhoTimer.Tick += NhacNhoTimer_Tick;
            nhacNhoTimer.Start();
        }

        private void NhacNhoTimer_Tick(object sender, EventArgs e)
        {
            // Gọi hàm nhắc nhở từ class NguoiDung
            string thongBao = user.NhacNhoUongNuoc();
            MessageBox.Show(thongBao, "Nhắc nhở uống nước", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUongNuoc_Click(object sender, EventArgs e)
        {
            // Cập nhật lượng nước đã uống khi người dùng nhấn nút "Đã uống nước"
            user.LuongNuocDaUong += 0.25; // Ví dụ mỗi lần uống 250ml
            MessageBox.Show("Bạn vừa uống 0.25 lít nước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
