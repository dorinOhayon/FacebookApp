using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookAppLogic;

namespace FacebookWinFormsApp
{
    public partial class FormLogin : Form
    {
        private readonly LogicManager r_LogicManager;
        private FormFeatures m_FormFacebookFeatures;

        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_LogicManager = LogicManager.Instance;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
              r_LogicManager.LoginToFacebook();
              m_FormFacebookFeatures = FactoryOfForms.CreateNewForm(eFormType.FormFacebookFeatures, r_LogicManager) as FormFeatures;

              Hide();
              m_FormFacebookFeatures.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_LogicManager.LogoutFromFacebook();
            MessageBox.Show(@"Logout Succeed!", @"Logout");
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
