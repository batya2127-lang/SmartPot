using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartPot.Program;

namespace SmartPot
{
    internal class OnDishReady
    {
        public event md onDishReady;
         public void StartCooking(string dish, int munutes)
        {
            for (int i = 0; i < munutes; i++) { }
            onDishReady?.Invoke(dish, munutes);
        }                                                                                                                                                           
    }
}
