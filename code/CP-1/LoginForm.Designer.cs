namespace CP_1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RadioButton passengerRadioButton;
        private System.Windows.Forms.RadioButton driverRadioButton;

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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passengerRadioButton = new System.Windows.Forms.RadioButton();
            this.driverRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(100, 30);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 22);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(100, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(100, 150);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passengerRadioButton
            // 
            this.passengerRadioButton.AutoSize = true;
            this.passengerRadioButton.Location = new System.Drawing.Point(100, 110);
            this.passengerRadioButton.Name = "passengerRadioButton";
            this.passengerRadioButton.Size = new System.Drawing.Size(89, 21);
            this.passengerRadioButton.TabIndex = 2;
            this.passengerRadioButton.TabStop = true;
            this.passengerRadioButton.Text = "Пасажир";
            this.passengerRadioButton.UseVisualStyleBackColor = true;
            // 
            // driverRadioButton
            // 
            this.driverRadioButton.AutoSize = true;
            this.driverRadioButton.Location = new System.Drawing.Point(210, 110);
            this.driverRadioButton.Name = "driverRadioButton";
            this.driverRadioButton.Size = new System.Drawing.Size(83, 21);
            this.driverRadioButton.TabIndex = 3;
            this.driverRadioButton.TabStop = true;
            this.driverRadioButton.Text = "Машиніст";
            this.driverRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.driverRadioButton);
            this.Controls.Add(this.passengerRadioButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
