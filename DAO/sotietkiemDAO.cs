using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace sotietkiem99
{
   public class sotietkiemDAO
   {

      public static int insert(sotietkiemModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_sotietkiem_Insert");
         
		cmd.Parameters.AddWithValue("@sothe", item.sothe);
		cmd.Parameters.AddWithValue("@gio", item.gio);
		cmd.Parameters.AddWithValue("@ngay", item.ngay);
		cmd.Parameters.AddWithValue("@thang", item.thang);
		cmd.Parameters.AddWithValue("@nam", item.nam);
		cmd.Parameters.AddWithValue("@tiengui", item.tiengui);
		cmd.Parameters.AddWithValue("@laixuat", item.laixuat);
		cmd.Parameters.AddWithValue("@thanhtien", item.thanhtien);
		cmd.Parameters.AddWithValue("@trangthai", item.trangthai);
		cmd.Parameters.AddWithValue("@idkyhan", item.idkyhan);
		cmd.Parameters.AddWithValue("@ngaylay", item.ngaylay);
		cmd.Parameters.AddWithValue("@thanglay", item.thanglay);
		cmd.Parameters.AddWithValue("@namlay", item.namlay);
		cmd.Parameters.AddWithValue("@giolay", item.giolay);
		cmd.Parameters.AddWithValue("@idnhanvientao", item.idnhanvientao);
		cmd.Parameters.AddWithValue("@sothanggui", item.sothanggui);
		cmd.Parameters.AddWithValue("@idkhach", item.idkhach);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int update(sotietkiemModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_sotietkiem_Update");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@sothe", item.sothe);
		cmd.Parameters.AddWithValue("@gio", item.gio);
		cmd.Parameters.AddWithValue("@ngay", item.ngay);
		cmd.Parameters.AddWithValue("@thang", item.thang);
		cmd.Parameters.AddWithValue("@nam", item.nam);
		cmd.Parameters.AddWithValue("@tiengui", item.tiengui);
		cmd.Parameters.AddWithValue("@laixuat", item.laixuat);
		cmd.Parameters.AddWithValue("@thanhtien", item.thanhtien);
		cmd.Parameters.AddWithValue("@trangthai", item.trangthai);
		cmd.Parameters.AddWithValue("@idkyhan", item.idkyhan);
		cmd.Parameters.AddWithValue("@ngaylay", item.ngaylay);
		cmd.Parameters.AddWithValue("@thanglay", item.thanglay);
		cmd.Parameters.AddWithValue("@namlay", item.namlay);
		cmd.Parameters.AddWithValue("@giolay", item.giolay);
		cmd.Parameters.AddWithValue("@idnhanvientao", item.idnhanvientao);
		cmd.Parameters.AddWithValue("@sothanggui", item.sothanggui);
		cmd.Parameters.AddWithValue("@idkhach", item.idkhach);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }

      public static int insertOrUpdate(sotietkiemModel item)
      {
         SqlCommand cmd = new SqlCommand("sp_sotietkiem_InsertOrUpdate");
		   
		cmd.Parameters.AddWithValue("@id", item.id);
		cmd.Parameters.AddWithValue("@sothe", item.sothe);
		cmd.Parameters.AddWithValue("@gio", item.gio);
		cmd.Parameters.AddWithValue("@ngay", item.ngay);
		cmd.Parameters.AddWithValue("@thang", item.thang);
		cmd.Parameters.AddWithValue("@nam", item.nam);
		cmd.Parameters.AddWithValue("@tiengui", item.tiengui);
		cmd.Parameters.AddWithValue("@laixuat", item.laixuat);
		cmd.Parameters.AddWithValue("@thanhtien", item.thanhtien);
		cmd.Parameters.AddWithValue("@trangthai", item.trangthai);
		cmd.Parameters.AddWithValue("@idkyhan", item.idkyhan);
		cmd.Parameters.AddWithValue("@ngaylay", item.ngaylay);
		cmd.Parameters.AddWithValue("@thanglay", item.thanglay);
		cmd.Parameters.AddWithValue("@namlay", item.namlay);
		cmd.Parameters.AddWithValue("@giolay", item.giolay);
		cmd.Parameters.AddWithValue("@idnhanvientao", item.idnhanvientao);
		cmd.Parameters.AddWithValue("@sothanggui", item.sothanggui);
		cmd.Parameters.AddWithValue("@idkhach", item.idkhach);
         return DatabaseUtils.getInstance()
                     .execute(cmd, CommandType.StoredProcedure);
      }
      
	public static int deleteByid(Int32 id)
	{
		SqlCommand cmd = new SqlCommand("sp_sotietkiem_DeleteByid");
		cmd.Parameters.AddWithValue("@id", id);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

	public static int deleteByidkyhan(Int32 idkyhan)
	{
		SqlCommand cmd = new SqlCommand("sp_sotietkiem_DeleteByidkyhan");
		cmd.Parameters.AddWithValue("@idkyhan", idkyhan);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

	public static int deleteByidnhanvientao(Int32 idnhanvientao)
	{
		SqlCommand cmd = new SqlCommand("sp_sotietkiem_DeleteByidnhanvientao");
		cmd.Parameters.AddWithValue("@idnhanvientao", idnhanvientao);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

	public static int deleteByidkhach(Int32 idkhach)
	{
		SqlCommand cmd = new SqlCommand("sp_sotietkiem_DeleteByidkhach");
		cmd.Parameters.AddWithValue("@idkhach", idkhach);
		return DatabaseUtils.getInstance().execute(cmd, CommandType.StoredProcedure);
	}

      public static List<sotietkiemModel> selectAll()
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try{
			cmd = new SqlCommand("sp_sotietkiem_SelectAll");
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new sotietkiemModel(reader));  
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
      
	public static sotietkiemModel selectByid(Int32 id)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try { cmd = new SqlCommand("sp_sotietkiem_SelectByid");
		cmd.Parameters.AddWithValue("@id", id);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new sotietkiemModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list.Count > 0 ? list[0]: null;
	}

	public static List<sotietkiemModel> selectByidkyhan(Int32 idkyhan)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try { cmd = new SqlCommand("sp_sotietkiem_SelectByidkyhan");
		cmd.Parameters.AddWithValue("@idkyhan", idkyhan);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new sotietkiemModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list;
	}

	public static List<sotietkiemModel> selectByidnhanvientao(Int32 idnhanvientao)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try { cmd = new SqlCommand("sp_sotietkiem_SelectByidnhanvientao");
		cmd.Parameters.AddWithValue("@idnhanvientao", idnhanvientao);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new sotietkiemModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list;
	}

	public static List<sotietkiemModel> selectByidkhach(Int32 idkhach)
	{
	SqlCommand cmd = null;
	SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try { cmd = new SqlCommand("sp_sotietkiem_SelectByidkhach");
		cmd.Parameters.AddWithValue("@idkhach", idkhach);
		reader = DatabaseUtils.getInstance().executeReader(cmd, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add(new sotietkiemModel(reader));
		}}finally{
		if(reader != null){reader.Close();}
		if(cmd != null){cmd.Connection.Close(); cmd.Dispose();}}
		return list;
	}

      public static List<sotietkiemModel> selectByDynamic(String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		 List<sotietkiemModel> list = new List<sotietkiemModel>();
		try{
			cmd = new SqlCommand("sp_sotietkiem_SelectByDynamic");
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new sotietkiemModel(reader));  
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

      public static List<sotietkiemModel> sort(List<sotietkiemModel> list, String columnName, String orderby)
      {
		if ("id" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.id).ToList(); } else { list = list.OrderByDescending(a => a.id).ToList(); } }
		if ("sothe" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.sothe).ToList(); } else { list = list.OrderByDescending(a => a.sothe).ToList(); } }
		if ("gio" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.gio).ToList(); } else { list = list.OrderByDescending(a => a.gio).ToList(); } }
		if ("ngay" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ngay).ToList(); } else { list = list.OrderByDescending(a => a.ngay).ToList(); } }
		if ("thang" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.thang).ToList(); } else { list = list.OrderByDescending(a => a.thang).ToList(); } }
		if ("nam" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.nam).ToList(); } else { list = list.OrderByDescending(a => a.nam).ToList(); } }
		if ("tiengui" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.tiengui).ToList(); } else { list = list.OrderByDescending(a => a.tiengui).ToList(); } }
		if ("laixuat" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.laixuat).ToList(); } else { list = list.OrderByDescending(a => a.laixuat).ToList(); } }
		if ("thanhtien" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.thanhtien).ToList(); } else { list = list.OrderByDescending(a => a.thanhtien).ToList(); } }
		if ("trangthai" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.trangthai).ToList(); } else { list = list.OrderByDescending(a => a.trangthai).ToList(); } }
		if ("idkyhan" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.idkyhan).ToList(); } else { list = list.OrderByDescending(a => a.idkyhan).ToList(); } }
		if ("ngaylay" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.ngaylay).ToList(); } else { list = list.OrderByDescending(a => a.ngaylay).ToList(); } }
		if ("thanglay" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.thanglay).ToList(); } else { list = list.OrderByDescending(a => a.thanglay).ToList(); } }
		if ("namlay" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.namlay).ToList(); } else { list = list.OrderByDescending(a => a.namlay).ToList(); } }
		if ("giolay" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.giolay).ToList(); } else { list = list.OrderByDescending(a => a.giolay).ToList(); } }
		if ("idnhanvientao" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.idnhanvientao).ToList(); } else { list = list.OrderByDescending(a => a.idnhanvientao).ToList(); } }
		if ("sothanggui" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.sothanggui).ToList(); } else { list = list.OrderByDescending(a => a.sothanggui).ToList(); } }
		if ("idkhach" == columnName) { if (orderby == "ASC") { list = list.OrderBy(a => a.idkhach).ToList(); } else { list = list.OrderByDescending(a => a.idkhach).ToList(); } }
         return list;
      }

      public static List<sotietkiemModel> search(String keyword)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try{
			cmd = new SqlCommand("sp_sotietkiem_Search");
			 cmd.Parameters.AddWithValue("@keyword", keyword);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new sotietkiemModel(reader));  
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

      public static List<sotietkiemModel> selectTop(Int32 top, String where, String orderby)
      {
         SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try{
			cmd = new SqlCommand("sp_sotietkiem_SelectTop");
			 cmd.Parameters.AddWithValue("@top", top);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new sotietkiemModel(reader));  
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

      public static List<sotietkiemModel> paging(Int32 page, Int32 size, String where, String orderby)
      {
		SqlCommand cmd = null;
		SqlDataReader reader = null;
		List<sotietkiemModel> list = new List<sotietkiemModel>();
		try{
			cmd = new SqlCommand("sp_sotietkiem_Paging");
			 cmd.Parameters.AddWithValue("@page", page);
			 cmd.Parameters.AddWithValue("@size", size);
			 cmd.Parameters.AddWithValue("@where", where);
			 cmd.Parameters.AddWithValue("@orderby", orderby);
			 reader = DatabaseUtils.getInstance()
					  .executeReader(cmd, CommandType.StoredProcedure);
			 while (reader.Read())
			 {
				list.Add(new sotietkiemModel(reader));  
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
