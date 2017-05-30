namespace WinForms.Controls
{
    partial class HelicopterControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.VolumeHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.SpacingHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.FuelHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Объем бака вертолета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пробег";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Расход на 100 км";
            // 
            // NameHelicopterTextBox
            // 
            this.NameHelicopterTextBox.Location = new System.Drawing.Point(6, 30);
            this.NameHelicopterTextBox.Name = "NameHelicopterTextBox";
            this.NameHelicopterTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameHelicopterTextBox.TabIndex = 4;
            // 
            // VolumeHelicopterTextBox
            // 
            this.VolumeHelicopterTextBox.Location = new System.Drawing.Point(6, 69);
            this.VolumeHelicopterTextBox.Name = "VolumeHelicopterTextBox";
            this.VolumeHelicopterTextBox.Size = new System.Drawing.Size(121, 20);
            this.VolumeHelicopterTextBox.TabIndex = 5;
            // 
            // SpacingHelicopterTextBox
            // 
            this.SpacingHelicopterTextBox.Location = new System.Drawing.Point(6, 108);
            this.SpacingHelicopterTextBox.Name = "SpacingHelicopterTextBox";
            this.SpacingHelicopterTextBox.Size = new System.Drawing.Size(41, 20);
            this.SpacingHelicopterTextBox.TabIndex = 6;
            // 
            // FuelHelicopterTextBox
            // 
            this.FuelHelicopterTextBox.Location = new System.Drawing.Point(6, 147);
            this.FuelHelicopterTextBox.Name = "FuelHelicopterTextBox";
            this.FuelHelicopterTextBox.Size = new System.Drawing.Size(93, 20);
            this.FuelHelicopterTextBox.TabIndex = 7;
            // 
            // HelicopterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FuelHelicopterTextBox);
            this.Controls.Add(this.SpacingHelicopterTextBox);
            this.Controls.Add(this.VolumeHelicopterTextBox);
            this.Controls.Add(this.NameHelicopterTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelicopterControl";
            this.Size = new System.Drawing.Size(150, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameHelicopterTextBox;
        private System.Windows.Forms.TextBox VolumeHelicopterTextBox;
        private System.Windows.Forms.TextBox SpacingHelicopterTextBox;
        private System.Windows.Forms.TextBox FuelHelicopterTextBox;
    }
}
