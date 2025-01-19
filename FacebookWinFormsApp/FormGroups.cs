using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormGroups : Form
    {
        private readonly FacebookObjectCollection<Group> r_Groups;
        private readonly GoBackVisitor GoBackVisitor;

        public FormGroups(FacebookObjectCollection<Group> i_UserGroups)
        {
            InitializeComponent();
            r_Groups = i_UserGroups;
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchGroups).Start();
        }

        private void fetchGroups()
        {
            try
            {
                listBoxGroups.Invoke(new Action(() => groupBindingSource.DataSource = r_Groups));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Groups! Sorry:(");
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show(@"No Groups to retrieve:(");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }
    }
}
