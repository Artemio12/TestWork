namespace TestWork
{
    partial class PromotedEmployees
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
            this.excelOutputButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.promotedDataGrid = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.executeButton = new System.Windows.Forms.Button();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promotedDataGrid)).BeginInit();
            this.requestPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // excelOutputButton
            // 
            this.excelOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excelOutputButton.Location = new System.Drawing.Point(671, 353);
            this.excelOutputButton.Name = "excelOutputButton";
            this.excelOutputButton.Size = new System.Drawing.Size(117, 85);
            this.excelOutputButton.TabIndex = 1;
            this.excelOutputButton.Text = "Output in Excel";
            this.excelOutputButton.UseVisualStyleBackColor = true;
            this.excelOutputButton.Click += new System.EventHandler(this.ExcelOutputButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(671, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 50);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear all";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(671, 68);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 50);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // promotedDataGrid
            // 
            this.promotedDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotedDataGrid.Location = new System.Drawing.Point(12, 12);
            this.promotedDataGrid.Name = "promotedDataGrid";
            this.promotedDataGrid.ReadOnly = true;
            this.promotedDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.promotedDataGrid.Size = new System.Drawing.Size(653, 335);
            this.promotedDataGrid.TabIndex = 23;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(671, 171);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(117, 50);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // requestPanel
            // 
            this.requestPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestPanel.Controls.Add(this.executeButton);
            this.requestPanel.Controls.Add(this.requestTextBox);
            this.requestPanel.Controls.Add(this.label2);
            this.requestPanel.Location = new System.Drawing.Point(12, 353);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(653, 85);
            this.requestPanel.TabIndex = 41;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Location = new System.Drawing.Point(19, 34);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(617, 40);
            this.executeButton.TabIndex = 33;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestTextBox.Location = new System.Drawing.Point(89, 8);
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(547, 20);
            this.requestTextBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Request";
            // 
            // PromotedEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestPanel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.promotedDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.excelOutputButton);
            this.Name = "PromotedEmployees";
            this.Text = "PromotedEmployees";
            this.Load += new System.EventHandler(this.PromotedEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promotedDataGrid)).EndInit();
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button excelOutputButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView promotedDataGrid;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label label2;
    }
}