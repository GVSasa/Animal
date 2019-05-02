using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalCat.Classes;
namespace AnimalCat.Classes
{
   class Cat : AnimalData, Interface
    {
         public void Talk(string z )
        {
            throw new NotImplementedException();
        }

        internal static void Talk()
        {
            throw new NotImplementedException();
        }

       

    }

     

}
