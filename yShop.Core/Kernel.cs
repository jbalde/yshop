using System;
using System.Data.SqlClient;


namespace yShop.Core
{
	public class Kernel
	{
		protected static Kernel instance;
		
		protected string connectionString = "data source=server;initial catalog=database;user id=user;pwd=pass;";
		protected SqlConnection connection;
		
		
		
		protected Kernel()
		{
			this.connection = new SqlConnection(this.connectionString);
		}
		

		protected void Finalize()
		{
			this.connection.Close();
			this.connection = null;
		}
		
		
		public static Kernel Instance {
			get {
				return Kernel.instance;
			}
		}
		
		
		
		public SqlConnection getConnection() {
			return this.connection;
		}
	}
}

