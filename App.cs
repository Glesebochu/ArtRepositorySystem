﻿using ArtRepositorySystem.ConsumerExperienceUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            ConsumerExperience consumerExperience = new ConsumerExperience();
            this.Controls.Add(consumerExperience);
            consumerExperience.Dock = DockStyle.Fill;
        }
    }
}
