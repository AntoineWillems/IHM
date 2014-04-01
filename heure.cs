using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM
{
    class heure
    {
        private int minute;
        private int heure1;
        private string semaine;
        public heure(int heure, int minute,string semaine)
        {
            this.heure1 = heure;
            this.minute = minute;
            this.semaine = semaine;
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Heure
        {
            get { return heure1; }
            set { heure1 = value; }
        }
        public string Semaine
        {
            get { return semaine; }
            set { semaine = value; }
        }
    }
}
