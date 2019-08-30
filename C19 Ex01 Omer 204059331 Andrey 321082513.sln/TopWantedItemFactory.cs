using FacebookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    public interface ITopWantedItem
    {
        void GetData(AppLogic i_AppLogic, UserData i_UserData);
    }
    public static class TopWantedItemFactory
    {
        public static ITopWantedItem Build(string i_WantedItem, UserData i_UserData, AppLogic i_AppLogic)
        {
            ITopWantedItem res = null;
            switch (i_WantedItem)
            {
                case "Top friends":
                    res = new TopFriendsForUser();
                    break;
                case "Top events":
                    res = new TopEventsForUser();
                    break;
                case "Top pages":
                    res = new TopPagesForUser();
                    break;
                default:
                    break;

            }
            return res;
        }
    }
}
