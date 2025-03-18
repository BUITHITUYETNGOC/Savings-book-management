using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace sotietkiem99
{
   public class DatabaseUtils
   {
        public static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
     //   private const String CONNECTION_STRING = @"Data Source=localhost; Initial Catalog=sotietkiem99; Integrated Security=True; Min Pool Size=0; Max Pool Size=100; Pooling=True";
      private const String INIT_VECTOR = "1234mothaibabon5";
      private const Int32 KEY_SIZE = 256;


      private static DatabaseUtils instance;

      public static DatabaseUtils getInstance()
      {
         if (instance == null)
         {
            instance = new DatabaseUtils();
         }
         return instance;
      }

      private DatabaseUtils()
      {
         
      }

      private SqlConnection getConnection()
      {
         SqlConnection con = new SqlConnection(CONNECTION_STRING);
         con.Open();
         return con;
      }

      public String executeScalar(SqlCommand cmd)
      {
         String result = null;
         try
         {
            cmd.Connection = getConnection();
            result = cmd.ExecuteScalar().ToString();
         }
         catch (Exception ex)
         {
            result = null;
            throw ex;
         }
         finally
         {
            cmd.Connection.Close();
			cmd.Dispose();
         }
         return result;
      }

      public String executeScalar(SqlCommand cmd, CommandType type)
      {
         cmd.CommandType = type;
         return executeScalar(cmd);
      }

      public String executeScalar(String sql)
      {
         return executeScalar(new SqlCommand(sql.Trim()));
      }

      public SqlDataReader executeReader(SqlCommand cmd)
      {
         return executeReader(cmd, CommandBehavior.Default);
      }

      public SqlDataReader executeReader(SqlCommand cmd, CommandType type)
      {
         cmd.CommandType = type;
         return executeReader(cmd);
      }

      public SqlDataReader executeReader(String sql)
      {
         return executeReader(new SqlCommand(sql.Trim()));
      }

      public SqlDataReader executeReader(SqlCommand cmd, CommandBehavior behavior)
      {
         SqlDataReader reader = null;
         try
         {
            cmd.Connection = getConnection();
            reader = cmd.ExecuteReader(behavior);
         }
         catch (Exception ex)
         {
            reader = null;
            throw ex;
         }
         return reader;
      }

      public SqlDataReader executeReader(SqlCommand cmd, CommandType type, CommandBehavior behavior)
      {
         cmd.CommandType = type;
         return executeReader(cmd, behavior);
      }

      public SqlDataReader executeReader(String sql, CommandBehavior behavior)
      {
         return executeReader(new SqlCommand(sql.Trim()), behavior);
      }

      public Int32 execute(SqlCommand cmd)
      {
         Int32 result = 0;
         try
         {
            cmd.Connection = getConnection();
            result = cmd.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            result = 0;
            throw ex;
         }
         finally
         {
            cmd.Connection.Close();
			cmd.Dispose();
         }
         return result;
      }

      public Int32 execute(SqlCommand cmd, CommandType type)
      {
         cmd.CommandType = type;
         return execute(cmd);
      }

      public Int32 execute(String sql)
      {
         return execute(new SqlCommand(sql.Trim()));
      }

      public String Encrypt(String plainText, String passPhrase)
      {
         Byte[] initVectorBytes = Encoding.UTF8.GetBytes(INIT_VECTOR);
         Byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
         PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
         Byte[] keyBytes = password.GetBytes(KEY_SIZE / 8);
         RijndaelManaged symmetricKey = new RijndaelManaged();
         symmetricKey.Mode = CipherMode.CBC;
         ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
         MemoryStream memoryStream = new MemoryStream();
         CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
         cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
         cryptoStream.FlushFinalBlock();
         Byte[] cipherTextBytes = memoryStream.ToArray();
         memoryStream.Close();
         cryptoStream.Close();
         return Convert.ToBase64String(cipherTextBytes);
      }

      public String Decrypt(String cipherText, String passPhrase)
      {
         Byte[] initVectorBytes = Encoding.ASCII.GetBytes(INIT_VECTOR);
         Byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
         PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
         Byte[] keyBytes = password.GetBytes(KEY_SIZE / 8);
         RijndaelManaged symmetricKey = new RijndaelManaged();
         symmetricKey.Mode = CipherMode.CBC;
         ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
         MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
         CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
         Byte[] plainTextBytes = new Byte[cipherTextBytes.Length];
         int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
         memoryStream.Close();
         cryptoStream.Close();
         return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
      }
   }
}
