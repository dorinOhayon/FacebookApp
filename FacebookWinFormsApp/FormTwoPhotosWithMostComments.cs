using System;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormTwoPhotosWithMostComments : Form
    {
        private readonly Photo[] m_TopTwoPhotos;
        private readonly GoBackVisitor GoBackVisitor;

        public FormTwoPhotosWithMostComments(FacebookObjectCollection<Photo> i_UserPhotosTaggedIn)
        {
            GoBackVisitor = new GoBackVisitor();
            InitializeComponent();
            try
            {
                m_TopTwoPhotos = new TopTwoPhotosFeature(i_UserPhotosTaggedIn).TopTwoPhotos;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Top Two Photos!");
            }
        }
        
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            showTopTwoPhotos();
        }

        private void showTopTwoPhotos()
        {
            showTopPhotoInfo(PictureBoxTopFirst, 0);
            showTopPhotoInfo(pictureBoxTopSecond, 1);
        }

        private void showTopPhotoInfo(PictureBox i_PictureBox, int i_PhotoPlace)
        {
            if (m_TopTwoPhotos[i_PhotoPlace] != null)
            {
                i_PictureBox.LoadAsync(m_TopTwoPhotos[i_PhotoPlace].PictureNormalURL);
                i_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                i_PictureBox.Image = i_PictureBox.ErrorImage;
            }

            i_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBoxTopFirst_Click(object sender, EventArgs e)
        {
            fetchTopPhotoComments(0);
        }

        private void pictureBoxTopSecond_Click(object sender, EventArgs e)
        {
            fetchTopPhotoComments(1);
        }
   
        private void fetchTopPhotoComments(int i_PhotoPlace)
        {
            try
            {
                FacebookObjectCollection<Comment> photosComments = m_TopTwoPhotos[(int)i_PhotoPlace].Comments;
                listBoxPhotoComments.Items.Clear();

                foreach (var comment in photosComments)
                {
                    listBoxPhotoComments.Items.Add(comment);
                }

                listBoxPhotoComments.DisplayMember = "Message";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, string.Format(@"Error Fetching {0} Photo's Comments!", i_PhotoPlace));
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }

        private void LabelTopTwoPhotos_Click(object sender, EventArgs e)
        {

        }
    }
}