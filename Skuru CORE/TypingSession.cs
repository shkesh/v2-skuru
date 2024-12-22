using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Skuru.Core
{
    public class TypingSession
    {
        #region Fields

        private string _difficultyLevel = string.Empty;
        private int _numberOfWords = 0;
        private string _text;

        private int _numberOfSymbols = 0;

        private int _currentIndex = 0;
        private int _numberOfMisprints = 0;

        private Stopwatch _stopwatchOfSession = new Stopwatch();
        private long _resultTime;

        Color defaultColor = Color.Gray;
        Color successColor = Color.White;
        Color misprintColor = Color.OrangeRed;

        Font defaultFont = new Font("Consolas", 16F, FontStyle.Regular);

        #endregion

        #region Properties

        public string DifficultyLevel
        {
            get { return _difficultyLevel; }
            set
            {
                if (value == "easy" || value == "normal" || value == "hard")
                {
                    _difficultyLevel = value;
                }
            }
        }

        public string Text
        {
            get { return _text; }
        }

        public int NumberOfWords
        {
            get { return _numberOfWords; }
            set
            {
                if (value == 30 || value == 60)
                {
                    _numberOfWords = value;
                }
            }
        }

        public int NumberOfSymbols
        { 
            get { return _numberOfSymbols; }
        }

        public int CurrentIndex
        {
            get { return _currentIndex; }
        }

        public int NumberOfMisprints
        {
            get { return _numberOfMisprints; }
        }

        public long ResultTime
        {
            get { return _resultTime; }
        }

        #endregion

        public TypingSession()
        {
            _difficultyLevel = "normal";
            _numberOfWords = 30;

            _text = TextGenerator.GenerateText(_difficultyLevel, _numberOfWords);

            _numberOfSymbols = _text.Length;

            _currentIndex = 0;
            _numberOfMisprints = 0;
        }

        public void CheckInputSymbol(RichTextBox textBoxForEditing, char inputSymbol)
        {
            if (inputSymbol == (char)Keys.Back && _currentIndex == 0)
            {
                return;
            }

            if (_currentIndex == _numberOfSymbols)
            {
                return;
            }

            if (inputSymbol == (char)Keys.Return)
            {
                return;
            }

            // -1
            if (inputSymbol == (char)Keys.Back)
            {
                TextEditor.EditSymbols(textBoxForEditing, _currentIndex, defaultColor, defaultFont);
                TextEditor.EditSymbols(textBoxForEditing, _currentIndex - 1, defaultColor, "Consolas", 16F, FontStyle.Underline);


                _currentIndex--;

                return;
            }

            // +1 
            if (inputSymbol == _text[_currentIndex])
            {
                TextEditor.EditSymbols(textBoxForEditing, _currentIndex, successColor, defaultFont);
                TextEditor.EditSymbols(textBoxForEditing, _currentIndex + 1, defaultColor, "Consolas", 16F, FontStyle.Underline);

                _currentIndex++;

                return;
            }

            // misprint
            if (inputSymbol != _text[_currentIndex])
            {

                if (_text[_currentIndex] == (char)Keys.Space)
                {
                    TextEditor.EditSymbols(textBoxForEditing, _currentIndex, misprintColor, "Consolas", 16F, FontStyle.Strikeout);

                }
                else
                {
                    TextEditor.EditSymbols(textBoxForEditing, _currentIndex, misprintColor, defaultFont);
                }

                TextEditor.EditSymbols(textBoxForEditing, _currentIndex + 1, defaultColor, "Consolas", 16F, FontStyle.Underline);

                _numberOfMisprints++;
                _currentIndex++;

                return;
            }
        }

        public void StartSession()
        {
            _stopwatchOfSession.Start();
        }

        public void FinishSession()
        {
            _stopwatchOfSession.Stop();
            _resultTime = _stopwatchOfSession.ElapsedMilliseconds;
            _stopwatchOfSession.Reset();
        }

        public void RefreshSession()
        {
            _text = TextGenerator.GenerateText(_difficultyLevel, _numberOfWords);
            _numberOfSymbols = _text.Length;

            _currentIndex = 0;
            _numberOfMisprints = 0;
        }
    }
}

