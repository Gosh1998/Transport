namespace WinForms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.HelicopterGroupBox = new System.Windows.Forms.GroupBox();
            this.NameHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.SpacingHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.VolumeHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.FuelHelicopterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CarGroupBox = new System.Windows.Forms.GroupBox();
            this.NameCarTextBox = new System.Windows.Forms.TextBox();
            this.SpacingCarTextBox = new System.Windows.Forms.TextBox();
            this.CurentFuelCarTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HybridCarGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TheCurrentOfElectricityTextBox = new System.Windows.Forms.TextBox();
            this.ElectricityHybridTextBox = new System.Windows.Forms.TextBox();
            this.PowerHybridTextBox = new System.Windows.Forms.TextBox();
            this.SpacingHybridTextBox = new System.Windows.Forms.TextBox();
            this.FuelHybridTextBox = new System.Windows.Forms.TextBox();
            this.NameHybridTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TransportComboBox = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.HelicopterGroupBox.SuspendLayout();
            this.CarGroupBox.SuspendLayout();
            this.HybridCarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.HelicopterGroupBox);
            this.GroupBox1.Controls.Add(this.CarGroupBox);
            this.GroupBox1.Controls.Add(this.HybridCarGroupBox);
            this.GroupBox1.Controls.Add(this.CancelButton);
            this.GroupBox1.Controls.Add(this.OKButton);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.TransportComboBox);
            this.GroupBox1.Location = new System.Drawing.Point(12, 11);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(190, 374);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // HelicopterGroupBox
            // 
            this.HelicopterGroupBox.Controls.Add(this.NameHelicopterTextBox);
            this.HelicopterGroupBox.Controls.Add(this.SpacingHelicopterTextBox);
            this.HelicopterGroupBox.Controls.Add(this.VolumeHelicopterTextBox);
            this.HelicopterGroupBox.Controls.Add(this.FuelHelicopterTextBox);
            this.HelicopterGroupBox.Controls.Add(this.label8);
            this.HelicopterGroupBox.Controls.Add(this.label7);
            this.HelicopterGroupBox.Controls.Add(this.label6);
            this.HelicopterGroupBox.Controls.Add(this.label5);
            this.HelicopterGroupBox.Location = new System.Drawing.Point(189, 61);
            this.HelicopterGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelicopterGroupBox.Name = "HelicopterGroupBox";
            this.HelicopterGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelicopterGroupBox.Size = new System.Drawing.Size(179, 268);
            this.HelicopterGroupBox.TabIndex = 6;
            this.HelicopterGroupBox.TabStop = false;
            // 
            // NameHelicopterTextBox
            // 
            this.NameHelicopterTextBox.Location = new System.Drawing.Point(9, 33);
            this.NameHelicopterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameHelicopterTextBox.Name = "NameHelicopterTextBox";
            this.NameHelicopterTextBox.Size = new System.Drawing.Size(104, 20);
            this.NameHelicopterTextBox.TabIndex = 7;
            // 
            // SpacingHelicopterTextBox
            // 
            this.SpacingHelicopterTextBox.Location = new System.Drawing.Point(9, 121);
            this.SpacingHelicopterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpacingHelicopterTextBox.Name = "SpacingHelicopterTextBox";
            this.SpacingHelicopterTextBox.Size = new System.Drawing.Size(42, 20);
            this.SpacingHelicopterTextBox.TabIndex = 6;
            this.SpacingHelicopterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpacingHelicopterTextBox_KeyPress);
            // 
            // VolumeHelicopterTextBox
            // 
            this.VolumeHelicopterTextBox.Location = new System.Drawing.Point(9, 80);
            this.VolumeHelicopterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VolumeHelicopterTextBox.Name = "VolumeHelicopterTextBox";
            this.VolumeHelicopterTextBox.Size = new System.Drawing.Size(120, 20);
            this.VolumeHelicopterTextBox.TabIndex = 5;
            this.VolumeHelicopterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VolumeHelicopterTextBox_KeyPress);
            // 
            // FuelHelicopterTextBox
            // 
            this.FuelHelicopterTextBox.Location = new System.Drawing.Point(6, 160);
            this.FuelHelicopterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FuelHelicopterTextBox.Name = "FuelHelicopterTextBox";
            this.FuelHelicopterTextBox.Size = new System.Drawing.Size(96, 20);
            this.FuelHelicopterTextBox.TabIndex = 4;
            this.FuelHelicopterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuelHelicopterTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Пробег";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Объем бака вертолета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Расход на 100 км";
            // 
            // CarGroupBox
            // 
            this.CarGroupBox.Controls.Add(this.NameCarTextBox);
            this.CarGroupBox.Controls.Add(this.SpacingCarTextBox);
            this.CarGroupBox.Controls.Add(this.CurentFuelCarTextBox);
            this.CarGroupBox.Controls.Add(this.label4);
            this.CarGroupBox.Controls.Add(this.label3);
            this.CarGroupBox.Controls.Add(this.label2);
            this.CarGroupBox.Location = new System.Drawing.Point(6, 61);
            this.CarGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarGroupBox.Name = "CarGroupBox";
            this.CarGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarGroupBox.Size = new System.Drawing.Size(177, 268);
            this.CarGroupBox.TabIndex = 5;
            this.CarGroupBox.TabStop = false;
            // 
            // NameCarTextBox
            // 
            this.NameCarTextBox.Location = new System.Drawing.Point(14, 30);
            this.NameCarTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameCarTextBox.Name = "NameCarTextBox";
            this.NameCarTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameCarTextBox.TabIndex = 5;
            // 
            // SpacingCarTextBox
            // 
            this.SpacingCarTextBox.Location = new System.Drawing.Point(14, 80);
            this.SpacingCarTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpacingCarTextBox.Name = "SpacingCarTextBox";
            this.SpacingCarTextBox.Size = new System.Drawing.Size(42, 20);
            this.SpacingCarTextBox.TabIndex = 4;
            this.SpacingCarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpacingCarTextBox_KeyPress);
            // 
            // CurentFuelCarTextBox
            // 
            this.CurentFuelCarTextBox.Location = new System.Drawing.Point(14, 121);
            this.CurentFuelCarTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurentFuelCarTextBox.Name = "CurentFuelCarTextBox";
            this.CurentFuelCarTextBox.Size = new System.Drawing.Size(114, 20);
            this.CurentFuelCarTextBox.TabIndex = 3;
            this.CurentFuelCarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurentFuelCarTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пробег";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество топлива";
            // 
            // HybridCarGroupBox
            // 
            this.HybridCarGroupBox.Controls.Add(this.label14);
            this.HybridCarGroupBox.Controls.Add(this.TheCurrentOfElectricityTextBox);
            this.HybridCarGroupBox.Controls.Add(this.ElectricityHybridTextBox);
            this.HybridCarGroupBox.Controls.Add(this.PowerHybridTextBox);
            this.HybridCarGroupBox.Controls.Add(this.SpacingHybridTextBox);
            this.HybridCarGroupBox.Controls.Add(this.FuelHybridTextBox);
            this.HybridCarGroupBox.Controls.Add(this.NameHybridTextBox);
            this.HybridCarGroupBox.Controls.Add(this.label13);
            this.HybridCarGroupBox.Controls.Add(this.label12);
            this.HybridCarGroupBox.Controls.Add(this.label11);
            this.HybridCarGroupBox.Controls.Add(this.label10);
            this.HybridCarGroupBox.Controls.Add(this.label9);
            this.HybridCarGroupBox.Location = new System.Drawing.Point(374, 61);
            this.HybridCarGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HybridCarGroupBox.Name = "HybridCarGroupBox";
            this.HybridCarGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HybridCarGroupBox.Size = new System.Drawing.Size(179, 268);
            this.HybridCarGroupBox.TabIndex = 4;
            this.HybridCarGroupBox.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Текущее кол-во эл-во";
            // 
            // TheCurrentOfElectricityTextBox
            // 
            this.TheCurrentOfElectricityTextBox.Location = new System.Drawing.Point(13, 241);
            this.TheCurrentOfElectricityTextBox.Name = "TheCurrentOfElectricityTextBox";
            this.TheCurrentOfElectricityTextBox.Size = new System.Drawing.Size(107, 20);
            this.TheCurrentOfElectricityTextBox.TabIndex = 10;
            this.TheCurrentOfElectricityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TheCurrentOfElectricityTextBox_KeyPress);
            // 
            // ElectricityHybridTextBox
            // 
            this.ElectricityHybridTextBox.Location = new System.Drawing.Point(12, 121);
            this.ElectricityHybridTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ElectricityHybridTextBox.Name = "ElectricityHybridTextBox";
            this.ElectricityHybridTextBox.Size = new System.Drawing.Size(79, 20);
            this.ElectricityHybridTextBox.TabIndex = 9;
            this.ElectricityHybridTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ElectricityHybridTextBox_KeyPress);
            // 
            // PowerHybridTextBox
            // 
            this.PowerHybridTextBox.Location = new System.Drawing.Point(12, 80);
            this.PowerHybridTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PowerHybridTextBox.Name = "PowerHybridTextBox";
            this.PowerHybridTextBox.Size = new System.Drawing.Size(100, 20);
            this.PowerHybridTextBox.TabIndex = 8;
            this.PowerHybridTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PowerHybridTextBox_KeyPress);
            // 
            // SpacingHybridTextBox
            // 
            this.SpacingHybridTextBox.Location = new System.Drawing.Point(14, 201);
            this.SpacingHybridTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpacingHybridTextBox.Name = "SpacingHybridTextBox";
            this.SpacingHybridTextBox.Size = new System.Drawing.Size(42, 20);
            this.SpacingHybridTextBox.TabIndex = 7;
            this.SpacingHybridTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpacingHybridTextBox_KeyPress);
            // 
            // FuelHybridTextBox
            // 
            this.FuelHybridTextBox.Location = new System.Drawing.Point(14, 160);
            this.FuelHybridTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FuelHybridTextBox.Name = "FuelHybridTextBox";
            this.FuelHybridTextBox.Size = new System.Drawing.Size(100, 20);
            this.FuelHybridTextBox.TabIndex = 6;
            this.FuelHybridTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuelHybridTextBox_KeyPress);
            // 
            // NameHybridTextBox
            // 
            this.NameHybridTextBox.Location = new System.Drawing.Point(12, 33);
            this.NameHybridTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameHybridTextBox.Name = "NameHybridTextBox";
            this.NameHybridTextBox.Size = new System.Drawing.Size(103, 20);
            this.NameHybridTextBox.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Заряд батареи";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Пробег";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Мощность батареи";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Количество топлива";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Имя";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(84, 337);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 22);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(6, 337);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 22);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите транспорт";
            // 
            // TransportComboBox
            // 
            this.TransportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportComboBox.FormattingEnabled = true;
            this.TransportComboBox.Items.AddRange(new object[] {
            "Машина",
            "Гибрид",
            "Вертолет"});
            this.TransportComboBox.Location = new System.Drawing.Point(9, 33);
            this.TransportComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransportComboBox.Name = "TransportComboBox";
            this.TransportComboBox.Size = new System.Drawing.Size(123, 21);
            this.TransportComboBox.TabIndex = 0;
            this.TransportComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportComboBox_SelectedIndexChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(214, 398);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddForm";
            this.Text = " Транспорт";
            this.Load += new System.EventHandler(this.TransportForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.HelicopterGroupBox.ResumeLayout(false);
            this.HelicopterGroupBox.PerformLayout();
            this.CarGroupBox.ResumeLayout(false);
            this.CarGroupBox.PerformLayout();
            this.HybridCarGroupBox.ResumeLayout(false);
            this.HybridCarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TransportComboBox;
        private System.Windows.Forms.GroupBox HelicopterGroupBox;
        private System.Windows.Forms.GroupBox CarGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox HybridCarGroupBox;
        private System.Windows.Forms.TextBox NameCarTextBox;
        private System.Windows.Forms.TextBox SpacingCarTextBox;
        private System.Windows.Forms.TextBox CurentFuelCarTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameHelicopterTextBox;
        private System.Windows.Forms.TextBox SpacingHelicopterTextBox;
        private System.Windows.Forms.TextBox VolumeHelicopterTextBox;
        private System.Windows.Forms.TextBox FuelHelicopterTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ElectricityHybridTextBox;
        private System.Windows.Forms.TextBox PowerHybridTextBox;
        private System.Windows.Forms.TextBox SpacingHybridTextBox;
        private System.Windows.Forms.TextBox FuelHybridTextBox;
        private System.Windows.Forms.TextBox NameHybridTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TheCurrentOfElectricityTextBox;
    }
}