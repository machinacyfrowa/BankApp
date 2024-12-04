namespace BankApp
{
    partial class TransferHistory
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
            components = new System.ComponentModel.Container();
            TransferHistoryDataGrid = new DataGridView();
            TransferHistorySource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)TransferHistoryDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransferHistorySource).BeginInit();
            SuspendLayout();
            // 
            // TransferHistoryDataGrid
            // 
            TransferHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransferHistoryDataGrid.Dock = DockStyle.Top;
            TransferHistoryDataGrid.Location = new Point(0, 0);
            TransferHistoryDataGrid.Name = "TransferHistoryDataGrid";
            TransferHistoryDataGrid.Size = new Size(800, 224);
            TransferHistoryDataGrid.TabIndex = 0;
            // 
            // TransferHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TransferHistoryDataGrid);
            Name = "TransferHistory";
            Text = "TransferHistory";
            ((System.ComponentModel.ISupportInitialize)TransferHistoryDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransferHistorySource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TransferHistoryDataGrid;
        private BindingSource TransferHistorySource;
    }
}