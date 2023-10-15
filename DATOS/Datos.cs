using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;

namespace DATOS
{
	public class Datos
	{
		SQLiteDataAdapter dataAdapter;
		DataTable dataTable;

		private static string dbstring = ConfigurationManager.ConnectionStrings["dbstring"].ConnectionString;
        SQLiteConnection conn = new SQLiteConnection(dbstring);

		public bool Ejecutar(SQLiteCommand cmd)
		{
			try
			{
				conn.Open();
				cmd.Connection = conn;
				int rowsAffected = cmd.ExecuteNonQuery();

				if (rowsAffected > 0) return true; else return false;
			}
			catch (Exception)
			{
				//return false;
				throw;
			}
			finally
			{
				conn.Close();
			}
		}

		public DataTable Obtener(SQLiteCommand cmd)
		{
			try
			{
				conn.Open();
				cmd.Connection = conn;
				dataAdapter = new SQLiteDataAdapter(cmd);
				dataTable = new DataTable();
				dataAdapter.Fill(dataTable);
				return dataTable;
			}
			catch (Exception)
			{
				//return null;
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
	}
}