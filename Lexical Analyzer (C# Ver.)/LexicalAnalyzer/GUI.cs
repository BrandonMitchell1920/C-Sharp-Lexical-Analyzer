/*
 * Name:    Brandon Mitchell
 * Description: The GUI code.  Most actual set-up code is in the designer 
 *              file, so this looks a bit cleaner.  I straight modified that
 *              designer file manually, though, so you can't open it in design
 *              view.  I did that because I wanted to use my own functions 
 *              with the same names, not its auto-generated names.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    /// <summary>
    /// My part of the GUI, this partial stuff is kind of nice, it would have
    /// kept my GUI.py file from being so long and confusing
    /// </summary>
    public partial class Root : Form
    {
        // Default directories and files
        public static readonly string
            DEF_TABLE_DIR  = "./tables/",
            DEF_SOURCE_DIR = "./testFiles/",
            DEF_HELP_DIR   = "./help/",

            DEF_SCAN   = DEF_TABLE_DIR  + "DefaultScanTable.csv",
            DEF_TOKEN  = DEF_TABLE_DIR  + "DefaultTokenTable.csv",
            DEF_KEY    = DEF_TABLE_DIR  + "DefaultKeywordTable.csv",
            DEF_SOURCE = DEF_SOURCE_DIR + "DefaultTestFile.c",

            DEF_ABOUT     = DEF_HELP_DIR + "README.txt",
            DEF_COPYRIGHT = DEF_HELP_DIR + "copyright.txt";

        // An instance of the Lex class
        private readonly Lex lex;

        /// <summary>
        /// Shows an info window informing user that EOF was hit
        /// </summary>
        private void infoUserEofHit()
        {
            MessageBox.Show("End-of-file reached!  No more tokens to read!", 
                "EOF Reached!", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Opens a dialog and asks the user if they want to continue with
        /// opening a new file
        /// </summary>
        /// <returns>bool, a true or false value to indicate if file dialog should be opened</returns>
        private bool warnUserFileOpen()
        {
            bool openNew = true;
            if (!lex.eof()) 
            {
                DialogResult result = MessageBox.Show("Opening a new file " +
                    "will restart scanning from the beginning.  Do you " +
                    "wish to continue?", "Restart Scanning?", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    openNew = (result == DialogResult.OK); 
            }

            return openNew;
        }

        /// <summary>
        /// Lets the user know that the file could not be opened
        /// </summary>
        /// <param name="fileName">string, the name of the file</param>
        /// <param name="message">string, what the error was</param>
        private void errorUserFileError(string fileName, string message)
        {
            // Probably not good from a security standpoint to show the user
            // detailed error messages, but this isn't a critical application.
            MessageBox.Show($"\"{fileName}\" could not be opened.\n\n" +
                $"{message}", "Error Opening File!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows the user the README file to let them know how to use the 
        /// program
        /// </summary>
        private void about()
        {
            try
            {
                string text = File.ReadAllText(DEF_ABOUT);
                MessageBox.Show(text, "How to Use", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't load help file!", "README.txt " +
                    "Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Shows the user my copyright so they don't get any sneaky ideas
        /// </summary>
        private void copyright()
        {
            try
            {
                string text = File.ReadAllText(DEF_COPYRIGHT);
                MessageBox.Show(text, "Don't Steal!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't load copyright file!  Don't think " +
                    "that means you can steal!", "copyright.txt Missing!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates a save file dialog so the user can save the ouput to a 
        /// file of their choosing
        /// </summary>
        private void saveOutputText()
        {
            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                Filter = "All Files|*.*",
                CheckFileExists = false,
                CheckPathExists = false,
                Title = "Save Output"
            };

            // If they didn't hit cancel or the X
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, outputText.Text);
                }
                catch (Exception err)
                {
                    // Tad hard to test this, I will just assume it works fine
                    MessageBox.Show($"\"{saveDialog.FileName}\" could not " +
                        $"be saved.\n\n{err.Message}", "Error Saving " +
                        "File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Creates a filedialog and warns user if needed
        /// </summary>
        private void openScanTable()
        {
            if (warnUserFileOpen())
            { 
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    InitialDirectory = DEF_TABLE_DIR,
                    Filter = "CSV Files|*.csv|All Files|*.*",
                    Title = "Choose a Scan Table"
                };

                // Only read file if the user selected one
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    try
                    {
                        lex.readScanTable(fileName);
                        scanTableText.Text = Path.GetFileName(fileName);
                    }
                    catch (Exception err)
                    {
                        errorUserFileError(fileName, err.Message);
                    }
                }

            }
        }

        /// <summary>
        /// Creates a filedialog and warns user if needed
        /// </summary>
        private void openTokenTable()
        {
            if (warnUserFileOpen())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    InitialDirectory = DEF_TABLE_DIR,
                    Filter = "CSV Files|*.csv|All Files|*.*",
                    Title = "Choose a Token Table"
                };

                // Only read file if the user selected one
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    try
                    {
                        lex.readTokenTable(fileName);
                        tokenTableText.Text = Path.GetFileName(fileName);
                    }
                    catch (Exception err)
                    {
                        errorUserFileError(fileName, err.Message);
                    }
                }

            }
        }

        /// <summary>
        /// Creates a filedialog and warns user if needed
        /// </summary>
        private void openKeywordTable()
        {
            if (warnUserFileOpen())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    InitialDirectory = DEF_TABLE_DIR,
                    Filter = "CSV Files|*.csv|All Files|*.*",
                    Title = "Choose a Keyword Table"
                };

                // Only read file if the user selected one
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    try
                    {
                        lex.readKeywordTable(fileName);
                        keywordTableText.Text = Path.GetFileName(fileName);
                    }
                    catch (Exception err)
                    {
                        errorUserFileError(fileName, err.Message);
                    }
                }

            }
        }

        /// <summary>
        /// Creates a filedialog and warns user if needed
        /// </summary>
        private void openSourceFile()
        {
            if (warnUserFileOpen())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    InitialDirectory = DEF_SOURCE_DIR,
                    Filter = "All Files|*.*",
                    Title = "Choose a Source File"
                };

                // Only read file if the user selected one
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    try
                    {
                        lex.readSourceFile(fileName);
                        sourceFileText.Text = Path.GetFileName(fileName);
                        outputText.AppendText($"\n~ {Path.GetFileName(fileName)} ~\n");
                        outputText.ScrollToCaret();
                    }
                    catch (Exception err)
                    {
                        errorUserFileError(fileName, err.Message);
                    }
                }

            }
        }

        /// <summary>
        /// Calls the lexical analyzer to get the next token, may call 
        /// several times to ignore comments, informs user when eof hit
        /// </summary>
        /// <param name="warn">bool, defaults to true, used to deal with edge case</param>
        private void scanManager(bool warn = true)
        {
            // Don't bother continuing if eof has been hit
            if (lex.eof()) { infoUserEofHit(); }

            else
            {
                // Get the token and keep getting tokens until it is something
                // other than whiteSpace or a comment or end-of-file is hit
                lex.readNextToken();
                while ((lex.curToken == "whiteSpace" || lex.curToken ==
                    "comment") && !lex.eof())
                {
                    lex.readNextToken();
                }

                // Some extra code for when the last token is a comment, only
                // happens if eof hit, warn specifically so autoScan doesn't 
                // mess up the output
                if (warn && lex.curToken == "comment")
                {
                    infoUserEofHit();
                }

                // So the autoScan doesn't print out the last comment
                else if (lex.curToken != "comment")
                {   
                    // Print out appropriate message depending on errorFlag
                    if (lex.errorFlag)
                    {
                        outputText.AppendText(lex.errorMessage + '\n');
                    }

                    else
                    {
                        outputText.AppendText($"Token: {lex.curToken,-12} " +
                            $"Lexemme: {lex.curLexemme}\n");
                    }

                    outputText.ScrollToCaret();
                }
            }
        }

        /// <summary>
        /// Simply keeps calling the lexical analyzer to read the whole file 
        /// automatically
        /// </summary>
        private void autoScanManager()
        {
            if (!lex.eof())
            {
                while (!lex.eof()) { scanManager(false); }
            }

            else
            {
                infoUserEofHit();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lexicalAnalyzer">Lex, an instance of Lex with its files read in</param>
        public Root(Lex lexicalAnalyzer)
        {
            InitializeComponent();

            lex = lexicalAnalyzer;

            // Fill out the text boxes with the file names
            scanTableText.Text = Path.GetFileName(DEF_SCAN);
            tokenTableText.Text = Path.GetFileName(DEF_TOKEN);
            keywordTableText.Text = Path.GetFileName(DEF_KEY);
            sourceFileText.Text = Path.GetFileName(DEF_SOURCE);

            outputText.AppendText($"~ {Path.GetFileName(DEF_SOURCE)} ~\n");

            // So you can just hit enter and start scanning!
            nextTokenButton.Select();
        }
    }
}
