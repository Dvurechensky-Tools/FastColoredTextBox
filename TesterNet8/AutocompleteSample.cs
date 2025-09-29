/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 сентября 2025 06:53:11
 * Version: 1.0.214
 */

using FastColoredTextBoxNS;

namespace TesterNet8
{
    public partial class AutocompleteSample : Form
    {
        AutocompleteMenu popupMenu;

        public AutocompleteSample()
        {
            InitializeComponent();

            //create autocomplete popup menu
            popupMenu = new AutocompleteMenu(fctb);
            popupMenu.MinFragmentLength = 2;

            //generate 456976 words
            var randomWords = new List<string>();
            int codeA = Convert.ToInt32('a');
            for (int i = 0; i < 26; i++)
            for (int j = 0; j < 26; j++)
            for (int k = 0; k < 26; k++)
            for (int l = 0; l < 26; l++)
                randomWords.Add(
                    new string(new char[]{Convert.ToChar(i + codeA), Convert.ToChar(j + codeA), Convert.ToChar(k + codeA), Convert.ToChar(l + codeA)}));

            //set words as autocomplete source
            popupMenu.Items.SetAutocompleteItems(randomWords);
            //size of popupmenu
            popupMenu.Items.MaximumSize = new System.Drawing.Size(200, 300);
            popupMenu.Items.Width = 200;
        }

        private void fctb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                //forced show (MinFragmentLength will be ignored)
                popupMenu.Show(true);
                e.Handled = true;
            }
        }
    }
}
