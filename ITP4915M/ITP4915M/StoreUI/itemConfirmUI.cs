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
                        listViewIItem.Items.Add(item);

                    }

                });
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeProgram();
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
    }
}
