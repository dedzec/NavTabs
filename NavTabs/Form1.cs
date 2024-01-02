using NavTabs.UserControls;

namespace NavTabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Inbox uc = new UC_Inbox();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Sent uc = new UC_Sent();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);
        }
    }
}