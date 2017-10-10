namespace WindowsFormsApplication3
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
            this.radioButtonInYear = new System.Windows.Forms.RadioButton();
            this.radioButtonInMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonInDay = new System.Windows.Forms.RadioButton();
            this.radioButtonInMinutes = new System.Windows.Forms.RadioButton();
            this.radioButtonInSeconds = new System.Windows.Forms.RadioButton();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // radioButtonInYear
            // 
            this.radioButtonInYear.AutoSize = true;
            this.radioButtonInYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonInYear.Location = new System.Drawing.Point(219, 18);
            this.radioButtonInYear.Name = "radioButtonInYear";
            this.radioButtonInYear.Size = new System.Drawing.Size(79, 23);
            this.radioButtonInYear.TabIndex = 1;
            this.radioButtonInYear.TabStop = true;
            this.radioButtonInYear.Text = "В годах";
            this.radioButtonInYear.UseVisualStyleBackColor = true;
            this.radioButtonInYear.CheckedChanged += new System.EventHandler(this.RadioButtonInYear_CheckedChanged);
            // 
            // radioButtonInMonth
            // 
            this.radioButtonInMonth.AutoSize = true;
            this.radioButtonInMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonInMonth.Location = new System.Drawing.Point(219, 47);
            this.radioButtonInMonth.Name = "radioButtonInMonth";
            this.radioButtonInMonth.Size = new System.Drawing.Size(98, 23);
            this.radioButtonInMonth.TabIndex = 2;
            this.radioButtonInMonth.TabStop = true;
            this.radioButtonInMonth.Text = "В месяцах";
            this.radioButtonInMonth.UseVisualStyleBackColor = true;
            this.radioButtonInMonth.CheckedChanged += new System.EventHandler(this.RadioButtonInMonth_CheckedChanged);
            // 
            // radioButtonInDay
            // 
            this.radioButtonInDay.AutoSize = true;
            this.radioButtonInDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonInDay.Location = new System.Drawing.Point(219, 76);
            this.radioButtonInDay.Name = "radioButtonInDay";
            this.radioButtonInDay.Size = new System.Drawing.Size(73, 23);
            this.radioButtonInDay.TabIndex = 3;
            this.radioButtonInDay.TabStop = true;
            this.radioButtonInDay.Text = "В днях";
            this.radioButtonInDay.UseVisualStyleBackColor = true;
            this.radioButtonInDay.CheckedChanged += new System.EventHandler(this.RadioButtonInDay_CheckedChanged);
            // 
            // radioButtonInMinutes
            // 
            this.radioButtonInMinutes.AutoSize = true;
            this.radioButtonInMinutes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonInMinutes.Location = new System.Drawing.Point(219, 105);
            this.radioButtonInMinutes.Name = "radioButtonInMinutes";
            this.radioButtonInMinutes.Size = new System.Drawing.Size(98, 23);
            this.radioButtonInMinutes.TabIndex = 4;
            this.radioButtonInMinutes.TabStop = true;
            this.radioButtonInMinutes.Text = "В минутах";
            this.radioButtonInMinutes.UseVisualStyleBackColor = true;
            this.radioButtonInMinutes.CheckedChanged += new System.EventHandler(this.RadioButtonInMinutes_CheckedChanged);
            // 
            // radioButtonInSeconds
            // 
            this.radioButtonInSeconds.AutoSize = true;
            this.radioButtonInSeconds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonInSeconds.Location = new System.Drawing.Point(219, 134);
            this.radioButtonInSeconds.Name = "radioButtonInSeconds";
            this.radioButtonInSeconds.Size = new System.Drawing.Size(104, 23);
            this.radioButtonInSeconds.TabIndex = 5;
            this.radioButtonInSeconds.TabStop = true;
            this.radioButtonInSeconds.Text = "В секундах";
            this.radioButtonInSeconds.UseVisualStyleBackColor = true;
            this.radioButtonInSeconds.CheckedChanged += new System.EventHandler(this.RadioButtonInSeconds_CheckedChanged);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(355, 18);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(337, 139);
            this.textBoxInfo.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(13, 18);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.radioButtonInSeconds);
            this.Controls.Add(this.radioButtonInMinutes);
            this.Controls.Add(this.radioButtonInDay);
            this.Controls.Add(this.radioButtonInMonth);
            this.Controls.Add(this.radioButtonInYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonInYear;
        private System.Windows.Forms.RadioButton radioButtonInMonth;
        private System.Windows.Forms.RadioButton radioButtonInDay;
        private System.Windows.Forms.RadioButton radioButtonInMinutes;
        private System.Windows.Forms.RadioButton radioButtonInSeconds;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

