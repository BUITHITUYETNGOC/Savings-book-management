﻿using System;
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
    public partial class frmchucvu : Form
    {
        public frmchucvu()
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
                    source = chucvuDAO.selectAll();
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
                        int count = chucvuDAO.deleteByid(Convert.ToInt32(txtid.Text));
                        if (count > 0)
                        {
                            labelMessage.Text = count + "  được xóa!";
                            load(chucvuDAO.selectAll(), labelMessage.Text);
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
                var list = chucvuDAO.search(textSearch.Text);
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
                chucvuModel doituong = new chucvuModel();
                doituong.id = Convert.ToInt32(txtid.Text.Trim());
                doituong.ten = Convert.ToString(txtten.Text.Trim());
             //   doituong.ghichu = Convert.ToString(txtghichu.Text.Trim());

                int count = chucvuDAO.insertOrUpdate(doituong);
                if (count > 0)
                {
                    labelMessage.Text = count + " data được cập nhật!";
                    load(chucvuDAO.selectAll(), labelMessage.Text);
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
                    txtten.Text = row.Cells[1].Value.ToString();
                  //  txtghichu.Text = row.Cells[2].Value.ToString();

                }
            }
            catch (Exception EXX)
            {
                labelMessage.Text = "load Gridview loi~";
            }
        }
        public void loadcombobox()
        {
            //var dt = banDAO.selectAll();
            //cbban.DataSource = dt;
            //cbban.DisplayMember = "ten";
            //cbban.ValueMember = "id";
            //cbban.SelectedItem = 0;
            //// khach
            //var dtkhach = khachhangDAO.selectAll();
            //cbkhach.DataSource = dtkhach;
            //cbkhach.DisplayMember = "ten";
            //cbkhach.ValueMember = "id";
            //cbkhach.SelectedItem = 0;
            //// nhan vien
            //ngayvaos.Text = DateTime.Now.ToString();
            //giothanhtoans.Text = DateTime.Now.ToString();

        }

        #endregion

        private void btnTim_Click(object sender, EventArgs e)
        {
            search();
        }


    }
}
