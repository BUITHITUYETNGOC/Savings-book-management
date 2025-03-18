using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sotietkiem99
{
    public partial class frmdangnhap : Form
    {
        private frmmain frmmain;

        public frmdangnhap()
        {
            InitializeComponent();
        }

        public frmdangnhap(frmmain frmmain)
        {
            this.frmmain = frmmain;
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            DataAccess ac = new DataAccess();
            var kt = ac.kiemtra_dangnhap("nhanvien", txtten.Text.Trim(), MD5.MD5.GetMD5Hash(txtmatkhau.Text.Trim()), "ten", "matkhau");
            if (kt)
            {
                MessageBox.Show("Đăng nhập thành công");
                keycode.dangnhap = true;
                keycode.manv = ac.Lay_GiaTri_TuBang("nhanvien", "ten", txtten.Text, "id");
                keycode.quyennv = ac.Lay_GiaTri_TuBang("nhanvien", "ten", txtten.Text, "idchucvu");
                keycode.tennv = ac.Lay_GiaTri_TuBang("nhanvien", "ten", txtten.Text, "tenhienthi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin không đúng! Thử lại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
