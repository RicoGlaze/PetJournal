namespace PetJournal
{
    partial class userLogin
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
            this.usernameLoginLbl = new System.Windows.Forms.Label();
            this.passwordLoginLbl = new System.Windows.Forms.Label();
            this.userLoginPanelBtn = new System.Windows.Forms.TableLayoutPanel();
            this.userLoginExitBtn = new System.Windows.Forms.Button();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userLoginPanelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLoginLbl
            // 
            this.usernameLoginLbl.AutoSize = true;
            this.usernameLoginLbl.Location = new System.Drawing.Point(32, 25);
            this.usernameLoginLbl.Name = "usernameLoginLbl";
            this.usernameLoginLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLoginLbl.TabIndex = 0;
            this.usernameLoginLbl.Text = "Username";
            // 
            // passwordLoginLbl
            // 
            this.passwordLoginLbl.AutoSize = true;
            this.passwordLoginLbl.Location = new System.Drawing.Point(32, 56);
            this.passwordLoginLbl.Name = "passwordLoginLbl";
            this.passwordLoginLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLoginLbl.TabIndex = 1;
            this.passwordLoginLbl.Text = "Password";
            // 
            // userLoginPanelBtn
            // 
            this.userLoginPanelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLoginPanelBtn.ColumnCount = 2;
            this.userLoginPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userLoginPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userLoginPanelBtn.Controls.Add(this.userLoginExitBtn, 0, 0);
            this.userLoginPanelBtn.Controls.Add(this.userLoginBtn, 1, 0);
            this.userLoginPanelBtn.Location = new System.Drawing.Point(29, 94);
            this.userLoginPanelBtn.Name = "userLoginPanelBtn";
            this.userLoginPanelBtn.RowCount = 1;
            this.userLoginPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userLoginPanelBtn.Size = new System.Drawing.Size(456, 39);
            this.userLoginPanelBtn.TabIndex = 2;
            // 
            // userLoginExitBtn
            // 
            this.userLoginExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLoginExitBtn.Location = new System.Drawing.Point(3, 3);
            this.userLoginExitBtn.Name = "userLoginExitBtn";
            this.userLoginExitBtn.Size = new System.Drawing.Size(222, 25);
            this.userLoginExitBtn.TabIndex = 0;
            this.userLoginExitBtn.Text = "Exit";
            this.userLoginExitBtn.UseVisualStyleBackColor = true;
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLoginBtn.Location = new System.Drawing.Point(231, 3);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(222, 25);
            this.userLoginBtn.TabIndex = 1;
            this.userLoginBtn.Text = "Login";
            this.userLoginBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(111, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(111, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 20);
            this.textBox2.TabIndex = 4;
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userLoginPanelBtn);
            this.Controls.Add(this.passwordLoginLbl);
            this.Controls.Add(this.usernameLoginLbl);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "userLogin";
            this.Text = "Login";
            this.userLoginPanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLoginLbl;
        private System.Windows.Forms.Label passwordLoginLbl;
        private System.Windows.Forms.TableLayoutPanel userLoginPanelBtn;
        private System.Windows.Forms.Button userLoginExitBtn;
        private System.Windows.Forms.Button userLoginBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

