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

        public Dictionary<int, String[]> loadMatches() {

            loadMatchesfromDatabase();
            Dictionary<int, String[]> drafts = new Dictionary<int,String[]>();
            foreach (var match in matches) {
                drafts.Add(match.getId(), match.getPicks());
            }

            return drafts;
        }
        private void loadMatchesfromDatabase() {
            DataTable table = dbc.LoadAllDrafts();
            foreach (DataRow match in table.Rows)
            {
              
               object[] t = match.ItemArray; //Change Datatype
                Match m = new Match((int)t.ElementAt(0), t.ElementAt(1).ToString(), t.ElementAt(2).ToString(), t.ElementAt(3).ToString(), t.ElementAt(4).ToString(), t.ElementAt(5).ToString(), t.ElementAt(6).ToString(), t.ElementAt(7).ToString(), t.ElementAt(8).ToString(), t.ElementAt(9).ToString(), t.ElementAt(10).ToString());
               
                if (!matches.Contains(m)) {
                    matches.Add(m);
                }
               
               // matches.Add(new Match());
            }
        }

        public Label[] loadPlayedCount() { 
        Dictionary<string,int> championCount = dbc.getChampionPlayedCount();
            Label[] champCountPairs = new Label[championCount.Count];
            int i = 0;
            foreach (var champ in championCount) { 
                string champion = champ.Key;
                int pickedCount = champ.Value;
                champCountPairs[i] = new Label { Text = champion +" Was picked:  "+ pickedCount + " times." };
                i++;
            }
            return champCountPairs;
        }
        public String[] getDraftById(int id) { 
            Match m =dbc.getMatchById(id);
            return m.getPicks();
        }
    }
}
