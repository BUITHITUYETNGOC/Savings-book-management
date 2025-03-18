using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace sotietkiem99
{
   public class khachhangDAO
   {

      public static int insert(khachhangModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_khachhang_Insert");
         
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@ghichu", item.ghichu);
		cmd.Parameters.AddWithValue("@ma", item.ma);
		cmd.Parameters.AddWithValue("@ngaysinh", item.ngaysinh);
		cmd.Parameters.AddWithValue("@thangsinh", item.thangsinh);
		cmd.Parameters.AddWithValue("@namsinh", item.namsinh);
		cmd.Parameters.AddWithValue("@ngaytao", item.ngaytao);
		cmd.Parameters.AddWithValue("@dienthoai", item.dienthoai);
		cmd.Parameters.AddWithValue("@diachi", item.diachi);
		cmd.Parameters.AddWithValue("@email", item.email);
		cmd.Parameters.AddWithValue("@gioitinh", item.gioitinh);
		cmd.Parameters.AddWithValue("@cmnd", item.cmnd);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int update(khachhangModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_khachhang_Update");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@ghichu", item.ghichu);
		cmd.Parameters.AddWithValue("@ma", item.ma);
		cmd.Parameters.AddWithValue("@ngaysinh", item.ngaysinh);
		cmd.Parameters.AddWithValue("@thangsinh", item.thangsinh);
		cmd.Parameters.AddWithValue("@namsinh", item.namsinh);
		cmd.Parameters.AddWithValue("@ngaytao", item.ngaytao);
		cmd.Parameters.AddWithValue("@dienthoai", item.dienthoai);
		cmd.Parameters.AddWithValue("@diachi", item.diachi);
		cmd.Parameters.AddWithValue("@email", item.email);
		cmd.Parameters.AddWithValue("@gioitinh", item.gioitinh);
		cmd.Parameters.AddWithValue("@cmnd", item.cmnd);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int insertOrUpdate(khachhangModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_khachhang_InsertOrUpdate");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@ten", item.ten);
		cmd.Parameters.AddWithValue("@ghichu", item.ghichu);
		cmd.Parameters.AddWithValue("@ma", item.ma);
		cmd.Parameters.AddWithValue("@ngaysinh", item.ngaysinh);
		cmd.Parameters.AddWithValue("@thangsinh", item.thangsinh);
		cmd.Parameters.AddWithValue("@namsinh", item.namsinh);
		cmd.Parameters.AddWithValue("@ngaytao", item.ngaytao);
		cmd.Parameters.AddWithValue("@dienthoai", item.dienthoai);
		cmd.Parameters.AddWithValue("@diachi", item.diachi);
		cmd.Parameters.AddWithValue("@email", item.email);
		cmd.Parameters.AddWithValue("@gioitinh", item.gioitinh);
		cmd.Parameters.AddWithValue("@cmnd", item.cmnd);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }
      
	public static int deleteByid(Int32 id)
	{
		SqlCommand cmd = new SqlCommand("sp_khachhang_DeleteByid");
		cmd.Parameters.AddWithValue("@id", id);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

      public static List<khachhangModel> selectAll()
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<khachhangModel> list = new List<khachhangModel>();
		try{
			cmd = new SqlCommand("sp_khachhang_SelectAll");
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new khachhangModel(reader));  
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
      
	public static khachhangModel selectByid(Int32 id)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<khachhangModel> list = new List<khachhangModel>();
		try { cmd = new SqlCommand("sp_khachhang_SelectByid");
		cmd.Parameters.AddWithValue("@id", id);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new khachhangModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list.Count > 0 ? list[0]: null;
	}

      public static List<khachhangModel> selectByDynamic(String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		 List<khachhangModel> list = new List<khachhangModel>();
		try{
			cmd = new SqlCommand("sp_khachhang_SelectByDynamic");
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new khachhangModel(reader));  
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

      public static List<khachhangModel> sort(List<khachhangModel> list, String columnName, String orderby)
      {
		if ("id" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.id).ToList(); } else { list = list.OrderByDescending(a => a.id).ToList(); } }
		if ("ten" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ten).ToList(); } else { list = list.OrderByDescending(a => a.ten).ToList(); } }
		if ("ghichu" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ghichu).ToList(); } else { list = list.OrderByDescending(a => a.ghichu).ToList(); } }
		if ("ma" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ma).ToList(); } else { list = list.OrderByDescending(a => a.ma).ToList(); } }
		if ("ngaysinh" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ngaysinh).ToList(); } else { list = list.OrderByDescending(a => a.ngaysinh).ToList(); } }
		if ("thangsinh" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.thangsinh).ToList(); } else { list = list.OrderByDescending(a => a.thangsinh).ToList(); } }
		if ("namsinh" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.namsinh).ToList(); } else { list = list.OrderByDescending(a => a.namsinh).ToList(); } }
		if ("ngaytao" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ngaytao).ToList(); } else { list = list.OrderByDescending(a => a.ngaytao).ToList(); } }
		if ("dienthoai" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.dienthoai).ToList(); } else { list = list.OrderByDescending(a => a.dienthoai).ToList(); } }
		if ("diachi" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.diachi).ToList(); } else { list = list.OrderByDescending(a => a.diachi).ToList(); } }
		if ("email" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.email).ToList(); } else { list = list.OrderByDescending(a => a.email).ToList(); } }
		if ("gioitinh" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.gioitinh).ToList(); } else { list = list.OrderByDescending(a => a.gioitinh).ToList(); } }
		if ("cmnd" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.cmnd).ToList(); } else { list = list.OrderByDescending(a => a.cmnd).ToList(); } }
         return list;
      }

      public static List<khachhangModel> search(String keyword)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<khachhangModel> list = new List<khachhangModel>();
		try{
			cmd = new SqlCommand("sp_khachhang_Search");
			 cmd.Parameters.AddWithValue("@keyword", keyword);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new khachhangModel(reader));  
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

      public static List<khachhangModel> selectTop(Int32 top, String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<khachhangModel> list = new List<khachhangModel>();
		try{
			cmd = new SqlCommand("sp_khachhang_SelectTop");
			 cmd.Parameters.AddWithValue("@top", top);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new khachhangModel(reader));  
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

      public static List<khachhangModel> paging(Int32 page, Int32 size, String where, String orderby)
      {
		SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<khachhangModel> list = new List<khachhangModel>();
		try{
			cmd = new SqlCommand("sp_khachhang_Paging");
			 cmd.Parameters.AddWithValue("@page", page);
			 cmd.Parameters.AddWithValue("@size", size);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new khachhangModel(reader));  
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
