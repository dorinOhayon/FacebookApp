using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookAppLogic
{
    public sealed class AlbumPhotosLogic
    {
        int m_PhotoIndex = 0, m_RowIndex = 1, m_ColIndex = 1;
        const int k_Width = 75, k_Height = 75, k_DropLine = 5, k_MaxPhotos = 25;

        public PictureBox getPictureBoxPhotoLocation(Photo photo)
        {
            PictureBox pictureBoxPhoto = new PictureBox();
            pictureBoxPhoto.LoadAsync(photo.PictureAlbumURL);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxPhoto.Location = new Point(m_ColIndex * (pictureBoxPhoto.Width + 5), m_RowIndex * (pictureBoxPhoto.Height + 5));
            pictureBoxPhoto.Width = k_Width;
            pictureBoxPhoto.Height = k_Height;
            pictureBoxPhoto.TabIndex = m_PhotoIndex;

            return pictureBoxPhoto;
        }

        public bool setPictureBoxIndex()
        {
            bool b_IsLimiteMaxPhotos = false;
            m_PhotoIndex++;

            if (m_PhotoIndex % k_DropLine == 0)
            {
                m_RowIndex += 2;
                m_ColIndex = 0;
            }

            if (m_PhotoIndex == k_MaxPhotos)
            {
                b_IsLimiteMaxPhotos = true;
            }

            m_ColIndex++;

            return b_IsLimiteMaxPhotos;
        }

    }
}

