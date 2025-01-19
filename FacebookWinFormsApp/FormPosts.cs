using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormPosts : Form
    {
        private readonly User r_User;
        private readonly FacebookObjectCollection<Post> r_UserPosts;
        private readonly GoBackVisitor GoBackVisitor;

        public FormPosts(User i_User)
        {
            InitializeComponent();
            r_User = i_User;
            r_UserPosts = r_User.Posts;
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchPosts();
        }

        private void fetchPosts()
        {
            try
            {
                listBoxPosts.Items.Clear();
                foreach (Post post in r_UserPosts)
                {
                    listBoxPosts.Items.Add(new PostsProxy {Post = post });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Posts! Sorry :(");
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show(@"No Posts to retrieve :(");
            }
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_User.PostStatus(textBoxPosts.Text);
                
                MessageBox.Show(@"Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Posting!");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBoxPost.Image = null;
                Post selected = r_UserPosts[listBoxPosts.SelectedIndex];
                
                if (selected.Type == Post.eType.photo)
                {
                    pictureBoxPost.LoadAsync(selected.PictureURL);
                    pictureBoxPost.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                listBoxPostComments.DisplayMember = "Message";
                listBoxPostComments.DataSource = selected.Comments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Post Comments! Sorry:(");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }
    }
}
