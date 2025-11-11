using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject.MainUserControl
{
    // CartItem.cs
    namespace FinalCPE142LProject
    {
        public class CartItem
        {
            public string Name { get; set; }
            public string Price { get; set; }

            public CartItem(string name, string price)
            {
                Name = name;
                Price = price;
            }
        }
    }
}
