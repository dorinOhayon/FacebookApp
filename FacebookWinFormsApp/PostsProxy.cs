using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    class PostsProxy
    {
        public Post Post { get; set; }

        public override string ToString()
        {
            if (Post.Message != null)
            {
                return string.Format("{0} ({1})", Post.Message, Post.Name);
            }
            else if (Post.Caption != null)
            {
                return string.Format("{0} ({1})", Post.Caption, Post.Name);
            }
            else
            {
                return string.Format("[{0}]", Post.Type);
            }
        }
    }
}
