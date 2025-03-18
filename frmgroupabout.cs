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
    public partial class frmgroupabout : Form
    {
        public frmgroupabout()
        {
            InitializeComponent();
        }

        private void frmgroupabout_Load(object sender, EventArgs e)
        {
            textBox1.Text = "NHÓM P2HN - Đề Tài Quản Lí Sổ Tiết Kiệm" + Environment.NewLine +
                "Thành Viên Nhóm:" + Environment.NewLine +
                "Nguyễn Hoàng Bảo Vinh-2100005112 " + Environment.NewLine +
                "Văn Văn Hà-2100004750 " + Environment.NewLine +
                "Bùi Thị Tuyết Ngọc-2100009299" + Environment.NewLine +
                "Nguyễn Hoàng Châu-2100008134 ";
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
