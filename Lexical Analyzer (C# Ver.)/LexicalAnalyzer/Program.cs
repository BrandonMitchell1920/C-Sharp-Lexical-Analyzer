/*
 * Name:    Brandon Mitchell
 * Description: Think of this as the Python version's "main.pyw."  Sets up the
 *              Lex and passes it to the GUI (known as "Root").
 */

using System;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Lex lex = new Lex();

            // Don't let program run if we are missing the default files.  I
            // don't catch the exception in the read functions anymore.
            try
            {
                lex.readScanTable(Root.DEF_SCAN);
                lex.readTokenTable(Root.DEF_TOKEN);
                lex.readKeywordTable(Root.DEF_KEY);
                lex.readSourceFile(Root.DEF_SOURCE);
            }
            catch (Exception err)
            {
                MessageBox.Show("Default files could not be loaded.  Make " +
                    $"sure they exist and try again.\n\n{err.Message}", 
                    "Error Loading Default Files!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            // Creates and runs the GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Root(lex));
        }
    }
}
