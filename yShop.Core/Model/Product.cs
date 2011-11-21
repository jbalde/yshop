using System;
using System.Data.SqlClient;


namespace yShop.Core.Model {
	public class Product : ModelBase {
		protected int id;
		protected string name;
        protected string shortDescription;
        protected string longDescription;
        protected decimal price;
        protected string homePhoto;
        protected int amount; 
        
        
		public Product() {
		}
		

		public int Amount {
			get {
				return this.amount;
			}
			set {
				amount = value;
			}
		}

		public string HomePhoto {
			get {
				return this.homePhoto;
			}
			set {
				homePhoto = value;
			}
		}

		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string LongDescription {
			get {
				return this.longDescription;
			}
			set {
				longDescription = value;
			}
		}

		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}

		public decimal Price {
			get {
				return this.price;
			}
			set {
				price = value;
			}
		}

		public string ShortDescription {
			get {
				return this.shortDescription;
			}
			set {
				shortDescription = value;
			}
		}

		
		
		public void fillProduct() {
			SqlConnection connection = Kernel.Instance.getConnection();
			
			SqlCommand command = new SqlCommand("select id, name, shortdescription, longdescription, price, homephoto from yshop_products where id = @productid", connection);
			
			command.Parameters.Add("@productid", System.Data.SqlDbType.Int).Value = this.id;
			
			
			SqlDataReader reader = command.ExecuteReader();
			
			reader.Read();
			
			this.id = (int)reader[0];
			this.name = reader[1].ToString();
			this.shortDescription = reader[2].ToString();
			this.longDescription = reader[3].ToString();
			this.price = (decimal)reader[4];
			this.homePhoto = reader[5].ToString();
			
			connection.Close();
		}
	}
}

