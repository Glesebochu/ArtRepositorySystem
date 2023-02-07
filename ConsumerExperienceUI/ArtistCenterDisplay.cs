﻿using ArtRepositorySystem.ArtForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class ArtistCenterDisplay : UserControl
    {
        User Artist;
        public ArtistCenterDisplay(User artist)
        {
            InitializeComponent();
            this.Artist = artist;
            
        }

        private void ArtistCenterDisplay_Load(object sender, EventArgs e)
        {
            //Set the text of the label representing the artist's name.
            LblArtistName.Text = $"{Artist.FirstName} {Artist.LastName}";

            //Fill the profile tab.
            tabPageProfilePic.BackgroundImage = Artist.ProfilePic;
            tabPageProfilePic.BackgroundImageLayout = ImageLayout.Zoom;

            //Fill the bio tab.
            richTextBoxBio.Text = Artist.Bio;

            //Fill the works tab.
            List<VisualArt> visualsFromArtist = Art.ToVisualArt(Artist.Works);

            //Get a list of CategoryTemplateDisplay objects from a list of VisualArt objects using 
            //the ConsumerExperience.GetCategoriesFromVisualArts() function.
            List<CategoryTemplateDisplay> categories = ConsumerExperience.GetCategoriesFromVisualArts(visualsFromArtist);
            foreach (CategoryTemplateDisplay category in categories)
            {
                //Add each category to the TableLayoutPanel in this UserControl.
                ConsumerExperience.AddToPanel(category, tableLayoutPanelArtistWorkCategories);
            }

        }

        private void ArtistCenterDisplay_Click(object sender, EventArgs e)
        {
            //Whenever the empty space around the TabControl is clicked,
            //hide this UserControl. This enables the user to easily return
            //to the page he/she was before clicking on the artist to be viewed.
            this.Hide();
        }
    }
}