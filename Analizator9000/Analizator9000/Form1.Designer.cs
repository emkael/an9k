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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateGroup = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.contractList = new System.Windows.Forms.ComboBox();
            this.declarerList = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.analyzeFileNameTexBox = new System.Windows.Forms.TextBox();
            this.generateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.analyzeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.generateGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateGroup
            // 
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
            this.generateGroup.Location = new System.Drawing.Point(12, 12);
            this.generateGroup.Name = "generateGroup";
            this.generateGroup.Size = new System.Drawing.Size(513, 444);
            this.generateGroup.TabIndex = 0;
            this.generateGroup.TabStop = false;
            this.generateGroup.Text = "Generowanie";
            // 
            // conditionBox
            // 
            this.conditionBox.AcceptsTab = true;
            this.conditionBox.Location = new System.Drawing.Point(10, 202);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(494, 137);
            this.conditionBox.TabIndex = 11;
            this.conditionBox.Text = "";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(10, 398);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(497, 40);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "GENERUJ";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // produceBox
            // 
            this.produceBox.Location = new System.Drawing.Point(280, 372);
            this.produceBox.Name = "produceBox";
            this.produceBox.Size = new System.Drawing.Size(224, 20);
            this.produceBox.TabIndex = 9;
            this.produceBox.Text = "100000";
            this.produceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Limit rozdań spełniających warunki:";
            // 
            // generateBox
            // 
            this.generateBox.Location = new System.Drawing.Point(280, 345);
            this.generateBox.Name = "generateBox";
            this.generateBox.Size = new System.Drawing.Size(224, 20);
            this.generateBox.TabIndex = 7;
            this.generateBox.Text = "10000000";
            this.generateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Limit rozdań generowanych:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Warunki:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 116);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // predealNorthSpadesBox
            // 
            this.predealNorthSpadesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealNorthSpadesBox.Location = new System.Drawing.Point(42, 26);
            this.predealNorthSpadesBox.Name = "predealNorthSpadesBox";
            this.predealNorthSpadesBox.Size = new System.Drawing.Size(108, 20);
            this.predealNorthSpadesBox.TabIndex = 0;
            // 
            // predealEastSpadesBox
            // 
            this.predealEastSpadesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealEastSpadesBox.Location = new System.Drawing.Point(42, 49);
            this.predealEastSpadesBox.Name = "predealEastSpadesBox";
            this.predealEastSpadesBox.Size = new System.Drawing.Size(108, 20);
            this.predealEastSpadesBox.TabIndex = 1;
            // 
            // predealSouthSpadesBox
            // 
            this.predealSouthSpadesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealSouthSpadesBox.Location = new System.Drawing.Point(42, 72);
            this.predealSouthSpadesBox.Name = "predealSouthSpadesBox";
            this.predealSouthSpadesBox.Size = new System.Drawing.Size(108, 20);
            this.predealSouthSpadesBox.TabIndex = 2;
            // 
            // predealWestSpadesBox
            // 
            this.predealWestSpadesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealWestSpadesBox.Location = new System.Drawing.Point(42, 95);
            this.predealWestSpadesBox.Name = "predealWestSpadesBox";
            this.predealWestSpadesBox.Size = new System.Drawing.Size(108, 20);
            this.predealWestSpadesBox.TabIndex = 3;
            // 
            // predealNorthHeartsBox
            // 
            this.predealNorthHeartsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealNorthHeartsBox.Location = new System.Drawing.Point(156, 26);
            this.predealNorthHeartsBox.Name = "predealNorthHeartsBox";
            this.predealNorthHeartsBox.Size = new System.Drawing.Size(108, 20);
            this.predealNorthHeartsBox.TabIndex = 4;
            // 
            // predealEastHeartsBox
            // 
            this.predealEastHeartsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealEastHeartsBox.Location = new System.Drawing.Point(156, 49);
            this.predealEastHeartsBox.Name = "predealEastHeartsBox";
            this.predealEastHeartsBox.Size = new System.Drawing.Size(108, 20);
            this.predealEastHeartsBox.TabIndex = 5;
            // 
            // predealSouthHeartsBox
            // 
            this.predealSouthHeartsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealSouthHeartsBox.Location = new System.Drawing.Point(156, 72);
            this.predealSouthHeartsBox.Name = "predealSouthHeartsBox";
            this.predealSouthHeartsBox.Size = new System.Drawing.Size(108, 20);
            this.predealSouthHeartsBox.TabIndex = 6;
            // 
            // predealWestHeartsBox
            // 
            this.predealWestHeartsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealWestHeartsBox.Location = new System.Drawing.Point(156, 95);
            this.predealWestHeartsBox.Name = "predealWestHeartsBox";
            this.predealWestHeartsBox.Size = new System.Drawing.Size(108, 20);
            this.predealWestHeartsBox.TabIndex = 7;
            // 
            // predealNorthDiamondsBox
            // 
            this.predealNorthDiamondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealNorthDiamondsBox.Location = new System.Drawing.Point(270, 26);
            this.predealNorthDiamondsBox.Name = "predealNorthDiamondsBox";
            this.predealNorthDiamondsBox.Size = new System.Drawing.Size(108, 20);
            this.predealNorthDiamondsBox.TabIndex = 8;
            // 
            // predealEastDiamondsBox
            // 
            this.predealEastDiamondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealEastDiamondsBox.Location = new System.Drawing.Point(270, 49);
            this.predealEastDiamondsBox.Name = "predealEastDiamondsBox";
            this.predealEastDiamondsBox.Size = new System.Drawing.Size(108, 20);
            this.predealEastDiamondsBox.TabIndex = 9;
            // 
            // predealSouthDiamondsBox
            // 
            this.predealSouthDiamondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealSouthDiamondsBox.Location = new System.Drawing.Point(270, 72);
            this.predealSouthDiamondsBox.Name = "predealSouthDiamondsBox";
            this.predealSouthDiamondsBox.Size = new System.Drawing.Size(108, 20);
            this.predealSouthDiamondsBox.TabIndex = 10;
            // 
            // predealWestDiamondsBox
            // 
            this.predealWestDiamondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealWestDiamondsBox.Location = new System.Drawing.Point(270, 95);
            this.predealWestDiamondsBox.Name = "predealWestDiamondsBox";
            this.predealWestDiamondsBox.Size = new System.Drawing.Size(108, 20);
            this.predealWestDiamondsBox.TabIndex = 11;
            // 
            // predealNorthClubsBox
            // 
            this.predealNorthClubsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealNorthClubsBox.Location = new System.Drawing.Point(384, 26);
            this.predealNorthClubsBox.Name = "predealNorthClubsBox";
            this.predealNorthClubsBox.Size = new System.Drawing.Size(110, 20);
            this.predealNorthClubsBox.TabIndex = 12;
            // 
            // predealEastClubsBox
            // 
            this.predealEastClubsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealEastClubsBox.Location = new System.Drawing.Point(384, 49);
            this.predealEastClubsBox.Name = "predealEastClubsBox";
            this.predealEastClubsBox.Size = new System.Drawing.Size(110, 20);
            this.predealEastClubsBox.TabIndex = 13;
            // 
            // predealSouthClubsBox
            // 
            this.predealSouthClubsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealSouthClubsBox.Location = new System.Drawing.Point(384, 72);
            this.predealSouthClubsBox.Name = "predealSouthClubsBox";
            this.predealSouthClubsBox.Size = new System.Drawing.Size(110, 20);
            this.predealSouthClubsBox.TabIndex = 14;
            // 
            // predealWestClubsBox
            // 
            this.predealWestClubsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.predealWestClubsBox.Location = new System.Drawing.Point(384, 95);
            this.predealWestClubsBox.Name = "predealWestClubsBox";
            this.predealWestClubsBox.Size = new System.Drawing.Size(110, 20);
            this.predealWestClubsBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "N:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "E:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "S:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "W:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(42, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "♠";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(156, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "♥";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(270, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "♦";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(384, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "♣";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Karty rozdane:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wybierz plik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateFileNameTextBox
            // 
            this.generateFileNameTextBox.Location = new System.Drawing.Point(7, 20);
            this.generateFileNameTextBox.Name = "generateFileNameTextBox";
            this.generateFileNameTextBox.ReadOnly = true;
            this.generateFileNameTextBox.Size = new System.Drawing.Size(419, 20);
            this.generateFileNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.contractList);
            this.groupBox2.Controls.Add(this.declarerList);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.analyzeFileNameTexBox);
            this.groupBox2.Location = new System.Drawing.Point(531, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analiza";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(497, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "ANALIZUJ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // contractList
            // 
            this.contractList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractList.FormattingEnabled = true;
            this.contractList.Items.AddRange(new object[] {
            "Wszystkie",
            "Bez atu",
            "Piki",
            "Kiery",
            "Kara",
            "Trefle"});
            this.contractList.Location = new System.Drawing.Point(89, 101);
            this.contractList.Name = "contractList";
            this.contractList.Size = new System.Drawing.Size(121, 21);
            this.contractList.TabIndex = 6;
            // 
            // declarerList
            // 
            this.declarerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.declarerList.FormattingEnabled = true;
            this.declarerList.Items.AddRange(new object[] {
            "Wszyscy",
            "N",
            "E",
            "S",
            "W"});
            this.declarerList.Location = new System.Drawing.Point(89, 73);
            this.declarerList.Name = "declarerList";
            this.declarerList.Size = new System.Drawing.Size(121, 21);
            this.declarerList.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Miano:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Rozgrywający:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kontrakt:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Wybierz plik";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // analyzeFileNameTexBox
            // 
            this.analyzeFileNameTexBox.Location = new System.Drawing.Point(7, 20);
            this.analyzeFileNameTexBox.Name = "analyzeFileNameTexBox";
            this.analyzeFileNameTexBox.ReadOnly = true;
            this.analyzeFileNameTexBox.Size = new System.Drawing.Size(419, 20);
            this.analyzeFileNameTexBox.TabIndex = 0;
            // 
            // generateFileDialog
            // 
            this.generateFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(531, 312);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(513, 23);
            this.progressBar.TabIndex = 2;
            // 
            // statusListBox
            // 
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.Location = new System.Drawing.Point(531, 343);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(513, 108);
            this.statusListBox.TabIndex = 3;
            // 
            // analyzeFileDialog
            // 
            this.analyzeFileDialog.FileName = "openFileDialog2";
            this.analyzeFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.analyzeFileDialog_FileOk);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(531, 197);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(513, 109);
            this.textBox22.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 463);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.statusListBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generateGroup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Analizator9000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generateGroup.ResumeLayout(false);
            this.generateGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox generateGroup;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.ComboBox contractList;
        private System.Windows.Forms.ComboBox declarerList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox analyzeFileNameTexBox;
        private System.Windows.Forms.OpenFileDialog analyzeFileDialog;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.RichTextBox conditionBox;
    }
}

