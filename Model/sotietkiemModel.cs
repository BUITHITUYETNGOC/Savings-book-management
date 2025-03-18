using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace sotietkiem99
{
   [Serializable]
   public class sotietkiemModel
   {
      public sotietkiemModel()
      {

      }

      public sotietkiemModel(SqlDataReader reader)
      {
         
		try { this._id = (Int32)reader["id"]; } catch (Exception) { }
		try { this._sothe = (String)reader["sothe"]; } catch (Exception) { }
		try { this._gio = (String)reader["gio"]; } catch (Exception) { }
		try { this._ngay = (String)reader["ngay"]; } catch (Exception) { }
		try { this._thang = (String)reader["thang"]; } catch (Exception) { }
		try { this._nam = (String)reader["nam"]; } catch (Exception) { }
		try { this._tiengui = (Double)reader["tiengui"]; } catch (Exception) { }
		try { this._laixuat = (Double)reader["laixuat"]; } catch (Exception) { }
		try { this._thanhtien = (Double)reader["thanhtien"]; } catch (Exception) { }
		try { this._trangthai = (String)reader["trangthai"]; } catch (Exception) { }
		try { this._idkyhan = (Int32)reader["idkyhan"]; } catch (Exception) { }
		try { this._ngaylay = (String)reader["ngaylay"]; } catch (Exception) { }
		try { this._thanglay = (String)reader["thanglay"]; } catch (Exception) { }
		try { this._namlay = (String)reader["namlay"]; } catch (Exception) { }
		try { this._giolay = (String)reader["giolay"]; } catch (Exception) { }
		try { this._idnhanvientao = (Int32)reader["idnhanvientao"]; } catch (Exception) { }
		try { this._sothanggui = (Double)reader["sothanggui"]; } catch (Exception) { }
		try { this._idkhach = (Int32)reader["idkhach"]; } catch (Exception) { }
      }
      
	private Int32 _id;
	private String _sothe;
	private String _gio;
	private String _ngay;
	private String _thang;
	private String _nam;
	private Double _tiengui;
	private Double _laixuat;
	private Double _thanhtien;
	private String _trangthai;
	private Int32 _idkyhan;
	private String _ngaylay;
	private String _thanglay;
	private String _namlay;
	private String _giolay;
	private Int32 _idnhanvientao;
	private Double _sothanggui;
	private Int32 _idkhach;
      
	public Int32 id
	{
		get { return _id; }
		set { _id = value; }
	}
	public String sothe
	{
		get { return _sothe; }
		set { _sothe = value; }
	}
	public String gio
	{
		get { return _gio; }
		set { _gio = value; }
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
	public Double tiengui
	{
		get { return _tiengui; }
		set { _tiengui = value; }
	}
	public Double laixuat
	{
		get { return _laixuat; }
		set { _laixuat = value; }
	}
	public Double thanhtien
	{
		get { return _thanhtien; }
		set { _thanhtien = value; }
	}
	public String trangthai
	{
		get { return _trangthai; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_trangthai = value.Substring(0, 50);
			}
			else
			{
				_trangthai = value;
			}
		}
	}
	public Int32 idkyhan
	{
		get { return _idkyhan; }
		set { _idkyhan = value; }
	}
	public String ngaylay
	{
		get { return _ngaylay; }
		set { _ngaylay = value; }
	}
	public String thanglay
	{
		get { return _thanglay; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_thanglay = value.Substring(0, 50);
			}
			else
			{
				_thanglay = value;
			}
		}
	}
	public String namlay
	{
		get { return _namlay; }
		set
		{
			if (!String.IsNullOrEmpty(value) && value.Length > 50)
			{
				_namlay = value.Substring(0, 50);
			}
			else
			{
				_namlay = value;
			}
		}
	}
	public String giolay
	{
		get { return _giolay; }
		set { _giolay = value; }
	}
	public Int32 idnhanvientao
	{
		get { return _idnhanvientao; }
		set { _idnhanvientao = value; }
	}
	public Double sothanggui
	{
		get { return _sothanggui; }
		set { _sothanggui = value; }
	}
	public Int32 idkhach
	{
		get { return _idkhach; }
		set { _idkhach = value; }
	}
   }
}