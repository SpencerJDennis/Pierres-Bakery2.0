using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery 
{
  public class Program
{
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. Bread costs $5.00 per loaf. If you buy two loaves the third loaf will be free. Pastries are sold for $2.00 a piece. If you buy three pastries the third pastry will be discounted by $1.00!");
      Console.WriteLine("How many loaves of bread would you like to order?");
      string BreadQuantity = Console.ReadLine();
      int numberOfLoaves = Int32.Parse(BreadQuantity);

      Console.WriteLine("How many pastries would you like to order?");
      string PastryQuantity = Console.ReadLine();
      int numberOfPastries = Int32.Parse(PastryQuantity);

      Bread orderBread = new Bread(numberOfLoaves);
      Pastry orderPastry = new Pastry(numberOfPastries);

      int breadTotal = orderBread.BreadCost();
      int pastryTotal =  orderPastry.PastryCost();
   
      int totalPrice = breadTotal + pastryTotal;

      Console.WriteLine("Your total is $" + totalPrice);
    }
  }
}

