using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport;

namespace WinForms
{
    public partial class MainForm : Form
    {
        
        public List<ITransport> Transports;

        public MainForm()
        {
            InitializeComponent();
            Transports = new List<ITransport>();
            ITransportBindingSource.DataSource = Transports;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ITransportBindingSource.Add(form.Transport);
            }
        }
        
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int index = TransportDataGridView.SelectedCells[0].RowIndex;
            var form = new AddForm
            {
                Transport = Transports[index]
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                ITransportBindingSource.RemoveAt(index);
                ITransportBindingSource.Insert(index,form.Transport);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ITransportBindingSource.RemoveCurrent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                Transports = Serialization.Deserialize(ofd.FileName);
                ITransportBindingSource.DataSource = Transports;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Transports.Count != 0)
            {
                var ofd = new SaveFileDialog
                {
                    Filter = @"txt files (*.dat)|*.dat",
                    RestoreDirectory = true
                };
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, Transports);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}