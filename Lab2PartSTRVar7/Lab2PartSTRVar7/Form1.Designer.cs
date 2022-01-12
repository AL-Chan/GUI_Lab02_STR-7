
namespace Lab2PartSTRVar7
{
    partial class Form1
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
            this.YourText = new System.Windows.Forms.TextBox();
            this.YourTextNoSpaces = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.NoSpaceLabel = new System.Windows.Forms.Label();
            this.ItogLabel = new System.Windows.Forms.Label();
            this.ItogText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // YourText
            // 
            this.YourText.Location = new System.Drawing.Point(24, 48);
            this.YourText.Name = "YourText";
            this.YourText.Size = new System.Drawing.Size(501, 20);
            this.YourText.TabIndex = 0;
            // 
            // YourTextNoSpaces
            // 
            this.YourTextNoSpaces.Location = new System.Drawing.Point(24, 138);
            this.YourTextNoSpaces.Name = "YourTextNoSpaces";
            this.YourTextNoSpaces.Size = new System.Drawing.Size(501, 20);
            this.YourTextNoSpaces.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(40, 86);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(427, 21);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Выполнить";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(28, 19);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(130, 13);
            this.StartLabel.TabIndex = 3;
            this.StartLabel.Text = "Исходное предложение:";
            // 
            // NoSpaceLabel
            // 
            this.NoSpaceLabel.AutoSize = true;
            this.NoSpaceLabel.Location = new System.Drawing.Point(27, 119);
            this.NoSpaceLabel.Name = "NoSpaceLabel";
            this.NoSpaceLabel.Size = new System.Drawing.Size(152, 13);
            this.NoSpaceLabel.TabIndex = 4;
            this.NoSpaceLabel.Text = "Предложение без пробелов:";
            // 
            // ItogLabel
            // 
            this.ItogLabel.AutoSize = true;
            this.ItogLabel.Location = new System.Drawing.Point(30, 175);
            this.ItogLabel.Name = "ItogLabel";
            this.ItogLabel.Size = new System.Drawing.Size(222, 13);
            this.ItogLabel.TabIndex = 5;
            this.ItogLabel.Text = "Каков результат выполнения программы:";
            // 
            // ItogText
            // 
            this.ItogText.Location = new System.Drawing.Point(23, 210);
            this.ItogText.Name = "ItogText";
            this.ItogText.Size = new System.Drawing.Size(501, 20);
            this.ItogText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.ItogText);
            this.Controls.Add(this.ItogLabel);
            this.Controls.Add(this.NoSpaceLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.YourTextNoSpaces);
            this.Controls.Add(this.YourText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИЩЕЙКА СОСЕДНИХ ПАР БУКВ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YourText;
        private System.Windows.Forms.TextBox YourTextNoSpaces;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label NoSpaceLabel;
        private System.Windows.Forms.Label ItogLabel;
        private System.Windows.Forms.TextBox ItogText;
    }
}

