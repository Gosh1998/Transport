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
    public partial class HelicopterControl : UserControl
    {
        public HelicopterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация полей вертолета
        /// </summary>
        public Helicopter Helicopter
        {
            get
            {
                var helicopter = new Helicopter();
                helicopter.TransportName = NameHelicopterTextBox.Text;
                helicopter.Distance = Convert.ToInt32(SpacingHelicopterTextBox.Text);
                helicopter.VolumeOfTheTank = Convert.ToInt32(VolumeHelicopterTextBox.Text);
                helicopter.FuelConsumption = Convert.ToDouble(FuelHelicopterTextBox.Text);
                return helicopter;
            }
            set
            {
                NameHelicopterTextBox.Text = value.TransportName;
                SpacingHelicopterTextBox.Text = value.Distance.ToString();
                VolumeHelicopterTextBox.Text = value.VolumeOfTheTank.ToString();
                FuelHelicopterTextBox.Text = value.FuelConsumption.ToString();
            }
        }
    }
}
