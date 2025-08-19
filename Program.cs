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
		public static void Main(string[] args){
			Double balance = 10000;
			Dictionary<String, Double> products = new Dictionary<String, Double>();
			products.Add("Apple", 5.99);
			products.Add("Pizza", 9.99);
			products.Add("Eggs", 6.00);

			foreach (KeyValuePair<String, Double>kvp in products){
				Console.WriteLine("{0} {1}$", kvp.Key, kvp.Value);
			}
			Console.WriteLine(balance);
			balance = buyingProduct(products, "Apple", balance);
			Console.WriteLine(balance);
		}
	}
}
