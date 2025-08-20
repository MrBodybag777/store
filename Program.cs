// See https://aka.ms/new-console-template for more information

namespace Store
{	
	
	class Program
	{

		public static void buyingProduct(Dictionary<String, Double> products, String product, Double balance)
		{
			balance -= products[product];
		}
		public static void shoppingLoop(Dictionary<String, Double> products, Double balance)
		{	
			for(;;){
				List<String> cart = new List<String>();

				Console.WriteLine("What item would you like to purches: ");
				Console.WriteLine("Or checkout");
				String desiredProduct = "";
				desiredProduct += Console.ReadLine();
				
				if (desiredProduct == "checkout"){
					foreach (String product in cart){
						buyingProduct(products, product, balance);
					}
					break;
				}
				if (products.ContainsKey(desiredProduct)){
					cart.Add(desiredProduct);
				}
				else{
					Console.WriteLine("We do not have that product please try again");
				}
			}
		}
		public static void Main(string[] args){
			Dictionary<String, Double> products = new Dictionary<String, Double>();
			Double balance = 10000;
			products.Add("Apple", 5.99);
			products.Add("Pizza", 9.99);
			products.Add("Eggs", 4.59);
			foreach (KeyValuePair<String, Double>kvp in products){
				Console.Write("--{0} {1}$--", kvp.Key, kvp.Value);
			}
			Console.Write("\n");
			shoppingLoop(products, balance);
			Console.WriteLine(balance);

		}
	}
}
