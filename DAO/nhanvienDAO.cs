using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace sotietkiem99
{
   public class nhanvienDAO
   {

      public static int insert(nhanvienModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_nhanvien_Insert");
         
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@matkhau", item.matkhau);
		cmd.Parameters.AddWithValue("@tenhienthi", item.tenhienthi);
		cmd.Parameters.AddWithValue("@idchucvu", item.idchucvu);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int update(nhanvienModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_nhanvien_Update");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@matkhau", item.matkhau);
		cmd.Parameters.AddWithValue("@tenhienthi", item.tenhienthi);
		cmd.Parameters.AddWithValue("@idchucvu", item.idchucvu);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int insertOrUpdate(nhanvienModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_nhanvien_InsertOrUpdate");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@matkhau", item.matkhau);
		cmd.Parameters.AddWithValue("@tenhienthi", item.tenhienthi);
		cmd.Parameters.AddWithValue("@idchucvu", item.idchucvu);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }
      
	public static int deleteByid(Int32 id)
	{
		SqlCommand cmd = new SqlCommand("sp_nhanvien_DeleteByid");
		cmd.Parameters.AddWithValue("@id", id);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

	public static int deleteByidchucvu(Int32 idchucvu)
	{
		SqlCommand cmd = new SqlCommand("sp_nhanvien_DeleteByidchucvu");
		cmd.Parameters.AddWithValue("@idchucvu", idchucvu);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

      public static List<nhanvienModel> selectAll()
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<nhanvienModel> list = new List<nhanvienModel>();
		try{
			cmd = new SqlCommand("sp_nhanvien_SelectAll");
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new nhanvienModel(reader));  
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
      
	public static nhanvienModel selectByid(Int32 id)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<nhanvienModel> list = new List<nhanvienModel>();
		try { cmd = new SqlCommand("sp_nhanvien_SelectByid");
		cmd.Parameters.AddWithValue("@id", id);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new nhanvienModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list.Count > 0 ? list[0]: null;
	}

	public static List<nhanvienModel> selectByidchucvu(Int32 idchucvu)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<nhanvienModel> list = new List<nhanvienModel>();
		try { cmd = new SqlCommand("sp_nhanvien_SelectByidchucvu");
		cmd.Parameters.AddWithValue("@idchucvu", idchucvu);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new nhanvienModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list;
	}

      public static List<nhanvienModel> selectByDynamic(String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		 List<nhanvienModel> list = new List<nhanvienModel>();
		try{
			cmd = new SqlCommand("sp_nhanvien_SelectByDynamic");
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new nhanvienModel(reader));  
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

      public static List<nhanvienModel> sort(List<nhanvienModel> list, String columnName, String orderby)
      {
		if ("id" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.id).ToList(); } else { list = list.OrderByDescending(a => a.id).ToList(); } }
		if ("ten" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ten).ToList(); } else { list = list.OrderByDescending(a => a.ten).ToList(); } }
		if ("matkhau" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.matkhau).ToList(); } else { list = list.OrderByDescending(a => a.matkhau).ToList(); } }
		if ("tenhienthi" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.tenhienthi).ToList(); } else { list = list.OrderByDescending(a => a.tenhienthi).ToList(); } }
		if ("idchucvu" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.idchucvu).ToList(); } else { list = list.OrderByDescending(a => a.idchucvu).ToList(); } }
         return list;
      }

      public static List<nhanvienModel> search(String keyword)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<nhanvienModel> list = new List<nhanvienModel>();
		try{
			cmd = new SqlCommand("sp_nhanvien_Search");
			 cmd.Parameters.AddWithValue("@keyword", keyword);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new nhanvienModel(reader));  
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

      public static List<nhanvienModel> selectTop(Int32 top, String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<nhanvienModel> list = new List<nhanvienModel>();
		try{
			cmd = new SqlCommand("sp_nhanvien_SelectTop");
			 cmd.Parameters.AddWithValue("@top", top);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new nhanvienModel(reader));  
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

      public static List<nhanvienModel> paging(Int32 page, Int32 size, String where, String orderby)
      {
		SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<nhanvienModel> list = new List<nhanvienModel>();
		try{
			cmd = new SqlCommand("sp_nhanvien_Paging");
			 cmd.Parameters.AddWithValue("@page", page);
			 cmd.Parameters.AddWithValue("@size", size);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new nhanvienModel(reader));  
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
