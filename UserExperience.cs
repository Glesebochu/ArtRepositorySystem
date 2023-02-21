using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ArtRepositorySystem.ArtForms;
using ArtRepositorySystem.ArtForms.VisualArts;
using ArtRepositorySystem.ConsumerExperienceUI;

namespace ArtRepositorySystem
{
    //Struct for storing the colors of the app's theme.
    public struct ColorThemes
    {
        public static Color NavigationPanel = Color.LightGray;
        public static Color ContentPanel = Color.White;
    }
    public partial class UserExperience : UserControl
    {
        User currentUser;
        
        public UserExperience(User ekele)
        {
            InitializeComponent();
            this.currentUser = ekele;
        }

        #region Custom Methods
        
        //Add a UserControl to PanelContent.
        public void AddToPanelContent(UserControl userControl)
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

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
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

            MededaContext mededaContext = new MededaContext();
            
                //For testing purposes
                VisualArt p, x, y, z;
                List<Art> arts;

                p = new VisualArt();
                p.Title = "The Total Liberation of Africa";
                Image DispalayedImage = Properties.Resources.TheTotalLiberationOfAfrica;
                byte[] byteImage = ImageToByteArray(DispalayedImage);
                p.Image = byteImage;
                p.Description = "In 1958, Ethiopian multi-disciplinary Artist Afewerk Tekle created arguably his greatest work: a stained-glass triptych entitled 'The Total Liberation of Africa', commissioned to be installed in the newly established Africa Hall, the headquarters of the United Nations Economic Commission for Africa, in Addis Ababa.";
                p.VisualArtShape = VisualArtShape.Rectangle;
                p.VisualArtType = VisualArtType.Painting;
                p.Genre = PaintingGenre.Expressionism.ToString();

                x = new VisualArt();
                x.Title = "Defender of His Country";
                Image DispalayedImage2 = Properties.Resources.DefenderOfHisCountry; ;
                byte[] byteImage2 = ImageToByteArray(DispalayedImage2);
                x.Image = byteImage2;
                x.Description = "Defender of His Country.";
                x.VisualArtShape = VisualArtShape.Rectangle;
                x.VisualArtType = VisualArtType.Painting;
                x.Genre = PaintingGenre.Abstract.ToString();


                y = new VisualArt();
                y.Title = "African Heritage";
                Image DispalayedImage3 = Properties.Resources.AfricanHeritage;
                byte[] byteImage3 = ImageToByteArray(DispalayedImage3);
                y.Image = byteImage3;
                y.Description = "African Heritage.";
                y.VisualArtShape = VisualArtShape.Rectangle;
                y.VisualArtType = VisualArtType.Painting;
                y.Genre = PaintingGenre.Surrealism.ToString();

                z = new VisualArt();
                z.Title = "Asabet Meal";
                Image DispalayedImage4 = Properties.Resources.Asabet;
                byte[] byteImage4 = ImageToByteArray(DispalayedImage4);
                z.Image = byteImage4;
                z.Description = "Asabet Meal.";
                z.VisualArtShape = VisualArtShape.Rectangle;
                z.VisualArtType = VisualArtType.Photograph;
                z.Genre = PhotographGenre.Still.ToString();

                //creating new User

                User afewerk = new User();
                afewerk.Username = "afewerk_tekle";
                afewerk.FirstName = "Afewerk";
                afewerk.LastName = "Tekle";
                afewerk.Bio = "The Shit.";
                afewerk.Works.AddRange(new[] { x, p, y });

                //adding the user to the context class
                //mededaContext.Users.Add(afewerk);

                p.Artists = new List<User> { afewerk };
                x.Artists = new List<User> { afewerk };
                y.Artists = new List<User> { afewerk };
                z.Artists = new List<User> { afewerk };

                FeedbackForm feedback1 = new FeedbackForm();
                //mededaContext.FeedbackForm.Add(feedback1);


                p.FeedbackForm = feedback1;
                x.FeedbackForm = feedback1;
                y.FeedbackForm = feedback1;
                z.FeedbackForm = feedback1;

            //Creating new FeedbackForm


            //adding the artworks to the context class

            //mededaContext.VisualArts.Add(x);
            //mededaContext.VisualArts.Add(y);
            //mededaContext.VisualArts.Add(p);
            //mededaContext.VisualArts.Add(z);

            //mededaContext.SaveChanges();

            List<VisualArt> contextArts = (from artwork in mededaContext.VisualArts
                                    select artwork).ToList();
               



            arts = new List<Art>();
            foreach (var Visualart in contextArts)
            {
                arts.Add(Visualart);
            }
            //arts.Add(p);
            //arts.Add(x);
            //arts.Add(y);
            //arts.Add(z);
            //arts.Add(p);
            //arts.Add(x);
            //arts.Add(y);
            //arts.Add(z);
            //arts.Add(p);
            //arts.Add(x);
            //arts.Add(y);
            //arts.Add(z);
          
            return arts;
        }

        //Get a list of User objects for testing purposes.
        public static List<User> GetDummyUsers()
        {

            MededaContext mededaContext = new MededaContext();

            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            Image DispalayedImage5 = Properties.Resources.Afewerk_Tekle;
            byte[] byteImage5 = ImageToByteArray(DispalayedImage5);
            afewerk.ProfilePic = byteImage5;
            //afewerk.Works = GetDummyArts().FindAll(x => x.Artists[0].Username == "afewerk_tekle");

            List<User> userList = (from user in mededaContext.Users
                                           select user).ToList();

            //List<User> userList = new List<User>();
            //userList.Add(afewerk);
            //userList.Add(afewerk);
            //userList.Add(afewerk);
            //userList.Add(afewerk);

            return userList;
        }
        
        //Get a list of Buttons from a list of VisualArts.
        public static List<Button> CreateButtonsFromVisualArtworks(List<VisualArt> visualArts)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < visualArts.Count(); i++)
            {
                Button button = new Button();
                Image buttonImage = byteArrayToImage(visualArts[i].Image);
                button.BackgroundImage = buttonImage;
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
               
                Image buttonImage = byteArrayToImage(users[i].ProfilePic);
                button.BackgroundImage = buttonImage;
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

        //A private function that I can call from anywhere to refresh the UserExperience.
        //This is very useful for easily switching between the consumer and artist experiences.
        private void LoadUserExperience()
        {
            //Set the text property of the labels for UserMode, FullName and Username and center them horizontally.
            LblUserMode.Text = currentUser.userMode.ToString();
            LblUserMode.CenterHorizontally();
            LblFullName.Text = currentUser.FirstName + " " + currentUser.LastName;
            LblFullName.CenterHorizontally();
            LblUsername.Text = $"@{currentUser.Username}";
            LblUsername.CenterHorizontally();

            //Set the image of the profile picture from the currentUser.
            Image ProfileImage = byteArrayToImage(currentUser.ProfilePic);
           

            guna2CirclePictureBoxProfilePic.Image = ProfileImage;

            //Check which user mode the user is in: consumer or artist.
            if (currentUser.userMode == UserMode.Consumer)
            {
                //The user is in consumer mode.
                //Create a new ConsumerExperienceNavButtons object and add it to the navigation panel.
                AddToPanel(new ConsumerNavButtons(), SplitContainerAll.Panel1);

                //Show the MyFeed page by default.
                //To be replaced with a database fetch of content specific to the user
                AddToPanelContent(new MyFeedPage(GetDummyArts()));
            }
            else
            {
                //The user is in consumer mode.
                //Create a new ConsumerExperienceNavButtons object and add it to the navigation panel.
                //AddToPanel(new ArtistExperienceNavButtons(), SplitContainerAll.Panel1);

                //Show the Home page by default.
                //To be replaced with a database fetch of content specific to the user
                //AddToPanelContent(new HomePage());
            }
        }
        
        #endregion

        #region Events
        private void UserExperience_Load(object sender, EventArgs e)
        {
            LoadUserExperience();
        }
        private void ToggleSwitchMode_CheckedChanged(object sender, EventArgs e)
        {
            //Switch the user's mode.
            currentUser.SwitchMode();

            //Reload this UserExperience.
            this.Controls.Clear();
            LoadUserExperience();

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
            AddToPanelContent(new SearchDisplay());
        }

        #endregion
    }
}