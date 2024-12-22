using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Skuru.Core
{
    public class TypingSession
    {
        private TextGenerator _textGenerator;
        public TypingSession()
        {
            _textGenerator = new TextGenerator();
            DifficultyLevel = "normal";
            NumberOfWords = 30;

            Text = _textGenerator.Generate(DifficultyLevel, NumberOfWords);

            NumberOfSymbols = Text.Length;

            CurrentSymbolIndex = 0;
            NumberOfMisprints = 0;
        }

        public void CheckInputSymbol(RichTextBox textBoxForEditing, char inputSymbol)
        {
            if (inputSymbol == (char)Keys.Back && CurrentSymbolIndex == 0) return;

            if (CurrentSymbolIndex == NumberOfSymbols) return;

            if (inputSymbol == (char)Keys.Return) return;

            if (inputSymbol == (char)Keys.Back)
            {
                TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex, _defaultColor, _defaultFont);
                TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex - 1, _defaultColor, "Consolas", 16F,
                    FontStyle.Underline);


                CurrentSymbolIndex--;

                return;
            }

            if (inputSymbol == Text[CurrentSymbolIndex])
            {
                TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex, _successColor, _defaultFont);
                TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex + 1, _defaultColor, "Consolas", 16F,
                    FontStyle.Underline);

                CurrentSymbolIndex++;

                return;
            }

            if (inputSymbol == Text[CurrentSymbolIndex]) return;


            if (Text[CurrentSymbolIndex] == (char)Keys.Space)
                TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex, _misprintColor, "Consolas", 16F,
                    FontStyle.Strikeout);
            else
                TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex, _misprintColor, _defaultFont);

            TextEditor.EditSymbols(textBoxForEditing, CurrentSymbolIndex + 1, _defaultColor, "Consolas", 16F,
                FontStyle.Underline);

            NumberOfMisprints++;
            CurrentSymbolIndex++;
        }

        public void StartSession()
        {
            _stopwatchOfSession.Start();
        }

        public void FinishSession()
        {
            _stopwatchOfSession.Stop();
            ResultTime = _stopwatchOfSession.ElapsedMilliseconds;
            _stopwatchOfSession.Reset();
        }

        public void RefreshSession()
        {
            Text = _textGenerator.Generate(DifficultyLevel, NumberOfWords);
            NumberOfSymbols = Text.Length;

            CurrentSymbolIndex = 0;
            NumberOfMisprints = 0;
        }

        #region Properties

        public string DifficultyLevel { get; private set; } = string.Empty;

        public void SetDifficultyLevel(string value)
        {
            if (value == "easy" || value == "normal" || value == "hard") DifficultyLevel = value;
        }

        public string Text { get; private set; }

        public int NumberOfWords { get; set; }

        public void SetNumberOfWords(int value)
        {
            if (value == 30 || value == 60) NumberOfWords = value;
        }

        public int NumberOfSymbols { get; private set; }

        public int CurrentSymbolIndex { get; private set; }

        public int NumberOfMisprints { get; private set; }

        public long ResultTime { get; private set; }

        #endregion

        #region Fields

        private readonly Stopwatch _stopwatchOfSession = new Stopwatch();

        private readonly Color _defaultColor = Color.Gray;
        private readonly Color _successColor = Color.White;
        private readonly Color _misprintColor = Color.OrangeRed;

        private readonly Font _defaultFont = new Font("Consolas", 16F, FontStyle.Regular);

        #endregion
    }
}