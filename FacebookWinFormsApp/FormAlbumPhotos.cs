using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookWinFormsApp
{
    public partial class FormAlbumPhotos : Form
    {
        private readonly Album r_Album;
        public AlbumPhotosLogic m_AlbumPhotosLogic;

        public FormAlbumPhotos(Album i_UserAlbum)
        {
            m_AlbumPhotosLogic = new AlbumPhotosLogic();
            InitializeComponent();
            r_Album = i_UserAlbum;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchPhotos();
        }

        private void fetchPhotos()
        {
            try
            {
                LabelPhotos.Text = r_Album.Name;
                bool isCheckBoxChecked = ((FormAlbums)Application.OpenForms["FormAlbums"]).PhotosCheckBox.Checked;

                if (isCheckBoxChecked)
                {
                    CollectionOfPhotos filteredPhotos = new CollectionOfPhotos(r_Album.Photos);

                    foreach (Photo photo in filteredPhotos)
                    {
                        Invoke(new Action(() => Controls.Add(m_AlbumPhotosLogic.getPictureBoxPhotoLocation(photo))));
                        if (m_AlbumPhotosLogic.setPictureBoxIndex())
                        {
                            break;
                        }
                    }
                }

                else
                {
                    foreach (Photo photo in r_Album.Photos)
                    {
                        Invoke(new Action(() => Controls.Add(m_AlbumPhotosLogic.getPictureBoxPhotoLocation(photo))));
                        if (m_AlbumPhotosLogic.setPictureBoxIndex())
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error fetching album photos! Sorry:(");
            }
        }
    }
    
}
