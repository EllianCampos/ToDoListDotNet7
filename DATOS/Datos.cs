using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;

namespace DATOS
{
	public class Datos
	{
		SQLiteConnection conn;
		SQLiteDataAdapter dataAdapter;
		DataTable dataTable;

		public Datos()
		{
			// Ruta relativa desde la posicion actual
			string databaseFilePath = Path.Combine("..", "..", "..", "..", "BASE_DE_DATOS", "ToDoListDB.db");

			// Ruta absoluta
			databaseFilePath = Path.GetFullPath(databaseFilePath);

			databaseFilePath = databaseFilePath.Replace("\\", "/");

			conn = new SQLiteConnection("Data Source=" + databaseFilePath);
		}

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