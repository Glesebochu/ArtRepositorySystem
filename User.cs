using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtRepositorySystem.ArtForms;

namespace ArtRepositorySystem
{
    public enum UserMode
    {
        Consumer,
        Artist
    }
    public struct AllArtistWorks
    {
        public List<VisualArt> visualArts;
        public List<PerformedArt> performedArts;
        public List<LiteraryArt> literaryArts;
    }
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public UserMode userMode { get; set; }
        public byte[] ProfilePic { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string password { get; set; }
        public string Bio { get; set; }
        public List<User> Followers { get; set; }
        public List<Art> Works { get; set; }

        public User()
        {
            Followers = new List<User>();
            Works = new List<Art>();
        }
        //Function for switching the mode of consumption from Consumer to Artist or vice versa.
        public void SwitchMode()
        {
            if(this.userMode == UserMode.Consumer)
            {
                this.userMode = UserMode.Artist;
            }
            else
            {
                this.userMode = UserMode.Consumer;
            }
        }
        public FeedbackForm CreateFeedackForm()
        {
            return null;
        }
        //Function for making a specific Analytic object visible to consumers.
        public void MakeAnalyticVisible(Analytic analytic, Art art)
        {
            //Check if this user made or collaborated on the art
            //Check if the analytic is for this art
            if (art.Artists.Contains(this) && art.Analytics.Contains(analytic))
            {
                analytic.Visibility = true;
            }
        }
        public List<Art> SearchArt(String artName)
        {
            List<Art> art = new List<Art>();


            //Search the DB for an art with this name


            return art;
        }
        public List<User> SearchArtist(String artistName)
        {
            List<User> artists = new List<User>();


            //Search the DB for an Artist with this name


            return artists;
        }
        public Reaction React(Art art, String response)
        {
            return new Reaction(this, art, response);
        }
        //Get a bundle of the Artist's artworks categorized by type.
        public AllArtistWorks? GetWorksByType()
        {
            if (this.userMode == UserMode.Artist)
            {
                AllArtistWorks allWorks = new AllArtistWorks();

                List<VisualArt> visualArts = new List<VisualArt>();

                List<LiteraryArt> literaryArts = new List<LiteraryArt>();

                List<PerformedArt> performedArts = new List<PerformedArt>();
                
                //Filter through the works of this artist and categorize them by type.
                foreach (Art art in this.Works)
                {
                    if (art.Type == ArtForm.Visual)
                        visualArts.Add(art as VisualArt);
                    else if (art.Type == ArtForm.Literary)
                        literaryArts.Add(art as LiteraryArt);
                    else if (art.Type == ArtForm.Performed)
                        performedArts.Add(art as PerformedArt);
                }

                allWorks.visualArts = visualArts;
                allWorks.literaryArts = literaryArts;
                allWorks.performedArts = performedArts;

                //Return the list of lists
                return allWorks;
            }
            else
            {
                return null;
            }
        }

    }
}
