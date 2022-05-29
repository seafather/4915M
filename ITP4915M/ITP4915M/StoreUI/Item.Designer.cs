
namespace ITP4915M.StoreUI
{
    partial class Item
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.labelItemQty = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxShopCart = new System.Windows.Forms.PictureBox();
            this.lableItemNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.Location = new System.Drawing.Point(461, 3);
            this.labelItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(45, 20);
            this.labelItemPrice.TabIndex = 9;
            this.labelItemPrice.Text = "$360";
            // 
            // labelItemQty
            // 
            this.labelItemQty.AutoSize = true;
            this.labelItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemQty.Location = new System.Drawing.Point(386, 3);
            this.labelItemQty.Margin = new System.Windows.Forms.Padding(0);
            this.labelItemQty.Name = "labelItemQty";
            this.labelItemQty.Size = new System.Drawing.Size(36, 20);
            this.labelItemQty.TabIndex = 8;
            this.labelItemQty.Text = "166";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(116, 0);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(62, 20);
            this.labelItemName.TabIndex = 7;
            this.labelItemName.Text = "testdsa";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 10);
            this.label1.TabIndex = 11;
            this.label1.Text = "—————————————————————————————————————————————————————————————————————————————————" +
    "————————————————————————————————\r\n";
            // 
            // pictureBoxShopCart
            // 
            this.pictureBoxShopCart.BackgroundImage = global::ITP4915M.Properties.Resources.shopping_cart;
            this.pictureBoxShopCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShopCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShopCart.Location = new System.Drawing.Point(540, -2);
            this.pictureBoxShopCart.Name = "pictureBoxShopCart";
            this.pictureBoxShopCart.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxShopCart.TabIndex = 12;
            this.pictureBoxShopCart.TabStop = false;
            this.pictureBoxShopCart.Tag = "123";
            this.pictureBoxShopCart.Click += new System.EventHandler(this.pictureBoxShopCart_Click);
            // 
            // lableItemNum
            // 
            this.lableItemNum.AutoSize = true;
            this.lableItemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableItemNum.Location = new System.Drawing.Point(14, 0);
            this.lableItemNum.Margin = new System.Windows.Forms.Padding(0);
            this.lableItemNum.Name = "lableItemNum";
            this.lableItemNum.Size = new System.Drawing.Size(63, 20);
            this.lableItemNum.TabIndex = 6;
            this.lableItemNum.Text = "316548";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxShopCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelItemPrice);
            this.Controls.Add(this.labelItemQty);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.lableItemNum);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(610, 33);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.Label labelItemQty;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxShopCart;
        private System.Windows.Forms.Label lableItemNum;

    }
}
