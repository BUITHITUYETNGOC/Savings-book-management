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
    public partial class frmappabout : Form
    {
        public frmappabout()
        {
            InitializeComponent();
        }

        private void frmappabout_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ứng dụng quản lý sổ tiết kiệm là một phần mềm Windows Forms được thiết kế để hỗ trợ các tổ chức tài chính quản lý hiệu quả các giao dịch liên quan đến sổ tiết kiệm. Với giao diện thân thiện và dễ sử dụng, ứng dụng giúp quản lý thông tin nhân viên, khách hàng và sổ tiết kiệm một cách hệ thống và chuyên nghiệp.\r\n\r\nCác chức năng chính của ứng dụng bao gồm: Quản lý thông tin nhân viên, cho phép thêm mới, sửa đổi và xóa thông tin nhân viên như họ tên, mã nhân viên, chức vụ và quyền hạn. Quản lý thông tin sổ tiết kiệm, bao gồm việc thêm mới, sửa đổi và xóa thông tin sổ tiết kiệm. Quản lý thông tin khách hàng, với khả năng thêm, sửa và xóa thông tin khách hàng, giúp duy trì cơ sở dữ liệu khách hàng chi tiết và chính xác. Ứng dụng còn hỗ trợ mở sổ tiết kiệm mới cho khách hàng, rút sổ tiết kiệm khi khách hàng có nhu cầu, và cung cấp các báo cáo chi tiết về tình trạng và hoạt động của các sổ tiết kiệm.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
