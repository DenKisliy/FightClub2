namespace Бойцовский_клуб_графика
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fight = new System.Windows.Forms.Button();
            this.Udar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Blok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fight
            // 
            this.Fight.Location = new System.Drawing.Point(133, 78);
            this.Fight.Name = "Fight";
            this.Fight.Size = new System.Drawing.Size(84, 21);
            this.Fight.TabIndex = 0;
            this.Fight.Text = "Начать бой";
            this.Fight.UseVisualStyleBackColor = true;
            this.Fight.Click += new System.EventHandler(this.Fight_Click);
            // 
            // Udar
            // 
            this.Udar.FormattingEnabled = true;
            this.Udar.Items.AddRange(new object[] {
            "Голова",
            "Туловище ",
            "Ноги"});
            this.Udar.Location = new System.Drawing.Point(185, 28);
            this.Udar.Name = "Udar";
            this.Udar.Size = new System.Drawing.Size(137, 21);
            this.Udar.TabIndex = 1;
            this.Udar.Text = "Выберите часть тела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбор части тела для атаки";
            // 
            // Blok
            // 
            this.Blok.FormattingEnabled = true;
            this.Blok.Items.AddRange(new object[] {
            "Голова",
            "Туловище ",
            "Ноги"});
            this.Blok.Location = new System.Drawing.Point(185, 51);
            this.Blok.Name = "Blok";
            this.Blok.Size = new System.Drawing.Size(137, 21);
            this.Blok.TabIndex = 4;
            this.Blok.Text = "Выберите часть тела";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбор части тела для защиты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Blok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Udar);
            this.Controls.Add(this.Fight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fight;
        private System.Windows.Forms.ComboBox Udar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Blok;
        private System.Windows.Forms.Label label1;

    }
}

