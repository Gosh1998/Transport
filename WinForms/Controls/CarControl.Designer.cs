namespace WinForms.Controls
{
    partial class CarControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameCarTextBox = new System.Windows.Forms.TextBox();
            this.SpacingCarTextBox = new System.Windows.Forms.TextBox();
            this.CurentFuelCarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameCarTextBox
            // 
            this.NameCarTextBox.Location = new System.Drawing.Point(8, 25);
            this.NameCarTextBox.Name = "NameCarTextBox";
            this.NameCarTextBox.Size = new System.Drawing.Size(91, 20);
            this.NameCarTextBox.TabIndex = 0;
            // 
            // SpacingCarTextBox
            // 
            this.SpacingCarTextBox.Location = new System.Drawing.Point(8, 66);
            this.SpacingCarTextBox.Name = "SpacingCarTextBox";
            this.SpacingCarTextBox.Size = new System.Drawing.Size(44, 20);
            this.SpacingCarTextBox.TabIndex = 1;
            // 
            // CurentFuelCarTextBox
            // 
            this.CurentFuelCarTextBox.Location = new System.Drawing.Point(8, 105);
            this.CurentFuelCarTextBox.Name = "CurentFuelCarTextBox";
            this.CurentFuelCarTextBox.Size = new System.Drawing.Size(110, 20);
            this.CurentFuelCarTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пробег";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество топлива";
            // 
            // CarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurentFuelCarTextBox);
            this.Controls.Add(this.SpacingCarTextBox);
            this.Controls.Add(this.NameCarTextBox);
            this.Name = "CarControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameCarTextBox;
        private System.Windows.Forms.TextBox SpacingCarTextBox;
        private System.Windows.Forms.TextBox CurentFuelCarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
