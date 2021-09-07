using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_KeyPressEventExample
{
  public class KeyEventArgs : EventArgs
  {
    public char ch;

  }
  public delegate void KeyHandler(object source, KeyEventArgs arg);

  public class KeyEvent
  {
    public event KeyHandler KeyPress;
    public void OnKeyPress(char key)
    {
      KeyEventArgs k = new KeyEventArgs();
      if (KeyPress != null)
      {
        k.ch = key;
        KeyPress(this, k);
      }
    }
  }
  class Program
  {
    static int count;

 
    static void Main(string[] args)
    {
      KeyEvent kevt=new KeyEvent();
      ConsoleKeyInfo key;
      
      kevt.KeyPress += new KeyHandler(kevt_KeyPress);
      Console.WriteLine("Enter some characters");
      do
      {
        key = Console.ReadKey();
        kevt.OnKeyPress(key.KeyChar);
      } while (key.KeyChar!='.');
      Console.WriteLine(count+" keys pressed.");
      Console.ReadKey();
    }

    private static void kevt_KeyPress(object source, KeyEventArgs arg)
    {
      count++;
      Console.WriteLine("\tReceived keystroke:"+arg.ch);
    }

    
  }
}
