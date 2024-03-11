namespace TestWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.openPromotedButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.reloadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionStrTextBox = new System.Windows.Forms.TextBox();
            this.checkLoadButton = new System.Windows.Forms.Button();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.refreshPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.actionPanel.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.requestPanel.SuspendLayout();
            this.refreshPanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.AutoSize = true;
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionPanel.Controls.Add(this.label4);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Controls.Add(this.openPromotedButton);
            this.actionPanel.Enabled = false;
            this.actionPanel.Location = new System.Drawing.Point(10, 22);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(168, 192);
            this.actionPanel.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Action panel";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(3, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 40);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // openPromotedButton
            // 
            this.openPromotedButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openPromotedButton.Location = new System.Drawing.Point(3, 84);
            this.openPromotedButton.Name = "openPromotedButton";
            this.openPromotedButton.Size = new System.Drawing.Size(160, 40);
            this.openPromotedButton.TabIndex = 19;
            this.openPromotedButton.Text = "Open Promoted Employees";
            this.openPromotedButton.UseVisualStyleBackColor = true;
            this.openPromotedButton.Click += new System.EventHandler(this.OpenPromotedButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.Location = new System.Drawing.Point(3, 37);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 40);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            // connectionPanel
            // 
            this.connectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionPanel.AutoSize = true;
            this.connectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionPanel.Controls.Add(this.reloadButton);
            this.connectionPanel.Controls.Add(this.label3);
            this.connectionPanel.Controls.Add(this.connectionStrTextBox);
            this.connectionPanel.Controls.Add(this.checkLoadButton);
            this.connectionPanel.Location = new System.Drawing.Point(602, 22);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(186, 187);
            this.connectionPanel.TabIndex = 36;
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reloadButton.Enabled = false;
            this.reloadButton.Location = new System.Drawing.Point(3, 142);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(176, 40);
            this.reloadButton.TabIndex = 25;
            this.reloadButton.Text = "Reconnect";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Connection panel";
            // 
            // connectionStrTextBox
            // 
            this.connectionStrTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.connectionStrTextBox.Location = new System.Drawing.Point(3, 36);
            this.connectionStrTextBox.Name = "connectionStrTextBox";
            this.connectionStrTextBox.Size = new System.Drawing.Size(176, 20);
            this.connectionStrTextBox.TabIndex = 18;
            // 
            // checkLoadButton
            // 
            this.checkLoadButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkLoadButton.Location = new System.Drawing.Point(3, 62);
            this.checkLoadButton.Name = "checkLoadButton";
            this.checkLoadButton.Size = new System.Drawing.Size(176, 40);
            this.checkLoadButton.TabIndex = 20;
            this.checkLoadButton.Text = "Check/Load";
            this.checkLoadButton.UseVisualStyleBackColor = true;
            this.checkLoadButton.Click += new System.EventHandler(this.CheckLoadButton_Click);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestTextBox.Location = new System.Drawing.Point(89, 8);
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(672, 20);
            this.requestTextBox.TabIndex = 34;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Location = new System.Drawing.Point(19, 34);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(742, 40);
            this.executeButton.TabIndex = 33;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Location = new System.Drawing.Point(184, 22);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.ReadOnly = true;
            this.mainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGrid.Size = new System.Drawing.Size(412, 334);
            this.mainDataGrid.TabIndex = 39;
            this.mainDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGrid_CellContentDoubleClick);
            // 
            // requestPanel
            // 
            this.requestPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestPanel.Controls.Add(this.executeButton);
            this.requestPanel.Controls.Add(this.requestTextBox);
            this.requestPanel.Controls.Add(this.label2);
            this.requestPanel.Enabled = false;
            this.requestPanel.Location = new System.Drawing.Point(10, 362);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(778, 85);
            this.requestPanel.TabIndex = 40;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshButton.Location = new System.Drawing.Point(3, 46);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(176, 90);
            this.refreshButton.TabIndex = 26;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // refreshPanel
            // 
            this.refreshPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refreshPanel.Controls.Add(this.label1);
            this.refreshPanel.Controls.Add(this.refreshButton);
            this.refreshPanel.Enabled = false;
            this.refreshPanel.Location = new System.Drawing.Point(602, 215);
            this.refreshPanel.Name = "refreshPanel";
            this.refreshPanel.Size = new System.Drawing.Size(186, 141);
            this.refreshPanel.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Refresh table panel";
            // 
            // deletePanel
            // 
            this.deletePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletePanel.Controls.Add(this.label5);
            this.deletePanel.Controls.Add(this.clearButton);
            this.deletePanel.Controls.Add(this.deleteButton);
            this.deletePanel.Enabled = false;
            this.deletePanel.Location = new System.Drawing.Point(10, 220);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(168, 136);
            this.deletePanel.TabIndex = 42;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.Location = new System.Drawing.Point(3, 83);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 40);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear table";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Delete panel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.refreshPanel);
            this.Controls.Add(this.requestPanel);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.connectionPanel);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.requestPanel.ResumeLayout(false);
            this.requestPanel.PerformLayout();
            this.refreshPanel.ResumeLayout(false);
            this.refreshPanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button openPromotedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox connectionStrTextBox;
        private System.Windows.Forms.Button checkLoadButton;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel refreshPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
    }
}

