namespace InventoryManagementSystem
{
    partial class AddPurchaseOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpPurchaseOrder = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearPOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPQuantity = new System.Windows.Forms.TextBox();
            this.txtPItemID = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPurchaseOrder
            // 
            this.dtpPurchaseOrder.Location = new System.Drawing.Point(380, 245);
            this.dtpPurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPurchaseOrder.Name = "dtpPurchaseOrder";
            this.dtpPurchaseOrder.Size = new System.Drawing.Size(204, 22);
            this.dtpPurchaseOrder.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 82);
            this.panel1.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(136, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "New Purchase Order Details";
            // 
            // btnClearPOrder
            // 
            this.btnClearPOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPOrder.Location = new System.Drawing.Point(339, 310);
            this.btnClearPOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearPOrder.Name = "btnClearPOrder";
            this.btnClearPOrder.Size = new System.Drawing.Size(115, 46);
            this.btnClearPOrder.TabIndex = 47;
            this.btnClearPOrder.Text = "Clear";
            this.btnClearPOrder.UseVisualStyleBackColor = true;
            this.btnClearPOrder.Click += new System.EventHandler(this.btnClearPOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Item ID";
            // 
            // txtPQuantity
            // 
            this.txtPQuantity.Location = new System.Drawing.Point(51, 245);
            this.txtPQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.Size = new System.Drawing.Size(205, 22);
            this.txtPQuantity.TabIndex = 43;
            // 
            // txtPItemID
            // 
            this.txtPItemID.Location = new System.Drawing.Point(380, 153);
            this.txtPItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPItemID.Name = "txtPItemID";
            this.txtPItemID.Size = new System.Drawing.Size(205, 22);
            this.txtPItemID.TabIndex = 42;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(51, 153);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(205, 22);
            this.txtSupplierID.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Supplier ID";
            // 
            // btnSavePOrder
            // 
            this.btnSavePOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePOrder.Location = new System.Drawing.Point(168, 310);
            this.btnSavePOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePOrder.Name = "btnSavePOrder";
            this.btnSavePOrder.Size = new System.Drawing.Size(108, 46);
            this.btnSavePOrder.TabIndex = 39;
            this.btnSavePOrder.Text = "Save";
            this.btnSavePOrder.UseVisualStyleBackColor = true;
            this.btnSavePOrder.Click += new System.EventHandler(this.btnSavePOrder_Click);
            // 
            // AddPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(637, 398);
            this.Controls.Add(this.dtpPurchaseOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearPOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPQuantity);
            this.Controls.Add(this.txtPItemID);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPurchaseOrder";
            this.Text = "Add Purchase Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPurchaseOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearPOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPQuantity;
        private System.Windows.Forms.TextBox txtPItemID;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePOrder;
    }
}