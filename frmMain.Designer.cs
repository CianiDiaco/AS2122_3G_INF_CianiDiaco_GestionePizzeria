
namespace AS2122_3G_INF_CianiDiaco_GestionePizzeria
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblPizMarg = new System.Windows.Forms.Label();
            this.lblNumPizMarg = new System.Windows.Forms.Label();
            this.lblPizQuattroFormaggi = new System.Windows.Forms.Label();
            this.lblNumPizQuattroFormaggi = new System.Windows.Forms.Label();
            this.lblPizVerd = new System.Windows.Forms.Label();
            this.lblNumPizVerd = new System.Windows.Forms.Label();
            this.lblScelta = new System.Windows.Forms.Label();
            this.lblQuantità = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lstPizze = new System.Windows.Forms.ListBox();
            this.cmbScelta = new System.Windows.Forms.ComboBox();
            this.txtQuantità = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblPizMarg
            // 
            this.lblPizMarg.AutoSize = true;
            this.lblPizMarg.Location = new System.Drawing.Point(566, 249);
            this.lblPizMarg.Name = "lblPizMarg";
            this.lblPizMarg.Size = new System.Drawing.Size(94, 15);
            this.lblPizMarg.TabIndex = 0;
            this.lblPizMarg.Text = "Pizza margherita";
            // 
            // lblNumPizMarg
            // 
            this.lblNumPizMarg.AutoSize = true;
            this.lblNumPizMarg.Location = new System.Drawing.Point(704, 249);
            this.lblNumPizMarg.Name = "lblNumPizMarg";
            this.lblNumPizMarg.Size = new System.Drawing.Size(13, 15);
            this.lblNumPizMarg.TabIndex = 1;
            this.lblNumPizMarg.Text = "0";
            // 
            // lblPizQuattroFormaggi
            // 
            this.lblPizQuattroFormaggi.AutoSize = true;
            this.lblPizQuattroFormaggi.Location = new System.Drawing.Point(566, 311);
            this.lblPizQuattroFormaggi.Name = "lblPizQuattroFormaggi";
            this.lblPizQuattroFormaggi.Size = new System.Drawing.Size(127, 15);
            this.lblPizQuattroFormaggi.TabIndex = 2;
            this.lblPizQuattroFormaggi.Text = "Pizza quattro formaggi";
            // 
            // lblNumPizQuattroFormaggi
            // 
            this.lblNumPizQuattroFormaggi.AutoSize = true;
            this.lblNumPizQuattroFormaggi.Location = new System.Drawing.Point(704, 311);
            this.lblNumPizQuattroFormaggi.Name = "lblNumPizQuattroFormaggi";
            this.lblNumPizQuattroFormaggi.Size = new System.Drawing.Size(13, 15);
            this.lblNumPizQuattroFormaggi.TabIndex = 3;
            this.lblNumPizQuattroFormaggi.Text = "0";
            // 
            // lblPizVerd
            // 
            this.lblPizVerd.AutoSize = true;
            this.lblPizVerd.Location = new System.Drawing.Point(566, 373);
            this.lblPizVerd.Name = "lblPizVerd";
            this.lblPizVerd.Size = new System.Drawing.Size(99, 15);
            this.lblPizVerd.TabIndex = 4;
            this.lblPizVerd.Text = "Pizza con verdure";
            // 
            // lblNumPizVerd
            // 
            this.lblNumPizVerd.AutoSize = true;
            this.lblNumPizVerd.Location = new System.Drawing.Point(704, 373);
            this.lblNumPizVerd.Name = "lblNumPizVerd";
            this.lblNumPizVerd.Size = new System.Drawing.Size(13, 15);
            this.lblNumPizVerd.TabIndex = 5;
            this.lblNumPizVerd.Text = "0";
            // 
            // lblScelta
            // 
            this.lblScelta.AutoSize = true;
            this.lblScelta.Location = new System.Drawing.Point(42, 51);
            this.lblScelta.Name = "lblScelta";
            this.lblScelta.Size = new System.Drawing.Size(72, 15);
            this.lblScelta.TabIndex = 6;
            this.lblScelta.Text = "Tipo di pizza";
            // 
            // lblQuantità
            // 
            this.lblQuantità.AutoSize = true;
            this.lblQuantità.Location = new System.Drawing.Point(42, 249);
            this.lblQuantità.Name = "lblQuantità";
            this.lblQuantità.Size = new System.Drawing.Size(53, 15);
            this.lblQuantità.TabIndex = 7;
            this.lblQuantità.Text = "Quantità";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(329, 47);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // lstPizze
            // 
            this.lstPizze.FormattingEnabled = true;
            this.lstPizze.ItemHeight = 15;
            this.lstPizze.Location = new System.Drawing.Point(566, 51);
            this.lstPizze.Name = "lstPizze";
            this.lstPizze.Size = new System.Drawing.Size(176, 154);
            this.lstPizze.TabIndex = 9;
            // 
            // cmbScelta
            // 
            this.cmbScelta.FormattingEnabled = true;
            this.cmbScelta.Items.AddRange(new object[] {
            "Pizza margherita",
            "Pizza quattro formaggi",
            "Pizza con verdure"});
            this.cmbScelta.Location = new System.Drawing.Point(138, 48);
            this.cmbScelta.Name = "cmbScelta";
            this.cmbScelta.Size = new System.Drawing.Size(121, 23);
            this.cmbScelta.TabIndex = 10;
            // 
            // txtQuantità
            // 
            this.txtQuantità.Location = new System.Drawing.Point(138, 246);
            this.txtQuantità.Name = "txtQuantità";
            this.txtQuantità.Size = new System.Drawing.Size(100, 23);
            this.txtQuantità.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.txtQuantità);
            this.Controls.Add(this.cmbScelta);
            this.Controls.Add(this.lstPizze);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lblQuantità);
            this.Controls.Add(this.lblScelta);
            this.Controls.Add(this.lblNumPizVerd);
            this.Controls.Add(this.lblPizVerd);
            this.Controls.Add(this.lblNumPizQuattroFormaggi);
            this.Controls.Add(this.lblPizQuattroFormaggi);
            this.Controls.Add(this.lblNumPizMarg);
            this.Controls.Add(this.lblPizMarg);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblPizMarg;
        private System.Windows.Forms.Label lblNumPizMarg;
        private System.Windows.Forms.Label lblPizQuattroFormaggi;
        private System.Windows.Forms.Label lblNumPizQuattroFormaggi;
        private System.Windows.Forms.Label lblPizVerd;
        private System.Windows.Forms.Label lblNumPizVerd;
        private System.Windows.Forms.Label lblScelta;
        private System.Windows.Forms.Label lblQuantità;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ListBox lstPizze;
        private System.Windows.Forms.ComboBox cmbScelta;
        private System.Windows.Forms.TextBox txtQuantità;
    }
}

