using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public abstract class  Band

    {
        // props
        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Membersofband { get; set; }

        public List<Genre> Genres { get; set; }


        public  Band()
        {

        }

        public  Band(string BName, int YFormed, string Mband)
        {
            BandName = BName;
            YearFormed = YFormed;
            Membersofband = Mband;
        }

        public override string ToString()
        {
            return (this.BandName + YearFormed + Membersofband);
        }
        public class Rock : Band
        {
            public override string ToString()
            {
                return (this.BandName + " - Rock");
            }
        }

        public class Pop : Band
        {
            public override string ToString()
            {
                return (this.BandName + " - Pop");
            }
        }

        public class Indie : Band
        {
            public override string ToString()
            {
                return (this.BandName + " - Indie");
            }
        }

        public class Genre
        {
            public string GenreName { get; set; }
            
        }
    }
}
