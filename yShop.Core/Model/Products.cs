using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace yShop.Core.Model {
	public class Products : IList<Product> {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="yShop.Core.Model.Products"/> class.
		/// </summary>
		public Products() {
		}
		#endregion
	
	
	
		#region IList[yShop.Core.Model.Product] implementation
		/// <summary>
		/// Indexs the of.
		/// </summary>
		/// <returns>
		/// The of.
		/// </returns>
		/// <param name='item'>
		/// Item.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public int IndexOf(yShop.Core.Model.Product item) {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Insert the specified index and item.
		/// </summary>
		/// <param name='index'>
		/// Index.
		/// </param>
		/// <param name='item'>
		/// Item.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public void Insert(int index, yShop.Core.Model.Product item) {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Removes at index.
		/// </summary>
		/// <param name='index'>
		/// Index.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public void RemoveAt(int index) {
			throw new System.NotImplementedException();
		}
	
	
		
		/// <summary>
		/// Gets or sets the <see cref="yShop.Core.Model.Products"/> at the specified index.
		/// </summary>
		/// <param name='index'>
		/// Index.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public yShop.Core.Model.Product this[int index] {
			get {
				throw new System.NotImplementedException();
			}
			set {
				throw new System.NotImplementedException();
			}
		}
		#endregion
	
	
	
		#region IEnumerable implementation
		/// <summary>
		/// Gets the enumerator.
		/// </summary>
		/// <returns>
		/// The enumerator.
		/// </returns>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public System.Collections.IEnumerator GetEnumerator() {
			throw new System.NotImplementedException();
		}
		#endregion
	
	
	
		#region IEnumerable[yShop.Core.Model.Product] implementation
		/// <summary>
		/// Gets the enumerator.
		/// </summary>
		/// <returns>
		/// The enumerator.
		/// </returns>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		System.Collections.Generic.IEnumerator<yShop.Core.Model.Product> System.Collections.Generic.IEnumerable<yShop.Core.Model.Product>.GetEnumerator() {
			throw new System.NotImplementedException();
		}
		#endregion
	
	
	
		#region ICollection[yShop.Core.Model.Product] implementation
		/// <summary>
		/// Add the specified item.
		/// </summary>
		/// <param name='item'>
		/// Item.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public void Add(yShop.Core.Model.Product item) {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Clear this instance.
		/// </summary>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public void Clear() {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Contains the specified item.
		/// </summary>
		/// <param name='item'>
		/// If set to <c>true</c> item.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public bool Contains(yShop.Core.Model.Product item) {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Copies to.
		/// </summary>
		/// <param name='array'>
		/// Array.
		/// </param>
		/// <param name='arrayIndex'>
		/// Array index.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public void CopyTo(yShop.Core.Model.Product[] array, int arrayIndex) {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Remove the specified item.
		/// </summary>
		/// <param name='item'>
		/// If set to <c>true</c> item.
		/// </param>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public bool Remove(yShop.Core.Model.Product item) {
			throw new System.NotImplementedException();
		}
	
	
	
		/// <summary>
		/// Gets the count.
		/// </summary>
		/// <value>
		/// The count.
		/// </value>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public int Count {
			get {
				throw new System.NotImplementedException();
			}
		}
	
	
	
		/// <summary>
		/// Gets a value indicating whether this instance is read only.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance is read only; otherwise, <c>false</c>.
		/// </value>
		/// <exception cref='System.NotImplementedException'>
		/// Is thrown when a requested operation is not implemented for a given type.
		/// </exception>
		public bool IsReadOnly {
			get {
				throw new System.NotImplementedException();
			}
		}
		#endregion		
			
		
		
		#region Data methods
		/// <summary>
		/// Gets all products.
		/// </summary>
		/// <returns>
		/// The all products.
		/// </returns>
		public List<Product> getAllProducts() {
			SqlConnection connection = Kernel.Instance.getConnection();
		
			SqlCommand command = new SqlCommand("select id, name, shortdescription, longdescription, price, homephoto from yshop_products", connection);
			SqlDataReader reader = command.ExecuteReader();
			
			List<Product> products = new List<Product>();
			
			while(reader.Read()) {
			Product product = new Product();
			
			product.Id = (int)reader[0];
			product.Name = reader[1].ToString();
			product.ShortDescription = reader[2].ToString();
			product.LongDescription = reader[3].ToString();
			product.Price = (decimal)reader[4];
			product.HomePhoto = reader[5].ToString();
			
			products.Add(product);
			}
			
			reader.Close();
			connection.Close();
			
			return products;
		}
		#endregion
	}
}