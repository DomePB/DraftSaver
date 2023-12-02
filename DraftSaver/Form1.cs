using System;
using System.ComponentModel;

namespace DraftSaver
{
    public partial class Form1 : Form
    {
        private String[] ChampionsArr = { "AFiller", "Aatrox", "Ahri", "Akali", "Akshan", "Alistar", "Amumu", "Anivia", "Annie", "Aphelios", "Ashe", "Aurelion Sol", "Azir", "Bard", "Bel'Veth", "Blitzcrank", "Brand", "Braum", "Briar", "Caitlyn", "Camille", "Cassiopeia", "Cho'Gath", "Corki", "Darius", "Diana", "Dr. Mundo", "Draven", "Ekko", "Elise", "Evelynn", "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio", "Gangplank", "Garen", "Gnar", "Gragas", "Graves", "Gwen", "Hecarim", "Heimerdinger", "Illaoi", "Irelia", "Ivern", "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx", "Kai'Sa", "Kalista", "Karma", "Karthus", "Kassadin", "Katarina", "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled", "Kog'Maw", "K'Sante", "LeBlanc", "Lee Sin", "Leona", "Lillia", "Lissandra", "Lucian", "Lulu", "Lux", "Malphite", "Malzahar", "Maokai", "Master Yi", "Milio", "Miss Fortune", "Mordekaiser", "Morgana", "Naafiri", "Nami", "Nasus", "Nautilus", "Neeko", "Nidalee", "Nilah", "Nocturne", "Nunu & Willump", "Olaf", "Orianna", "Ornn", "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn", "Rakan", "Rammus", "Rek'Sai", "Rell", "Renata Glasc", "Renekton", "Rengar", "Riven", "Rumble", "Ryze", "Samira", "Sejuani", "Senna", "Seraphine", "Sett", "Shaco", "Shen", "Shyvana", "Singed", "Sion", "Sivir", "Skarner", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tahm Kench", "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana", "Trundle", "Tryndamere", "Twisted Fate", "Twitch", "Udyr", "Urgot", "Varus", "Vayne", "Veigar", "Vel'Koz", "Vex", "Vi", "Viego", "Viktor", "Vladimir", "Volibear", "Warwick", "Wukong", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi", "Zac", "Zed", "Zeri", "Ziggs", "Zilean", "Zoe", "Zyra" };
        private String[] TopLaneChamps = { "AFiller", "Aatrox", "Akali", "Camille", "Cho'Gath", "Darius", "Dr. Mundo", "Fiora", "Gangplank", "Garen", "Gnar", "Gragas", "Gwen", "Heimerdinger", "Illaoi", "Irelia", "Jax", "Jayce", "Kayle", "Kennen", "Kled", "K'Sante", "Malphite", "Maokai", "Mordekaiser", "Nasus", "Olaf", "Ornn", "Pantheon", "Poppy", "Renekton", "Riven", "Rumble", "Sett", "Shen", "Singed", "Sion", "Swain", "Sylas", "Tryndamere", "Urgot", "Vladimir", "Volibear", "Wukong", "Yone", "Yorick" };
        private String[] JungleChamps = { "AFiller", "Amumu", "Bel'Veth", "Briar", "Camille", "Diana", "Dr. Mundo", "Ekko", "Elise", "Evelynn", "Fiddlesticks", "Gragas", "Graves", "Gwen", "Hecarim", "Ivern", "Jarvan IV", "Karthus", "Kayn", "Kha'Zix", "Kindred", "Lee Sin", "lillia", "Maokai", "Master Yi", "Naafiri", "Neeko", "Nidalee", "Nocturne", "Nunu & Willump", "Olaf", "Pantheon", "Poppy", "Rammus", "Rek'Sai", "Rell", "Rengar", "Sejuani", "Shyvana", "Skarner", "Trundle", "Udyr", "Vi", "Viego", "Volibear", "Warwick", "Wukong", "Xin Zhao", "Zac" };
        private String[] MidChamps = { "AFiller", "Ahri", "Akali", "Akshan", "Anivia", "Aurelion Sol", "Azir", "Brand", "Cassiopeia", "Corki", "Diana", "Ekko", "Fizz", "Galio", "Heimerdinger", "Irelia", "Jayce", "Kassadin", "Katarina", "LeBlanc", "Lissandra", "Lux", "Malzahar", "Naafiri", "Neeko", "Orianna", "Pantheon", "Qiyana", "Rumble", "Ryze", "Seraphine", "Swain", "Sylas", "Syndra", "Taliyah", "Talon", "Twisted Fate", "Veigar", "Vel'Koz", "Vex", "Viktor", "Vladimir", "Xerath", "Yasuo", "Yone", "Zed", "Ziggs", "Zoe" };
        private String[] AdcChamps = { "AFiller", "Aphelios", "Ashe", "Caitlyn", "Draven", "Ezreal", "Jhin", "Jinx", "Kai'Sa", "Kalista", "Kog'Maw", "Lucian", "Miss Fortune", "Nilah", "Samira", "Senna", "Sivir", "Tristana", "Twitch", "Varus", "Vayne", "Xayah", "Zeri" };
        private String[] SupportChamps = { "AFiller", "Alistar", "Amumu", "Bard", "Blitzcrank", "Brand", "Braum", "Janna", "Karma", "Leona", "Lulu", "Lux", "Milio", "Morgana", "Nami", "Nautilus", "Pantheon", "Poppy", "Pyke", "Rakan", "Rell", "Renata Glasc", "Senna", "Seraphine", "Sett", "Sona", "Soraka", "Tahm Kench", "Taric", "Thresh", "Yuumi", "Zilean", "Zyra" };
        private int pickIndex = 0;
        private Label[] Picks;
        private String[] Picked = new string[10];
        private PictureBox[] PictureBoxes;
        DatabaseConnection dbc = new DatabaseConnection();
        MatchService matches;
        public Form1()
        {
            matches = new MatchService(dbc);
            InitializeComponent();
            fillChampionsTextBox();
            InitializeLabels();
            InitializePicturebox();
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexchanged);
        }

        public Form1(string[] picked)
        {
            matches = new MatchService(dbc);
            Picked = picked;
            pickIndex = 10;
            InitializeComponent();
            fillChampionsTextBox();
            InitializeLabels();
            InitializePicturebox();
            loadPictureboxes(Picked);
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexchanged);

        }


        private void InitializePicturebox()
        {
            PictureBoxes = new PictureBox[]{
                B1Picture,
                R1Picture,
                R2Picture,
                B2Picture,
                B3Picture,
                R3Picture,
                R4Picture,
                B4Picture,
                B5Picture,
                R5Picture,
            };
        }

        private void InitializeLabels()
        {
            Picks = new Label[]
            {
               B1Pick,
               R1Pick,
               R2Pick,
               B2Pick,
               B3Pick,
               R3Pick,
               R4Pick,
               B4Pick,
               B5Pick,
               R5Pick,

            };
            B1Pick.BackColor = Color.Yellow;
        }
        private void loadPictureboxes(string[] picked)
        {
            int i = 0;
            foreach (string champ in picked)
            {
                PictureBoxes[i].Image = Image.FromFile(getPathtoPNG(champ));
                PictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                PictureBoxes[i].SizeMode = PictureBoxSizeMode.CenterImage;
                i++;
            }

        }


        private void fillChampionsTextBox()
        {
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            Champions.View = View.LargeIcon;

            foreach (string champ in ChampionsArr)
            {

                Image img = Image.FromFile(getPathtoPNG(champ));
                imageList1.Images.Add(champ, img);


            }
            Champions.LargeImageList = imageList1;


            if (searchChamps.Text.Length == 0)
            {
                foreach (string str in ChampionsArr)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (Champions.SelectedItems.Count > 0 && pickIndex < 10)
            {
                string? champion = Champions.SelectedItems[0].ImageKey;
                if (!Picked.Contains(champion) || champion == "AFiller")
                {
                    Picked[pickIndex] = champion;
                    Picks[pickIndex].Text = champion;
                    Picks[pickIndex].BackColor = Color.White;
                    if (pickIndex < 9)
                    {
                        Picks[pickIndex + 1].BackColor = Color.Yellow;
                    }
                    PictureBoxes[pickIndex].Image = Image.FromFile(getPathtoPNG(champion));
                    PictureBoxes[pickIndex].SizeMode = PictureBoxSizeMode.Zoom;
                    PictureBoxes[pickIndex].SizeMode = PictureBoxSizeMode.CenterImage;
                    pickIndex++;
                }
            }




        }


        private void searchChamps_TextChanged(object sender, EventArgs e)
        {
            Champions.Items.Clear();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);

            foreach (string champ in ChampionsArr)
            {
                if (champ.StartsWith(searchChamps.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    imageList1.Images.Add(champ, Image.FromFile(getPathtoPNG(champ)));

                }
            }
            Champions.LargeImageList = imageList1;
            foreach (string str in ChampionsArr)
            {
                if (str.StartsWith(searchChamps.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
            if (Champions.Items.Count > 0)
            {
                Champions.Items[0].Selected = true;
            }

        }

        private string getPathtoPNG(string champion)
        {
            string championFormatted = champion.Replace(" ", "_");
            string path = "Ressources/Champion Pictures/" + championFormatted + "Square.png";
            return File.Exists(path) ? Path.GetFullPath(path) : Path.GetFullPath("Ressources/Champion Pictures/UnkownSquare.png");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Picked[9] != null)
            {
                dbc.Save(Picked);
                MessageBox.Show("Succesfully Saved");
            }
            else
            {
                MessageBox.Show("NOT FINISHED DRAFTING");
            }

        }

        private void tabControl1_SelectedIndexchanged(object sender, EventArgs e)
        {
           
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    TabPage2Loading();
                    break;
                case 2:
                    Label[] playedCount = matches.loadPlayedCount();
                    int positionChamp = 10;
                    foreach (Label l in playedCount) { 
                        l.AutoSize = true;
                        l.Size = new Size(20, 15);
                        l.Location = new Point(70, positionChamp);
                        positionChamp += 20;
                        tabPage3.Controls.Add(l);
                    }
                    break;
                default: break;
            }
        }

        private void TabPage2Loading()
        {
            tabPage2.Controls.Clear();
            Dictionary<int, String[]> drafts = matches.loadMatches();
            int positionmatch = 10;
            int positionPick = 15;
            int j = 0; //Match id
            foreach (var match in drafts.Reverse())
            {
                int id = match.Key;
                String[] picks = match.Value;
                int i = 0;
                foreach (string pick in picks)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(getPathtoPNG(pick));
                    pictureBox.Size = new Size(20, 20);

                    Label label = new Label();
                    label.AutoSize = true;
                    label.Size = new Size(20, 15);
                    label.Text = pick;

                    if (i < 5)
                    {

                        label.Location = new Point(70, positionmatch + positionPick * i);
                        pictureBox.Location = new Point(10, positionmatch + positionPick * i);
                    }
                    else
                    {
                        label.Location = new Point(350, positionmatch + positionPick * (i - 5));
                        pictureBox.Location = new Point(300, positionmatch + positionPick * (i - 5));
                    }
                    i++;
                    tabPage2.Controls.Add(pictureBox);
                    tabPage2.Controls.Add(label);

                }
                Button load = new Button();
                load.Name = id.ToString();
                load.Location = new Point(500, positionmatch);
                load.Text = "Load";
                load.Click += Load_Click;
                tabPage2.Controls.Add(load);

                Button delete = new Button();
                delete.Name = id.ToString();
                delete.Location = new Point(500, positionmatch + 30);
                delete.Text = "Delete";
                delete.Click += Delete_Click;
                tabPage2.Controls.Add(delete);
                positionmatch += 90;
                j++;
            }
        }

        private void Delete_Click(object? sender, EventArgs e)
        {
            Button b = sender as Button;
            bool deletion = matches.deleteDraftById(int.Parse(b.Name));
            TabPage2Loading();
           
        }

        private void Load_Click(object? sender, EventArgs e) // has to be fixed
        {
            Button b = sender as Button;
            

            String[] champs = matches.getDraftById(int.Parse(b.Name));
            String[] picks = { champs[0], champs[5], champs[6], champs[1], champs[2], champs[7], champs[8], champs[3], champs[4], champs[9] };
            Form1 form = new Form1(picks);
            form.Show();

        }

        private void NewDraft_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            Champions.Clear();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            foreach (string str in TopLaneChamps)
            {
                imageList1.Images.Add(str, Image.FromFile(getPathtoPNG(str)));
            }
            Champions.LargeImageList = imageList1;

            if (searchChamps.Text.Length == 0)
            {
                foreach (string str in TopLaneChamps)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            Champions.Clear();
            fillChampionsTextBox();
        }

        private void Jungle_Click(object sender, EventArgs e)
        {

            Champions.Clear();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            foreach (string str in JungleChamps)
            {
                imageList1.Images.Add(str, Image.FromFile(getPathtoPNG(str)));
            }
            Champions.LargeImageList = imageList1;

            if (searchChamps.Text.Length == 0)
            {
                foreach (string str in JungleChamps)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
        }

        private void Mid_Click(object sender, EventArgs e)
        {
            Champions.Clear();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            foreach (string str in MidChamps)
            {
                imageList1.Images.Add(str, Image.FromFile(getPathtoPNG(str)));
            }
            Champions.LargeImageList = imageList1;

            if (searchChamps.Text.Length == 0)
            {
                foreach (string str in MidChamps)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
        }

        private void Adc_Click(object sender, EventArgs e)
        {
            Champions.Clear();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            foreach (string str in AdcChamps)
            {
                imageList1.Images.Add(str, Image.FromFile(getPathtoPNG(str)));
            }
            Champions.LargeImageList = imageList1;

            if (searchChamps.Text.Length == 0)
            {
                foreach (string str in AdcChamps)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
        }

        private void Support_Click(object sender, EventArgs e)
        {
            Champions.Clear();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            foreach (string str in SupportChamps)
            {
                imageList1.Images.Add(str, Image.FromFile(getPathtoPNG(str)));
            }
            Champions.LargeImageList = imageList1;

            if (searchChamps.Text.Length == 0)
            {
                foreach (string str in SupportChamps)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = str;

                    Champions.Items.Add(item);
                }
            }
        }
    }
}