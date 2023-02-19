using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ArtRepositorySystem.ArtForms;
using ArtRepositorySystem.ArtForms.VisualArts;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    //Struct for storing the colors of the app's theme.
    public struct ColorThemes
    {
        public static Color NavigationPanel = Color.LightGray;
        public static Color ContentPanel = Color.White;
    }
    public partial class ConsumerExperience : UserControl
    {
        User currentUser;
        
        public ConsumerExperience(User ekele)
        {
            InitializeComponent();
            this.currentUser = ekele;
        }

        #region Custom Methods
        
        //Add a UserControl to the content Panel.
        private void addUserControl(UserControl userControl)
        {
            //Remove all the controls from PanelContent.
            PanelContent.Controls.Clear();
            //Add the UserControl object to the panel.
            PanelContent.Controls.Add(userControl);
            //Set the Dock property to Fill.
            userControl.Dock = DockStyle.Fill;
            //Bring the UserControl to the front.
            userControl.BringToFront();
        }
        
        //Create a center display for an Artwork.
        public static void CreateCenterDisplayForArt(Art art, Panel panelContent)
        {
            //Create CenterDisplay object.
            ArtworkCenterDisplay centerDisplay = new ArtworkCenterDisplay(art);

            //Set the paddding to 10 % of the panel's dimensions (x and y)
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            //Set the Dock property to Fill.
            centerDisplay.Dock = DockStyle.Fill;

            //Add the CenterDisplay to the panel and bring it to the front.
            panelContent.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();
        }
        
        //Create a center display for an Artist.
        public static void CreateCenterDisplayForArtist(User artist, Panel panelContent)
        {
            //Create CenterDisplay object.
            ArtistCenterDisplay centerDisplay = new ArtistCenterDisplay(artist);

            //Set the padding to 10% of the panel's dimensions
            int xPadding = (int)(panelContent.Width * 0.1);
            int yPadding = (int)(panelContent.Height * 0.1);
            centerDisplay.Padding = new Padding(xPadding, (yPadding / 2), xPadding, yPadding);

            //Set the Dock property to Fill.
            centerDisplay.Dock = DockStyle.Fill;

            //Add the CenterDisplay to the panel and bring it to the front.
            panelContent.Controls.Add(centerDisplay);
            centerDisplay.BringToFront();
            
        }
        
        //Get a list of Art objects for testing purposes.
        public static List<Art> GetDummyArts()
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
            arts.Add(z);
            arts.Add(p);
            arts.Add(x);
            arts.Add(y);
            arts.Add(z);

            return arts;
        }

        //Get a list of User objects for testing purposes.
        public static List<User> GetDummyUsers()
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
        
        //Get a list of Buttons from a list of VisualArts.
        public static List<Button> CreateButtonsFromVisualArtworks(List<VisualArt> visualArts)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < visualArts.Count(); i++)
            {
                Button button = new Button();
                button.BackgroundImage = visualArts[i].Image;
                button.BackgroundImageLayout = ImageLayout.Tile;
                button.Text = "";
                button.Tag = visualArts[i];
                buttonList.Add(button);
            }

            return buttonList;
        }

        //Get a list of Buttons from a list of Users(Artists).
        public static List<Button> CreateButtonsFromUsers(List<User> users)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < users.Count(); i++)
            {
                Button button = new Button();
                button.BackgroundImage = users[i].ProfilePic;
                button.BackgroundImageLayout = ImageLayout.Center;
                button.Text = "";
                button.Tag = users[i];
                buttonList.Add(button);
            }

            return buttonList;
        }
        
        //Add a control to a panel.
        public static void AddToPanel(Control c, Panel panel)
        {
            //Add control to panel.
            panel.Controls.Add(c);
            //Set Dock property of control to Fill.
            c.Dock = DockStyle.Fill;
            //Set AutoSize of control property to true.
            c.AutoSize = true;
            //Set backcolor of control to transparent.
            c.BackColor = System.Drawing.Color.Transparent;
            //Bring the control to the front.
            c.BringToFront();
        }
        
        //Get a list of CategoryTemplateDisplay objects from a list of VisualArts.
        public static List<CategoryTemplateDisplay> GetCategoriesFromVisualArts(List<VisualArt> visuals)
        {
            //Create a empty list of CategoryTemplateDisplay objects.
            List<CategoryTemplateDisplay> categories = new List<CategoryTemplateDisplay>();

            //Create a list of objects to store the genres found in the VisualArts sent.
            List<Object> genres = new List<Object>();

            //Identify all the genres in the list
            foreach (VisualArt v in visuals)
            {
                //Add each genre to the genres list.
                genres.Add(v.Genre);
            }
            //Remove duplicate genres.
            genres = genres.Distinct().ToList();

            //Create one CategoryTemplateDisplay for each genre
            foreach(Object genre in genres)
            {
                //Create a list of VisualArts that are of the specific genre.
                List<VisualArt> visualsOfGenre = visuals.FindAll(visual => visual.Genre == genre);
                //Create a CategoryTemplateDisplay object for this genre based on the selected visuals.
                CategoryTemplateDisplay categoryTemplateDisplay = new CategoryTemplateDisplay(genre.ToString(), visualsOfGenre);
                //Add the CategoryTemplateDisplay object to the categories list.
                categories.Add(categoryTemplateDisplay);
            }

            return categories;
        }

        #endregion

        #region Events
        private void ConsumerExperience_Load(object sender, EventArgs e)
        {

            //Set the text property of the labels for UserMode, FullName and Username and center them horizontally.
            LblUserMode.Text = currentUser.userMode.ToString();
            LblUserMode.CenterHorizontally();
            LblFullName.Text = currentUser.FirstName + " " + currentUser.LastName;
            LblFullName.CenterHorizontally();
            LblUsername.Text = $"@{currentUser.Username}";
            LblUsername.CenterHorizontally();

            //Set the image of the profile picture from the currentUser.
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
            //Switch the user's mode.
            currentUser.SwitchMode();
            //Change the text of the label representing the usermode.
            LblUserMode.Text = currentUser.userMode.ToString();
            //Center the label horizontally.
            LblUserMode.CenterHorizontally();
        }

        //Event for hiding and showing the navigation panel based on a button click.
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
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            addUserControl(new SettingsPage());
        }

        #endregion

        private void linkLabelAboutPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\hp\\Desktop\\NPN\\ArtRepositorySystem\\Resources");
        }
    }
}