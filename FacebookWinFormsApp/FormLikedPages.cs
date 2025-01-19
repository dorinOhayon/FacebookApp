using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormLikedPages : Form
    {
        private readonly FacebookObjectCollection<Page> r_LikedPages;
        private readonly GoBackVisitor GoBackVisitor;

        public FormLikedPages(FacebookObjectCollection<Page> i_UserLikedPages)
        {
            InitializeComponent();
            r_LikedPages = i_UserLikedPages;
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchLikedPages).Start();
        }

        private void fetchLikedPages()
        {
            try
            {
                listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = r_LikedPages));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error Fetching Liked Pages! Sorry:(");
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show(@"No liked pages to retrieve:(");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }
    }
}
