using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookApp;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    class TopEventsForUser : ITopWantedItem
    {
        private List<Event> m_TopEventsForUser { get; set; }
        public void GetData(AppLogic i_AppLogic, UserData i_UserData)
        {
            m_TopEventsForUser = i_AppLogic.GetTopNumberEvents(i_UserData);
        }
    }
}
