﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Analizator9000
{
    /// <summary>
    /// Parsers dealer script files into fileds used by the application and compiles deler script files from them.
    /// </summary>
    class DealerParser
    {
        /// <summary>
        /// Contents of 'condition' section of dealer input script.
        /// </summary>
        public String condition = "";
        /// <summary>
        /// Limit of deals to generate, 'generate' section of input script.
        /// </summary>
        public long generate = -1;
        /// <summary>
        /// Limit of deals to produce, 'produce' section of input script.
        /// </summary>
        public long produce = -1;
        /// <summary>
        /// Pre-dealt cards, indexed by player. Compiles into 'predeal' section of onput script.
        /// </summary>
        public Dictionary<String, String[]> predeal = new Dictionary<String, String[]>();

        /// <summary>
        /// Loads the input script file and parses it. Parses out everything outside of predeal/condition/produce/generate/action sections.
        /// </summary>
        /// <param name="file">Filename of the script.</param>
        public void loadFile(String file)
        {
            String[] contents = File.ReadAllLines(file);
            Dictionary<String, int> keyLines = new Dictionary<String, int>();
            String[] keywords = {"predeal", "condition", "generate", "produce", "action"};
            for (int i = 0; i < contents.Length; i++)
            {
                String line = contents[i];
                int lineNo = Array.IndexOf(keywords, line.Trim());
                if (lineNo >= 0)
                {
                    keyLines.Add(keywords[lineNo], i);
                }
            }
            keyLines = keyLines.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            for (int i = 0; i < keyLines.Count; i++)
            {
                KeyValuePair<String, int> keyline = keyLines.ElementAt(i);
                String[] section = new String[contents.Length - keyline.Value];
                if (i + 1 < keyLines.Count)
                {
                    Array.Copy(contents, keyline.Value, section, 0, keyLines.ElementAt(i + 1).Value - keyline.Value);
                }
                else
                {
                    Array.Copy(contents, keyline.Value, section, 0, contents.Length - keyline.Value);
                }
                section[0] = Regex.Replace(section[0], "^"+keyline.Key, "").Trim();
                section = section.Where(str => str != null && str.Trim().Length > 0).ToArray();
                switch (keyline.Key)
                {
                    case "predeal":
                        String[] players = { "north", "east", "south", "west" };
                        char[] suits = { 'S', 'H', 'D', 'C' };
                        foreach (String l in section)
                        {
                            String line = l.Trim();
                            int player = Array.IndexOf(players, line.Substring(0, line.IndexOf(' ')));
                            if (player >= 0) {
                                String[] chunks = Regex.Replace(line, "^" + players[player], "").Split(',');
                                String[] hand = new String[4];
                                foreach (String chunk in chunks)
                                {
                                    int suit = Array.IndexOf(suits, chunk.Trim().ToUpper()[0]);
                                    if (suit >= 0)
                                    {
                                        hand[suit] = chunk.Trim().Substring(1);
                                    }
                                }
                                this.predeal.Add(players[player], hand);
                            }
                        }
                        break;
                    case "condition":
                        this.condition = section.Aggregate((a, b) => a + "\n" + b);
                        break;
                    case "generate":
                        if (section.Length > 1)
                        {
                            throw new Exception("Zbyt duża liczba wartości 'generate' w skrypcie");
                        }
                        if (section.Length == 1)
                        {
                            try
                            {
                                this.generate = Convert.ToInt64(section[0]);
                            }
                            catch (OverflowException)
                            {
                                throw new Exception("Za duża wartość 'generate'");
                            }
                        }
                        break;
                    case "produce":
                        if (section.Length > 1)
                        {
                            throw new Exception("Zbyt duża liczba linii 'produce' w skrypcie");
                        }
                        if (section.Length == 1)
                        {
                            try
                            {
                                this.produce = Convert.ToInt64(section[0]);
                            }
                            catch (OverflowException)
                            {
                                throw new Exception("Za duża wartość 'produce'");
                            }
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Compiles dealer input script from provided data. Assumes no overhead section and single action: printoneline.
        /// </summary>
        /// <returns>Input script contents.</returns>
        public String saveFile()
        {
            String filename = Utils.getFilename("dealer");
            StreamWriter file = new StreamWriter(@"files\" + filename);
            String predealStr = "";
            String suitLetters = "SHDC";
            foreach (KeyValuePair<String, String[]> pre in this.predeal)
            {
                List<String> hand = new List<String>();
                for (int i = 0; i < pre.Value.Length; i++)
                {
                    if (pre.Value[i].Trim().Length > 0)
                    {
                        hand.Add(suitLetters[i] + pre.Value[i].Trim());
                    }
                }
                if (hand.Count > 0)
                {
                    predealStr += pre.Key + " " + hand.Aggregate((a, b) => a + ", " + b) + "\n";
                }
            }
            if (predealStr.Length > 0)
            {
                file.WriteLine("predeal");
                file.Write(predealStr);
            }
            if (this.condition.Trim().Length > 0)
            {
                file.WriteLine("condition");
                file.WriteLine(this.condition);
            }
            file.WriteLine("generate");
            file.WriteLine(this.generate);
            file.WriteLine("produce");
            file.WriteLine(this.produce);
            file.WriteLine("action");
            file.WriteLine("printoneline");
            file.Close();
            return filename;
        }
    }
}
