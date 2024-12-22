using System.Drawing;
using System.Windows.Forms;

namespace Skuru.Core
{
    public class TextEditor
    {
        public static void EditSymbols(RichTextBox textBoxForEdit, int indexOfSymbol, Color colorOfSymbol, Font fontOfSymbol)
        {
            textBoxForEdit.Select(indexOfSymbol, 1);
            textBoxForEdit.SelectionColor = colorOfSymbol;
            textBoxForEdit.SelectionFont = fontOfSymbol;
            textBoxForEdit.Select(0, 0);
        }

        public static void EditSymbols(RichTextBox textBoxForEdit, int indexOfSymbol, Color colorOfSymbol, string fontOfSymbol, float sizeOfSymbol, FontStyle styleOfSymbol)
        {
            textBoxForEdit.Select(indexOfSymbol, 1);
            textBoxForEdit.SelectionColor = colorOfSymbol;
            textBoxForEdit.SelectionFont = new Font(fontOfSymbol, sizeOfSymbol, styleOfSymbol);
            textBoxForEdit.Select(0, 0);
        }
    }
}
