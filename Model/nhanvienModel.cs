using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace sotietkiem99
{
   [Serializable]
   public class nhanvienModel
   {
      public nhanvienModel()
      {

      }

      public nhanvienModel(SqlDataReader reader)
      {
         
		try { this._id = (Int32)reader["id"]; } catch (Exception) { }
		try { this._ten = (String)reader["ten"]; } catch (Exception) { }
		try { this._matkhau = (String)reader["matkhau"]; } catch (Exception) { }
		try { this._tenhienthi = (String)reader["tenhienthi"]; } catch (Exception) { }
		try { this._idchucvu = (Int32)reader["idchucvu"]; } catch (Exception) { }
      }
      
	private Int32 _id;
	private String _ten;
	private String _matkhau;
	private String _tenhienthi;
	private Int32 _idchucvu;
      
	public Int32 id
	{
		get { return _id; }
		set { _id = value; }
	}
	public String ten
	{
		get { return _ten; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_ten = value.Substring(0, 50);
			}
			else
			{
				_ten = value;
			}
		}
	}
	public String matkhau
	{
		get { return _matkhau; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_matkhau = value.Substring(0, 50);
			}
			else
			{
				_matkhau = value;
			}
		}
	}
	public String tenhienthi
	{
		get { return _tenhienthi; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_tenhienthi = value.Substring(0, 50);
			}
			else
			{
				_tenhienthi = value;
			}
		}
	}
	public Int32 idchucvu
	{
		get { return _idchucvu; }
		set { _idchucvu = value; }
	}
   }
}