using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormFavoriteTeams : Form
    {
        private readonly Page[] r_FavoriteTeams;
        private readonly GoBackVisitor GoBackVisitor;

        public FormFavoriteTeams(Page[] i_UserFavoriteTeams)
        {
            InitializeComponent();
            r_FavoriteTeams = i_UserFavoriteTeams;
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            try
            {
                listBoxFavoriteTeams.Items.Clear();
                listBoxFavoriteTeams.DisplayMember = "Name";

                if (r_FavoriteTeams != null)
                {
                    foreach (Page team in r_FavoriteTeams)
                    {
                        listBoxFavoriteTeams.Items.Add(team);
                    }
                }
                else
                {
                    MessageBox.Show(@"Error Fetching Favorite teams! Sorry :(");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error Fetching Favorite teams! Sorry :(");
            }

            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show(@"No Favorite teams to retrieve :(");
            }
        }

        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                if (listBoxFavoriteTeams.SelectedItem is Page selectedTeam)
                {
                    try
                    {
                        pictureBoxTeam.LoadAsync(selectedTeam.PictureNormalURL);
                        pictureBoxTeam.SizeMode = PictureBoxSizeMode.StretchImage;
                        richTextBoxTeamDescription.Text = selectedTeam.Description;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Error Fetching Team Information! Sorry :(");
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
