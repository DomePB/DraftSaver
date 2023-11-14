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
            panel1 = new Panel();
            R5Pick = new Label();
            R4Pick = new Label();
            R3Pick = new Label();
            R2Pick = new Label();
            R1Pick = new Label();
            label5 = new Label();
            B5Pick = new Label();
            B4Pick = new Label();
            B3Pick = new Label();
            B2Pick = new Label();
            B1Champ = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            Champions = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(R5Pick);
            tabPage1.Controls.Add(R4Pick);
            tabPage1.Controls.Add(R3Pick);
            tabPage1.Controls.Add(R2Pick);
            tabPage1.Controls.Add(R1Pick);
            tabPage1.Controls.Add(label5);
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
            // panel1
            // 
            panel1.Controls.Add(Champions);
            panel1.Location = new Point(219, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 627);
            panel1.TabIndex = 12;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 71);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 6;
            label5.Text = "B1";
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
            tabPage3.Text = "IDK Yet";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Champions
            // 
            Champions.FormattingEnabled = true;
            Champions.ItemHeight = 15;
            Champions.Location = new Point(24, 15);
            Champions.Name = "Champions";
            Champions.Size = new Size(1193, 604);
            Champions.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 935);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private Label label5;
        private Panel panel1;
        private Label R5Pick;
        private Label R4Pick;
        private Label R3Pick;
        private Label R2Pick;
        private Label R1Pick;
        private ListBox Champions;
    }
}