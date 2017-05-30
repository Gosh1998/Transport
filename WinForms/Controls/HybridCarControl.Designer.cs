namespace WinForms.Controls
{
    partial class HybridCarControl
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
            this.NameHybridTextBox = new System.Windows.Forms.TextBox();
            this.PowerHybridTextBox = new System.Windows.Forms.TextBox();
            this.ElectricityHybridTextBox = new System.Windows.Forms.TextBox();
            this.FuelHybridTextBox = new System.Windows.Forms.TextBox();
            this.SpacingHybridTextBox = new System.Windows.Forms.TextBox();
            this.TheCurrentOfElectricityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameHybridTextBox
            // 
            this.NameHybridTextBox.Location = new System.Drawing.Point(6, 23);
            this.NameHybridTextBox.Name = "NameHybridTextBox";
            this.NameHybridTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameHybridTextBox.TabIndex = 0;
            // 
            // PowerHybridTextBox
            // 
            this.PowerHybridTextBox.Location = new System.Drawing.Point(6, 64);
            this.PowerHybridTextBox.Name = "PowerHybridTextBox";
            this.PowerHybridTextBox.Size = new System.Drawing.Size(100, 20);
            this.PowerHybridTextBox.TabIndex = 1;
            // 
            // ElectricityHybridTextBox
            // 
            this.ElectricityHybridTextBox.Location = new System.Drawing.Point(6, 103);
            this.ElectricityHybridTextBox.Name = "ElectricityHybridTextBox";
            this.ElectricityHybridTextBox.Size = new System.Drawing.Size(82, 20);
            this.ElectricityHybridTextBox.TabIndex = 2;
            // 
            // FuelHybridTextBox
            // 
            this.FuelHybridTextBox.Location = new System.Drawing.Point(6, 145);
            this.FuelHybridTextBox.Name = "FuelHybridTextBox";
            this.FuelHybridTextBox.Size = new System.Drawing.Size(107, 20);
            this.FuelHybridTextBox.TabIndex = 3;
            // 
            // SpacingHybridTextBox
            // 
            this.SpacingHybridTextBox.Location = new System.Drawing.Point(6, 187);
            this.SpacingHybridTextBox.Name = "SpacingHybridTextBox";
            this.SpacingHybridTextBox.Size = new System.Drawing.Size(44, 20);
            this.SpacingHybridTextBox.TabIndex = 4;
            // 
            // TheCurrentOfElectricityTextBox
            // 
            this.TheCurrentOfElectricityTextBox.Location = new System.Drawing.Point(6, 226);
            this.TheCurrentOfElectricityTextBox.Name = "TheCurrentOfElectricityTextBox";
            this.TheCurrentOfElectricityTextBox.Size = new System.Drawing.Size(110, 20);
            this.TheCurrentOfElectricityTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мощьность батареи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заряд батареи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество топлива";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пробег";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Текущее кол-во эл-во";
            // 
            // HybridCarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TheCurrentOfElectricityTextBox);
            this.Controls.Add(this.SpacingHybridTextBox);
            this.Controls.Add(this.FuelHybridTextBox);
            this.Controls.Add(this.ElectricityHybridTextBox);
            this.Controls.Add(this.PowerHybridTextBox);
            this.Controls.Add(this.NameHybridTextBox);
            this.Name = "HybridCarControl";
            this.Size = new System.Drawing.Size(150, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameHybridTextBox;
        private System.Windows.Forms.TextBox PowerHybridTextBox;
        private System.Windows.Forms.TextBox ElectricityHybridTextBox;
        private System.Windows.Forms.TextBox FuelHybridTextBox;
        private System.Windows.Forms.TextBox SpacingHybridTextBox;
        private System.Windows.Forms.TextBox TheCurrentOfElectricityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
