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
    public partial class TransportControl : UserControl
    {
        public TransportControl()
        {
            InitializeComponent();
            carControl1.Visible = false;
            helicopterControl1.Visible = false;
            hybridCarControl1.Visible = false;
        }

        /// <summary>
        /// Инициализация полей траспортов
        /// </summary>
        public ITransport Transports
        {
            get
            {
                ITransport transport = null;
                int check = TransportControlComboBox.SelectedIndex;
                switch(check)
                {
                    case 0 :
                        {
                            transport = carControl1.Car;
                            break;
                        }
                    case 1:
                        {
                            transport = hybridCarControl1.HybridCar;
                            break;
                        }
                    case 2:
                        {
                            transport = helicopterControl1.Helicopter;
                            break;
                        }

                }
                return transport;
            }
            set
            {
                if(value is Car)
                {
                    TransportControlComboBox.SelectedIndex = 0;
                    carControl1.Car = (Car)value;
                }
                
                else if (value is HybridCar)
                {
                    TransportControlComboBox.SelectedIndex = 1;
                    hybridCarControl1.HybridCar = (HybridCar)value;
                }

                else if (value is Helicopter)
                {
                    TransportControlComboBox.SelectedIndex = 2;
                    helicopterControl1.Helicopter = (Helicopter)value;
                }
            }
        }

        private void TransportControlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carControl1.Visible = (TransportControlComboBox.SelectedIndex == 0);
            hybridCarControl1.Visible = (TransportControlComboBox.SelectedIndex == 1);
            helicopterControl1.Visible = (TransportControlComboBox.SelectedIndex == 2);
        }
    }
}
