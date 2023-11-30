using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSaver
{
    internal class MatchService
    {
        private List<Match> matches = new List<Match>();
        DatabaseConnection dbc;
        public MatchService(DatabaseConnection conn) { dbc = conn; }

        public void createMatch(string[] picks) { 
            Match match = new Match(picks[0], picks[1], picks[2], picks[3], picks[4], picks[5], picks[6], picks[7], picks[8], picks[9]);
            matches.Add(match);
            dbc.Save(picks);
        }
        public Label[][] loadMatches() { // HAVE TO CHANGE RETURN TYPE AND NOT USE LISTVIEW WANT TO RETURN List of Textboxes and a button hmmm
                                                               //   ListView drafts = new ListView();
            loadMatchesfromDatabase();
            Label[][] drafts = new Label[matches.Count][];

           for (int i = matches.Count-1; i >= 0; i--)
            {
                string[] picks = matches[i].getPicks();
                drafts[matches.Count-i-1] = new Label[10];
                for(int j = 0;j< picks.Length;j++)
                {
                    drafts[matches.Count-i-1][j] = new Label() { Text = picks[j] };
                    
                }
            }

            return drafts;
        }
        private void loadMatchesfromDatabase() {
            DataTable table = dbc.LoadAllDrafts();
            foreach (DataRow match in table.Rows)
            {
               object[] t = match.ItemArray; //Change Datatype
                matches.Add(new Match(t.ElementAt(1).ToString(), t.ElementAt(2).ToString(), t.ElementAt(3).ToString(), t.ElementAt(4).ToString(), t.ElementAt(5).ToString(), t.ElementAt(6).ToString(), t.ElementAt(7).ToString(), t.ElementAt(8).ToString(), t.ElementAt(9).ToString(), t.ElementAt(10).ToString()));
               // matches.Add(new Match());
            }
        }
    }
}
