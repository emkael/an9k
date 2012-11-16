﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Analizator9000
{
    public partial class Form1 : Form
    {
        private DealerParser parser;

        public Form1()
        {
            InitializeComponent();
            this.parser = new DealerParser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateFileDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                this.parser = new DealerParser();
                parser.loadFile(generateFileDialog.FileName);
                if (parser.produce > 0) produceBox.Text = parser.produce.ToString();
                if (parser.generate > 0) generateBox.Text = parser.generate.ToString();
                conditionBox.Text = parser.condition;
                if (parser.predeal.ContainsKey("east"))
                {
                    predealEastSpadesBox.Text = parser.predeal["east"][0];
                    predealEastHeartsBox.Text = parser.predeal["east"][1];
                    predealEastDiamondsBox.Text = parser.predeal["east"][2];
                    predealEastClubsBox.Text = parser.predeal["east"][3];
                }
                if (parser.predeal.ContainsKey("west"))
                {
                    predealWestSpadesBox.Text = parser.predeal["west"][0];
                    predealWestHeartsBox.Text = parser.predeal["west"][1];
                    predealWestDiamondsBox.Text = parser.predeal["west"][2];
                    predealWestClubsBox.Text = parser.predeal["west"][3];
                }
                if (parser.predeal.ContainsKey("north"))
                {
                    predealNorthSpadesBox.Text = parser.predeal["north"][0];
                    predealNorthHeartsBox.Text = parser.predeal["north"][1];
                    predealNorthDiamondsBox.Text = parser.predeal["north"][2];
                    predealNorthClubsBox.Text = parser.predeal["north"][3];
                }
                if (parser.predeal.ContainsKey("south"))
                {
                    predealSouthSpadesBox.Text = parser.predeal["south"][0];
                    predealSouthHeartsBox.Text = parser.predeal["south"][1];
                    predealSouthDiamondsBox.Text = parser.predeal["south"][2];
                    predealSouthClubsBox.Text = parser.predeal["south"][3];
                }
                generateFileNameTextBox.Text = generateFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wczytywania pliku: " + ex.Message, "Błąd wczytywania pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            generateGroup.Enabled = false;
            analyzeGroup.Enabled = false;
            progressBar.Value = 0;
            try
            {
                this.parser.generate = Convert.ToInt64(generateBox.Text);
                this.parser.produce = Convert.ToInt64(produceBox.Text);
                parser.condition = conditionBox.Text;
                parser.predeal["north"] = new String[] { predealNorthSpadesBox.Text, predealNorthHeartsBox.Text, predealNorthDiamondsBox.Text, predealNorthClubsBox.Text };
                parser.predeal["south"] = new String[] { predealSouthSpadesBox.Text, predealSouthHeartsBox.Text, predealSouthDiamondsBox.Text, predealSouthClubsBox.Text };
                parser.predeal["west"] = new String[] { predealWestSpadesBox.Text, predealWestHeartsBox.Text, predealWestDiamondsBox.Text, predealWestClubsBox.Text };
                parser.predeal["east"] = new String[] { predealEastSpadesBox.Text, predealEastHeartsBox.Text, predealEastDiamondsBox.Text, predealEastClubsBox.Text };
                foreach (KeyValuePair<String, String[]> predeal in parser.predeal)
                {
                    for (int i = 0; i < predeal.Value.Length; i++)
                    {
                        predeal.Value[i] = predeal.Value[i].ToUpper().Replace('D', 'Q').Replace('W', 'J').Replace("10", "T");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wprowadzania danych: " + ex.Message, "Błąd wprowadzania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateGroup.Enabled = true;
                analyzeGroup.Enabled = true;
            }
            try
            {
                String outputFileName = parser.saveFile();
                DealerWrapper dealer = new DealerWrapper("files/" + outputFileName, this, this.parser.produce);
                dealer.run(this.generateEnd);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nie można utworzyć pliku. Sprawdź, czy w katalogu programu istnieje katalog 'files'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateGroup.Enabled = true;
                analyzeGroup.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd generatora: " + ex.Message, "Błąd generatora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateGroup.Enabled = true;
                analyzeGroup.Enabled = true;
            }
        }

        private delegate void endDelegate(String filename);
        private void generateEnd(String filename)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new endDelegate(generateEnd), new object[] { filename });
            }
            else
            {
                progressBar.Value = 100;
                if (filename != null)
                {
                    this.addStatusLine("Zapisano do pliku: " + filename);
                }
                analyzeFileNameTextBox.Text = Path.GetFullPath(@"files\" + filename);
                generateGroup.Enabled = true;
                analyzeGroup.Enabled = true;
            }
        }

        private delegate void AddStatusDelegate(String line);
        public void addStatusLine(String line)
        {
            if (line != null)
            {
                if (statusListBox.InvokeRequired)
                {
                    this.Invoke(new AddStatusDelegate(addStatusLine), new object[] { line });
                }
                else
                {
                    statusListBox.Items.Add(line);
                    statusListBox.SelectedIndex = statusListBox.Items.Count - 1;
                }
            }
        }

        private delegate void SetProgressDelegate(int progress);
        public void setProgress(int progress)
        {
            if (progressBar.InvokeRequired)
            {
                this.Invoke(new SetProgressDelegate(setProgress), new object[]{ progress });
            }
            else
            {
                progressBar.Value = progress;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void analyzeFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            analyzeFileNameTextBox.Text = analyzeFileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            analyzeFileDialog.ShowDialog();
        }

        private Accumulator ac;
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            analyzeGroup.Enabled = false;
            generateGroup.Enabled = false;
            abortButton.Enabled = true;
            this.addStatusLine("Otwieram plik: " + analyzeFileNameTextBox.Text);
            try
            {
                String[] deals = File.ReadAllLines(analyzeFileNameTextBox.Text);
                List<Contract> cons = new List<Contract>();
                foreach (int i in Enumerable.Range(1, 5))
                {
                    foreach (int j in Enumerable.Range(1, 4))
                    {
                        if (((CheckBox)contractTable.GetControlFromPosition(i, j)).Checked)
                        {
                            cons.Add(new Contract(5 - i, j - 1));
                        }
                    }
                }
                if (cons.Count == 0)
                {
                    throw new Exception("Nie podano kontraktów");
                }
                this.ac = new Accumulator(deals, cons, this);
                this.ac.run(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd analizy: " + ex.Message, "Błąd analizy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.setProgress(0);
                abortButton.Enabled = false;
                analyzeGroup.Enabled = true;
                generateGroup.Enabled = true;
            }
        }

        private delegate void EndAnalysisDelegate();
        public void endAnalysis()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EndAnalysisDelegate(endAnalysis));
            }
            else
            {
                this.setProgress(100);
                abortButton.Enabled = false;
                analyzeGroup.Enabled = true;
                generateGroup.Enabled = true;
                this.ac = null;
            }
        }

        private delegate void SetResultDelegate(String res);
        public void setResult(String res)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetResultDelegate(setResult), new object[] { res });
            }
            else
            {
                resultTextBox.Text = res;
            }
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            if (this.ac != null)
            {
                this.ac.abortAnalysis();
            }
        }

        private void toggleBoxes(IEnumerable<int> xRange, IEnumerable<int> yRange)
        {
            foreach (int x in xRange)
            {
                foreach (int y in yRange)
                {
                    CheckBox cb = ((CheckBox)contractTable.GetControlFromPosition(x, y));
                    cb.Checked = !cb.Checked;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(1, 4));
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 1), Enumerable.Range(1, 4));
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(2, 1), Enumerable.Range(1, 4));
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(3, 1), Enumerable.Range(1, 4));
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(4, 1), Enumerable.Range(1, 4));
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(5, 1), Enumerable.Range(1, 4));
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(1, 1));
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(2, 1));
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(3, 1));
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(4, 1));
        }
    }
}