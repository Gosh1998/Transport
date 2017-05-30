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
    public partial class CarControl : UserControl
    {
        public CarControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация полей машины
        /// </summary>
        public Car Car
        {
            get
            {
                var car = new Car();
                car.TransportName = NameCarTextBox.Text;
                car.Distance = Convert.ToInt32(SpacingCarTextBox.Text);
                car.TheCurrentAmountOfFuel = Convert.ToDouble(CurentFuelCarTextBox.Text);
                return car;
            }
            set
            {
                NameCarTextBox.Text = value.TransportName;
                CurentFuelCarTextBox.Text = value.TheCurrentAmountOfFuel.ToString();
                SpacingCarTextBox.Text = value.Distance.ToString();
            }
        }

    }
}
