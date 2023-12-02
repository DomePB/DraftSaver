using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSaver
{
    internal class Match
    {
        private readonly int id;
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

        public Match(int id,string b1pick, string b2pick, string b3pick, string b4pick, string b5pick, string r1pick, string r2pick, string r3pick, string r4pick, string r5pick)
        {
            this.id = id; ;
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

        public string[] getPicks() { 
         return new string[] { B1pick, B2pick, B3pick, B4pick, B5pick, R1pick, R2pick, R3pick, R4pick, R5pick };
        }
        public void setB1(string B1) {
            B1pick = B1;
        }
        public void setB2(string B2)
        {
            B2pick = B2;
        }
        public void setB3(string B3)
        {
            B3pick = B3;
        }
        public void setB4(string B4)
        {
            B4pick = B4;
        }
        public void setB5(string B5)
        {
            B5pick = B5;
        }
        public int getId() {  return id; }

        public override bool Equals(object? obj)
        {
            return obj is Match match &&
                   id == match.id;
        }
    }
}
