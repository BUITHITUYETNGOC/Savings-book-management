using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace sotietkiem99
{
    public partial class frmmain : Form
    {
        bool isThoat = true;
        public frmmain()
        {
            InitializeComponent();
        }
        public static string quyen;

        private void frmmain_Load(object sender, EventArgs e)
        {
            
            lbltenhienthi.Text = keycode.tennv;
          

            if (keycode.dangnhap)
            {
                if (Convert.ToInt32(keycode.quyennv) == 1)
                {
                   
                    dỊCHVỤToolStripMenuItem.Visible = false ;
                    
                }
                else if (Convert.ToInt32(keycode.quyennv) == 2)
                {
                    
                    mnnhanvien.Visible = false;
                    mnkhachhang.Visible = false;
                    mnchucvu.Visible = false;
                    mnbaocao.Visible = false;
                }

                lbltenhienthi.Text = keycode.dangnhap ? $"Xin chào {keycode.tennv}" : "";
            }
           
        } 
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Hide();
            frmdangnhap frmdangnhap = new frmdangnhap();
            frmdangnhap.Show();
            

        }
        frmdangnhap frmdangnhap;
        frmchucvu frmchucvu;
        frmkyhan frmkyhan;
        frmkhachhang frmkhachhang;
        frmnhanvien frmnhanvien;
        frmsotietkiem frmsotietkiem;

        private void mnchucvu_Click(object sender, EventArgs e)
        {
            if (frmchucvu == null)
            {
                frmchucvu = new frmchucvu();
                frmchucvu.MdiParent = this;
                frmchucvu.FormClosed += new FormClosedEventHandler(frmchucvu_FormClosed);
                frmchucvu.Show();
            }
            else
            {
                frmchucvu.Activate();
            }
        }
        void frmchucvu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmchucvu = null;
        }

        private void mnkyhan_Click(object sender, EventArgs e)
        {
            if (frmkyhan == null)
            {
                frmkyhan = new frmkyhan();
                frmkyhan.MdiParent = this;
                frmkyhan.FormClosed += new FormClosedEventHandler(frmkyhan_FormClosed);
                frmkyhan.Show();
            }
            else
            {
                frmkyhan.Activate();
            }
        }
        void frmkyhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmkyhan = null;
        }

        private void mnkhachhang_Click(object sender, EventArgs e)
        {
            if (frmkhachhang == null)
            {
                frmkhachhang = new frmkhachhang();
                frmkhachhang.MdiParent = this;
                frmkhachhang.FormClosed += new FormClosedEventHandler(frmkhachhang_FormClosed);
                frmkhachhang.Show();
            }
            else
            {
                frmkhachhang.Activate();
            }
        }
        void frmkhachhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmkhachhang = null;
        }

        private void mnnhanvien_Click(object sender, EventArgs e)
        {
            if (frmnhanvien == null)
            {
                frmnhanvien = new frmnhanvien();
                frmnhanvien.MdiParent = this;
                frmnhanvien.FormClosed += new FormClosedEventHandler(frmnhanvien_FormClosed);
                frmnhanvien.Show();
            }
            else
            {
                frmnhanvien.Activate();
            }
        }
        void frmnhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmnhanvien = null;
        
    }

        private void mnsotietkiem_Click(object sender, EventArgs e)
        {
            if (frmsotietkiem == null)
            {
                frmsotietkiem = new frmsotietkiem();
                frmsotietkiem.MdiParent = this;
                frmsotietkiem.FormClosed += new FormClosedEventHandler(frmsotietkiem_FormClosed);
                frmsotietkiem.Show();
            }
            else
            {
                frmsotietkiem.Activate();
            }
        }
        void frmsotietkiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmsotietkiem = null;
        }
        frmbaocao frmbaocao;
        private void mnbaocao_Click(object sender, EventArgs e)
        {
            if (frmbaocao == null)
            {
                frmbaocao = new frmbaocao();
                frmbaocao.MdiParent = this;
                frmbaocao.FormClosed += new FormClosedEventHandler(frmbaocao_FormClosed);
                frmbaocao.Show();
            }
            else
            {
                frmbaocao.Activate();
            }
        }
        void frmbaocao_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmbaocao = null;
        }

        private void dỊCHVỤToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isThoat)
            Application.Exit();
        }

        private void groupAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgroupabout frmgrab = new frmgroupabout();
            frmgrab.Show();
        }

        private void appAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmappabout frmappab = new frmappabout();
            frmappab.Show();    
        }

        private void mnlogout_Click(object sender, EventArgs e)
        {

            frmdangnhap frmdangnhap = new frmdangnhap();
            frmdangnhap.Show();
        }

        private void mndanhmuc_Click(object sender, EventArgs e)
        {

        }
    }
    
}
