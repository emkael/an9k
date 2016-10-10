using System.Drawing;
using System.Windows.Forms;

namespace Analizator9000
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        string[] cards8 = new string[6] { " ", "♣", "♦", "♥", "♠", "NT" };
        string[] cards9 = new string[6] { " ", "♣", "♦", "♥", "♠", "NT" };
        string[] cards10 = new string[6] { " ", "♣", "♦", "♥", "♠", "NT" };
        string[] cards11 = new string[6] { " ", "♣", "♦", "♥", "♠", "NT" };
        string[] cards12 = new string[6] { " ", "♣", "♦", "♥", "♠", "NT" };
        string[] cards13 = new string[6] { " ", "♣", "♦", "♥", "♠", "NT" };

        private void comboBox8_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 44;
            e.ItemHeight = 15;
        }

        private void comboBox8_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            this.comboBox8.DataSource = cards8;

            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            switch (e.Index)
            {
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Red;
                    break;
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            if (e.Index >= 0) e.Graphics.DrawString(comboBox8.Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void comboBox9_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 44;
            e.ItemHeight = 15;
        }

        private void comboBox9_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            this.comboBox9.DataSource = cards9;
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            switch (e.Index)
            {
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Red;
                    break;
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            if (e.Index >= 0) e.Graphics.DrawString(comboBox9.Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void comboBox10_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 44;
            e.ItemHeight = 15;
        }

        private void comboBox10_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            this.comboBox10.DataSource = cards10;
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            switch (e.Index)
            {
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Red;
                    break;
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            if (e.Index >= 0) e.Graphics.DrawString(comboBox10.Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void comboBox11_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 44;
            e.ItemHeight = 15;
        }

        private void comboBox11_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            this.comboBox10.DataSource = cards11;
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            switch (e.Index)
            {
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Red;
                    break;
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            if (e.Index >= 0) e.Graphics.DrawString(comboBox11.Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void comboBox12_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 44;
            e.ItemHeight = 15;
        }

        private void comboBox12_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            this.comboBox10.DataSource = cards12;
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            switch (e.Index)
            {
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Red;
                    break;
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            if (e.Index >= 0) e.Graphics.DrawString(comboBox12.Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void comboBox13_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 44;
            e.ItemHeight = 15;
        }


        private void comboBox13_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            this.comboBox13.DataSource = cards13;
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based on the index of the item to draw.
            switch (e.Index)
            {
                case 2:
                    myBrush = Brushes.Red;
                    break;
                case 3:
                    myBrush = Brushes.Red;
                    break;
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            if (e.Index >= 0) e.Graphics.DrawString(comboBox13.Items[e.Index].ToString(),
                  e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateGroup = new System.Windows.Forms.GroupBox();
            this.actionsBox = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.RichTextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.produceBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.generateBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.predealNorthSpadesBox = new System.Windows.Forms.TextBox();
            this.predealEastSpadesBox = new System.Windows.Forms.TextBox();
            this.predealSouthSpadesBox = new System.Windows.Forms.TextBox();
            this.predealWestSpadesBox = new System.Windows.Forms.TextBox();
            this.predealNorthHeartsBox = new System.Windows.Forms.TextBox();
            this.predealEastHeartsBox = new System.Windows.Forms.TextBox();
            this.predealSouthHeartsBox = new System.Windows.Forms.TextBox();
            this.predealWestHeartsBox = new System.Windows.Forms.TextBox();
            this.predealNorthDiamondsBox = new System.Windows.Forms.TextBox();
            this.predealEastDiamondsBox = new System.Windows.Forms.TextBox();
            this.predealSouthDiamondsBox = new System.Windows.Forms.TextBox();
            this.predealWestDiamondsBox = new System.Windows.Forms.TextBox();
            this.predealNorthClubsBox = new System.Windows.Forms.TextBox();
            this.predealEastClubsBox = new System.Windows.Forms.TextBox();
            this.predealSouthClubsBox = new System.Windows.Forms.TextBox();
            this.predealWestClubsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.generateFileNameTextBox = new System.Windows.Forms.TextBox();
            this.analyzeGroup = new System.Windows.Forms.GroupBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.contractTable = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.vulnerabilityBox = new System.Windows.Forms.ComboBox();
            this.fullContractTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.comboBox27 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.contractCancelButton = new System.Windows.Forms.Button();
            this.contractAnalyzeButton = new System.Windows.Forms.Button();
            this.analyzeFileNameTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.generateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.analyzeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.langSelectSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripWebsiteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripExitButton = new System.Windows.Forms.ToolStripButton();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.generateGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.analyzeGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contractTable.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.fullContractTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateGroup
            // 
            this.generateGroup.Controls.Add(this.actionsBox);
            this.generateGroup.Controls.Add(this.label23);
            this.generateGroup.Controls.Add(this.conditionBox);
            this.generateGroup.Controls.Add(this.generateButton);
            this.generateGroup.Controls.Add(this.produceBox);
            this.generateGroup.Controls.Add(this.label12);
            this.generateGroup.Controls.Add(this.generateBox);
            this.generateGroup.Controls.Add(this.label11);
            this.generateGroup.Controls.Add(this.label10);
            this.generateGroup.Controls.Add(this.tableLayoutPanel1);
            this.generateGroup.Controls.Add(this.label1);
            this.generateGroup.Controls.Add(this.button1);
            this.generateGroup.Controls.Add(this.generateFileNameTextBox);
            resources.ApplyResources(this.generateGroup, "generateGroup");
            this.generateGroup.Name = "generateGroup";
            this.generateGroup.TabStop = false;
            // 
            // actionsBox
            // 
            this.actionsBox.AcceptsTab = true;
            resources.ApplyResources(this.actionsBox, "actionsBox");
            this.actionsBox.Name = "actionsBox";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // conditionBox
            // 
            this.conditionBox.AcceptsTab = true;
            resources.ApplyResources(this.conditionBox, "conditionBox");
            this.conditionBox.Name = "conditionBox";
            // 
            // generateButton
            // 
            resources.ApplyResources(this.generateButton, "generateButton");
            this.generateButton.Name = "generateButton";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // produceBox
            // 
            resources.ApplyResources(this.produceBox, "produceBox");
            this.produceBox.Name = "produceBox";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // generateBox
            // 
            resources.ApplyResources(this.generateBox, "generateBox");
            this.generateBox.Name = "generateBox";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.predealNorthSpadesBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.predealEastSpadesBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.predealSouthSpadesBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.predealWestSpadesBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.predealNorthHeartsBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.predealEastHeartsBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.predealSouthHeartsBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.predealWestHeartsBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.predealNorthDiamondsBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.predealEastDiamondsBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.predealSouthDiamondsBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.predealWestDiamondsBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.predealNorthClubsBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.predealEastClubsBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.predealSouthClubsBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.predealWestClubsBox, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // predealNorthSpadesBox
            // 
            resources.ApplyResources(this.predealNorthSpadesBox, "predealNorthSpadesBox");
            this.predealNorthSpadesBox.Name = "predealNorthSpadesBox";
            // 
            // predealEastSpadesBox
            // 
            resources.ApplyResources(this.predealEastSpadesBox, "predealEastSpadesBox");
            this.predealEastSpadesBox.Name = "predealEastSpadesBox";
            // 
            // predealSouthSpadesBox
            // 
            resources.ApplyResources(this.predealSouthSpadesBox, "predealSouthSpadesBox");
            this.predealSouthSpadesBox.Name = "predealSouthSpadesBox";
            // 
            // predealWestSpadesBox
            // 
            resources.ApplyResources(this.predealWestSpadesBox, "predealWestSpadesBox");
            this.predealWestSpadesBox.Name = "predealWestSpadesBox";
            // 
            // predealNorthHeartsBox
            // 
            resources.ApplyResources(this.predealNorthHeartsBox, "predealNorthHeartsBox");
            this.predealNorthHeartsBox.Name = "predealNorthHeartsBox";
            // 
            // predealEastHeartsBox
            // 
            resources.ApplyResources(this.predealEastHeartsBox, "predealEastHeartsBox");
            this.predealEastHeartsBox.Name = "predealEastHeartsBox";
            // 
            // predealSouthHeartsBox
            // 
            resources.ApplyResources(this.predealSouthHeartsBox, "predealSouthHeartsBox");
            this.predealSouthHeartsBox.Name = "predealSouthHeartsBox";
            // 
            // predealWestHeartsBox
            // 
            resources.ApplyResources(this.predealWestHeartsBox, "predealWestHeartsBox");
            this.predealWestHeartsBox.Name = "predealWestHeartsBox";
            // 
            // predealNorthDiamondsBox
            // 
            resources.ApplyResources(this.predealNorthDiamondsBox, "predealNorthDiamondsBox");
            this.predealNorthDiamondsBox.Name = "predealNorthDiamondsBox";
            // 
            // predealEastDiamondsBox
            // 
            resources.ApplyResources(this.predealEastDiamondsBox, "predealEastDiamondsBox");
            this.predealEastDiamondsBox.Name = "predealEastDiamondsBox";
            // 
            // predealSouthDiamondsBox
            // 
            resources.ApplyResources(this.predealSouthDiamondsBox, "predealSouthDiamondsBox");
            this.predealSouthDiamondsBox.Name = "predealSouthDiamondsBox";
            // 
            // predealWestDiamondsBox
            // 
            resources.ApplyResources(this.predealWestDiamondsBox, "predealWestDiamondsBox");
            this.predealWestDiamondsBox.Name = "predealWestDiamondsBox";
            // 
            // predealNorthClubsBox
            // 
            resources.ApplyResources(this.predealNorthClubsBox, "predealNorthClubsBox");
            this.predealNorthClubsBox.Name = "predealNorthClubsBox";
            // 
            // predealEastClubsBox
            // 
            resources.ApplyResources(this.predealEastClubsBox, "predealEastClubsBox");
            this.predealEastClubsBox.Name = "predealEastClubsBox";
            // 
            // predealSouthClubsBox
            // 
            resources.ApplyResources(this.predealSouthClubsBox, "predealSouthClubsBox");
            this.predealSouthClubsBox.Name = "predealSouthClubsBox";
            // 
            // predealWestClubsBox
            // 
            resources.ApplyResources(this.predealWestClubsBox, "predealWestClubsBox");
            this.predealWestClubsBox.Name = "predealWestClubsBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateFileNameTextBox
            // 
            resources.ApplyResources(this.generateFileNameTextBox, "generateFileNameTextBox");
            this.generateFileNameTextBox.Name = "generateFileNameTextBox";
            this.generateFileNameTextBox.ReadOnly = true;
            // 
            // analyzeGroup
            // 
            this.analyzeGroup.Controls.Add(this.exportBtn);
            this.analyzeGroup.Controls.Add(this.button2);
            this.analyzeGroup.Controls.Add(this.tabControl1);
            this.analyzeGroup.Controls.Add(this.analyzeFileNameTextBox);
            this.analyzeGroup.Controls.Add(this.progressBar);
            this.analyzeGroup.Controls.Add(this.statusListBox);
            resources.ApplyResources(this.analyzeGroup, "analyzeGroup");
            this.analyzeGroup.Name = "analyzeGroup";
            this.analyzeGroup.TabStop = false;
            // 
            // exportBtn
            // 
            resources.ApplyResources(this.exportBtn, "exportBtn");
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.resultTextBox);
            this.tabPage1.Controls.Add(this.abortButton);
            this.tabPage1.Controls.Add(this.analyzeButton);
            this.tabPage1.Controls.Add(this.contractTable);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // resultTextBox
            // 
            resources.ApplyResources(this.resultTextBox, "resultTextBox");
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            // 
            // abortButton
            // 
            resources.ApplyResources(this.abortButton, "abortButton");
            this.abortButton.Name = "abortButton";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // analyzeButton
            // 
            resources.ApplyResources(this.analyzeButton, "analyzeButton");
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // contractTable
            // 
            resources.ApplyResources(this.contractTable, "contractTable");
            this.contractTable.Controls.Add(this.label21, 0, 3);
            this.contractTable.Controls.Add(this.label17, 5, 0);
            this.contractTable.Controls.Add(this.label15, 3, 0);
            this.contractTable.Controls.Add(this.checkBox1, 1, 1);
            this.contractTable.Controls.Add(this.checkBox2, 1, 2);
            this.contractTable.Controls.Add(this.checkBox3, 1, 3);
            this.contractTable.Controls.Add(this.checkBox4, 1, 4);
            this.contractTable.Controls.Add(this.checkBox5, 2, 1);
            this.contractTable.Controls.Add(this.checkBox6, 2, 2);
            this.contractTable.Controls.Add(this.checkBox7, 2, 3);
            this.contractTable.Controls.Add(this.checkBox8, 2, 4);
            this.contractTable.Controls.Add(this.checkBox9, 3, 1);
            this.contractTable.Controls.Add(this.checkBox10, 4, 1);
            this.contractTable.Controls.Add(this.checkBox11, 5, 1);
            this.contractTable.Controls.Add(this.checkBox12, 3, 2);
            this.contractTable.Controls.Add(this.checkBox13, 4, 2);
            this.contractTable.Controls.Add(this.checkBox14, 5, 2);
            this.contractTable.Controls.Add(this.checkBox15, 3, 3);
            this.contractTable.Controls.Add(this.checkBox16, 4, 3);
            this.contractTable.Controls.Add(this.checkBox17, 5, 3);
            this.contractTable.Controls.Add(this.checkBox18, 3, 4);
            this.contractTable.Controls.Add(this.checkBox19, 4, 4);
            this.contractTable.Controls.Add(this.checkBox20, 5, 4);
            this.contractTable.Controls.Add(this.label14, 2, 0);
            this.contractTable.Controls.Add(this.label16, 4, 0);
            this.contractTable.Controls.Add(this.label18, 1, 0);
            this.contractTable.Controls.Add(this.label19, 0, 1);
            this.contractTable.Controls.Add(this.label20, 0, 2);
            this.contractTable.Controls.Add(this.label22, 0, 4);
            this.contractTable.Controls.Add(this.button3, 0, 0);
            this.contractTable.Name = "contractTable";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Name = "label15";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            resources.ApplyResources(this.checkBox9, "checkBox9");
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            resources.ApplyResources(this.checkBox10, "checkBox10");
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            resources.ApplyResources(this.checkBox11, "checkBox11");
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            resources.ApplyResources(this.checkBox12, "checkBox12");
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            resources.ApplyResources(this.checkBox13, "checkBox13");
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            resources.ApplyResources(this.checkBox14, "checkBox14");
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            resources.ApplyResources(this.checkBox15, "checkBox15");
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            resources.ApplyResources(this.checkBox16, "checkBox16");
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            resources.ApplyResources(this.checkBox17, "checkBox17");
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            resources.ApplyResources(this.checkBox18, "checkBox18");
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            resources.ApplyResources(this.checkBox19, "checkBox19");
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            resources.ApplyResources(this.checkBox20, "checkBox20");
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Name = "label16";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Name = "label18";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.vulnerabilityBox);
            this.tabPage2.Controls.Add(this.fullContractTable);
            this.tabPage2.Controls.Add(this.contractCancelButton);
            this.tabPage2.Controls.Add(this.contractAnalyzeButton);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // vulnerabilityBox
            // 
            this.vulnerabilityBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.vulnerabilityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vulnerabilityBox.FormattingEnabled = true;
            this.vulnerabilityBox.Items.AddRange(new object[] {
            resources.GetString("vulnerabilityBox.Items"),
            resources.GetString("vulnerabilityBox.Items1"),
            resources.GetString("vulnerabilityBox.Items2"),
            resources.GetString("vulnerabilityBox.Items3")});
            resources.ApplyResources(this.vulnerabilityBox, "vulnerabilityBox");
            this.vulnerabilityBox.Name = "vulnerabilityBox";
            // 
            // fullContractTable
            // 
            resources.ApplyResources(this.fullContractTable, "fullContractTable");
            this.fullContractTable.Controls.Add(this.textBox22, 7, 5);
            this.fullContractTable.Controls.Add(this.textBox23, 8, 5);
            this.fullContractTable.Controls.Add(this.textBox24, 6, 6);
            this.fullContractTable.Controls.Add(this.textBox25, 7, 6);
            this.fullContractTable.Controls.Add(this.textBox26, 8, 6);
            this.fullContractTable.Controls.Add(this.textBox15, 6, 3);
            this.fullContractTable.Controls.Add(this.textBox16, 7, 3);
            this.fullContractTable.Controls.Add(this.textBox17, 8, 3);
            this.fullContractTable.Controls.Add(this.textBox18, 6, 4);
            this.fullContractTable.Controls.Add(this.textBox19, 7, 4);
            this.fullContractTable.Controls.Add(this.textBox20, 8, 4);
            this.fullContractTable.Controls.Add(this.textBox21, 6, 5);
            this.fullContractTable.Controls.Add(this.textBox9, 6, 1);
            this.fullContractTable.Controls.Add(this.textBox10, 7, 1);
            this.fullContractTable.Controls.Add(this.textBox11, 8, 1);
            this.fullContractTable.Controls.Add(this.textBox12, 6, 2);
            this.fullContractTable.Controls.Add(this.textBox13, 7, 2);
            this.fullContractTable.Controls.Add(this.textBox14, 8, 2);
            this.fullContractTable.Controls.Add(this.label24, 0, 0);
            this.fullContractTable.Controls.Add(this.label25, 1, 0);
            this.fullContractTable.Controls.Add(this.label27, 3, 0);
            this.fullContractTable.Controls.Add(this.label28, 4, 0);
            this.fullContractTable.Controls.Add(this.label29, 5, 0);
            this.fullContractTable.Controls.Add(this.label30, 6, 0);
            this.fullContractTable.Controls.Add(this.comboBox1, 0, 1);
            this.fullContractTable.Controls.Add(this.comboBox2, 0, 2);
            this.fullContractTable.Controls.Add(this.comboBox3, 0, 3);
            this.fullContractTable.Controls.Add(this.comboBox4, 0, 4);
            this.fullContractTable.Controls.Add(this.comboBox5, 0, 5);
            this.fullContractTable.Controls.Add(this.comboBox6, 0, 6);
            this.fullContractTable.Controls.Add(this.comboBox8, 1, 1);
            this.fullContractTable.Controls.Add(this.comboBox9, 1, 2);
            this.fullContractTable.Controls.Add(this.comboBox10, 1, 3);
            this.fullContractTable.Controls.Add(this.comboBox11, 1, 4);
            this.fullContractTable.Controls.Add(this.comboBox12, 1, 5);
            this.fullContractTable.Controls.Add(this.comboBox13, 1, 6);
            this.fullContractTable.Controls.Add(this.comboBox15, 2, 1);
            this.fullContractTable.Controls.Add(this.comboBox16, 2, 2);
            this.fullContractTable.Controls.Add(this.comboBox17, 2, 3);
            this.fullContractTable.Controls.Add(this.comboBox18, 2, 4);
            this.fullContractTable.Controls.Add(this.comboBox19, 2, 5);
            this.fullContractTable.Controls.Add(this.comboBox20, 2, 6);
            this.fullContractTable.Controls.Add(this.comboBox22, 3, 1);
            this.fullContractTable.Controls.Add(this.comboBox23, 3, 2);
            this.fullContractTable.Controls.Add(this.comboBox24, 3, 3);
            this.fullContractTable.Controls.Add(this.comboBox25, 3, 4);
            this.fullContractTable.Controls.Add(this.comboBox26, 3, 5);
            this.fullContractTable.Controls.Add(this.comboBox27, 3, 6);
            this.fullContractTable.Controls.Add(this.numericUpDown1, 4, 1);
            this.fullContractTable.Controls.Add(this.numericUpDown2, 4, 2);
            this.fullContractTable.Controls.Add(this.numericUpDown3, 4, 3);
            this.fullContractTable.Controls.Add(this.numericUpDown4, 4, 4);
            this.fullContractTable.Controls.Add(this.numericUpDown5, 4, 5);
            this.fullContractTable.Controls.Add(this.numericUpDown6, 4, 6);
            this.fullContractTable.Controls.Add(this.textBox1, 5, 1);
            this.fullContractTable.Controls.Add(this.textBox2, 5, 2);
            this.fullContractTable.Controls.Add(this.textBox3, 5, 3);
            this.fullContractTable.Controls.Add(this.textBox4, 5, 4);
            this.fullContractTable.Controls.Add(this.textBox5, 5, 5);
            this.fullContractTable.Controls.Add(this.textBox6, 5, 6);
            this.fullContractTable.Controls.Add(this.label32, 9, 0);
            this.fullContractTable.Controls.Add(this.label31, 8, 0);
            this.fullContractTable.Controls.Add(this.textBox7, 9, 1);
            this.fullContractTable.Controls.Add(this.textBox8, 9, 2);
            this.fullContractTable.Controls.Add(this.textBox27, 9, 3);
            this.fullContractTable.Controls.Add(this.textBox28, 9, 4);
            this.fullContractTable.Controls.Add(this.textBox29, 9, 5);
            this.fullContractTable.Controls.Add(this.textBox30, 9, 6);
            this.fullContractTable.Controls.Add(this.label33, 7, 0);
            this.fullContractTable.Name = "fullContractTable";
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            // 
            // textBox23
            // 
            resources.ApplyResources(this.textBox23, "textBox23");
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            // 
            // textBox24
            // 
            resources.ApplyResources(this.textBox24, "textBox24");
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            // 
            // textBox25
            // 
            resources.ApplyResources(this.textBox25, "textBox25");
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            // 
            // textBox26
            // 
            resources.ApplyResources(this.textBox26, "textBox26");
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            // 
            // textBox19
            // 
            resources.ApplyResources(this.textBox19, "textBox19");
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            // 
            // textBox20
            // 
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            // 
            // textBox21
            // 
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5"),
            resources.GetString("comboBox2.Items6"),
            resources.GetString("comboBox2.Items7"),
            resources.GetString("comboBox2.Items8")});
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4"),
            resources.GetString("comboBox3.Items5"),
            resources.GetString("comboBox3.Items6"),
            resources.GetString("comboBox3.Items7"),
            resources.GetString("comboBox3.Items8")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            resources.GetString("comboBox4.Items1"),
            resources.GetString("comboBox4.Items2"),
            resources.GetString("comboBox4.Items3"),
            resources.GetString("comboBox4.Items4"),
            resources.GetString("comboBox4.Items5"),
            resources.GetString("comboBox4.Items6"),
            resources.GetString("comboBox4.Items7"),
            resources.GetString("comboBox4.Items8")});
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            resources.GetString("comboBox5.Items"),
            resources.GetString("comboBox5.Items1"),
            resources.GetString("comboBox5.Items2"),
            resources.GetString("comboBox5.Items3"),
            resources.GetString("comboBox5.Items4"),
            resources.GetString("comboBox5.Items5"),
            resources.GetString("comboBox5.Items6"),
            resources.GetString("comboBox5.Items7"),
            resources.GetString("comboBox5.Items8")});
            resources.ApplyResources(this.comboBox5, "comboBox5");
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            resources.GetString("comboBox6.Items"),
            resources.GetString("comboBox6.Items1"),
            resources.GetString("comboBox6.Items2"),
            resources.GetString("comboBox6.Items3"),
            resources.GetString("comboBox6.Items4"),
            resources.GetString("comboBox6.Items5"),
            resources.GetString("comboBox6.Items6"),
            resources.GetString("comboBox6.Items7"),
            resources.GetString("comboBox6.Items8")});
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox8
            // 
            this.comboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox8, "comboBox8");
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox8_DrawItem);
            this.comboBox8.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox8_MeasureItem);
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox9
            // 
            this.comboBox9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox9, "comboBox9");
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox9_DrawItem);
            this.comboBox9.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox9_MeasureItem);
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox10
            // 
            this.comboBox10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox10, "comboBox10");
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox10_DrawItem);
            this.comboBox10.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox10_MeasureItem);
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox11
            // 
            this.comboBox11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox11, "comboBox11");
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox11_DrawItem);
            this.comboBox11.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox11_MeasureItem);
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox12
            // 
            this.comboBox12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox12, "comboBox12");
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox12_DrawItem);
            this.comboBox12.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox12_MeasureItem);
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox13
            // 
            this.comboBox13.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox13, "comboBox13");
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox13_DrawItem);
            this.comboBox13.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox13_MeasureItem);
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            resources.GetString("comboBox15.Items"),
            resources.GetString("comboBox15.Items1"),
            resources.GetString("comboBox15.Items2")});
            resources.ApplyResources(this.comboBox15, "comboBox15");
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            resources.GetString("comboBox16.Items"),
            resources.GetString("comboBox16.Items1"),
            resources.GetString("comboBox16.Items2")});
            resources.ApplyResources(this.comboBox16, "comboBox16");
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox17
            // 
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            resources.GetString("comboBox17.Items"),
            resources.GetString("comboBox17.Items1"),
            resources.GetString("comboBox17.Items2")});
            resources.ApplyResources(this.comboBox17, "comboBox17");
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox18
            // 
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            resources.GetString("comboBox18.Items"),
            resources.GetString("comboBox18.Items1"),
            resources.GetString("comboBox18.Items2")});
            resources.ApplyResources(this.comboBox18, "comboBox18");
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox19
            // 
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            resources.GetString("comboBox19.Items"),
            resources.GetString("comboBox19.Items1"),
            resources.GetString("comboBox19.Items2")});
            resources.ApplyResources(this.comboBox19, "comboBox19");
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox20
            // 
            this.comboBox20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            resources.GetString("comboBox20.Items"),
            resources.GetString("comboBox20.Items1"),
            resources.GetString("comboBox20.Items2")});
            resources.ApplyResources(this.comboBox20, "comboBox20");
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox22
            // 
            this.comboBox22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            resources.GetString("comboBox22.Items"),
            resources.GetString("comboBox22.Items1"),
            resources.GetString("comboBox22.Items2"),
            resources.GetString("comboBox22.Items3"),
            resources.GetString("comboBox22.Items4")});
            resources.ApplyResources(this.comboBox22, "comboBox22");
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox23
            // 
            this.comboBox23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Items.AddRange(new object[] {
            resources.GetString("comboBox23.Items"),
            resources.GetString("comboBox23.Items1"),
            resources.GetString("comboBox23.Items2"),
            resources.GetString("comboBox23.Items3"),
            resources.GetString("comboBox23.Items4")});
            resources.ApplyResources(this.comboBox23, "comboBox23");
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox24
            // 
            this.comboBox24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            resources.GetString("comboBox24.Items"),
            resources.GetString("comboBox24.Items1"),
            resources.GetString("comboBox24.Items2"),
            resources.GetString("comboBox24.Items3"),
            resources.GetString("comboBox24.Items4")});
            resources.ApplyResources(this.comboBox24, "comboBox24");
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox25
            // 
            this.comboBox25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Items.AddRange(new object[] {
            resources.GetString("comboBox25.Items"),
            resources.GetString("comboBox25.Items1"),
            resources.GetString("comboBox25.Items2"),
            resources.GetString("comboBox25.Items3"),
            resources.GetString("comboBox25.Items4")});
            resources.ApplyResources(this.comboBox25, "comboBox25");
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox26
            // 
            this.comboBox26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Items.AddRange(new object[] {
            resources.GetString("comboBox26.Items"),
            resources.GetString("comboBox26.Items1"),
            resources.GetString("comboBox26.Items2"),
            resources.GetString("comboBox26.Items3"),
            resources.GetString("comboBox26.Items4")});
            resources.ApplyResources(this.comboBox26, "comboBox26");
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // comboBox27
            // 
            this.comboBox27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox27.FormattingEnabled = true;
            this.comboBox27.Items.AddRange(new object[] {
            resources.GetString("comboBox27.Items"),
            resources.GetString("comboBox27.Items1"),
            resources.GetString("comboBox27.Items2"),
            resources.GetString("comboBox27.Items3"),
            resources.GetString("comboBox27.Items4")});
            resources.ApplyResources(this.comboBox27, "comboBox27");
            this.comboBox27.Name = "comboBox27";
            this.comboBox27.SelectedIndexChanged += new System.EventHandler(this.tableCombo_Change);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Name = "numericUpDown2";
            // 
            // numericUpDown3
            // 
            resources.ApplyResources(this.numericUpDown3, "numericUpDown3");
            this.numericUpDown3.Name = "numericUpDown3";
            // 
            // numericUpDown4
            // 
            resources.ApplyResources(this.numericUpDown4, "numericUpDown4");
            this.numericUpDown4.Name = "numericUpDown4";
            // 
            // numericUpDown5
            // 
            resources.ApplyResources(this.numericUpDown5, "numericUpDown5");
            this.numericUpDown5.Name = "numericUpDown5";
            // 
            // numericUpDown6
            // 
            resources.ApplyResources(this.numericUpDown6, "numericUpDown6");
            this.numericUpDown6.Name = "numericUpDown6";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            // 
            // textBox27
            // 
            resources.ApplyResources(this.textBox27, "textBox27");
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            // 
            // textBox28
            // 
            resources.ApplyResources(this.textBox28, "textBox28");
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            // 
            // textBox29
            // 
            resources.ApplyResources(this.textBox29, "textBox29");
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            // 
            // textBox30
            // 
            resources.ApplyResources(this.textBox30, "textBox30");
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // contractCancelButton
            // 
            resources.ApplyResources(this.contractCancelButton, "contractCancelButton");
            this.contractCancelButton.Name = "contractCancelButton";
            this.contractCancelButton.UseVisualStyleBackColor = true;
            this.contractCancelButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // contractAnalyzeButton
            // 
            resources.ApplyResources(this.contractAnalyzeButton, "contractAnalyzeButton");
            this.contractAnalyzeButton.Name = "contractAnalyzeButton";
            this.contractAnalyzeButton.UseVisualStyleBackColor = true;
            this.contractAnalyzeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // analyzeFileNameTextBox
            // 
            resources.ApplyResources(this.analyzeFileNameTextBox, "analyzeFileNameTextBox");
            this.analyzeFileNameTextBox.Name = "analyzeFileNameTextBox";
            this.analyzeFileNameTextBox.ReadOnly = true;
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // statusListBox
            // 
            resources.ApplyResources(this.statusListBox, "statusListBox");
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.Name = "statusListBox";
            // 
            // generateFileDialog
            // 
            resources.ApplyResources(this.generateFileDialog, "generateFileDialog");
            this.generateFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // analyzeFileDialog
            // 
            resources.ApplyResources(this.analyzeFileDialog, "analyzeFileDialog");
            this.analyzeFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.analyzeFileDialog_FileOk);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langSelectSplitButton,
            this.toolStripWebsiteButton,
            this.toolStripExitButton});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // langSelectSplitButton
            // 
            this.langSelectSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.langSelectSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polskiToolStripMenuItem,
            this.englishToolStripMenuItem});
            resources.ApplyResources(this.langSelectSplitButton, "langSelectSplitButton");
            this.langSelectSplitButton.Name = "langSelectSplitButton";
            this.langSelectSplitButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.langSelectSplitButton_DropDownItemClicked);
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.Image = global::Analizator9000.Properties.Resources.pl;
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            resources.ApplyResources(this.polskiToolStripMenuItem, "polskiToolStripMenuItem");
            this.polskiToolStripMenuItem.Tag = "pl";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = global::Analizator9000.Properties.Resources.en;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Tag = "en";
            // 
            // toolStripWebsiteButton
            // 
            this.toolStripWebsiteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripWebsiteButton, "toolStripWebsiteButton");
            this.toolStripWebsiteButton.Name = "toolStripWebsiteButton";
            this.toolStripWebsiteButton.Click += new System.EventHandler(this.toolStripWebsiteButton_Click);
            // 
            // toolStripExitButton
            // 
            this.toolStripExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripExitButton, "toolStripExitButton");
            this.toolStripExitButton.Name = "toolStripExitButton";
            this.toolStripExitButton.Click += new System.EventHandler(this.toolStripExitButton_Click);
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.DefaultExt = "pbn";
            resources.ApplyResources(this.exportFileDialog, "exportFileDialog");
            this.exportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportFileDialog_FileOk);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.analyzeGroup);
            this.Controls.Add(this.generateGroup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generateGroup.ResumeLayout(false);
            this.generateGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.analyzeGroup.ResumeLayout(false);
            this.analyzeGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contractTable.ResumeLayout(false);
            this.contractTable.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.fullContractTable.ResumeLayout(false);
            this.fullContractTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox generateGroup;
        private System.Windows.Forms.GroupBox analyzeGroup;
        private System.Windows.Forms.OpenFileDialog generateFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox predealNorthSpadesBox;
        private System.Windows.Forms.TextBox predealEastSpadesBox;
        private System.Windows.Forms.TextBox predealSouthSpadesBox;
        private System.Windows.Forms.TextBox predealWestSpadesBox;
        private System.Windows.Forms.TextBox predealNorthHeartsBox;
        private System.Windows.Forms.TextBox predealEastHeartsBox;
        private System.Windows.Forms.TextBox predealSouthHeartsBox;
        private System.Windows.Forms.TextBox predealWestHeartsBox;
        private System.Windows.Forms.TextBox predealNorthDiamondsBox;
        private System.Windows.Forms.TextBox predealEastDiamondsBox;
        private System.Windows.Forms.TextBox predealSouthDiamondsBox;
        private System.Windows.Forms.TextBox predealWestDiamondsBox;
        private System.Windows.Forms.TextBox predealNorthClubsBox;
        private System.Windows.Forms.TextBox predealEastClubsBox;
        private System.Windows.Forms.TextBox predealSouthClubsBox;
        private System.Windows.Forms.TextBox predealWestClubsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox generateFileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox produceBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox generateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox statusListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox analyzeFileNameTextBox;
        private System.Windows.Forms.OpenFileDialog analyzeFileDialog;
        private System.Windows.Forms.RichTextBox conditionBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox actionsBox;
        private System.Windows.Forms.TableLayoutPanel contractTable;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel fullContractTable;
        private System.Windows.Forms.Button contractCancelButton;
        private System.Windows.Forms.Button contractAnalyzeButton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.ComboBox comboBox26;
        private System.Windows.Forms.ComboBox comboBox27;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox vulnerabilityBox;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton langSelectSplitButton;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripWebsiteButton;
        private System.Windows.Forms.ToolStripButton toolStripExitButton;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
    }
}