using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Analizator9000
{
    /// <summary>
    /// Main application window control.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Dealer input scripts parser instance.
        /// </summary>
        private DealerParser parser;

        /// <summary>
        /// Constructs the main window.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.parser = new DealerParser();
        }

        /// <summary>
        /// "Select file" button click, opens file selection dialog for input script.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            generateFileDialog.ShowDialog();
        }

        /// <summary>
        /// Input script file selection event. Initiates input script parsing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                foreach (String action in parser.actions)
                {
                    actionsBox.Text += action.Substring("average".Length) + "\n";
                }
                generateFileNameTextBox.Text = generateFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wczytywania pliku: " + ex.Message, "Błąd wczytywania pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// "Generate" button click. Saves the input script file and runs deals generating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            generateGroup.Enabled = false;
            analyzeGroup.Enabled = false;
            statusListBox.Items.Clear();
            progressBar.Value = 0;
            resultTextBox.Text = "";
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
                parser.actions = actionsBox.Text.Split('\n').ToList();
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

        /// <summary>
        /// Delegate for generating end method callback.
        /// </summary>
        /// <param name="filename"></param>
        private delegate void endDelegate(String filename);
        /// <summary>
        /// Generating end callback method. Prints out deal generating summary.
        /// </summary>
        /// <param name="filename">Output (generated deals) file name.</param>
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

        /// <summary>
        /// Delegate for debug line addition method.
        /// </summary>
        /// <param name="line"></param>
        private delegate void AddStatusDelegate(String line);
        /// <summary>
        /// Debug line addition method (thread-safe).
        /// </summary>
        /// <param name="line">String to be appended to the debug output.</param>
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

        /// <summary>
        /// Delegate for progress bar update method.
        /// </summary>
        /// <param name="progress">Percentage of progress to set (0-100)</param>
        private delegate void SetProgressDelegate(int progress);
        /// <summary>
        /// Progress bar update method (thread-safe).
        /// </summary>
        /// <param name="progress">Percentage of progress to set (0-100)</param>
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

        /// <summary>
        /// Deals file selection event. Sets the deals file path in the text field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void analyzeFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            analyzeFileNameTextBox.Text = analyzeFileDialog.FileName;
        }

        /// <summary>
        /// "Select file" button click for deals file selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            analyzeFileDialog.ShowDialog();
        }

        /// <summary>
        /// Instance of analysis summary class.
        /// </summary>
        private Accumulator ac;
        /// <summary>
        /// "Analyze" button click. Runs the analysis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            this.contractCancelButton.Enabled = true;
            this.contractAnalyzeButton.Enabled = false;
            this.analyzeButton.Enabled = false;
            this.abortButton.Enabled = true;
            this.fullContractTable.Enabled = false;
            statusListBox.Items.Clear();
            this.addStatusLine("Otwieram plik: " + analyzeFileNameTextBox.Text);
            try
            {
                String[] deals = File.ReadAllLines(analyzeFileNameTextBox.Text);
                if (deals.Length == 0)
                {
                    throw new Exception("Plik nie zawiera żadnych rozdań");
                }
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
                // we run either "old" Accumulator or contract analysis with ScoreAccumulator,
                // depending on the button of event origin
                this.ac = sender.GetHashCode().Equals(this.analyzeButton.GetHashCode())
                    ? new Accumulator(deals, cons, this)
                    : new ScoreAccumulator(deals, cons, this.contractsToScore, vulnerabilityBox.SelectedIndex, this);
                this.ac.run(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd analizy: " + ex.Message, "Błąd analizy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.setProgress(0);
                abortButton.Enabled = false;
                analyzeGroup.Enabled = true;
                generateGroup.Enabled = true;
                contractAnalyzeButton.Enabled = true;
                contractCancelButton.Enabled = false;
                fullContractTable.Enabled = true;
            }
        }

        /// <summary>
        /// Delegate for analysis end callback method.
        /// </summary>
        private delegate void EndAnalysisDelegate();
        /// <summary>
        /// Analysis end callback method. Cleans up visually after the analysis.
        /// </summary>
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
                contractAnalyzeButton.Enabled = true;
                contractCancelButton.Enabled = false;
                fullContractTable.Enabled = true;
                statusListBox.Focus();
                this.ac = null;
            }
        }

        /// <summary>
        /// Delegate for result summary display method.
        /// </summary>
        /// <param name="res">Result summary string.</param>
        private delegate void SetResultDelegate(String res);
        /// <summary>
        /// Displays analysis results summary.
        /// </summary>
        /// <param name="res">Result summary string.</param>
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

        /// <summary>
        /// Delegate for contract analysis output
        /// </summary>
        /// <param name="trickSum">Dictionary of trick sums for analyzed contracts</param>
        /// <param name="scoreSum">Dictionary of score sums for analyzed contracts</param>
        /// <param name="maxSum">Dictionary of matchpoint sums for analyzed contracts</param>
        /// <param name="impSum">Dictionary of IMP sums for analyzed contracts</param>
        /// <param name="dealCount">Number of deals already scored</param>
        private delegate void UpdateContractTableDelegate(Dictionary<Contract, long> trickSum, Dictionary<Contract, long> scoreSum, Dictionary<Contract, double> maxSum, Dictionary<Contract, double> impSum, long dealCount);
        /// <summary>
        /// Updates GUI output for contract analysis
        /// </summary>
        /// <param name="trickSum">Dictionary of trick sums for analyzed contracts</param>
        /// <param name="scoreSum">Dictionary of score sums for analyzed contracts</param>
        /// <param name="maxSum">Dictionary of matchpoint sums for analyzed contracts</param>
        /// <param name="impSum">Dictionary of IMP sums for analyzed contracts</param>
        /// <param name="dealCount">Number of deals already scored</param>
        public void updateContractTable(Dictionary<Contract, long> trickSum, Dictionary<Contract, long> scoreSum, Dictionary<Contract, double> maxSum, Dictionary<Contract, double> impSum, long dealCount)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateContractTableDelegate(updateContractTable), new object[] { trickSum, scoreSum, maxSum, impSum, dealCount });
            }
            else
            {
                foreach (int row in Enumerable.Range(1, fullContractTable.RowCount - 1))
                {
                    Contract rowContract = this.getContractFromTableRow(row);
                    if (rowContract != null && rowContract.Frequency > 0)
                    {
                        ((TextBox)fullContractTable.GetControlFromPosition(5, row)).Text = ((double)trickSum[rowContract] / dealCount).ToString("0.##");
                        ((TextBox)fullContractTable.GetControlFromPosition(6, row)).Text = ((double)scoreSum[rowContract] / dealCount).ToString("0.##");
                        ((TextBox)fullContractTable.GetControlFromPosition(7, row)).Text = (maxSum[rowContract] / dealCount).ToString("0.##");
                        ((TextBox)fullContractTable.GetControlFromPosition(8, row)).Text = (impSum[rowContract] / dealCount).ToString("0.##");
                    }
                }
            }
        }

        /// <summary>
        /// "Abort" button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abortButton_Click(object sender, EventArgs e)
        {
            if (this.ac != null)
            {
                this.ac.abortAnalysis();
            }
        }

        /// <summary>
        /// Mass checkboxes within contract table layout toggle method.
        /// </summary>
        /// <param name="xRange">Set of x-coordinates for checkboxes to toggle.</param>
        /// <param name="yRange">Set of y-coordinates for checkboxes to toggle.</param>
        /// <param name="toggle">Indicates whether box range should be toggled (true) or just checked (false)</param>
        private void toggleBoxes(IEnumerable<int> xRange, IEnumerable<int> yRange, bool toggle = true)
        {
            foreach (int x in xRange)
            {
                foreach (int y in yRange)
                {
                    CheckBox cb = ((CheckBox)contractTable.GetControlFromPosition(x, y));
                    cb.Checked = !(toggle && cb.Checked);
                }
            }
        }

        /// <summary>
        /// Toggles all contract chackboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(1, 4));
        }

        /// <summary>
        /// Toggles the first column of checkboxes ("NT").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label18_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 1), Enumerable.Range(1, 4), false);
        }

        /// <summary>
        /// Toggles the second column of checkboxes (spades).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label14_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(2, 1), Enumerable.Range(1, 4), false);
        }

        /// <summary>
        /// Toggles the third column of checkboxes (hearts).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label15_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(3, 1), Enumerable.Range(1, 4), false);
        }

        /// <summary>
        /// Toggles the fourth column of checkboxes (diamonds).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label16_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(4, 1), Enumerable.Range(1, 4), false);
        }

        /// <summary>
        /// Toggles the fifth column of checkboxes (clubs).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label17_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(5, 1), Enumerable.Range(1, 4), false);
        }

        /// <summary>
        /// Toggles the first row of checkboxes (North).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label19_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(1, 1), false);
        }

        /// <summary>
        /// Toggles the second row of checkboxes (East).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label20_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(2, 1), false);
        }

        /// <summary>
        /// Toggles the third row of checkboxes (South).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label21_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(3, 1), false);
        }

        /// <summary>
        /// Toggles the fourth row of checkboxes (West).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label22_Click(object sender, EventArgs e)
        {
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(4, 1), false);
        }

        /// <summary>
        /// List of contracts to score by ScoreAccumulator
        /// </summary>
        private List<Contract> contractsToScore = new List<Contract>();
        /// <summary>
        /// Starts contract analysis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.contractsToScore.Clear();
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(1, 4), false);
            this.toggleBoxes(Enumerable.Range(1, 5), Enumerable.Range(1, 4));
            foreach (int row in Enumerable.Range(1, fullContractTable.RowCount - 1)) {
                Contract rowContract = this.getContractFromTableRow(row);
                if (rowContract != null)
                {
                    if (rowContract.Level > 0)
                    {
                        this.toggleBoxes(Enumerable.Range(5 - rowContract.Denomination, 1), Enumerable.Range(rowContract.Declarer + 1, 1), false); // forcing analysis of certain denomination-declarer combinations
                    }
                    if (rowContract.Frequency > 0)
                    {
                        this.contractsToScore.Add(rowContract);
                    }
                }
                foreach (int column in Enumerable.Range(5, 4)) {
                    ((TextBox)this.fullContractTable.GetControlFromPosition(column, row)).Text = "";
                }
            }
            this.analyzeButton_Click(sender, e);
        }

        /// <summary>
        /// Enables contract table fields accordingly to selected combo boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableCombo_Change(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition position = fullContractTable.GetPositionFromControl((Control)sender);
            NumericUpDown frequencyBox = (NumericUpDown)fullContractTable.GetControlFromPosition(4, position.Row);
            Contract rowContract = this.getContractFromTableRow(position.Row);
            if (rowContract != null)
            {
                frequencyBox.Enabled = true;
                if (frequencyBox.Value < 1)
                {
                    frequencyBox.Value = 1;
                }
                if (rowContract.Level == 0)
                {
                    ((ComboBox)fullContractTable.GetControlFromPosition(1, position.Row)).SelectedIndex = 0;
                    ((ComboBox)fullContractTable.GetControlFromPosition(2, position.Row)).SelectedIndex = 0;
                    ((ComboBox)fullContractTable.GetControlFromPosition(3, position.Row)).SelectedIndex = 0;
                }
            }
            else
            {
                frequencyBox.Enabled = false;
                frequencyBox.Value = 0;
            }
        }

        /// <summary>
        /// Retrieves contract based on a row of GUI table
        /// </summary>
        /// <param name="rowIndex">Index of the row for the contract</param>
        /// <returns>Contract object representing user's choice or NULL when the choice is invalid/incomplete</returns>
        private Contract getContractFromTableRow(int rowIndex)
        {
            ComboBox levelBox = (ComboBox)fullContractTable.GetControlFromPosition(0, rowIndex);
            ComboBox denominationBox = (ComboBox)fullContractTable.GetControlFromPosition(1, rowIndex);
            ComboBox modifiersBox = (ComboBox)fullContractTable.GetControlFromPosition(2, rowIndex);
            ComboBox declarerBox = (ComboBox)fullContractTable.GetControlFromPosition(3, rowIndex);
            NumericUpDown frequencyBox = (NumericUpDown)fullContractTable.GetControlFromPosition(4, rowIndex);
            if (levelBox.SelectedIndex < 1 || (denominationBox.SelectedIndex < 1 && levelBox.SelectedIndex != 1) || (declarerBox.SelectedIndex < 1 && levelBox.SelectedIndex != 1))
            {
                return null;
            }
            return new Contract(levelBox.SelectedIndex - 1, denominationBox.SelectedIndex - 1, (declarerBox.SelectedIndex + 2) % 4, Math.Max(0, modifiersBox.SelectedIndex), (int)frequencyBox.Value, rowIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vulnerabilityBox.SelectedIndex = 0; // set default vulnerability for contracts analysis
        }

        /// <summary>
        /// Cancels contract analysis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.contractCancelButton.Enabled = false;
            this.contractAnalyzeButton.Enabled = true;
            this.abortButton_Click(sender, e);
        }
    }
}
