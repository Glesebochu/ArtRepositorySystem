namespace ArtRepositorySystem
{
    public partial class ConsumerExperience : Form
    {
        public ConsumerExperience()
        {
            InitializeComponent();
            InitializeDummyObjects();
        }

        public void InitializeDummyObjects()
        {
            Painting p = new Painting();
            p.Title = "The Total Liberation of Africa";
            p.Image = Image.FromFile("C:\\Users\\hp\\Desktop\\ArtRepositorySystemV3\\Resources\\The Total Liberation of Africa.jpg");
            p.Description = @"
                In 1958, Ethiopian multi-disciplinary artist Afewerk Tekle created arguably his greatest work: a 
                stained-glass triptych entitled 'The Total Liberation of Africa', commissioned to be installed in 
                the newly established Africa Hall, the headquarters of the United Nations Economic Commission for 
                Africa, in Addis Ababa.
            ";
            p.Shape = PaintingShape.Rectangle;

            User afewerk = new User();
            afewerk.Username = "afewerk_tekle";
            afewerk.FirstName = "Afewerk";
            afewerk.LastName = "Tekle";
            afewerk.Bio = "The Shit.";
            afewerk.Works = new List<Art>();
            afewerk.Works.Add(p);

            p.Artists = new List<User> {afewerk};

            pictureBox1.BackgroundImage = p.Image;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Get an Art object based on the picture box that was clicked and make sure all its properties are filled
            //Create a new panel that hovers above everything
            //This panel is a card layout panel that has 4 cards {art, description & artist, feedback, analytic}
                // art
                // description & artist
                // feedback form
                // analytics
            //Buttons appear to the right and left of the panel for navigating through the cards
                // The button on the left is disabled when on page 1
                // The button on the right is disabled when on page 4
            
        }
    }
}