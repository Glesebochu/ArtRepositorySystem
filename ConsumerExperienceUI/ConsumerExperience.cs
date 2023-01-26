using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ArtRepositorySystem.ArtForms;
using ArtRepositorySystem.ArtForms.VisualArts;

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
        User currentUser;
        
        public ConsumerExperience(User ekele)
        {
            InitializeComponent();
            this.currentUser = ekele;
        }

        #region Custom Methods
        private void addUserControl(UserControl userControl)
        {
            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        internal static void CreateCenterDisplayForArt(Art art, Panel panelContent)
        {
            //Create center display
            ArtworkCenterDisplay centerDisplay = new ArtworkCenterDisplay(art);

            //Set the paddding to 10% of the panel's dimensions (x and y)
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            centerDisplay.Dock = DockStyle.Fill;

            panelContent.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();

        }
        internal static void CreateCenterDisplayForArtist(User artist, Panel panelContent)
        {

            ArtistCenterDisplay centerDisplay = new ArtistCenterDisplay(artist);

            //Set the padding to 10% of the panel's dimensions
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            centerDisplay.Dock = DockStyle.Fill;

            panelContent.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();
            
        }
        internal static List<Art> GetDummyArts()
        {
            //For testing purposes
            VisualArt p, x, y, z;
            List<Art> arts;

            p = new VisualArt();
            p.Title = "The Total Liberation of Africa";
            p.Image = Properties.Resources.TheTotalLiberationOfAfrica;
            p.Description = "In 1958, Ethiopian multi-disciplinary Artist Afewerk Tekle created arguably his greatest work: a stained-glass triptych entitled 'The Total Liberation of Africa', commissioned to be installed in the newly established Africa Hall, the headquarters of the United Nations Economic Commission for Africa, in Addis Ababa.";
            p.VisualArtShape = VisualArtShape.Rectangle;
            p.VisualArtType = VisualArtType.Painting;
            p.Genre = PaintingGenre.Expressionism;

            x = new VisualArt();
            x.Title = "Defender of His Country";
            x.Image = Properties.Resources.DefenderOfHisCountry;
            x.Description = "Defender of His Country.";
            x.VisualArtShape = VisualArtShape.Rectangle;
            x.VisualArtType = VisualArtType.Painting;
            x.Genre = PaintingGenre.Abstract;

            y = new VisualArt();
            y.Title = "African Heritage";
            y.Image = Properties.Resources.AfricanHeritage;
            y.Description = "African Heritage.";
            y.VisualArtShape = VisualArtShape.Rectangle;
            y.VisualArtType = VisualArtType.Painting;
            y.Genre = PaintingGenre.Surrealism;

            z = new VisualArt();
            z.Title = "Asabet Meal";
            z.Image = Properties.Resources.Asabet;
            z.Description = "Asabet Meal.";
            z.VisualArtShape = VisualArtShape.Rectangle;
            z.VisualArtType = VisualArtType.Photograph;
            z.Genre = PhotographGenre.Still;

            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            afewerk.Works.AddRange(new[] { x, p, y });

            p.Artists = new List<User> {afewerk};
            x.Artists = new List<User> {afewerk};
            y.Artists = new List<User> {afewerk};
            z.Artists = new List<User> { new User() };

            arts = new List<Art>();
            arts.Add(p);
            arts.Add(x);
            arts.Add(y);
            arts.Add(z);
            arts.Add(p);
            arts.Add(x);
            arts.Add(y);
            //arts.Add(z);

            return arts;
        }
        internal static List<User> GetDummyUsers()
        {
            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            afewerk.ProfilePic = Properties.Resources.Afewerk_Tekle;
            afewerk.Works = GetDummyArts().FindAll(x => x.Artists[0].Username == "afewerk_tekle");

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
                button.BackgroundImage = visualArts[i].Image;
                button.BackgroundImageLayout = ImageLayout.None;
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
        public static void AddToPanel(Control c, Panel panel)
        {
            panel.Controls.Add(c);
            //panel.AutoScroll = true;
            c.Dock = DockStyle.Fill;
            //c.AutoScroll = true;
            c.AutoSize = true;
            c.BackColor = System.Drawing.Color.Transparent;
            c.BringToFront();
        }
        public static List<CategoryTemplateDisplay> GetCategoriesFromVisualArts(List<VisualArt> visuals)
        {
            List<CategoryTemplateDisplay> categories = new List<CategoryTemplateDisplay>();

            List<Object> genres = new List<Object>();
            //Identify all the genres in the list
            foreach (VisualArt v in visuals)
            {
                //Stopped here...
                genres.Add(v.Genre);
            }
            genres = genres.Distinct().ToList();
            //Create one CategoryTemplateDisplay for each genre
            foreach(Object genre in genres)
            {
                List<VisualArt> visualsOfGenre = visuals.FindAll(visual => visual.Genre == genre);
                CategoryTemplateDisplay categoryTemplateDisplay = new CategoryTemplateDisplay(genre.ToString(), visualsOfGenre);
                categories.Add(categoryTemplateDisplay);
            }
            //Add that CategoryTemplateDisplay to categories

            return categories;
        }

        #endregion

        #region Events
        private void ConsumerExperience_Load(object sender, EventArgs e)
        {
            LblUserMode.Text = currentUser.userMode.ToString();
            LblUserMode.CenterHorizontally();
            LblFullName.Text = currentUser.FirstName + " " + currentUser.LastName;
            LblFullName.CenterHorizontally();
            LblUsername.Text = $"@{currentUser.Username}";
            LblUsername.CenterHorizontally();

            guna2CirclePictureBoxProfilePic.Image = currentUser.ProfilePic;

            //To be replaced with a database fetch of content specific to the user
            addUserControl(new MyFeedPage(GetDummyArts()));
        }
        private void BtnMyFeed_Click(object sender, EventArgs e)
        {
            //Database fetch for the specific feed of this user
            List<Art> arts = GetDummyArts();

            addUserControl(new MyFeedPage(arts));
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
            currentUser.SwitchMode();
            LblUserMode.Text = currentUser.userMode.ToString();
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

        #endregion
    }
}