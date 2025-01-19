using System;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormFeatures : Form
    {
        private readonly User r_LoggedInUser;
        private FormPosts m_FormPosts;
        private FormFriends m_FormFriends;
        private FormAlbums m_FormAlbums;
        private FormEvents m_FormEvents;
        private FormGroups m_FormGroups;
        private FormLikedPages m_FormLikedPages;
        private FormFavoriteTeams m_FormFavoriteTeams;
        private FormNotAttendEvents m_FormNotAttendEvents;
        private FormTwoPhotosWithMostComments m_FormTwoPhotosWithMostComments;


        public FormFeatures(LogicManager i_LogicManager)
        {
           r_LoggedInUser = i_LogicManager.LoggedInUser;
            InitializeComponent();
           CreateForms();
        }

        private void CreateForms()
        {
            new Thread(CreateFormPosts).Start();
            new Thread(CreateFormFriends).Start();
            new Thread(CreateFormAlbums).Start();
            new Thread(CreateFormEvents).Start();
            new Thread(CreateFormGroups).Start();
            new Thread(CreateFormLikedPages).Start();
            new Thread(CreateFormNotAttendEvents).Start();
            new Thread(CreateFormFavoriteTeams).Start();
            m_FormTwoPhotosWithMostComments = FactoryOfForms.CreateNewForm(eFormType.FormTwoPhotosWithMostComments, LogicManager.Instance) as FormTwoPhotosWithMostComments;
        }

        private void CreateFormNotAttendEvents()
        {
            m_FormNotAttendEvents = FactoryOfForms.CreateNewForm(eFormType.FormNotAttendEvents, LogicManager.Instance) as FormNotAttendEvents;
        }

        private void CreateFormFavoriteTeams()
        {
            m_FormFavoriteTeams = FactoryOfForms.CreateNewForm(eFormType.FormFavoriteTeams, LogicManager.Instance) as FormFavoriteTeams;
        }

        private void CreateFormLikedPages()
        {
            m_FormLikedPages = FactoryOfForms.CreateNewForm(eFormType.FormLikedPages, LogicManager.Instance) as FormLikedPages;
        }

        private void CreateFormGroups()
        {
            m_FormGroups = FactoryOfForms.CreateNewForm(eFormType.FormGroups, LogicManager.Instance) as FormGroups;
        }

        private void CreateFormEvents()
        {
            m_FormEvents = FactoryOfForms.CreateNewForm(eFormType.FormEvents, LogicManager.Instance) as FormEvents;
        }

        private void CreateFormAlbums()
        {
            m_FormAlbums = FactoryOfForms.CreateNewForm(eFormType.FormAlbums, LogicManager.Instance) as FormAlbums;
        }

        private void CreateFormFriends()
        {
            m_FormFriends = FactoryOfForms.CreateNewForm(eFormType.FormFriends, LogicManager.Instance) as FormFriends;
        }

        private void CreateFormPosts()
        {
            m_FormPosts = FactoryOfForms.CreateNewForm(eFormType.FormPosts, LogicManager.Instance) as FormPosts;
        }

        protected override void OnShown(EventArgs e) 
        {
            base.OnShown(e);
            FetchUserInfo();
        }

        private void FetchUserInfo()
        {
            try
            {
                PictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
                PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                LabelName.Text = r_LoggedInUser.Name;
                LabelBirthday.Text = r_LoggedInUser.Birthday;
                LabelEmail.Text = r_LoggedInUser.Email;
                LabelLocation.Text = r_LoggedInUser.Location.ToString();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message, @"Error Fetching User Info! Sorry:(");
            }
        }

        private void pictureBoxPosts_Click(object sender, EventArgs e)
        {
            m_FormPosts.ShowDialog();
        }

        private void pictureBoxFriends_Click(object sender, EventArgs e)
        {
            m_FormFriends.ShowDialog();
        }

        private void pictureBoxAlbums_Click(object sender, EventArgs e)
        {
            m_FormAlbums.ShowDialog();
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
            m_FormEvents.ShowDialog();
        }

        private void pictureBoxGroups_Click(object sender, EventArgs e)
        {
            m_FormGroups.ShowDialog();
        }

        private void pictureBoxLikedPages_Click(object sender, EventArgs e)
        {
            m_FormLikedPages.ShowDialog();
        }

        private void pictureBoxFavoriteTeams_Click(object sender, EventArgs e)
        {
            m_FormFavoriteTeams.ShowDialog();
        }

        private void pictureBoxNotAttendEvents_Click(object sender, EventArgs e)
        {
            m_FormNotAttendEvents.ShowDialog();
        }

        private void pictureBoxTopTwoPhotos_Click(object sender, EventArgs e)
        {
            m_FormTwoPhotosWithMostComments.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogicManager.Instance.LogoutFromFacebook();
            MessageBox.Show(@"Logout Succeed!", @"Logout");
            this.Close();
        }
    }
}
