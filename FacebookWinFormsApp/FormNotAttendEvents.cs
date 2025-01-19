using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormNotAttendEvents : Form
    {
        private readonly FacebookObjectCollection<Event> r_EventsYouAreNotYetConfirmed;
        private Event m_SelectedEvent;
        private readonly GoBackVisitor GoBackVisitor;

        public FormNotAttendEvents(FacebookObjectCollection<Event> i_UserEventsNotYetConfirme)
        {
            InitializeComponent();
            r_EventsYouAreNotYetConfirmed = i_UserEventsNotYetConfirme;
            m_SelectedEvent = null;
            GoBackVisitor = new GoBackVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchEventsNotYetConfirmed();
        }

        private void fetchEventsNotYetConfirmed()
        {
            try
            {
                listBoxEventsNotYetConfirmed.Invoke(new Action(() => NotAttendEventBindingSource.DataSource = r_EventsYouAreNotYetConfirmed));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Fetching Events! Sorry:(");
            }

            if (listBoxEventsNotYetConfirmed.Items.Count == 0)
            {
                MessageBox.Show(@"No events not yet confirmed to retrieve:(");
            }
        }

        private void listBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEventsNotYetConfirmed.SelectedItems.Count == 1)
            {
                m_SelectedEvent = listBoxEventsNotYetConfirmed.SelectedItem as Event;

                if (m_SelectedEvent != null)
                { 
                    try
                    {
                        pictureBoxEvent.LoadAsync(m_SelectedEvent.PictureNormalURL);
                        pictureBoxEvent.SizeMode = PictureBoxSizeMode.StretchImage;
                        LabelStartTime.Text = m_SelectedEvent.StartTime.ToString();
                        LabelEndTime.Text = m_SelectedEvent.EndTime.ToString();
                        LabelLocation.Text = m_SelectedEvent.Location;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Error Fetching Event Information! Sorry:(");
                    }
                }
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }

        private void LabelNotYetConfirmedEvents_Click(object sender, EventArgs e)
        {

        }
    }
}
