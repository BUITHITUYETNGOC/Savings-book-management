using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace sotietkiem99
{
   public class kyhanDAO
   {

      public static int insert(kyhanModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_kyhan_Insert");
         
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@ghichu", item.ghichu);
		cmd.Parameters.AddWithValue("@laixuat", item.laixuat);
		cmd.Parameters.AddWithValue("@sothang", item.sothang);
		cmd.Parameters.AddWithValue("@ngay", item.ngay);
		cmd.Parameters.AddWithValue("@thang", item.thang);
		cmd.Parameters.AddWithValue("@nam", item.nam);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int update(kyhanModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_kyhan_Update");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@ghichu", item.ghichu);
		cmd.Parameters.AddWithValue("@laixuat", item.laixuat);
		cmd.Parameters.AddWithValue("@sothang", item.sothang);
		cmd.Parameters.AddWithValue("@ngay", item.ngay);
		cmd.Parameters.AddWithValue("@thang", item.thang);
		cmd.Parameters.AddWithValue("@nam", item.nam);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int insertOrUpdate(kyhanModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_kyhan_InsertOrUpdate");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@ghichu", item.ghichu);
		cmd.Parameters.AddWithValue("@laixuat", item.laixuat);
		cmd.Parameters.AddWithValue("@sothang", item.sothang);
		cmd.Parameters.AddWithValue("@ngay", item.ngay);
		cmd.Parameters.AddWithValue("@thang", item.thang);
		cmd.Parameters.AddWithValue("@nam", item.nam);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }
      
	public static int deleteByid(Int32 id)
	{
		SqlCommand cmd = new SqlCommand("sp_kyhan_DeleteByid");
		cmd.Parameters.AddWithValue("@id", id);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

      public static List<kyhanModel> selectAll()
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<kyhanModel> list = new List<kyhanModel>();
		try{
			cmd = new SqlCommand("sp_kyhan_SelectAll");
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new kyhanModel(reader));  
			 }
         }finally{
			if(reader != null){
				reader.Close();
			}
			if(cmd != null){
			cmd.Connection.Close();
				cmd.Dispose();
			}
		}
         return list;
      }
      
	public static kyhanModel selectByid(Int32 id)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<kyhanModel> list = new List<kyhanModel>();
		try { cmd = new SqlCommand("sp_kyhan_SelectByid");
		cmd.Parameters.AddWithValue("@id", id);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new kyhanModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list.Count > 0 ? list[0]: null;
	}

      public static List<kyhanModel> selectByDynamic(String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		 List<kyhanModel> list = new List<kyhanModel>();
		try{
			cmd = new SqlCommand("sp_kyhan_SelectByDynamic");
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new kyhanModel(reader));  
			 }
         }finally{
			if(reader != null){
				reader.Close();
			}
			if(cmd != null){
			cmd.Connection.Close();
			cmd.Dispose();
			}
		}
         return list;
      }

      public static List<kyhanModel> sort(List<kyhanModel> list, String columnName, String orderby)
      {
		if ("id" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.id).ToList(); } else { list = list.OrderByDescending(a => a.id).ToList(); } }
		if ("ten" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ten).ToList(); } else { list = list.OrderByDescending(a => a.ten).ToList(); } }
		if ("ghichu" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ghichu).ToList(); } else { list = list.OrderByDescending(a => a.ghichu).ToList(); } }
		if ("laixuat" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.laixuat).ToList(); } else { list = list.OrderByDescending(a => a.laixuat).ToList(); } }
		if ("sothang" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.sothang).ToList(); } else { list = list.OrderByDescending(a => a.sothang).ToList(); } }
		if ("ngay" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ngay).ToList(); } else { list = list.OrderByDescending(a => a.ngay).ToList(); } }
		if ("thang" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.thang).ToList(); } else { list = list.OrderByDescending(a => a.thang).ToList(); } }
		if ("nam" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.nam).ToList(); } else { list = list.OrderByDescending(a => a.nam).ToList(); } }
         return list;
      }

      public static List<kyhanModel> search(String keyword)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<kyhanModel> list = new List<kyhanModel>();
		try{
			cmd = new SqlCommand("sp_kyhan_Search");
			 cmd.Parameters.AddWithValue("@keyword", keyword);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new kyhanModel(reader));  
			 }
         }finally{
			if(reader != null){
				reader.Close();
			}
			if(cmd != null){
			cmd.Connection.Close();
			cmd.Dispose();
			}
		}
         return list;
      }

      public static List<kyhanModel> selectTop(Int32 top, String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<kyhanModel> list = new List<kyhanModel>();
		try{
			cmd = new SqlCommand("sp_kyhan_SelectTop");
			 cmd.Parameters.AddWithValue("@top", top);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new kyhanModel(reader));  
			 }
         }finally{
			if(reader != null){
				reader.Close();
			}
			if(cmd != null){
			cmd.Connection.Close();
			cmd.Dispose();
			}
		}
         return list;
      }

      public static List<kyhanModel> paging(Int32 page, Int32 size, String where, String orderby)
      {
		SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<kyhanModel> list = new List<kyhanModel>();
		try{
			cmd = new SqlCommand("sp_kyhan_Paging");
			 cmd.Parameters.AddWithValue("@page", page);
			 cmd.Parameters.AddWithValue("@size", size);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new kyhanModel(reader));  
			 }
		}finally{
			if(reader != null){
				reader.Close();
			}
			if(cmd != null){
			cmd.Connection.Close();
			cmd.Dispose();
			}
		}
         return list;
      }
   }
}
