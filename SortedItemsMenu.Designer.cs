namespace InventoryManagementSystem
{
    partial class SortedItemsMenu
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
            this.dgvSortedItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSortedItems
            // 
            this.dgvSortedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSortedItems.Location = new System.Drawing.Point(0, 0);
            this.dgvSortedItems.Name = "dgvSortedItems";
            this.dgvSortedItems.RowHeadersWidth = 51;
            this.dgvSortedItems.RowTemplate.Height = 24;
            this.dgvSortedItems.Size = new System.Drawing.Size(800, 450);
            this.dgvSortedItems.TabIndex = 0;
            // 
            // SortedItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSortedItems);
            this.Name = "SortedItemsMenu";
            this.Text = "Sort Result";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortedItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSortedItems;
    }
}