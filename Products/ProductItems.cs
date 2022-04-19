using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ProductItems : Product
    {
        // To Create A List For All Products.
        // Cant Create A List In Abstract Class ( If We Do That,Sub Classes Has To Create Lists Too Which Is Not Wanted)

        // Print All Details Of Product - Start
        public override string[] printProperties()
        {
            string[] propers = new string[5];

            propers[0] = Id.ToString();
            propers[1] = Name.ToString();
            propers[2] = Price.ToString();
            propers[3] = ProductType.ToString();
            propers[4] = CoverPagePicture;

            return propers;
        }
        // Print All Details Of Product - End
    }
}