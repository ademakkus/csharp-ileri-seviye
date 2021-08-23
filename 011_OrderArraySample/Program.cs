using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_OrderArraySample
{
  public class OrderComparer : IComparer
  {
    public int Compare(object x, object y)
    {
      //throw new NotImplementedException();
      if (x is Order && y is Order)
      {
        Order p1 = (Order)x;
        Order p2 = (Order)y;
        if (p1.GetGrandTotal() > p2.GetGrandTotal())
          return 1;
        else if (p1.GetGrandTotal() < p2.GetGrandTotal())
          return -1;
        else
          return 0;

      }
      else
        throw new ArgumentException();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Order order1 = new Order();
      Elma e1 = new Elma();
      e1.Cost = 10;
      e1.Quantity = 10;
      Altın a1 = new Altın();
      a1.Cost = 100;
      a1.Quantity = 2;
      order1.AddProduct(e1);
      order1.AddProduct(a1);
      Console.WriteLine(order1.GetGrandTotal());
      Order order2 = new Order();
      Elma e2 = new Elma();
      e2.Cost = 20;
      e2.Quantity = 10;
      Altın a2 = new Altın();
      a2.Cost = 400;
      a2.Quantity = 2;
      order2.AddProduct(e2);
      order2.AddProduct(a2);

      ArrayList siparisler = new ArrayList();
      siparisler.Add(order1);
      siparisler.Add(order2);
      siparisler.Sort(new OrderComparer());
      foreach (Order order in siparisler)
      {
        Console.WriteLine(order.ToString());
      }

      Console.ReadKey();


    }
  }
}
