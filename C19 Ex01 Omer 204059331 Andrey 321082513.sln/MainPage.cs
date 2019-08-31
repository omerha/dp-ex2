using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApp;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    public partial class MainPage : Form
    {
        private AppLogic m_AppLogic;
        private UserData m_UserData;

        public MainPage()
        {
            InitializeComponent();
            m_AppLogic = AppLogic.Instance;
        }

        private void updateAllPanels(UserData i_User)
        {
            if (i_User != null)
            {
                postBindingSource.DataSource = i_User.NewsFeed;
                userPostsBindingSource.DataSource = i_User.Statuses;
                friendsBindingSource.DataSource = i_User.Friends;
                eventsCreatedBindingSource.DataSource = i_User.Events;
               // languagesBindingSource.DataSource = i_User.Pages;
               // bestFriendsBindingSource.DataSource = i_User.BestFriendsDict;
            }
        }

        private void updateUserPanel(UserData i_ToShow)
        {
            if (i_ToShow != null && i_ToShow.LocalUser != null)
            {
                userImage.Image = i_ToShow.LocalUser.ImageLarge;
                userName.Text = i_ToShow.LocalUser.Name;
                userBirthday.Text = i_ToShow.LocalUser.Birthday;

            }
        }

        private void showUIComponents()
        {
            panelPageOwner.Visible = true;
            panelUpPart.Visible = true;
        }

        private void hideUIComponents()
        {
            panelPageOwner.Visible = false;
            panelUpPart.Visible = false;     
        }

        private void loginFacebook()
        {
            try
            {
                m_UserData = m_AppLogic.LoginAndInit();
                showUIComponents();
            }
            catch(Exception)
            {
                MessageBox.Show("There was error trying to login to Facebook, please try again.");
            }

            updateUserPanel(m_UserData);
            updateAllPanels(m_UserData);
            Text = "Welcome To Facebook!";
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                m_AppLogic.PostStatus(textBoxPostStatus.Text, m_UserData.LocalUser);
            }
            catch (Exception)
            {
                MessageBox.Show("There was error trying to post status");
            }
        }

        private void buttonPostOnAllFriends_Click(object sender, EventArgs e)
        {
           MessageBox.Show(m_AppLogic.PostStatusToAllFriendsAdapter(m_UserData, textBoxPostStatus.Text));
        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {
            if (m_UserData != null)
            {
                m_AppLogic.LogOutFromFacebook();
                hideUIComponents();
                buttonLogInOut.Text = "Login";
                m_UserData = null;
            }
            else
            {
                loginFacebook();
                if (m_UserData != null)
                {
                    buttonLogInOut.Text = "Logout";
                }
            }
        }

        private void buttonTopFriends_Click(object sender, EventArgs e)
        {
            TopFriendsForUser top = TopWantedItemFactory.Build("Top friends", m_UserData, m_AppLogic) as TopFriendsForUser;
            listBoxTops.DisplayMember = "Name";
            listBoxTops.DataSource = top.TopList;
            labelTopTitle.Text = "Top friends";
        }

        private void buttonTopEvents_Click(object sender, EventArgs e)
        {
            TopEventsForUser top = TopWantedItemFactory.Build("Top events", m_UserData, m_AppLogic) as TopEventsForUser;
            listBoxTops.DisplayMember = "Name";
            listBoxTops.DataSource = top.TopList;
            labelTopTitle.Text = "Top events";
        }

        private void buttonTopPages_Click(object sender, EventArgs e)
        {
            TopPagesForUser top = TopWantedItemFactory.Build("Top pages", m_UserData, m_AppLogic) as TopPagesForUser;
            listBoxTops.DisplayMember = "Name";
            listBoxTops.DataSource = top.TopList;
            labelTopTitle.Text = "Top pages";
        }
    }
}
