using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookWinFormsApp
{
    public partial class FormFriends : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;
        private readonly FriendsSortStrategy r_FbFriendsSorter;
        private readonly GoBackVisitor GoBackVisitor;

        public FormFriends(FacebookObjectCollection<User> i_UserFriends)
        {
            InitializeComponent();
            r_Friends = i_UserFriends;
            r_FbFriendsSorter = new FriendsSortStrategy();
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchFriends();
        }

        private void fetchFriends(string i_SortStrategy = null)
        {
            try
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
            
                if (!string.IsNullOrEmpty(i_SortStrategy))
                {
                    eSort sortStrategy;
                    bool sortStrategyParsedSuccessfully = Enum.TryParse(i_SortStrategy, out sortStrategy);

                    if (sortStrategyParsedSuccessfully)
                    {
                        if (sortStrategy == eSort.Ascending)
                        {
                            r_FbFriendsSorter.SorterComparer = new AscendingComparer();
                        }
                        else if (sortStrategy == eSort.Descending)
                        {
                            r_FbFriendsSorter.SorterComparer = new DescendingComparer();
                        }

                        r_FbFriendsSorter.SortUserFriendsList(r_Friends);
                    }
                }

                foreach (User friend in r_Friends)  
                {
                    listBoxFriends.Items.Add(friend);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Friends! Sorry :(");
            }

            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show(@"No Friends :(");
            }
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortingMethodItem = sortByComboBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedSortingMethodItem))
            {
                fetchFriends(selectedSortingMethodItem);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                if (listBoxFriends.SelectedItem is User selectedGroup)
                {
                    try
                    {
                        pictureBoxFriend.LoadAsync(selectedGroup.PictureNormalURL);
                        pictureBoxFriend.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Error Fetching Friend Photo!");
                    }
                }
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }

    }
}

