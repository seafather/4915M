using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M.StoreUI
{
    public partial class itemConfirmUI : Form
    {
        private ListViewItem item;
        public itemConfirmUI()
        {
            InitializeComponent();
            LoaditemDatail();

            txtAddress.AutoSize = false;
            txtAddress.Height = 50;

        }

        private void LoaditemDatail()
        {
            using ( var db = new )
            {

            }


                item = new ListViewItem();
            item.Text = "number";
            item.SubItems.Add("name");
            item.SubItems.Add("Qty");
            item.SubItems.Add("Invetory Qty");
            listViewIItem.Items.Add(item);

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeProgram();
        }
        private void closeProgram()
        {
            this.Close();
        }
    }
}
