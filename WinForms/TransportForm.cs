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
        
        /// <summary>
        /// Создание и изменение транспортов
        /// </summary>
        public ITransport Transport
        {
            get
            {
                var cathThrowTransports = transportControl1.Transports; 
                return transportControl1.Transports;
            }
            set
            {
                transportControl1.Transports = value;
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                var a = this.Transport;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
