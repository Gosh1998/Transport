using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Transport;

namespace WinForms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список 
        /// </summary>
        private List<ITransport> Transports;
        /// <summary>
        /// Флаг сохранения
        /// </summary>
        public bool _change = false;

        public MainForm()
        {
            InitializeComponent();
            Transports = new List<ITransport>();
            bindingSource1.DataSource = Transports;
        }
        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bindingSource1.Add(form.Transport);
            }
            _change = true;
        }
        /// <summary>
        /// Изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int index = TransportGridView.SelectedCells[0].RowIndex;
            var form = new AddForm
            {
                Transport = Transports[index]
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                bindingSource1.RemoveAt(index);
                bindingSource1.Insert(index,form.Transport);
            }
            _change = true;
        }
        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            _change = true;
        }
        /// <summary>
        /// Открыть из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                Transports = Serialization.Deserialize(ofd.FileName);
                bindingSource1.DataSource = Transports;
            }
            _change = false;
        }
        /// <summary>
        /// Сохранить из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                _change = false;
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }
        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transports = new List<ITransport>();
            bindingSource1.DataSource = Transports;

        }
        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// При закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Transports.Count != 0 && _change!=false)
            {
                var dialog = MessageBox.Show(@"Сохранить изменения?", @"Предупреждение",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                switch(dialog)
                {
                    case DialogResult.Yes:
                        {
                            var ofd = new SaveFileDialog
                            {
                                Filter = @"txt files (*.dat)|*.dat",
                                RestoreDirectory = true
                            };
                            Serialization.Serialize(ofd.FileName, Transports);
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// Сохранить как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"txt file (*.dat)|*.dat";
            saveFileDialog.RestoreDirectory = true;
            if(Transports.Count != 0)
            {
                Serialization.Serialize(saveFileDialog.FileName, Transports);
                _change = false;
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }
    }
}