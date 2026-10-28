using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPot
{
    internal class Program
    {
        public delegate void md(string dish, int minutes);

        
        static void Main(string[] args)
        {
            OnDishReady Odr= new OnDishReady();
            Chef ch= new Chef();
            Odr.onDishReady += ch.takeOffStove;
            Odr.onDishReady += (string dish, int minutes) => { Console.WriteLine("!!!!"); };
            Odr.onDishReady -= ch.takeOffStove;
            Odr.onDishReady -= ch.takeOffStove;
            Odr.StartCooking("בשר ביין", 240);

        }
    }
}
