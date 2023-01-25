using System.Globalization;
using System.Runtime.CompilerServices;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    //Structure for storing the colors of the app's theme.
    public struct ColorThemes
    {
        public static Color NavigationPanel = Color.LightGray;
        public static Color ContentPanel = Color.White;
    }
    public partial class ConsumerExperience : UserControl
    {
        //For testing purposes
        User? ekele;
        
        public ConsumerExperience()
        {
            InitializeComponent();
        }
        private void ConsumerExperience_Load(object sender, EventArgs e)
        {
            ekele = new User();
            ekele.FirstName = "Yelelew";
            ekele.LastName = "Aymertim";
            ekele.Username = "ekele";
            LblUserMode.Text = ekele.userMode.ToString();
            LblFullName.Text = ekele.FirstName + " " + ekele.LastName;
            LblUsername.Text = "@" + ekele.Username;
            addUserControl(new MyFeedPage());
        }
        private void addUserControl(UserControl userControl)
        {
            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        internal static void CreateCenterDisplayFor(Art art, Panel panelContent)
        {
            //Create center display
            CenterDisplay centerDisplay = new CenterDisplay(art);

            //Set the paddding to 10% of the form's dimensions (x and y)
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            centerDisplay.Dock = DockStyle.Fill;

            panelContent.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();

        }
        internal static List<VisualArt> GetDummyVisualArts()
        {
            //For testing purposes
            VisualArt p, x;
            List<VisualArt> visuals;

            p = new VisualArt();
            p.Title = "The Total Liberation of Africa";
            p.Image = Properties.Resources.TheTotalLiberationOfAfrica;
            p.Description = "In 1958, Ethiopian multi-disciplinary artist Afewerk Tekle created arguably his greatest work: a stained-glass triptych entitled 'The Total Liberation of Africa', commissioned to be installed in the newly established Africa Hall, the headquarters of the United Nations Economic Commission for Africa, in Addis Ababa.";
            p.Shape = VisualArtShape.Rectangle;

            x = new VisualArt();
            x.Title = "Defender of His Country";
            x.Image = Properties.Resources.DefenderOfHisCountry;
            x.Description = "Defender of His Country.";
            x.Shape = VisualArtShape.Rectangle;

            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            afewerk.Works = new List<Art>() { p, x};

            p.Artists = new List<User> { afewerk};
            x.Artists = new List<User> { afewerk};

            visuals = new List<VisualArt>();
            visuals.Add(p);
            visuals.Add(x);
            visuals.Add(p);
            visuals.Add(x);
            visuals.Add(p);
            visuals.Add(x);

            return visuals;
        }
        internal static List<User> GetDummyUsers()
        {
            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            afewerk.ProfilePic = Properties.Resources.Afewerk_Tekle;

            List<User> userList = new List<User>();
            userList.Add(afewerk);
            userList.Add(afewerk);
            userList.Add(afewerk);
            userList.Add(afewerk);

            return userList;
        }
        internal static List<Button> CreateButtonsFromVisualArtworks(List<VisualArt> visualArts)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < visualArts.Count(); i++)
            {
                Button button = new Button();
                button.BackgroundImage = visualArts.ElementAt(i).Image;
                button.Text = "";
                button.Tag = visualArts[i];
                buttonList.Add(button);
            }

            return buttonList;
        }
        internal static List<Button> CreateButtonsFromUsers(List<User> users)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < users.Count(); i++)
            {
                Button button = new Button();
                button.BackgroundImage = users[i].ProfilePic;
                button.Text = "";
                button.Tag = users[i];
                buttonList.Add(button);
            }

            return buttonList;
        }

        private void BtnMyFeed_Click(object sender, EventArgs e)
        {
            addUserControl(new MyFeedPage());
        }

        private void BtnTopArtists_Click(object sender, EventArgs e)
        {
            addUserControl(new TopArtistsPage());
        }

        private void BtnTopArtworks_Click(object sender, EventArgs e)
        {
            addUserControl(new TopArtworksPage());
        }

        private void BtnMyPlaylist_Click(object sender, EventArgs e)
        {
            addUserControl(new MyPlaylistsPage());
        }

        private void ToggleSwitchMode_CheckedChanged(object sender, EventArgs e)
        {
            ekele.SwitchMode();
            LblUserMode.Text = ekele.userMode.ToString();
        }


        private void BtnNavigation_Click(object sender, EventArgs e)
        {
            if(SplitContainerAll.Panel1.Visible == true)
            {
                SplitContainerAll.Panel1.Hide();
                SplitContainerAll.Panel2.Dock = DockStyle.Fill;
            }
            else
            {
                SplitContainerAll.Panel1.Show();
                SplitContainerAll.Panel2.Dock = DockStyle.None;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            addUserControl(new SearchDisplay());
            //BtnSearch.Hide();
        }
    }
}