using System;
using System.Drawing;
using System.Windows.Forms;
using Skuru.Core;

namespace Skuru.App
{
    public partial class MainForm : Form
    {
        private readonly TypingSession _activeSession;
        private ScoreUpdater _scoreUpdater;
        
        public MainForm()
        {
            _activeSession = new TypingSession();
            _scoreUpdater = new ScoreUpdater();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextBoxForInput.Text = _activeSession.Text;
            MaskedTextBoxForInput.Focus();
            TextEditor.EditSymbols(TextBoxForInput, 0, Color.Gray, "Consolas", 16F, FontStyle.Underline);
            LabelForScore.Text = _scoreUpdater.UpdateScore(_activeSession.CurrentSymbolIndex, _activeSession.NumberOfSymbols);

            Button30Words.BackColor = Color.Gray;
        }

        #region StyleOfBorder

        private Point _mouseDownLocation;
        private const int TITLEBARHEIGHT = 25;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#282828"), 1))
            {
                Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Проверяем, нажата ли левая кнопка мыши и находится ли курсор в заголовке
            if (e.Button == MouseButtons.Left && e.Y <= TITLEBARHEIGHT)
            {
                _mouseDownLocation = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            // Перемещаем форму, если нажата левая кнопка мыши и курсор был в заголовке
            if (e.Button == MouseButtons.Left && _mouseDownLocation != Point.Empty)
            {
                this.Location = new Point(this.Location.X + e.X - _mouseDownLocation.X,
                                          this.Location.Y + e.Y - _mouseDownLocation.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            // Сбрасываем положение мыши после отпускания кнопки
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = Point.Empty;
            }
        }

        #endregion

        private void MaskedTextBoxForInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            _activeSession.CheckInputSymbol(TextBoxForInput, e.KeyChar);

            if (_activeSession.CurrentSymbolIndex == 1)
            {
                _activeSession.StartSession();
            }

            if (_activeSession.CurrentSymbolIndex == TextBoxForInput.Text.Length)
            {
                _activeSession.FinishSession();
                TextBoxForInput.Text = Statistics.OutputStatistics(_activeSession.ResultTime, _activeSession.NumberOfSymbols, _activeSession.NumberOfWords, _activeSession.NumberOfMisprints);
                MaskedTextBoxForInput.ReadOnly = true;
                LabelForScore.ForeColor = Color.Green;
            }

            LabelForScore.Text = _scoreUpdater.UpdateScore(_activeSession.CurrentSymbolIndex, _activeSession.NumberOfSymbols);
        }
        

        private void Button30Words_Click(object sender, EventArgs e)
        {
            if (_activeSession.NumberOfWords == 30)
            {
                return;
            }

            _activeSession.RefreshSession();
            _activeSession.NumberOfWords = 30;

            Button30Words.BackColor = Color.Gray;
            MaskedTextBoxForInput.ReadOnly = false;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _activeSession.RefreshSession();
            
            TextBoxForInput.Text = _activeSession.Text;
            MaskedTextBoxForInput.Focus();

            TextEditor.EditSymbols(TextBoxForInput, 0, Color.Gray, "Consolas", 16F, FontStyle.Underline);
            LabelForScore.Text = _scoreUpdater.UpdateScore(_activeSession.CurrentSymbolIndex, _activeSession.NumberOfSymbols);

            LabelForScore.ForeColor = Color.Gray;
        }
    }
}
