using System.Windows.Forms;

namespace Skuru.App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxForInput = new System.Windows.Forms.RichTextBox();
            this.MaskedTextBoxForInput = new System.Windows.Forms.TextBox();
            this.LabelForScore = new System.Windows.Forms.Label();
            this.Mask = new System.Windows.Forms.Label();
            this.Button30Words = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxForInput
            // 
            this.TextBoxForInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBoxForInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxForInput.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForInput.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxForInput.Location = new System.Drawing.Point(40, 125);
            this.TextBoxForInput.Name = "TextBoxForInput";
            this.TextBoxForInput.ReadOnly = true;
            this.TextBoxForInput.Size = new System.Drawing.Size(720, 200);
            this.TextBoxForInput.TabIndex = 0;
            this.TextBoxForInput.TabStop = false;
            this.TextBoxForInput.Text = "Text";
            // 
            // MaskedTextBoxForInput
            // 
            this.MaskedTextBoxForInput.Font = new System.Drawing.Font("Consolas", 10F);
            this.MaskedTextBoxForInput.Location = new System.Drawing.Point(12, 415);
            this.MaskedTextBoxForInput.Name = "MaskedTextBoxForInput";
            this.MaskedTextBoxForInput.ShortcutsEnabled = false;
            this.MaskedTextBoxForInput.Size = new System.Drawing.Size(776, 23);
            this.MaskedTextBoxForInput.TabIndex = 1;
            this.MaskedTextBoxForInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBoxForInput_KeyPress);
            // 
            // LabelForScore
            // 
            this.LabelForScore.AutoSize = true;
            this.LabelForScore.ForeColor = System.Drawing.Color.Gray;
            this.LabelForScore.Location = new System.Drawing.Point(35, 80);
            this.LabelForScore.Name = "LabelForScore";
            this.LabelForScore.Size = new System.Drawing.Size(72, 26);
            this.LabelForScore.TabIndex = 2;
            this.LabelForScore.Text = "0 / 0";
            // 
            // Mask
            // 
            this.Mask.Location = new System.Drawing.Point(12, 358);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(781, 83);
            this.Mask.TabIndex = 3;
            // 
            // Button30Words
            // 
            this.Button30Words.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button30Words.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button30Words.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button30Words.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button30Words.Font = new System.Drawing.Font("Consolas", 12F);
            this.Button30Words.Location = new System.Drawing.Point(112, 367);
            this.Button30Words.Name = "Button30Words";
            this.Button30Words.Size = new System.Drawing.Size(45, 29);
            this.Button30Words.TabIndex = 4;
            this.Button30Words.Text = "30";
            this.Button30Words.UseVisualStyleBackColor = false;
            this.Button30Words.Click += new System.EventHandler(this.Button30Words_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.RefreshButton.Location = new System.Drawing.Point(331, 367);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(145, 29);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Button30Words);
            this.Controls.Add(this.Mask);
            this.Controls.Add(this.LabelForScore);
            this.Controls.Add(this.MaskedTextBoxForInput);
            this.Controls.Add(this.TextBoxForInput);
            this.Font = new System.Drawing.Font("Consolas", 16F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxForInput;
        private System.Windows.Forms.TextBox MaskedTextBoxForInput;
        private System.Windows.Forms.Label LabelForScore;
        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.Button Button30Words;
        private Button RefreshButton;
    }
}

