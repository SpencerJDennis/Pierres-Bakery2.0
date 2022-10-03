using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQuantity { get; set; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }

    public int PastryCost()
    {
     
      int pastryPrice = 2;
      int pastryDiscountPrice = 1;

      if(PastryQuantity < 3)
      {
      int orderPrice = pastryPrice * PastryQuantity;
      return orderPrice;
      }
      else if (PastryQuantity >= 3)
      {
      int discountPastry = PastryQuantity / 3;

      int normalPastryPrice = PastryQuantity - discountPastry;
      
      int discount = discountPastry * pastryDiscountPrice;
      
      int normalPastry = normalPastryPrice * pastryPrice;
      
      int orderTotal = discount + normalPastry;
      
      return orderTotal;
      }
      else
      {
      return 0;
      }
    }
  }
} 