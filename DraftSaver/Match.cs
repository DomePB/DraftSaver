using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSaver
{
    internal class Match
    {
        private String B1pick;
        private String B2pick;
        private String B3pick;
        private String B4pick;
        private String B5pick;
        private String R1pick;
        private String R2pick;
        private String R3pick;
        private String R4pick;
        private String R5pick;

        public Match(string b1pick, string b2pick, string b3pick, string b4pick, string b5pick, string r1pick, string r2pick, string r3pick, string r4pick, string r5pick)
        {
            B1pick = b1pick;
            B2pick = b2pick;
            B3pick = b3pick;
            B4pick = b4pick;
            B5pick = b5pick;
            R1pick = r1pick;
            R2pick = r2pick;
            R3pick = r3pick;
            R4pick = r4pick;
            R5pick = r5pick;
        }
       
    }
}
