using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ClassSample
{
    class Building
    {
        int floors;
        public int Floors
        {
            get { return floors; }
            set
            {
                if (value > 1)
                    floors = value;
                else
                    floors = 1;
            }
        }
        int area;
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        int occupants;
        public int Occupants
        {
            get { return occupants; }
            set { occupants = value; }
        }
        public int Room { get; set; }
        //public Building()
        //{
        //    Area = 100;

        //}
        //yerine 
        public Building():this(100,0,0)
        {
            // Area = 100;
           // Console.WriteLine("Boş constructor");
        }
        public override string ToString()
        {
            return Room.ToString();
        }
        public Building(int _area,int _floor,int _occupants)
        {
            Area = _area;
            Floors = _floor;
            Occupants = _occupants;
          //  Console.WriteLine("parametreli constructor");
        }
        public int MaxOccupants(int minArea)
        {
            return area / minArea;
        } 
        public int MaxOccupants( )
        {
            return area / 25;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
                Building home = new Building();
               // home.Area = 100;
            home.Floors = 5;
            home.Occupants = 6;
            home.Room = 12;
          
            Building office = new Building();
            Console.WriteLine("Area:"+home.Area.ToString());
            Console.WriteLine("Flors:"+home.Floors.ToString());
            Console.WriteLine("Occupants:" + home.Occupants.ToString());
            Console.WriteLine("Max Occupants:" + home.MaxOccupants(20));
            Console.WriteLine("Rooms:"+home.ToString());
            Console.ReadKey();
        }
    }
}
