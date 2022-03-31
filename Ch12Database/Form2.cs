using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12Database
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cDInventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cDInventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cDInventory_20171_CDInventory);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            try
            {
                // TODO: This line of code loads data into the 'cDInventory_20171_CDInventory.CDInventory' table. You can move, or remove it, as needed.
                this.cDInventoryTableAdapter.Fill
                    (this.cDInventory_20171_CDInventory.CDInventory);

            }
            catch (Exception ex)
            {

               
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            DetailsForm myForm = new DetailsForm();
            myForm.ShowDialog();
        }

        private void fillByJazzToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cDInventoryTableAdapter.FillByJazz
                    (this.cDInventory_20171_CDInventory.CDInventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'cDInventory_20171_CDInventory.CDInventory' table. You can move, or remove it, as needed.
                this.cDInventoryTableAdapter.Fill
                    (this.cDInventory_20171_CDInventory.CDInventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'cDInventory_20171_CDInventory.CDInventory' table. You can move, or remove it, as needed.
                this.cDInventoryTableAdapter.FillByGenreId
                    (this.cDInventory_20171_CDInventory.CDInventory, int.Parse(toolStripTextBoxGenre.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
