using System;
using System.Data.SqlClient;



namespace yShop.Core.Model {
	/// <summary>
	/// Product.
	/// </summary>
	public class Product {
		#region Attributes
		/// <summary>
		/// The identifier.
		/// </summary>
		protected int id;
		
		
		
		/// <summary>
		/// The name.
		/// </summary>
		protected string name;
		
		
		
		/// <summary>
		/// The short description.
		/// </summary>
        protected string shortDescription;
        
        
        
        /// <summary>
        /// The long description.
        /// </summary>
        protected string longDescription;
        
        
        
        /// <summary>
        /// The price.
        /// </summary>
        protected decimal price;
        
        
        
        /// <summary>
        /// The home photo.
        /// </summary>
        protected string homePhoto;
        
        
        
        /// <summary>
        /// The amount.
        /// </summary>
        protected int amount;
		#endregion
        
        
        
        #region Constructors
		public Product() {
		}
		#endregion
		
		
		
		#region Properties
		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		/// <value>
		/// The amount.
		/// </value>
		public int Amount {
			get {
				return this.amount;
			}
			set {
				amount = value;
			}
		}
		
		
		
		/// <summary>
		/// Gets or sets the home photo.
		/// </summary>
		/// <value>
		/// The home photo.
		/// </value>
		public string HomePhoto {
			get {
				return this.homePhoto;
			}
			set {
				homePhoto = value;
			}
		}
		
		
		
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		
		
		/// <summary>
		/// Gets or sets the long description.
		/// </summary>
		/// <value>
		/// The long description.
		/// </value>
		public string LongDescription {
			get {
				return this.longDescription;
			}
			set {
				longDescription = value;
			}
		}
		
		
		
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}
		
		
		
		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>
		/// The price.
		/// </value>
		public decimal Price {
			get {
				return this.price;
			}
			set {
				price = value;
			}
		}
		
		
		
		/// <summary>
		/// Gets or sets the short description.
		/// </summary>
		/// <value>
		/// The short description.
		/// </value>
		public string ShortDescription {
			get {
				return this.shortDescription;
			}
			set {
				shortDescription = value;
			}
		}
		#endregion

		
		
		#region Data methods
		/// <summary>
		/// Fills the product.
		/// </summary>
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
		#endregion
	}
}