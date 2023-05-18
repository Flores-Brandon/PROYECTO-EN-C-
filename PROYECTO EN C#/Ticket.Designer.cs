namespace PROYECTO_EN_C_
{
    partial class Ticket
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
            this.lblTicket = new System.Windows.Forms.Label();
            this.btnGenerarTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicket
            // 
            this.lblTicket.Location = new System.Drawing.Point(176, 137);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(449, 275);
            this.lblTicket.TabIndex = 4;
            this.lblTicket.Click += new System.EventHandler(this.lblTicket_Click);
            // 
            // btnGenerarTicket
            // 
            this.btnGenerarTicket.Location = new System.Drawing.Point(301, 38);
            this.btnGenerarTicket.Name = "btnGenerarTicket";
            this.btnGenerarTicket.Size = new System.Drawing.Size(135, 55);
            this.btnGenerarTicket.TabIndex = 3;
            this.btnGenerarTicket.Text = "CERRAR APP";
            this.btnGenerarTicket.UseVisualStyleBackColor = true;
            this.btnGenerarTicket.Click += new System.EventHandler(this.btnGenerarTicket_Click_1);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.btnGenerarTicket);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblTicket;
        internal System.Windows.Forms.Button btnGenerarTicket;
    }
}