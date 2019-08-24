using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    public interface ITopWantedItemForm { }
    public static class TopWantedItemFormFactory
    {
        public static ITopWantedItemForm Build(string i_WantedItem)
        {
            ITopWantedItemForm res = null;
            switch (i_WantedItem)
            {

            }
            return res;
        }
    }
}
