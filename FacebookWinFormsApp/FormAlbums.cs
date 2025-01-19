using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormAlbums : Form
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly GoBackVisitor GoBackVisitor;


        public FormAlbums(FacebookObjectCollection<Album> i_UserAlbums)
        {
            InitializeComponent();
            r_Albums = i_UserAlbums;
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAlbums).Start();
        }

        public CheckBox PhotosCheckBox // Make the CheckBox accessible
        {
            get { return PhotosFilterCheckBox; }
        }

        private void fetchAlbums()
        {
            try
            {
                listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = r_Albums));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Albums!");
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show(@"No Albums to retrieve :(");
            }
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {
            if (albumBindingSource.Current != null)
            {
                Album selectedAlbum = albumBindingSource.Current as Album;

                if (selectedAlbum.Photos?.Count > 0)
                {
                    FormAlbumPhotos formAlbumPhotos = new FormAlbumPhotos(selectedAlbum);
                    formAlbumPhotos.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"No photos in this album to retrieve :(");
                }
            }
            else
            {
                MessageBox.Show(@"No album was selected!");
            }
        }

        private void showFormAlbumsPhotos(Album i_SelectedAlbum)
        {
            FormAlbumPhotos formAlbumPhotos = new FormAlbumPhotos(i_SelectedAlbum);
            formAlbumPhotos.ShowDialog();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }

        private void PhotosFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
