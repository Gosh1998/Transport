using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport;

namespace WinForms.Controls
{
    public partial class HybridCarControl : UserControl
    {
        public HybridCarControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Инициализация полей гибрид-машины
        /// </summary>
        
        public HybridCar HybridCar
        {
            get
            {
                var hybrid = new HybridCar();
                hybrid.TransportName = NameHybridTextBox.Text;
                hybrid.Distance = Convert.ToInt32(SpacingHybridTextBox.Text);
                hybrid.ElectricityConsumption = Convert.ToInt32(ElectricityHybridTextBox.Text);
                hybrid.PowerOfBattery = Convert.ToInt32(PowerHybridTextBox.Text);
                hybrid.TheCurrentAmountOfFuel = Convert.ToDouble(FuelHybridTextBox.Text);
                hybrid.CurrentAmountOfElectricity = Convert.ToInt32(TheCurrentOfElectricityTextBox.Text);
                return hybrid;
            }
            set
            {
                NameHybridTextBox.Text = value.TransportName;
                SpacingHybridTextBox.Text = value.Distance.ToString();
                ElectricityHybridTextBox.Text = value.ElectricityConsumption.ToString();
                PowerHybridTextBox.Text = value.PowerOfBattery.ToString();
                FuelHybridTextBox.Text = value.TheCurrentAmountOfFuel.ToString();
                TheCurrentOfElectricityTextBox.Text = value.CurrentAmountOfElectricity.ToString();
            }
        }
    }
}
