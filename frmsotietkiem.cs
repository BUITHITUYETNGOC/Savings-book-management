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
    public partial class frmsotietkiem : Form
    {
        public frmsotietkiem()
        {
            InitializeComponent();
        }
        #region CAC NUT 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            xoa();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            luu();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            load(null);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void btnExcelX_Click(object sender, EventArgs e)
        {
            export_excel();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            txtid.Text = "0";
        }
        #endregion
        #region KO CAN SUA 
        private void load(object source, String message)
        {
            load(source);
            labelMessage.Text = message;
        }
        private void clear()
        {
            txtid.Text = "0";
        }
        protected void labelMessage_PreRender(object sender, EventArgs e)
        {
            string start = "Thông báo: ";
            if (!String.IsNullOrEmpty(labelMessage.Text) && !labelMessage.Text.StartsWith(start))
            {
                labelMessage.Text = start + labelMessage.Text;
            }
        }
        #endregion
        #region Excel
        Excels exec = new Excels();
        public void export_excel()
        {
            var dt = loaddata();
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                var chuoi = f.FileName;
                var ten = this.Text;
                labelMessage.Text = chuoi;
                labelMessage.Text = exec.Exports(dt, labelMessage.Text, ten);
            }
            else
            {
                labelMessage.Text = "Không thực hiện được!";
            }
        }
        public DataTable loaddata()
        {
            DataTable dt = new DataTable();
            //Adding the Columns.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dt;
        }
        #endregion
        #region HAM CO BAN 
        private void load(object source)
        {
            try
            {
                if (source == null)
                {
                    source = sotietkiemDAO.selectAll();
                }
                dataGridView1.DataSource = source;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                labelMessage.Text = "Hiển thị database!";
                loadcombobox();
            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message;
            }
        }
        public void xoa()
        {
            try
            {
                if (int.Parse(txtid.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo!", MessageBoxButtons.OK);
                    labelMessage.Text = "Chưa chọn dữ liệu.";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hết dữ liệu không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int count = sotietkiemDAO.deleteByid(Convert.ToInt32(txtid.Text));
                        if (count > 0)
                        {
                            labelMessage.Text = count + "  được xóa!";
                            load(sotietkiemDAO.selectAll(), labelMessage.Text);
                        }
                        else
                        {
                            labelMessage.Text = "Lỗi!";
                        }
                    }
                    else
                    {
                        txtid.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message;
            }
        }
        private void search()
        {
            try
            {
                var list = sotietkiemDAO.search(textSearch.Text);
                load(list, "Tìm kiếm với từ khóa \"" + textSearch.Text + "\"");
            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message;
            }
        }
        private void frm_Load(object sender, EventArgs e)
        {
            load(null);
        }
        public void luu()
        {
            try
            {
                sotietkiemModel doituong = new sotietkiemModel();
                doituong.id = Convert.ToInt32(txtid.Text.Trim());
                doituong.sothe = Convert.ToString(sothe.Text.Trim());
                doituong.gio = Convert.ToString(DateTime.Now.ToString());
               
                doituong.ngay = Convert.ToString(ngay.Text.Trim());
                doituong.thang = Convert.ToString(thang.Text.Trim());
                doituong.nam = Convert.ToString(nam.Text.Trim());

                doituong.tiengui = Convert.ToDouble(tiengui.Text);
                doituong.laixuat = Convert.ToDouble(laixuat.Text.Trim());
                doituong.thanhtien = Convert.ToDouble(thanhtien.Text.Trim());
                doituong.trangthai = Convert.ToString(trangthai.Text.Trim());
                doituong.idkyhan = Convert.ToInt32(idkyhan.SelectedValue.ToString());
                doituong.ngaylay = Convert.ToString(ngaylay.Text.Trim());
                doituong.thanglay = Convert.ToString(thanglay.Text.Trim());
                doituong.namlay = Convert.ToString(namlay.Text.Trim());
                doituong.giolay = DateTime.Now.ToString();
                doituong.idnhanvientao = Convert.ToInt32(idnhanvientao.SelectedValue.ToString());
                doituong.sothanggui = Convert.ToInt32(sothanggui.Text.Trim());
                doituong.idkhach = Convert.ToInt32(idkhach.SelectedValue.ToString());
               

                int count = sotietkiemDAO.insertOrUpdate(doituong);
                if (count > 0)
                {
                    labelMessage.Text = count + " data được cập nhật!";
                    load(sotietkiemDAO.selectAll(), labelMessage.Text);
                }
                else
                {
                    labelMessage.Text = "Lỗi!";
                }
            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message;

            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    txtid.Text = row.Cells[0].Value.ToString();
                    sothe.Text = row.Cells[1].Value.ToString();
                    gio.Text = row.Cells[2].Value.ToString();                    
                    ngay.Text = row.Cells[3].Value.ToString();
                    thang.Text = row.Cells[4].Value.ToString();
                    nam.Text = row.Cells[5].Value.ToString();
                    tiengui.Text = row.Cells[6].Value.ToString();
                    laixuat.Text = row.Cells[7].Value.ToString();
                    thanhtien.Text = row.Cells[8].Value.ToString();
                    trangthai.Text = row.Cells[9].Value.ToString();
                    idkyhan.SelectedValue = int.Parse(row.Cells[10].Value.ToString());
                    ngaylay.Text = row.Cells[11].Value.ToString();
                    thanglay.Text = row.Cells[12].Value.ToString();
                    namlay.Text = row.Cells[13].Value.ToString();
                    giolay.Text = row.Cells[14].Value.ToString();
                    idnhanvientao.SelectedValue = int.Parse(row.Cells[15].Value.ToString());
                    sothanggui.Text = row.Cells[16].Value.ToString();
                    idkhach.SelectedValue = int.Parse(row.Cells[17].Value.ToString());



                }
            }
            catch (Exception EXX)
            {
                labelMessage.Text = "load Gridview loi~";
            }
        }
        public void loadcombobox()
        {
            var dt = khachhangDAO.selectAll();
            idkhach.DataSource = dt;
            idkhach.DisplayMember = "ten";
            idkhach.ValueMember = "id";
            idkhach.SelectedItem = 0;
            //// khach
            var dtkhach = kyhanDAO.selectAll();
            idkyhan.DataSource = dtkhach;
            idkyhan.DisplayMember = "ten";
            idkyhan.ValueMember = "id";
            idkyhan.SelectedItem = 0;
            //// nhan vien
            //ngayvaos.Text = DateTime.Now.ToString();
            //giothanhtoans.Text = DateTime.Now.ToString();
            var idnhanvi = nhanvienDAO.selectAll();
            idnhanvientao.DataSource = idnhanvi;
            idnhanvientao.DisplayMember = "ten";
            idnhanvientao.ValueMember = "id";
            idnhanvientao.SelectedItem = 0;

            gio.Text = DateTime.Now.ToString();
            giolay.Text = DateTime.Now.ToString();
            ngay.Text= DateTime.Now.Day.ToString();
            thang.Text = DateTime.Now.Month.ToString();
            nam.Text = DateTime.Now.Year.ToString();

            ngaylay.Text = DateTime.Now.Day.ToString();
         //   thanglay.Text = DateTime.Now.Month.ToString();
            namlay.Text = DateTime.Now.Year.ToString();


        }

        #endregion
        DataAccess ac = new DataAccess();
        private void idkyhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // khi click vao ky han thi lay so thang cho vao textbox
            try
            {
                var tsothang = ac.Lay_GiaTri_TuBang("kyhan", "id", idkyhan.SelectedValue.ToString(), "sothang");
                sothanggui.Text = tsothang;
                var tlaixuat= ac.Lay_GiaTri_TuBang("kyhan", "id", idkyhan.SelectedValue.ToString(), "laixuat");
                laixuat.Text = tlaixuat;
                // nhay ngay gui
                thanglay.Text = DateTime.Now.AddMonths(int.Parse(tsothang)).Month.ToString();

            }
            catch (Exception ex)
            {
                labelMessage.Text = "Load combobox"+ ex.ToString();
                //throw;
            }
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            double tienlai = float.Parse(tiengui.Text) * float.Parse(laixuat.Text) * float.Parse(sothanggui.Text);
            thanhtien.Text = tienlai.ToString();

        }
    }
}
