using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace FacebookAppLogic
{
    public class CollectionOfPhotos : IEnumerable<Photo>
    {
        private readonly FacebookObjectCollection<Photo> r_Photos;

        public CollectionOfPhotos(FacebookObjectCollection<Photo> i_Photos)
        {
            r_Photos = i_Photos;
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            for (int i = 0; i < r_Photos.Count; i++)
            {
                if (r_Photos[i].Comments.Count > 0) 
                {
                    yield return r_Photos[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
