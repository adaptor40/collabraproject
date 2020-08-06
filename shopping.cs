using System;
namespace Project1 
{
public class Program : GetProducts
{
	public static void Main()
	{
		Console.WriteLine("Hello Please enter number of product you want(A/B/C/D)");
		int num = Convert.ToInt16(Console.ReadLine());
		int total=0;
		int promototal=0;
		string prodstring=String.Empty;
		GetProducts getp=new GetProducts();
		for (int i=0;i<num;i++)
		{
			Console.Write("Hello Please enter your product {0}: ",i);
			string prod = Console.ReadLine();
			prodstring+=prod;
			int price =getp.GetProductCost(prod);
			total+=price;
			
		}
		
		Console.WriteLine("Your bill is {0}",total);
		promototal = getp.ApplyPromotion(prodstring,total);
		Console.WriteLine("Your promotion bill is {0}",promototal);
	}
	
	
}
}

public abstract class  Products
{
    public int ProductA() { return 50; }
    public int ProductB() { return 30; }	
    public int ProductC() { return 20; }		
	public int ProductD() { return 15; }
	public int ProductAAA() { return -20; }
	public int ProductBB() { return -15; }
	public int ProductCD() { return -5; }	
 
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
			/*case "AAA":
				return ProductAAA();
			case "BB":
				return ProductBB();
			case "CD":
				return ProductCD();*/
		}
		return 0;
	}
	
	public int ApplyPromotion(string strProducts,int total)
	{
		char []arr = strProducts.ToCharArray();  
        Array.Sort(arr);  
		string prdstring = String.Join("",arr);
		
		while (prdstring.Length>0)
		{
			if (prdstring.IndexOf("AAA")>=0)
			{
				total+=ProductAAA();
				prdstring=prdstring.Remove(prdstring.IndexOf("AAA"),3);
				
			}
			if (prdstring.IndexOf("BB")>=0)
			{
				total+=ProductBB();
				prdstring=prdstring.Remove(prdstring.IndexOf("BB"),2);
				
			}
			if (prdstring.IndexOf("CD")>=0)
			{
				total+=ProductCD();
				prdstring=prdstring.Remove(prdstring.IndexOf("CD"),2);
				
			}
			if ((prdstring.IndexOf("AAA")<=0) && (prdstring.IndexOf("BB")<=0) &&  (prdstring.IndexOf("CD")<=0))
			{
				break;
			}
			
			
		}
		return total;
	}
}

