using FacebookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    public interface ITopWantedItemForm
    {
        void GetData(AppLogic i_AppLogic);
    }
    public static class TopWantedItemFormFactory
    {
        public static ITopWantedItemForm Build(string i_WantedItem, UserData i_UserData)
        {
            ITopWantedItemForm res = null;
            switch (i_WantedItem)
            {
                case "Top friends":
                    res = new TopFriendsForm(i_UserData);
                    break;
                case "Top events":
                    res = new TopEventsForm(i_UserData);
                    break;
                case "Top pages":
                    res = new TopPagesForm(i_UserData);
                    break;
                default:
                    break;

            }
            return res;
        }
    }
}
