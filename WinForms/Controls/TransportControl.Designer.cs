namespace WinForms.Controls
{
    partial class TransportControl
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
            this.TransportControlComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hybridCarControl1 = new WinForms.Controls.HybridCarControl();
            this.helicopterControl1 = new WinForms.Controls.HelicopterControl();
            this.carControl1 = new WinForms.Controls.CarControl();
            this.SuspendLayout();
            // 
            // TransportControlComboBox
            // 
            this.TransportControlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportControlComboBox.FormattingEnabled = true;
            this.TransportControlComboBox.Items.AddRange(new object[] {
            "Машина",
            "Гибрид",
            "Вертолет"});
            this.TransportControlComboBox.Location = new System.Drawing.Point(3, 26);
            this.TransportControlComboBox.Name = "TransportControlComboBox";
            this.TransportControlComboBox.Size = new System.Drawing.Size(121, 21);
            this.TransportControlComboBox.TabIndex = 3;
            this.TransportControlComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportControlComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите транспорт";
            // 
            // hybridCarControl1
            // 
            this.hybridCarControl1.Location = new System.Drawing.Point(3, 53);
            this.hybridCarControl1.Name = "hybridCarControl1";
            this.hybridCarControl1.Size = new System.Drawing.Size(150, 270);
            this.hybridCarControl1.TabIndex = 2;
            // 
            // helicopterControl1
            // 
            this.helicopterControl1.Location = new System.Drawing.Point(3, 45);
            this.helicopterControl1.Name = "helicopterControl1";
            this.helicopterControl1.Size = new System.Drawing.Size(150, 273);
            this.helicopterControl1.TabIndex = 1;
            // 
            // carControl1
            // 
            this.carControl1.Location = new System.Drawing.Point(3, 48);
            this.carControl1.Name = "carControl1";
            this.carControl1.Size = new System.Drawing.Size(150, 270);
            this.carControl1.TabIndex = 0;
            // 
            // TransportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransportControlComboBox);
            this.Controls.Add(this.hybridCarControl1);
            this.Controls.Add(this.helicopterControl1);
            this.Controls.Add(this.carControl1);
            this.Name = "TransportControl";
            this.Size = new System.Drawing.Size(174, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarControl carControl1;
        private HelicopterControl helicopterControl1;
        private HybridCarControl hybridCarControl1;
        private System.Windows.Forms.ComboBox TransportControlComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
