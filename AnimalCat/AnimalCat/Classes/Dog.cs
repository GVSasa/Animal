using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCat.Classes
{
    class Dog : AnimalData, Interface
    {
        void Interface.Talk(string z = "wuau")
        {
            throw new NotImplementedException();
        }

        internal static void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
