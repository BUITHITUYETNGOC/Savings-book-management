using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace sotietkiem99
{
    internal class DataAccess
    {
        #region bien
        SqlCommand sqlCmd;
        public static string chuoi = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection cn;
        public static DataAccess ac = new DataAccess();
        public static DataTable dt = new DataTable();
        #endregion  
        public SqlConnection getConnect()
        {
            cn = new SqlConnection(chuoi);
            cn.Open();
            return cn;
        }

        #region GetDataTable 
        public DataTable GetDataTable_Text(string query)
        {
            try
            {
                getConnect();
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = query;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = cn;
                SqlDataAdapter dapter = new SqlDataAdapter(sqlCmd);
                dapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
                sqlCmd.Dispose();
            }
        }
        public DataTable GetDataTable_Store(string query)
        {
            try
            {
                getConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                DataTable result = new DataTable();
                SqlDataAdapter dapter = new SqlDataAdapter(cmd);

                dapter.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();

            }
        }
        public DataTable GetDataTable_Store_Paramater(string TenStoreProcedure, SqlParameter[] sqlParam)
        {
            DataTable result = new DataTable();// tao thang nay
            try
            {
                getConnect();
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = cn;
                sqlCmd.CommandText = TenStoreProcedure;
                for (int i = 0; i < sqlParam.Length; i++)
                {
                    sqlCmd.Parameters.Add(sqlParam[i]);
                }

                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = sqlCmd;
                sqlDA.Fill(result);
                return result;// tra ket qua ve day
            }
            catch (SqlException ex)
            {
                return result;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }

        }
        #endregion
        #region CHAY SQL 
        public void ExecuteCommandtext(string sql)
        {
            getConnect();
            sqlCmd = new SqlCommand(sql, cn);
            sqlCmd.ExecuteNonQuery();
            cn.Close();
        }
        public string ExecuteScalar(string sql)
        {
            getConnect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            string kq = cmd.ExecuteScalar().ToString();
            cn.Close();
            cmd.Dispose();
            return kq;
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            getConnect();
            sqlCmd = new SqlCommand(sql, cn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            cn.Close();
            sqlCmd.Dispose();
            return dr;
        }
        #endregion


        #region LOAD DATATABLE THEO MÃ
        public DataTable Load_Theo_ma(string tenstore, string ma1)
        {
            SqlParameter[] para = {
                                  new SqlParameter("@ma1", ma1)
                              };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, int ma1)
        {
            SqlParameter[] para = {
                                  new SqlParameter("@ma1", ma1)
                              };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, int ma1, int ma2)
        {
            SqlParameter[] para = {
                                  new SqlParameter("@ma1", ma1),
                                  new SqlParameter("@ma2", ma2)
                              };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, int ma1, string ma2)
        {
            SqlParameter[] para = {
                                  new SqlParameter("@ma1", ma1),
                                  new SqlParameter("@ma2", ma2)
                              };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, string ma1, string ma2)
        {
            SqlParameter[] para = {
                                  new SqlParameter("@ma1", ma1),
                                  new SqlParameter("@ma2", ma2)
                              };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, string ma1, string ma2, string ma3)
        {
            SqlParameter[] para = {
                                  new SqlParameter("@ma1", ma1),
                                  new SqlParameter("@ma2", ma2),
                                  new SqlParameter("@ma3", ma3)
                              };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }

        #endregion

        #region CAC HAM CO BAN KHAC
        public Boolean kiemtra_dangnhap(string tenbang, string user, string pass, string tb_user, string tb_pass)
        {
            getConnect();
            int c = 0;
            string sql = "select count(*) from " + tenbang + " where " + tb_user + "= '" + user + "' and " + tb_pass + " = '" + pass + "' ";
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sql;
                sqlCmd.Connection = cn;
                c = (int)sqlCmd.ExecuteScalar();
                // cn.Close();
                //sqlCmd.Dispose();
            }

            catch
            {
                return false;
            }
            return (c != 0);
        }

        public Boolean OKBABY(string tenbang, string user, string pass, string tb_user, string tb_pass)
        {
            getConnect();
            int c = 0;
            string sql = "select count(*) from " + tenbang + " where " + tb_user + "= '" + user + "' and trangthai = 'HOẠT ĐỘNG' ";
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sql;
                sqlCmd.Connection = cn;
                c = (int)sqlCmd.ExecuteScalar();
                // cn.Close();
                //sqlCmd.Dispose();
            }

            catch
            {
                return false;
            }
            return (c != 0);
        }

        public Boolean check_tontai(string tenbang, string tentruong, string giatri)
        {
            getConnect();
            int c = 0;
            string sql = "select count(*) from " + tenbang + " where " + tentruong + " = '" + giatri + "' ";
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sql;
                sqlCmd.Connection = cn;
                c = (int)sqlCmd.ExecuteScalar();
                cn.Close();
                sqlCmd.Dispose();
            }

            catch
            {
                return false;
            }
            finally
            {
                cn.Close();
                sqlCmd.Dispose();
            }

            return (c != 0);
        }

        public static bool IsNumeric(string value)
        {
            decimal result = 0;
            return decimal.TryParse(value, out result);
        }
        //Hàm kiểm tra khoá trùng
        public bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, cn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public string Lay_GiaTri_TuBang(string tenbang, string tentruong, string giatri, string cotcanlay)
        {
            getConnect();
            //*************** code here for all ****************************//
            string finddata = "select * from " + tenbang + " WHERE " + tentruong + " = '" + giatri + "'";
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = cn;
            sqlCmd.CommandText = finddata;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(finddata, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string kq;
            kq = ds.Tables[0].Rows[0][cotcanlay].ToString();
            //sqlCmd.Dispose();
            // cn.Close();
            return kq;
        }
        public void loadCombobox(DataTable dt, ComboBox cbo, string ma, string ten)
        {
            cbo.DataSource = dt;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        #endregion 
    }
}
