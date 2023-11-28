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
        public Label[][] loadMatches() { // HAVE TO CHANGE RETURN TYPE AND NOT USE LISTVIEW WANT TO RETURN List of Textboxes and a button hmmm
                                                               //   ListView drafts = new ListView();
            
            Label[][] drafts = new Label[matches.Count][];

           for (int i = 0; i < matches.Count; i++)
            {
                string[] picks = matches[i].getPicks();
                drafts[i] = new Label[10];
                for(int j = 0;j< picks.Length;j++)
                {
                    drafts[i][j] = new Label() { Text = picks[j] };
                    
                }
            }

            return drafts;
        }
    }
}
