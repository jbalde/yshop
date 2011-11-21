using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace yShop.Core.Model
{
	public class Products : IList<Product>
	{
		public Products()
		{
		}
	
		#region IList[yShop.Core.Model.Product] implementation
		public int IndexOf(yShop.Core.Model.Product item)
		{
			throw new System.NotImplementedException();
		}
	
		public void Insert(int index, yShop.Core.Model.Product item)
		{
			throw new System.NotImplementedException();
		}
	
		public void RemoveAt(int index)
		{
			throw new System.NotImplementedException();
		}
	
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
		public System.Collections.IEnumerator GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
		#endregion
	
		#region IEnumerable[yShop.Core.Model.Product] implementation
		System.Collections.Generic.IEnumerator<yShop.Core.Model.Product> System.Collections.Generic.IEnumerable<yShop.Core.Model.Product>.GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
		#endregion
	
		#region ICollection[yShop.Core.Model.Product] implementation
		public void Add(yShop.Core.Model.Product item)
		{
			throw new System.NotImplementedException();
		}
	
		public void Clear()
		{
			throw new System.NotImplementedException();
		}
	
		public bool Contains(yShop.Core.Model.Product item)
		{
			throw new System.NotImplementedException();
		}
	
		public void CopyTo(yShop.Core.Model.Product[] array, int arrayIndex)
		{
			throw new System.NotImplementedException();
		}
	
		public bool Remove(yShop.Core.Model.Product item)
		{
			throw new System.NotImplementedException();
		}
	
		public int Count {
			get {
				throw new System.NotImplementedException();
			}
		}
	
		public bool IsReadOnly {
			get {
				throw new System.NotImplementedException();
			}
		}
		#endregion		
			
		
		
		
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
		
	}
}

