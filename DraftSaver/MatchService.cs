using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSaver
{
    internal class MatchService
    {
        private List<Match> matches = new List<Match>();
        public MatchService() { }

        public void createMatch(string[] picks) { 
            Match match = new Match(picks[0], picks[1], picks[2], picks[3], picks[4], picks[5], picks[6], picks[7], picks[8], picks[9]);
            matches.Add(match);
        }
        public ListView.ListViewItemCollection loadMatches() { // HAVE TO CHANGE RETURN TYPE AND NOT USE LISTVIEW WANT TO RETURN List of Textboxes and a button hmmm
            ListView drafts = new ListView();
            foreach (Match match in matches)
            {
                string[] picks = match.getPicks();
                foreach (string pick in picks)
                {
                    new TextBox().Text = pick; // HAVE TO CHANGE THIS TO A LIST OF TEXTBOX 
                }
            }
            
        throw new NotImplementedException();
        }
    }
}
