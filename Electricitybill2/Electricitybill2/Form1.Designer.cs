namespace Electricitybill2
{
    partial class Form1
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
            this.txtunits = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lblcustomertype = new System.Windows.Forms.Label();
            this.lblunits = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.cmbcustype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtunits
            // 
            this.txtunits.Location = new System.Drawing.Point(481, 171);
            this.txtunits.Name = "txtunits";
            this.txtunits.Size = new System.Drawing.Size(219, 22);
            this.txtunits.TabIndex = 1;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(481, 246);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(219, 22);
            this.txttotal.TabIndex = 2;
            // 
            // lblcustomertype
            // 
            this.lblcustomertype.AutoSize = true;
            this.lblcustomertype.Location = new System.Drawing.Point(301, 109);
            this.lblcustomertype.Name = "lblcustomertype";
            this.lblcustomertype.Size = new System.Drawing.Size(99, 16);
            this.lblcustomertype.TabIndex = 3;
            this.lblcustomertype.Text = "Customer Type";
            // 
            // lblunits
            // 
            this.lblunits.AutoSize = true;
            this.lblunits.Location = new System.Drawing.Point(304, 176);
            this.lblunits.Name = "lblunits";
            this.lblunits.Size = new System.Drawing.Size(37, 16);
            this.lblunits.TabIndex = 4;
            this.lblunits.Text = "Units";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(304, 251);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(59, 16);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total Bill";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(624, 361);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(462, 361);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(307, 360);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // cmbcustype
            // 
            this.cmbcustype.FormattingEnabled = true;
            this.cmbcustype.Items.AddRange(new object[] {
            "Domestic customer",
            "Business customer"});
            this.cmbcustype.Location = new System.Drawing.Point(481, 109);
            this.cmbcustype.Name = "cmbcustype";
            this.cmbcustype.Size = new System.Drawing.Size(219, 24);
            this.cmbcustype.TabIndex = 9;
            this.cmbcustype.Text = "Select Customer Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbcustype);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblunits);
            this.Controls.Add(this.lblcustomertype);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtunits);
            this.Name = "Form1";
            this.Text = "Electricity Bill Calculater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtunits;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblcustomertype;
        private System.Windows.Forms.Label lblunits;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ComboBox cmbcustype;
    }
}

