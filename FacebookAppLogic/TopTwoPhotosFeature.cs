using FacebookWrapper.ObjectModel;
using System;

namespace FacebookAppLogic
{
    public sealed class TopTwoPhotosFeature
    {
        private const int k_NumberOfPhotos = 2;
        private readonly FacebookObjectCollection<Photo> r_Photos;
        public Photo[] TopTwoPhotos { get; }

        public TopTwoPhotosFeature(FacebookObjectCollection<Photo> i_UserPhotos)
        {
            r_Photos = i_UserPhotos;
            TopTwoPhotos = new Photo[k_NumberOfPhotos];

            if (i_UserPhotos != null)
            {
                setTopTwoPhotos();
            }
        }

        private void setTopTwoPhotos()
        {
            try
            {
                TopTwoPhotos[0] = r_Photos[0];
                TopTwoPhotos[1] = r_Photos[0];
                foreach (Photo photo in r_Photos)
                {
                    if (photo.Comments.Count >= TopTwoPhotos[0].Comments.Count)
                    {                       
                        TopTwoPhotos[1] = TopTwoPhotos[0];
                        TopTwoPhotos[0] = photo;
                    }
                    else if((photo.Comments.Count < TopTwoPhotos[0].Comments.Count) && (photo.Comments.Count > TopTwoPhotos[1].Comments.Count))
                    {
                        TopTwoPhotos[1] = photo;
                    }
                    
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
