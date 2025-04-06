namespace FloorAndCarpetApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCustomerData = new System.Windows.Forms.Label();
            this.lblInvoiceText = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerData
            // 
            this.lblCustomerData.AutoSize = true;
            this.lblCustomerData.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerData.Location = new System.Drawing.Point(13, 13);
            this.lblCustomerData.Name = "lblCustomerData";
            this.lblCustomerData.Size = new System.Drawing.Size(0, 19);
            this.lblCustomerData.TabIndex = 0;
            // 
            // lblInvoiceText
            // 
            this.lblInvoiceText.AutoSize = true;
            this.lblInvoiceText.Font = new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceText.Location = new System.Drawing.Point(13, 133);
            this.lblInvoiceText.Name = "lblInvoiceText";
            this.lblInvoiceText.Size = new System.Drawing.Size(0, 19);
            this.lblInvoiceText.TabIndex = 1;
            // 
            // picBox
            // 
            this.picBox.Image = global::FloorAndCarpetApp.Properties.Resources.Pic11;
            this.picBox.Location = new System.Drawing.Point(428, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(753, 709);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Silver;
            this.btnPrint.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 659);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 63);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 734);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblInvoiceText);
            this.Controls.Add(this.lblCustomerData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Crooked Flooring Invoice";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerData;
        private System.Windows.Forms.Label lblInvoiceText;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnPrint;
    }
}