using System;
namespace Project1 
{
public class Program : GetProducts
{
	public static void Main()
	{
		Console.WriteLine("Hello Please enter number of product you want");
		int num = Convert.ToInt16(Console.ReadLine());
		int total=0;
		GetProducts getp=new GetProducts();
		for (int i=0;i<num;i++)
		{
			Console.Write("Hello Please enter your product {0}(A-D)",i);
			string prod = Console.ReadLine();
			int price =getp.GetProductCost(prod);
			total+=price;
		}
		
		Console.WriteLine("Your bill is {0}",total);
	}
	
	
}
}

public abstract class  Products
{
    public int ProductA() { return 50; }
    public int ProductB() { return 30; }	
    public int ProductC() { return 20; }		
	public int ProductD() { return 15; }
	public int ProductAB() { return 130; }
	public int ProductBC() { return 45; }
	public int ProductCD() { return 30; }	
 
}

public class GetProducts : Products
{
	 public  int GetProductCost(string prod)
	{
		switch(prod)
		{
			case "A":
				return ProductA();
			case "B":
				return ProductB();
			case "C":
				return ProductC();
			case "D":
				return ProductD();
			case "AB":
				return ProductAB();
			case "BC":
				return ProductBC();
			case "CD":
				return ProductCD();
		}
		return 0;
	}
}

