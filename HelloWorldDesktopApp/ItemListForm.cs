using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldDesktopApp
{
    public partial class ItemListForm : Form
    {
        public ItemListForm()
        {
            InitializeComponent();
        }

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutApp = new Form();
            AboutApp.Text = "Sample App for testing purposes";
            AboutApp.Show();
        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pop up add data form
            AddDataForm addDataForm = new AddDataForm();
            addDataForm.Show();
        }
    }
}
