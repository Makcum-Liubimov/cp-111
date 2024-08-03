namespace CP_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Label userTypeLabel;

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
            this.showDataButton = new System.Windows.Forms.Button();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showDataButton
            // 
            this.showDataButton.Location = new System.Drawing.Point(12, 50);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(150, 23);
            this.showDataButton.TabIndex = 0;
            this.showDataButton.Text = "Показати розклад";
            this.showDataButton.UseVisualStyleBackColor = true;
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 16;
            this.dataListBox.Location = new System.Drawing.Point(12, 80);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(776, 388);
            this.dataListBox.TabIndex = 1;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Location = new System.Drawing.Point(12, 20);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(0, 17);
            this.userTypeLabel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.showDataButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
