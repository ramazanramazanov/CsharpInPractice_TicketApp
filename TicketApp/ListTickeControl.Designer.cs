namespace TicketSystemApp
{
    partial class ListTickeControl
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
            this.ticketListGrid = new System.Windows.Forms.DataGridView();
            this.btn_UpdateTicket = new System.Windows.Forms.Button();
            this.txbx_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketListGrid
            // 
            this.ticketListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketListGrid.Location = new System.Drawing.Point(12, 14);
            this.ticketListGrid.Name = "ticketListGrid";
            this.ticketListGrid.Size = new System.Drawing.Size(719, 189);
            this.ticketListGrid.TabIndex = 0;
            this.ticketListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketListGrid_CellClick);
            this.ticketListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketListGrid_CellContentClick);
            // 
            // btn_UpdateTicket
            // 
            this.btn_UpdateTicket.Location = new System.Drawing.Point(129, 429);
            this.btn_UpdateTicket.Name = "btn_UpdateTicket";
            this.btn_UpdateTicket.Size = new System.Drawing.Size(85, 34);
            this.btn_UpdateTicket.TabIndex = 5;
            this.btn_UpdateTicket.Text = "Update Ticket";
            this.btn_UpdateTicket.UseVisualStyleBackColor = true;
            this.btn_UpdateTicket.Click += new System.EventHandler(this.btn_UpdateTicket_Click);
            // 
            // txbx_Description
            // 
            this.txbx_Description.Location = new System.Drawing.Point(12, 280);
            this.txbx_Description.Multiline = true;
            this.txbx_Description.Name = "txbx_Description";
            this.txbx_Description.Size = new System.Drawing.Size(291, 143);
            this.txbx_Description.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txbx_Title
            // 
            this.txbx_Title.Location = new System.Drawing.Point(12, 227);
            this.txbx_Title.Name = "txbx_Title";
            this.txbx_Title.Size = new System.Drawing.Size(291, 20);
            this.txbx_Title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // ListTickeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbx_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_UpdateTicket);
            this.Controls.Add(this.txbx_Title);
            this.Controls.Add(this.ticketListGrid);
            this.Controls.Add(this.label1);
            this.Name = "ListTickeControl";
            this.Size = new System.Drawing.Size(748, 473);
            this.Load += new System.EventHandler(this.ListTickeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ticketListGrid;
        public System.Windows.Forms.Button btn_UpdateTicket;
        public System.Windows.Forms.TextBox txbx_Description;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbx_Title;
        private System.Windows.Forms.Label label1;
    }
}
