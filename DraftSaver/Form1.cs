namespace DraftSaver
{
    public partial class Form1 : Form
    {
        private String[] ChampionsArr = { "Ahri", "Akali", "Alistar", "Amumu", "Anivia", "Annie", "Aphelios", "Ashe", "Aurelion Sol", "Azir", "Bard", "Blitzcrank", "Brand", "Braum", "Caitlyn", "Camille", "Cho'Gath", "Corki", "Darius", "Diana", "Dr. Mundo", "Draven", "Ekko", "Elise", "Evelynn", "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio", "Gangplank", "Garen", "Gnar", "Gragas", "Graves", "Gwen", "Hecarim", "Heimerdinger", "Illaoi", "Irelia", "Ivern", "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx", "Kai'Sa", "Kalista", "Karma", "Karthus", "Kassadin", "Katarina", "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled", "Kog'Maw", "LeBlanc", "Lee Sin", "Leona", "Lillia", "Lissandra", "Lucian", "Lulu", "Lux", "Malphite", "Malzahar", "Maokai", "Master Yi", "Miss Fortune", "Mordekaiser", "Morgana", "Nami", "Nasus", "Nautilus", "Neeko", "Nidalee", "Nocturne", "Nunu & Willump", "Olaf", "Orianna", "Ornn", "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn", "Rakan", "Rammus", "Rek'Sai", "Rell", "Renekton", "Rengar", "Riven", "Rumble", "Ryze", "Samira", "Sejuani", "Senna", "Seraphine", "Sett", "Shaco", "Shen", "Shyvana", "Singed", "Sion", "Sivir", "Skarner", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tahm Kench", "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana", "Trundle", "Tryndamere", "Twisted Fate", "Twitch", "Udyr", "Urgot", "Varus", "Vayne", "Veigar", "Vel'Koz", "Vi", "Viego", "Viktor", "Vladimir", "Volibear", "Warwick", "Wukong", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi", "Zac", "Zed", "Ziggs", "Zilean", "Zoe", "Zyra" };
        private int pickIndex = 0;
        private Label[] Picks;
        private String[] Picked = new string[10];
        private PictureBox[] PictureBoxes;
        public Form1()
        {
            InitializeComponent();
            fillChampionsTextBox();
            InitializeLabels();
            InitializePicturebox();
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

        private void fillChampionsTextBox()
        {
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(120, 120);
            Champions.View = View.LargeIcon;
            foreach (string champ in ChampionsArr) {
                imageList1.Images.Add(champ,Image.FromFile(getPathtoPNG(champ)));
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
            if (Champions.SelectedItems != null && pickIndex < 10)
            {
                string? champion = Champions.SelectedItems[0].Text;
                if (!Picked.Contains(champion))
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

            foreach (string str in ChampionsArr)
            {
                if (str.StartsWith(searchChamps.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    Champions.Items.Add(str);
                }
            }
        }

        private string getPathtoPNG(string champion)
        {
            string championFormatted = champion.Replace(" ", "_");
            string path = "Ressources/Champion Pictures/" + championFormatted + "Square.png";
            return File.Exists(path)? Path.GetFullPath(path) :Path.GetFullPath("Ressources/Champion Pictures/" + "Ashe" + "Square.png");
        }
    }
}