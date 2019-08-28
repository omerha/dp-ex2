using FacebookApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    public partial class TopPagesForm : Form, ITopWantedItemForm
    {
        public TopPagesForm(UserData i_UserData)
        {
            InitializeComponent();
        }

        public void GetData(AppLogic i_AppLogic)
        {

        }

        private void pageLiked_OnIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
