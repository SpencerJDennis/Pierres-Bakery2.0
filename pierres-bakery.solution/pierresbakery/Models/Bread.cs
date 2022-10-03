using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }

    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }

    public int BreadCost()
    {
      int breadPrice = 5;

      if(BreadQuantity < 3)
      {
        int orderPrice = breadPrice * BreadQuantity;
        return orderPrice;
      }
      else if (BreadQuantity >= 3)
      {
        int freeBread = BreadQuantity / 3;

        int normalBreadPrice = BreadQuantity - freeBread;

        int discount = freeBread * breadPrice;

        int orderTotal = normalBreadPrice * breadPrice;

        return orderTotal;
      }
      else
      {
        return 0;
      }
    }
  }
}