using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_OrderArraySample
{
  public class Product : IOrderDetail
  {
    //private int quantity;
    public int Quantity { get; set; }
    public double Cost { get; set; }

    public virtual double GetTotalCost()
    {
      //throw new NotImplementedException();
      return Cost * Quantity;
    }
  }
  class Elma : Product
  { }
  class Altın : Product
  {
    public override double GetTotalCost()
    {
      return base.Cost * base.Quantity * 2;
    }
  }

  public class Order
  {
    ArrayList products = new ArrayList();
    public void AddProduct(Product urun)
    {
      products.Add(urun);
    }
    public double GetGrandTotal()
    {
      double toplam = 0;
      foreach (Product _urun in products)
      {
       toplam += _urun.GetTotalCost();
      }
      return toplam;
    }
    public override string ToString()
    {
      return this.GetGrandTotal().ToString();
    }
  }
}
 
