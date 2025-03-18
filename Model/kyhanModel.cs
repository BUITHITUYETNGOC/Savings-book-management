using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace sotietkiem99
{
   [Serializable]
   public class kyhanModel
   {
      public kyhanModel()
      {

      }

      public kyhanModel(SqlDataReader reader)
      {
         
		try { this._id = (Int32)reader["id"]; } catch (Exception) { }
		try { this._ten = (String)reader["ten"]; } catch (Exception) { }
		try { this._ghichu = (String)reader["ghichu"]; } catch (Exception) { }
		try { this._laixuat = (Double)reader["laixuat"]; } catch (Exception) { }
		try { this._sothang = (Int32)reader["sothang"]; } catch (Exception) { }
		try { this._ngay = (String)reader["ngay"]; } catch (Exception) { }
		try { this._thang = (String)reader["thang"]; } catch (Exception) { }
		try { this._nam = (String)reader["nam"]; } catch (Exception) { }
      }
      
	private Int32 _id;
	private String _ten;
	private String _ghichu;
	private Double _laixuat;
	private Int32 _sothang;
	private String _ngay;
	private String _thang;
	private String _nam;
      
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
	public Double laixuat
	{
		get { return _laixuat; }
		set { _laixuat = value; }
	}
	public Int32 sothang
	{
		get { return _sothang; }
		set { _sothang = value; }
	}
	public String ngay
	{
		get { return _ngay; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_ngay = value.Substring(0, 50);
			}
			else
			{
				_ngay = value;
			}
		}
	}
	public String thang
	{
		get { return _thang; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_thang = value.Substring(0, 50);
			}
			else
			{
				_thang = value;
			}
		}
	}
	public String nam
	{
		get { return _nam; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_nam = value.Substring(0, 50);
			}
			else
			{
				_nam = value;
			}
		}
	}
   }
}