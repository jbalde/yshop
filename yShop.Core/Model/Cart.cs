using System;

namespace yShop.Core.Model
{
	public class Cart
	{
		protected Products products;
		
		public Cart()
		{
			this.products = new Products();
		}

		public Products Products {
			get {
				return this.products;
			}
			set {
				products = value;
			}
		}

		
		public void add(int id, int amount) {
			Product product = new Product();
			product.Id = id;
			product.Amount = amount;
		
			this.add(product);
		}
		
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
		
		
		public void del(int id) {
			Product product = new Product();
			product.Id = id;
		
			this.del(product);
		}
		
		
		public void del(Product product) {
			for(int i = 0; i < this.products.Count; i++) {
				if(this.products[i].Id == product.Id) {
					this.products.RemoveAt(i);
					return;
				}
			}
		}
	}
}

