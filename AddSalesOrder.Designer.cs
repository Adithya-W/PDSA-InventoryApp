namespace InventoryManagementSystem
{
    partial class AddSalesOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearSOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQuantity = new System.Windows.Forms.TextBox();
            this.txtSItemID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveSOrder = new System.Windows.Forms.Button();
            this.dtpSalesOrder = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 82);
            this.panel1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(148, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "New Sales Order Details";
            // 
            // btnClearSOrder
            // 
            this.btnClearSOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSOrder.Location = new System.Drawing.Point(343, 351);
            this.btnClearSOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearSOrder.Name = "btnClearSOrder";
            this.btnClearSOrder.Size = new System.Drawing.Size(115, 46);
            this.btnClearSOrder.TabIndex = 36;
            this.btnClearSOrder.Text = "Clear";
            this.btnClearSOrder.UseVisualStyleBackColor = true;
            this.btnClearSOrder.Click += new System.EventHandler(this.btnClearSOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Item ID";
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.Location = new System.Drawing.Point(51, 277);
            this.txtSQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(205, 22);
            this.txtSQuantity.TabIndex = 31;
            // 
            // txtSItemID
            // 
            this.txtSItemID.Location = new System.Drawing.Point(381, 199);
            this.txtSItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSItemID.Name = "txtSItemID";
            this.txtSItemID.Size = new System.Drawing.Size(205, 22);
            this.txtSItemID.TabIndex = 30;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(51, 199);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(205, 22);
            this.txtCustomerID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customer ID";
            // 
            // btnSaveSOrder
            // 
            this.btnSaveSOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSOrder.Location = new System.Drawing.Point(168, 351);
            this.btnSaveSOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveSOrder.Name = "btnSaveSOrder";
            this.btnSaveSOrder.Size = new System.Drawing.Size(108, 46);
            this.btnSaveSOrder.TabIndex = 27;
            this.btnSaveSOrder.Text = "Save";
            this.btnSaveSOrder.UseVisualStyleBackColor = true;
            this.btnSaveSOrder.Click += new System.EventHandler(this.btnSaveSOrder_Click);
            // 
            // dtpSalesOrder
            // 
            this.dtpSalesOrder.Location = new System.Drawing.Point(381, 277);
            this.dtpSalesOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSalesOrder.Name = "dtpSalesOrder";
            this.dtpSalesOrder.Size = new System.Drawing.Size(204, 22);
            this.dtpSalesOrder.TabIndex = 38;
            // 
            // AddSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.dtpSalesOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearSOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSQuantity);
            this.Controls.Add(this.txtSItemID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveSOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddSalesOrder";
            this.Text = "Add Sales Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearSOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQuantity;
        private System.Windows.Forms.TextBox txtSItemID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveSOrder;
        private System.Windows.Forms.DateTimePicker dtpSalesOrder;
    }
}