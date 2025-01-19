using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormEvents : Form
    {
        private readonly FacebookObjectCollection<Event> r_Events;
        private DateTime? m_StartTime;
        private DateTime? m_EndTime;
        private readonly GoBackVisitor GoBackVisitor;

        public FormEvents(FacebookObjectCollection<Event> i_Events)
        {
            InitializeComponent();
            r_Events = i_Events;
            m_StartTime = null;
            m_EndTime = null;
            GoBackVisitor = new GoBackVisitor();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            m_StartTime = dateTimePickerStart.Value;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            m_EndTime = dateTimePickerEnd.Value;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (m_StartTime != null && m_EndTime != null)
            {
                fetchEventsByDate();
            }
            else
            {
                MessageBox.Show(@"You must add an events start and end time!");
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchEventsByDate).Start();
        }

        private void fetchEventsByDate()
        {
            try
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = r_Events));
            }
            catch (Exception)
            {
                MessageBox.Show("Error Fetching Events! Sorry :(");
            }
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show(@"No events in that date to retrieve :(");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeFormAndGoToFeaturesForm(this);
        }
    }
}
