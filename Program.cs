// See https://aka.ms/new-console-template for more information

namespace Store
{	
	
	class Program
	{

		public static double buyingProduct(Dictionary<String, Double> products, String productCost, Double balance)
		{
			balance -= products[productCost];
			return balance;
		}
		public static Dictionary<String, Double> addingProducts(String name, Double price)
		{
			
			Dictionary<String, Double> products = new Dictionary<String, Double>();
			products.Add(name, price);
			return products;
		}
		public static void Main(string[] args){
			Double balance = 10000;
			addingProducts("Apple", 5.99);
			addingProducts("Pizza", 9.99);
			addingProducts("Eggs", 6.00);

			foreach (KeyValuePair<String, Double>kvp in products){
				Console.WriteLine("{0} {1}$", kvp.Key, kvp.Value);
			}
			Console.WriteLine(balance);
			//balance = buyingProduct(products, "Apple", balance);
			Console.WriteLine(balance);
		}
	}
}
