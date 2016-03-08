﻿using ProjektSimulation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjektSimulation
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private BindingList<Entwickler> aktuellesTeam;
        private BindingList<Projekt> aktuelleProjekte;

        public MainForm()
        {
            InitializeComponent();

            aktuellesTeam = new BindingList<Entwickler>(EntwicklerPool.HoleEntwicklerTeam());
            aktuelleProjekte = new BindingList<Projekt>(ProjektPortfolio.HoleAktuelleProjekte());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.gridEntwickler.BestFitColumns();
            this.gridEntwickler.DataSource = aktuellesTeam;

            this.gridProjekte.BestFitColumns();
            this.gridProjekte.DataSource = aktuelleProjekte;
        }
    }
}