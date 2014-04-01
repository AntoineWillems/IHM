using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM
{
    class arret
    {
        private int numeroArret;
        private string nomArret;
        private List<heure> listeheure = new List<heure>();
        private int numeroLigneArret;
        private int numeroLigne;

        public arret(int numeroLigne,int numeroArret,int numeroArretLigne)
        {
            this.numeroLigne = numeroLigne;
            this.numeroArret = numeroArret;
            this.numeroLigneArret = numeroArretLigne;
        }
        public arret(int numeroLigneArret, string nomArret)
        {
            this.numeroLigneArret = numeroLigneArret;
            this.nomArret = nomArret;
        }

        public int NumeroArret
        {
            get { return numeroArret; }
            set { numeroArret = value; }
        }
        public string NomArret
        {
            get { return nomArret; }
            set { nomArret = value; }
        }
        public List<heure> ListeHeure
        {
            get { return listeheure; }
            set { listeheure = value; }
        }
        public int NumeroLigneArret
        {
            get { return numeroLigneArret; }
            set { numeroLigneArret = value; }
        }
        public int NumeroLigne
        {
            get { return numeroLigne; }
            set { numeroLigne = value; }
        }

    }
}
