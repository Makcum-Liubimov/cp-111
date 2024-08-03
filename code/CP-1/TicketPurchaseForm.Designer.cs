namespace CP_1
{
    partial class TicketPurchaseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox daysComboBox;
        private System.Windows.Forms.Button purchaseButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.daysComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysComboBox
            // 
            this.daysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daysComboBox.FormattingEnabled = true;
            this.daysComboBox.Location = new System.Drawing.Point(12, 12);
            this.daysComboBox.Name = "daysComboBox";
            this.daysComboBox.Size = new System.Drawing.Size(260, 24);
            this.daysComboBox.TabIndex = 0;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(12, 42);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(260, 23);
            this.purchaseButton.TabIndex = 1;
            this.purchaseButton.Text = "Придбати";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // TicketPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.daysComboBox);
            this.Name = "TicketPurchaseForm";
            this.Text = "Придбати квиток";
            this.ResumeLayout(false);
        }
    }
}
