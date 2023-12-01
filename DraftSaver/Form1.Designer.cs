namespace DraftSaver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Support = new Button();
            Adc = new Button();
            Mid = new Button();
            Jungle = new Button();
            ShowAll = new Button();
            Top = new Button();
            NewDraft = new Button();
            SaveButton = new Button();
            R5Picture = new PictureBox();
            R4Picture = new PictureBox();
            R3Picture = new PictureBox();
            R2Picture = new PictureBox();
            R1Picture = new PictureBox();
            B5Picture = new PictureBox();
            B4Picture = new PictureBox();
            B3Picture = new PictureBox();
            B2Picture = new PictureBox();
            B1Picture = new PictureBox();
            searchChamps = new TextBox();
            Select = new Button();
            panel1 = new Panel();
            Champions = new ListView();
            R5Pick = new Label();
            R4Pick = new Label();
            R3Pick = new Label();
            R2Pick = new Label();
            R1Pick = new Label();
            B1Pick = new Label();
            B5Pick = new Label();
            B4Pick = new Label();
            B3Pick = new Label();
            B2Pick = new Label();
            B1Champ = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)R5Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R4Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R3Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R2Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R1Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B5Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B4Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B3Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B2Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B1Picture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1706, 935);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Support);
            tabPage1.Controls.Add(Adc);
            tabPage1.Controls.Add(Mid);
            tabPage1.Controls.Add(Jungle);
            tabPage1.Controls.Add(ShowAll);
            tabPage1.Controls.Add(Top);
            tabPage1.Controls.Add(NewDraft);
            tabPage1.Controls.Add(SaveButton);
            tabPage1.Controls.Add(R5Picture);
            tabPage1.Controls.Add(R4Picture);
            tabPage1.Controls.Add(R3Picture);
            tabPage1.Controls.Add(R2Picture);
            tabPage1.Controls.Add(R1Picture);
            tabPage1.Controls.Add(B5Picture);
            tabPage1.Controls.Add(B4Picture);
            tabPage1.Controls.Add(B3Picture);
            tabPage1.Controls.Add(B2Picture);
            tabPage1.Controls.Add(B1Picture);
            tabPage1.Controls.Add(searchChamps);
            tabPage1.Controls.Add(Select);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(R5Pick);
            tabPage1.Controls.Add(R4Pick);
            tabPage1.Controls.Add(R3Pick);
            tabPage1.Controls.Add(R2Pick);
            tabPage1.Controls.Add(R1Pick);
            tabPage1.Controls.Add(B1Pick);
            tabPage1.Controls.Add(B5Pick);
            tabPage1.Controls.Add(B4Pick);
            tabPage1.Controls.Add(B3Pick);
            tabPage1.Controls.Add(B2Pick);
            tabPage1.Controls.Add(B1Champ);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1698, 907);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Draft";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Support
            // 
            Support.Location = new Point(543, 43);
            Support.Name = "Support";
            Support.Size = new Size(75, 23);
            Support.TabIndex = 29;
            Support.Text = "Support";
            Support.UseVisualStyleBackColor = true;
            Support.Click += Support_Click;
            // 
            // Adc
            // 
            Adc.Location = new Point(462, 42);
            Adc.Name = "Adc";
            Adc.Size = new Size(75, 23);
            Adc.TabIndex = 28;
            Adc.Text = "Adc";
            Adc.UseVisualStyleBackColor = true;
            Adc.Click += Adc_Click;
            // 
            // Mid
            // 
            Mid.Location = new Point(381, 43);
            Mid.Name = "Mid";
            Mid.Size = new Size(75, 23);
            Mid.TabIndex = 1;
            Mid.Text = "Mid";
            Mid.UseVisualStyleBackColor = true;
            Mid.Click += Mid_Click;
            // 
            // Jungle
            // 
            Jungle.Location = new Point(300, 42);
            Jungle.Name = "Jungle";
            Jungle.Size = new Size(75, 23);
            Jungle.TabIndex = 27;
            Jungle.Text = "Jungle";
            Jungle.UseVisualStyleBackColor = true;
            Jungle.Click += Jungle_Click;
            // 
            // ShowAll
            // 
            ShowAll.Location = new Point(1136, 43);
            ShowAll.Name = "ShowAll";
            ShowAll.Size = new Size(75, 23);
            ShowAll.TabIndex = 26;
            ShowAll.Text = "Show All";
            ShowAll.UseVisualStyleBackColor = true;
            ShowAll.Click += ShowAll_Click;
            // 
            // Top
            // 
            Top.Location = new Point(219, 43);
            Top.Name = "Top";
            Top.Size = new Size(75, 23);
            Top.TabIndex = 25;
            Top.Text = "Top";
            Top.UseVisualStyleBackColor = true;
            Top.Click += Top_Click;
            // 
            // NewDraft
            // 
            NewDraft.Location = new Point(298, 803);
            NewDraft.Name = "NewDraft";
            NewDraft.Size = new Size(75, 23);
            NewDraft.TabIndex = 1;
            NewDraft.Text = "New Draft";
            NewDraft.UseVisualStyleBackColor = true;
            NewDraft.Click += NewDraft_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(1271, 803);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // R5Picture
            // 
            R5Picture.Location = new Point(1487, 652);
            R5Picture.Name = "R5Picture";
            R5Picture.Size = new Size(90, 90);
            R5Picture.TabIndex = 24;
            R5Picture.TabStop = false;
            // 
            // R4Picture
            // 
            R4Picture.Location = new Point(1487, 492);
            R4Picture.Name = "R4Picture";
            R4Picture.Size = new Size(90, 90);
            R4Picture.TabIndex = 23;
            R4Picture.TabStop = false;
            // 
            // R3Picture
            // 
            R3Picture.Location = new Point(1487, 349);
            R3Picture.Name = "R3Picture";
            R3Picture.Size = new Size(90, 90);
            R3Picture.TabIndex = 22;
            R3Picture.TabStop = false;
            // 
            // R2Picture
            // 
            R2Picture.Location = new Point(1487, 187);
            R2Picture.Name = "R2Picture";
            R2Picture.Size = new Size(90, 90);
            R2Picture.TabIndex = 21;
            R2Picture.TabStop = false;
            // 
            // R1Picture
            // 
            R1Picture.Location = new Point(1487, 71);
            R1Picture.Name = "R1Picture";
            R1Picture.Size = new Size(90, 90);
            R1Picture.TabIndex = 20;
            R1Picture.TabStop = false;
            // 
            // B5Picture
            // 
            B5Picture.Location = new Point(102, 652);
            B5Picture.Name = "B5Picture";
            B5Picture.Size = new Size(90, 90);
            B5Picture.TabIndex = 19;
            B5Picture.TabStop = false;
            // 
            // B4Picture
            // 
            B4Picture.Location = new Point(102, 492);
            B4Picture.Name = "B4Picture";
            B4Picture.Size = new Size(90, 90);
            B4Picture.TabIndex = 18;
            B4Picture.TabStop = false;
            // 
            // B3Picture
            // 
            B3Picture.Location = new Point(102, 349);
            B3Picture.Name = "B3Picture";
            B3Picture.Size = new Size(90, 90);
            B3Picture.TabIndex = 17;
            B3Picture.TabStop = false;
            // 
            // B2Picture
            // 
            B2Picture.Location = new Point(102, 187);
            B2Picture.Name = "B2Picture";
            B2Picture.Size = new Size(90, 90);
            B2Picture.TabIndex = 16;
            B2Picture.TabStop = false;
            // 
            // B1Picture
            // 
            B1Picture.Location = new Point(102, 71);
            B1Picture.Name = "B1Picture";
            B1Picture.Size = new Size(90, 90);
            B1Picture.TabIndex = 15;
            B1Picture.TabStop = false;
            // 
            // searchChamps
            // 
            searchChamps.Location = new Point(1253, 43);
            searchChamps.Name = "searchChamps";
            searchChamps.Size = new Size(163, 23);
            searchChamps.TabIndex = 14;
            searchChamps.TextChanged += searchChamps_TextChanged;
            // 
            // Select
            // 
            Select.Location = new Point(663, 786);
            Select.Name = "Select";
            Select.Size = new Size(375, 56);
            Select.TabIndex = 13;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Champions);
            panel1.Location = new Point(219, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 627);
            panel1.TabIndex = 12;
            // 
            // Champions
            // 
            Champions.Location = new Point(0, 0);
            Champions.Name = "Champions";
            Champions.Size = new Size(1238, 624);
            Champions.TabIndex = 0;
            Champions.UseCompatibleStateImageBehavior = false;
            // 
            // R5Pick
            // 
            R5Pick.AutoSize = true;
            R5Pick.Location = new Point(1583, 652);
            R5Pick.Name = "R5Pick";
            R5Pick.Size = new Size(20, 15);
            R5Pick.TabIndex = 11;
            R5Pick.Text = "R5";
            // 
            // R4Pick
            // 
            R4Pick.AutoSize = true;
            R4Pick.Location = new Point(1583, 492);
            R4Pick.Name = "R4Pick";
            R4Pick.Size = new Size(20, 15);
            R4Pick.TabIndex = 10;
            R4Pick.Text = "R4";
            // 
            // R3Pick
            // 
            R3Pick.AutoSize = true;
            R3Pick.Location = new Point(1583, 349);
            R3Pick.Name = "R3Pick";
            R3Pick.Size = new Size(20, 15);
            R3Pick.TabIndex = 9;
            R3Pick.Text = "R3";
            // 
            // R2Pick
            // 
            R2Pick.AutoSize = true;
            R2Pick.Location = new Point(1583, 187);
            R2Pick.Name = "R2Pick";
            R2Pick.Size = new Size(20, 15);
            R2Pick.TabIndex = 8;
            R2Pick.Text = "R2";
            // 
            // R1Pick
            // 
            R1Pick.AutoSize = true;
            R1Pick.Location = new Point(1583, 71);
            R1Pick.Name = "R1Pick";
            R1Pick.Size = new Size(20, 15);
            R1Pick.TabIndex = 7;
            R1Pick.Text = "R1";
            // 
            // B1Pick
            // 
            B1Pick.AutoSize = true;
            B1Pick.Location = new Point(59, 71);
            B1Pick.Name = "B1Pick";
            B1Pick.Size = new Size(20, 15);
            B1Pick.TabIndex = 6;
            B1Pick.Text = "B1";
            // 
            // B5Pick
            // 
            B5Pick.AutoSize = true;
            B5Pick.Location = new Point(59, 652);
            B5Pick.Name = "B5Pick";
            B5Pick.Size = new Size(20, 15);
            B5Pick.TabIndex = 4;
            B5Pick.Text = "B5";
            // 
            // B4Pick
            // 
            B4Pick.AutoSize = true;
            B4Pick.Location = new Point(59, 492);
            B4Pick.Name = "B4Pick";
            B4Pick.Size = new Size(20, 15);
            B4Pick.TabIndex = 3;
            B4Pick.Text = "B4";
            // 
            // B3Pick
            // 
            B3Pick.AutoSize = true;
            B3Pick.Location = new Point(59, 349);
            B3Pick.Name = "B3Pick";
            B3Pick.Size = new Size(20, 15);
            B3Pick.TabIndex = 2;
            B3Pick.Text = "B3";
            // 
            // B2Pick
            // 
            B2Pick.AutoSize = true;
            B2Pick.Location = new Point(59, 187);
            B2Pick.Name = "B2Pick";
            B2Pick.Size = new Size(20, 15);
            B2Pick.TabIndex = 1;
            B2Pick.Text = "B2";
            // 
            // B1Champ
            // 
            B1Champ.Location = new Point(0, 0);
            B1Champ.Name = "B1Champ";
            B1Champ.Size = new Size(100, 23);
            B1Champ.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1698, 907);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Saved Drafts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1698, 907);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Stats";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = Select;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 935);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drafter";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)R5Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)R4Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)R3Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)R2Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)R1Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)B5Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)B4Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)B3Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)B2Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)B1Picture).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label B5Pick;
        private Label B4Pick;
        private Label B3Pick;
        private Label B2Pick;
        private Label B1Champ;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label B1Pick;
        private Panel panel1;
        private Label R5Pick;
        private Label R4Pick;
        private Label R3Pick;
        private Label R2Pick;
        private Label R1Pick;
        private Button Select;
        private TextBox searchChamps;
        private PictureBox B1Picture;
        private PictureBox R5Picture;
        private PictureBox R4Picture;
        private PictureBox R3Picture;
        private PictureBox R2Picture;
        private PictureBox R1Picture;
        private PictureBox B5Picture;
        private PictureBox B4Picture;
        private PictureBox B3Picture;
        private PictureBox B2Picture;
        private ListView Champions;
        private Button SaveButton;
        private Button NewDraft;
        private Button Top;
        private Button ShowAll;
        private Button Jungle;
        private Button Mid;
        private Button Adc;
        private Button Support;
    }
}