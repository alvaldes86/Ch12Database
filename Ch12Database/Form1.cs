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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'cDInventory_20171_CDInventory.CDInventory' table. You can move, or remove it, as needed.
                this.cDInventoryTableAdapter.Fill
                    (this.cDInventory_20171_CDInventory.CDInventory);
            }
            catch (Exception ex)          
            {

                MessageBox.Show("Error: " + ex.ToString(), "Database Error");
            }

        }
    }
}
