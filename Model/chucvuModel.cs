using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace sotietkiem99
{
   [Serializable]
   public class chucvuModel
   {
      public chucvuModel()
      {

      }

      public chucvuModel(SqlDataReader reader)
      {
         
		try { this._id = (Int32)reader["id"]; } catch (Exception) { }
		try { this._ten = (String)reader["ten"]; } catch (Exception) { }
      }
      
	private Int32 _id;
	private String _ten;
      
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
   }
}