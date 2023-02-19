using ArtRepositorySystem.ArtForms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class MededaContext:DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<VisualArt> VisualArts { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<QnA> QnA { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<FeedbackForm> FeedbackForm { get; set; }
        public DbSet<Analytic> Analytic { get; set; }
        

      

    }
}
