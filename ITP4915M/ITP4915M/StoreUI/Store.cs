using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ITP4915M.StoreUI;

namespace ITP4915M
{
    public partial class store : UserControl
    {
        static public List<string> bePurchasedList;
        public store()
        {
            InitializeComponent();

            bePurchasedList = new List<string>();  //
            Loaditem();


        }

        private void Loaditem()
        {
            
            using (var dbContext = new better_shopEntities())
            {
                
                var info = from i in dbContext.items
                           select i;
                
                foreach(var item in info)
                {
                    String[] data = {item.item_id,item.item_name,item.item_price.ToString()};

                    Item itemControl = new Item(data);
                    flowLayoutPanelShowAllItems.Controls.Add(itemControl);

                }
            }




        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            openShoppingCart();
        }

        private void openShoppingCart()
        {
            itemConfirmUI UI = new itemConfirmUI();
            UI.ShowDialog();
        }
    }
}
