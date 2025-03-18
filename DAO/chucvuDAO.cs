using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace sotietkiem99
{
   public class chucvuDAO
   {

      public static int insert(chucvuModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_chucvu_Insert");
         
		cmd.Parameters.AddWithValue("@ten", item.ten);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int update(chucvuModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_chucvu_Update");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int insertOrUpdate(chucvuModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_chucvu_InsertOrUpdate");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }
      
	public static int deleteByid(Int32 id)
	{
		SqlCommand cmd = new SqlCommand("sp_chucvu_DeleteByid");
		cmd.Parameters.AddWithValue("@id", id);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

      public static List<chucvuModel> selectAll()
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<chucvuModel> list = new List<chucvuModel>();
		try{
			cmd = new SqlCommand("sp_chucvu_SelectAll");
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new chucvuModel(reader));  
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
      
	public static chucvuModel selectByid(Int32 id)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<chucvuModel> list = new List<chucvuModel>();
		try { cmd = new SqlCommand("sp_chucvu_SelectByid");
		cmd.Parameters.AddWithValue("@id", id);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new chucvuModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list.Count > 0 ? list[0]: null;
	}

      public static List<chucvuModel> selectByDynamic(String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		 List<chucvuModel> list = new List<chucvuModel>();
		try{
			cmd = new SqlCommand("sp_chucvu_SelectByDynamic");
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new chucvuModel(reader));  
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

      public static List<chucvuModel> sort(List<chucvuModel> list, String columnName, String orderby)
      {
		if ("id" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.id).ToList(); } else { list = list.OrderByDescending(a => a.id).ToList(); } }
		if ("ten" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ten).ToList(); } else { list = list.OrderByDescending(a => a.ten).ToList(); } }
         return list;
      }

      public static List<chucvuModel> search(String keyword)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<chucvuModel> list = new List<chucvuModel>();
		try{
			cmd = new SqlCommand("sp_chucvu_Search");
			 cmd.Parameters.AddWithValue("@keyword", keyword);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new chucvuModel(reader));  
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

      public static List<chucvuModel> selectTop(Int32 top, String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<chucvuModel> list = new List<chucvuModel>();
		try{
			cmd = new SqlCommand("sp_chucvu_SelectTop");
			 cmd.Parameters.AddWithValue("@top", top);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new chucvuModel(reader));  
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

      public static List<chucvuModel> paging(Int32 page, Int32 size, String where, String orderby)
      {
		SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<chucvuModel> list = new List<chucvuModel>();
		try{
			cmd = new SqlCommand("sp_chucvu_Paging");
			 cmd.Parameters.AddWithValue("@page", page);
			 cmd.Parameters.AddWithValue("@size", size);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new chucvuModel(reader));  
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
