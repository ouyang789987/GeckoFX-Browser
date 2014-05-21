using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeckoFX
{
    public partial class Window : Form
    {
        // global string for home web site url
        private string HomeUrl = "https://www.google.fr";

        public Window()
        {
            InitializeComponent();
        }

        //OnLoad Initialize firefox user-agent and local languages
        private void Form1_Load(object sender, EventArgs e)
        {
            string Archi = "", OS = "";

            if (System.Environment.Is64BitOperatingSystem)  //for 64 bit OS
                Archi = " WOW64;";  //Say you have a 64 os with a 32 bit web browser
            //Take the current version of your Windows NT kernel version. Win 8.1 have a 6.3 kernel but you see 6.2 like Win 8
            OS = (System.Environment.OSVersion.Version.Major.ToString() + "." + System.Environment.OSVersion.Version.Minor.ToString());

            //Set the new user-agent
            Gecko.GeckoPreferences.User["general.useragent.override"] = "Mozilla/5.0 (Windows NT " + OS + ";" + Archi + " rv:29.0) Gecko/20100101 Firefox/29.0";
            //Set your request language
            Gecko.GeckoPreferences.User["intl.accept_languages"] = "fr-fr";

            //Some code for resizing Icon Bar and Url textbox
            IconBar.Size = new Size(this.Width - 10, 25);
            Url.Size = new Size(this.Width - 140, 25);

            //Go to the home page
            Content.Navigate(HomeUrl);
        }

        //Resize Icon Bar with Url textbox
        private void Form1_Resize(object sender, EventArgs e)
        {
            IconBar.Size = new Size(this.Width - 10, 25);
            Url.Size = new Size(this.Width - 140, 25);
        }

        //Navigate when you press enter on Url Textbox
        private void Url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  //When you press Enter
            {
                Content.Navigate(Url.Text);
                e.Handled = true;
            }
        }

        //Change the main windows title with the web page title
        private void Content_DocumentTitleChanged(object sender, System.EventArgs e)
        {
            this.Text = Content.DocumentTitle + " - GeckoFX";
        }

        //When the page has been fully loaded
        private void Content_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            //Take the new url and write it in the Url textbox
            Url.Text = Content.Url.ToString();

            //enable back button
            if (Content.CanGoBack)
                GoBack.Enabled = true;
            else
                GoBack.Enabled = false;

            //enable forward button
            if (Content.CanGoForward)
                GoForward.Enabled = true;
            else
                GoForward.Enabled = false;
        }

        //When web site want create new windows (popup)
        private void Content_CreateWindow2(object sender, Gecko.GeckoCreateWindow2EventArgs e)
        {
            e.Cancel = true;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Content.GoBack();
        }

        private void GoForward_Click(object sender, EventArgs e)
        {
            Content.GoForward();
        }

        private void GoRefresh_Click(object sender, EventArgs e)
        {
            Content.Navigate(Content.Url.ToString());
        }

        private void GoHome_Click(object sender, EventArgs e)
        {
            Content.Navigate(HomeUrl);
        }
    }
}
