using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void closeProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void DisableButton()
        {
            foreach (Control currentBtn in panelMenu.Controls)
            {
                if (currentBtn.GetType() == typeof(Button))
                {
                    currentBtn.Enabled = true;
                    currentBtn.BackColor = Color.FromArgb(19, 211, 172);
                    currentBtn.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void ActivateButton(object Sender)
        {
            if (Sender == null) return;

            DisableButton();
            Button currentBtn = (Button)Sender;

            currentBtn.Enabled = false;
            currentBtn.BackColor = Color.FromArgb(22, 253, 206);
            currentBtn.ForeColor = Color.FromArgb(31, 153, 206);
            clearSubForm();

        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            loadSubForm(new store(), sender);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void clearSubForm()
        {
            PanelShowSubForm.Controls.Clear();
        }

        private void loadSubForm(UserControl subFrom, object sender)
        {
            ActivateButton(sender);

            PanelShowSubForm.Controls.Add(subFrom);

        }

    }


}
