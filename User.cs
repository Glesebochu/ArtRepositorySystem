using ArtRepositorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public enum UserMode
    {
        Consumer,
        Artist
    }
    public class User
    {
        public string Username { get; set; }
        public UserMode userMode { get; set; }
        public Image ProfilePic;
        public string FirstName;
        public string LastName;
        public string Bio;

        public List<User> Followers;
        public List<Art> Works;

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
            //Search the DB for an artist with this name
            return artists;
        }
        public Reaction React(Art art)
        {
            return new Reaction();
        }
    
    }
}
