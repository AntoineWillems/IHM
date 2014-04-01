using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IHM
{
    public partial class FicheHoraire : UserControl
    {

        public FicheHoraire( int numeroArret,int numeroLigne)
        {
            InitializeComponent();
            FicheHoraire1 fh1 = new FicheHoraire1(numeroArret, "Lundi au Vendredi", numeroLigne);
            FicheHoraire1 fh2 = new FicheHoraire1(numeroArret, "Lundi au Vendredi (vacances)", numeroLigne);
            FicheHoraire1 fh3 = new FicheHoraire1(numeroArret, "Samedi", numeroLigne);
            FicheHoraire1 fh4 = new FicheHoraire1(numeroArret, "Dimanche et jour ferie", numeroLigne);
            fh1.Location = new Point(0, 50);
            fh2.Location = new Point(0, 50);
            fh3.Location = new Point(0, 50);
            fh4.Location = new Point(0, 50);
            splitContainer2.Panel1.Controls.Add(fh1);
            splitContainer2.Panel2.Controls.Add(fh2);
            splitContainer3.Panel1.Controls.Add(fh3);
            splitContainer3.Panel2.Controls.Add(fh4);
            
        }
    }
}
