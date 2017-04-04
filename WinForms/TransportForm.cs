using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport;

namespace WinForms
{
    public partial class AddForm : Form
    {
        private ITransport _transport;
        /// <summary>
        /// Создание и изменение транспортов
        /// </summary>
        public ITransport Transport
        {
            get
            {
                if (TransportComboBox.SelectedIndex == 0)
                {
                    var car = new Car
                    {
                        Distance = Convert.ToInt32(SpacingCarTextBox.Text),
                        TheCurrentAmountOfFuel = Convert.ToInt32(CurentFuelCarTextBox.Text),
                        TransportName = Convert.ToString(NameCarTextBox.Text)
                    };
                    _transport = car;
                }
                else if (TransportComboBox.SelectedIndex == 1)
                {
                    var hybrid = new HybridCar
                    {
                        TransportName = Convert.ToString(NameHybridTextBox.Text),
                        Distance = Convert.ToInt32(SpacingHybridTextBox.Text),
                        CurrentAmountOfElectricity = Convert.ToDouble(ElectricityHybridTextBox.Text),
                        PowerOfBattery = Convert.ToInt32(PowerHybridTextBox.Text),
                        TheCurrentAmountOfFuel = Convert.ToDouble(FuelHybridTextBox.Text)
                    };
                    _transport = hybrid;
                }
                else if (TransportComboBox.SelectedIndex == 2)
                {
                    var helicopter = new Helicopter
                    {
                        TransportName = Convert.ToString(NameHelicopterTextBox.Text),
                        Distance = Convert.ToInt32(SpacingHelicopterTextBox.Text),
                        FuelConsumption = Convert.ToDouble(FuelHelicopterTextBox.Text),
                        VolumeOfTheTank = Convert.ToInt32(VolumeHelicopterTextBox.Text)

                    };
                    _transport = helicopter;
                }
                    return _transport;
            }
            set
            {
                if (value is Car)
                {
                    var car = (Car) value;
                    TransportComboBox.SelectedIndex = 0;
                    TransportComboBox.Enabled = false;
                    CarGroupBox.Visible = true;
                    HelicopterGroupBox.Visible = false;
                    HybridCarGroupBox.Visible = false;
                    CarGroupBox.Location = new Point(10, 65);
                    CurentFuelCarTextBox.Text = car.TheCurrentAmountOfFuel.ToString(CultureInfo.InvariantCulture);
                    SpacingCarTextBox.Text = car.Distance.ToString(CultureInfo.InvariantCulture);
                    NameCarTextBox.Text = car.TransportName;
                }
                else if (value is HybridCar)
                {
                    var hybrid = (HybridCar) value;
                    TransportComboBox.SelectedIndex = 1;
                    TransportComboBox.Enabled = false;
                    HybridCarGroupBox.Visible = true;
                    HelicopterGroupBox.Visible = false;
                    CarGroupBox.Visible = false;
                    HybridCarGroupBox.Location = new Point(10, 65);
                    NameHybridTextBox.Text = hybrid.TransportName;
                    FuelHybridTextBox.Text = hybrid.TheCurrentAmountOfFuel.ToString(CultureInfo.InvariantCulture);
                    SpacingHybridTextBox.Text = hybrid.Distance.ToString(CultureInfo.InvariantCulture);
                    PowerHybridTextBox.Text=hybrid.PowerOfBattery.ToString(CultureInfo.InvariantCulture);
                    ElectricityHybridTextBox.Text=hybrid.CurrentAmountOfElectricity.ToString(CultureInfo.InvariantCulture);

                }
                else if (value is Helicopter)
                {
                    var helicopter = (Helicopter) value;
                    TransportComboBox.SelectedIndex = 2;
                    TransportComboBox.Enabled = false;
                    HelicopterGroupBox.Visible = true;
                    CarGroupBox.Visible = false;
                    HybridCarGroupBox.Visible = false;
                    HelicopterGroupBox.Location = new Point(10, 65);
                    NameHelicopterTextBox.Text = helicopter.TransportName;
                    FuelHelicopterTextBox.Text=helicopter.FuelConsumption.ToString(CultureInfo.InvariantCulture);
                    VolumeHelicopterTextBox.Text=helicopter.VolumeOfTheTank.ToString(CultureInfo.InvariantCulture);
                    SpacingHelicopterTextBox.Text=helicopter.Distance.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            if (TransportComboBox.Enabled)
            {
                CarGroupBox.Visible = false;
                CarGroupBox.Location= new Point(10, 65);
                HybridCarGroupBox.Visible = false;
                HybridCarGroupBox.Location = new Point(10, 65);
                HelicopterGroupBox.Visible = false;
                HelicopterGroupBox.Location = new Point(10, 65);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TransportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportComboBox.SelectedIndex == 0)
            {
                CarGroupBox.Visible = true;
                HybridCarGroupBox.Visible = false;
                HelicopterGroupBox.Visible = false;
            }
            else if (TransportComboBox.SelectedIndex == 1)
            {
                CarGroupBox.Visible = false;
                HybridCarGroupBox.Visible = true;
                HelicopterGroupBox.Visible = false;
            }
            else if (TransportComboBox.SelectedIndex == 2)
            {
                CarGroupBox.Visible = false;
                HybridCarGroupBox.Visible = false;
                HelicopterGroupBox.Visible = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
