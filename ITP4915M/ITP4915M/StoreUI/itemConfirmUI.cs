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
            //DataGridViewRow row = new DataGridViewRow();
            DataTable table = new DataTable();
            table.Columns.Add("ColumnItemNum", Type.GetType("System.String"));
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Unit price", Type.GetType("System.Int16"));
            table.Columns.Add("Inventory Qty", Type.GetType("System.Int16"));
            table.Columns.Add("Qty", Type.GetType("System.Int16"));

            for(int i = 0; i < 20; i++)
            {
                DataRow drTemp = null;
                drTemp = table.NewRow();
                drTemp["ColumnItemNum"] = "111";
                drTemp["Name"] = "111";
                drTemp["Unit price"] = 123;
                drTemp["Inventory Qty"] = 123;
                drTemp["Qty"] = 123;
                table.Rows.Add(drTemp);
            }

            dataGridViewUI.DataSource = table;


            /*
            using ( var db = new better_shopEntities())
            {
                store.bePurchasedList.ForEach(id => {

                    var info = from i in db.items
                               where i.item_id == id
                               select i;

                    foreach (var data in info)
                    {
                        item = new ListViewItem();
                        item.Text = data.item_id;
                        item.SubItems.Add(data.item_name);
                        item.SubItems.Add(data.item_price.ToString());
                        item.SubItems.Add("i dont know");
                        item.SubItems.Add("tst");
                        //listViewIItem.Items.Add(item);

                    }

                })
            }*/

        }

        private void closeProgram()
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            submitOrder();
        }

        //to submit and create order
        private void submitOrder()
        {
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            closeProgram();
        }
    }
}
