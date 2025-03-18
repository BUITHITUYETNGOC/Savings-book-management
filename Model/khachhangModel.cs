using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace sotietkiem99
{
   [Serializable]
   public class khachhangModel
   {
      public khachhangModel()
      {

      }

      public khachhangModel(SqlDataReader reader)
      {
         
		try { this._id = (Int32)reader["id"]; } catch (Exception) { }
		try { this._ten = (String)reader["ten"]; } catch (Exception) { }
		try { this._ghichu = (String)reader["ghichu"]; } catch (Exception) { }
		try { this._ma = (String)reader["ma"]; } catch (Exception) { }
		try { this._ngaysinh = (String)reader["ngaysinh"]; } catch (Exception) { }
		try { this._thangsinh = (String)reader["thangsinh"]; } catch (Exception) { }
		try { this._namsinh = (String)reader["namsinh"]; } catch (Exception) { }
		try { this._ngaytao = (String)reader["ngaytao"]; } catch (Exception) { }
		try { this._dienthoai = (String)reader["dienthoai"]; } catch (Exception) { }
		try { this._diachi = (String)reader["diachi"]; } catch (Exception) { }
		try { this._email = (String)reader["email"]; } catch (Exception) { }
		try { this._gioitinh = (String)reader["gioitinh"]; } catch (Exception) { }
		try { this._cmnd = (String)reader["cmnd"]; } catch (Exception) { }
      }
      
	private Int32 _id;
	private String _ten;
	private String _ghichu;
	private String _ma;
	private String _ngaysinh;
	private String _thangsinh;
	private String _namsinh;
	private String _ngaytao;
	private String _dienthoai;
	private String _diachi;
	private String _email;
	private String _gioitinh;
	private String _cmnd;
      
	public Int32 id
	{
		get { return _id; }
		set { _id = value; }
	}
	public String ten
	{
		get { return _ten; }
		set { _ten = value; }
	}
	public String ghichu
	{
		get { return _ghichu; }
		set { _ghichu = value; }
	}
	public String ma
	{
		get { return _ma; }
		set { _ma = value; }
	}
	public String ngaysinh
	{
		get { return _ngaysinh; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_ngaysinh = value.Substring(0, 50);
			}
			else
			{
				_ngaysinh = value;
			}
		}
	}
	public String thangsinh
	{
		get { return _thangsinh; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_thangsinh = value.Substring(0, 50);
			}
			else
			{
				_thangsinh = value;
			}
		}
	}
	public String namsinh
	{
		get { return _namsinh; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 10)
			{
				_namsinh = value.Substring(0, 10);
			}
			else
			{
				_namsinh = value;
			}
		}
	}
	public String ngaytao
	{
		get { return _ngaytao; }
		set { _ngaytao = value; }
	}
	public String dienthoai
	{
		get { return _dienthoai; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_dienthoai = value.Substring(0, 50);
			}
			else
			{
				_dienthoai = value;
			}
		}
	}
	public String diachi
	{
		get { return _diachi; }
		set { _diachi = value; }
	}
	public String email
	{
		get { return _email; }
		set { _email = value; }
	}
	public String gioitinh
	{
		get { return _gioitinh; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_gioitinh = value.Substring(0, 50);
			}
			else
			{
				_gioitinh = value;
			}
		}
	}
	public String cmnd
	{
		get { return _cmnd; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_cmnd = value.Substring(0, 50);
			}
			else
			{
				_cmnd = value;
			}
		}
	}
   }
}