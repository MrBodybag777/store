
namespace Store
{	
	
	class Program
	{
		public static void reciptMaker(Dictionary<String, Double> products, List<String> cart,ref double balance)
		{
			double itemValue = 0;
			double total = 0;
			Console.WriteLine("\nRecipt~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			foreach(String item in cart){
				itemValue = products[item];
				Console.WriteLine("Product bought: {0} \nCost: {1}", item.PadLeft(31), Convert.ToString(itemValue).PadLeft(41));
				Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				total += itemValue;
			}
			Console.WriteLine("Total Amount:{0}", Convert.ToString(total).PadLeft(34));
			Console.WriteLine("Remaining Blance: {0}", Convert.ToString(balance).PadLeft(29));
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

		}
		public static void buyingProduct(Dictionary<String, Double> products, String product,ref Double balance)
		{
			balance -= products[product];
		}
		public static void shoppingLoop(Dictionary<String, Double> products,ref Double balance)
		{	
			List<String> cart = new List<String>();
			for(;;){

				Console.WriteLine("What item would you like to purches: ");
				Console.WriteLine("Or checkout");
				String desiredProduct = "";
				desiredProduct += Console.ReadLine();
				
				if (desiredProduct == "checkout"){
					foreach (String product in cart){
						buyingProduct(products, product,ref balance);
					}
					reciptMaker(products, cart,ref balance);
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
			products.Add("Soda", 1.99);
			foreach (KeyValuePair<String, Double>kvp in products){
				Console.Write("--{0} {1}$--", kvp.Key, kvp.Value);
			}
			Console.Write("\n");
			shoppingLoop(products,ref balance);
		}
	}
}
