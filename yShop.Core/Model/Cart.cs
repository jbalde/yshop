using System;



namespace yShop.Core.Model {
	/// <summary>
	/// Shopping cart model
	/// </summary>
	public class Cart {
		#region Attributes
		/// <summary>
		/// The products.
		/// </summary>
		protected Products products;
		#endregion
		
		
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="yShop.Core.Model.Cart"/> class.
		/// </summary>
		public Cart() {
			this.products = new Products();
		}//Cart
		#endregion
		
		
		
		#region Properties
		/// <summary>
		/// Gets or sets the products.
		/// </summary>
		/// <value>
		/// The products.
		/// </value>
		public Products Products {
			get {
				return this.products;
			}
			set {
				products = value;
			}
		}
		#endregion
		
		
		
		#region Model methods
		/// <summary>
		/// Add the specified id and amount.
		/// </summary>
		/// <param name='id'>
		/// Identifier.
		/// </param>
		/// <param name='amount'>
		/// Amount.
		/// </param>
		public void add(int id, int amount) {
			Product product = new Product();
			product.Id = id;
			product.Amount = amount;
		
			this.add(product);
		}
		
		
		
		/// <summary>
		/// Add the specified product.
		/// </summary>
		/// <param name='product'>
		/// Product.
		/// </param>
		public void add(Product product) {
			for(int i = 0; i < this.products.Count; i++) {
				if(this.products[i].Id == product.Id) {
					this.products[i].Amount += product.Amount;
					return;
				}
			}
		
			product.fillProduct();
			this.products.Add(product);
		}
		
		
		
		/// <summary>
		/// Del the specified id.
		/// </summary>
		/// <param name='id'>
		/// Identifier.
		/// </param>
		public void del(int id) {
			Product product = new Product();
			product.Id = id;
		
			this.del(product);
		}
		
		
		
		/// <summary>
		/// Del the specified product.
		/// </summary>
		/// <param name='product'>
		/// Product.
		/// </param>
		public void del(Product product) {
			for(int i = 0; i < this.products.Count; i++) {
				if(this.products[i].Id == product.Id) {
					this.products.RemoveAt(i);
					return;
				}
			}
		}
		#endregion
	}
}