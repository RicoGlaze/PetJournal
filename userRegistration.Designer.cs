namespace PetJournal
{
    partial class userRegistration
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
            this.usernameRegLbl = new System.Windows.Forms.Label();
            this.passwordRegLbl = new System.Windows.Forms.Label();
            this.passwordConfirmRegLbl = new System.Windows.Forms.Label();
            this.usernameRegTxt = new System.Windows.Forms.TextBox();
            this.passwordRegTxt = new System.Windows.Forms.TextBox();
            this.passwordConfirmRegTxt = new System.Windows.Forms.TextBox();
            this.userRegButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userRegSubmitBtn = new System.Windows.Forms.Button();
            this.userRegBackBtn = new System.Windows.Forms.Button();
            this.userRegButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameRegLbl
            // 
            this.usernameRegLbl.AutoSize = true;
            this.usernameRegLbl.Location = new System.Drawing.Point(37, 33);
            this.usernameRegLbl.Name = "usernameRegLbl";
            this.usernameRegLbl.Size = new System.Drawing.Size(83, 13);
            this.usernameRegLbl.TabIndex = 0;
            this.usernameRegLbl.Text = "Enter Username";
            // 
            // passwordRegLbl
            // 
            this.passwordRegLbl.AutoSize = true;
            this.passwordRegLbl.Location = new System.Drawing.Point(37, 67);
            this.passwordRegLbl.Name = "passwordRegLbl";
            this.passwordRegLbl.Size = new System.Drawing.Size(81, 13);
            this.passwordRegLbl.TabIndex = 1;
            this.passwordRegLbl.Text = "Enter Password";
            // 
            // passwordConfirmRegLbl
            // 
            this.passwordConfirmRegLbl.AutoSize = true;
            this.passwordConfirmRegLbl.Location = new System.Drawing.Point(37, 102);
            this.passwordConfirmRegLbl.Name = "passwordConfirmRegLbl";
            this.passwordConfirmRegLbl.Size = new System.Drawing.Size(91, 13);
            this.passwordConfirmRegLbl.TabIndex = 2;
            this.passwordConfirmRegLbl.Text = "Confirm Password";
            // 
            // usernameRegTxt
            // 
            this.usernameRegTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameRegTxt.Location = new System.Drawing.Point(146, 30);
            this.usernameRegTxt.Name = "usernameRegTxt";
            this.usernameRegTxt.Size = new System.Drawing.Size(350, 20);
            this.usernameRegTxt.TabIndex = 3;
            // 
            // passwordRegTxt
            // 
            this.passwordRegTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordRegTxt.Location = new System.Drawing.Point(146, 64);
            this.passwordRegTxt.Name = "passwordRegTxt";
            this.passwordRegTxt.Size = new System.Drawing.Size(350, 20);
            this.passwordRegTxt.TabIndex = 4;
            // 
            // passwordConfirmRegTxt
            // 
            this.passwordConfirmRegTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordConfirmRegTxt.Location = new System.Drawing.Point(146, 99);
            this.passwordConfirmRegTxt.Name = "passwordConfirmRegTxt";
            this.passwordConfirmRegTxt.Size = new System.Drawing.Size(350, 20);
            this.passwordConfirmRegTxt.TabIndex = 5;
            // 
            // userRegButtonPanel
            // 
            this.userRegButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userRegButtonPanel.ColumnCount = 2;
            this.userRegButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userRegButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userRegButtonPanel.Controls.Add(this.userRegSubmitBtn, 1, 0);
            this.userRegButtonPanel.Controls.Add(this.userRegBackBtn, 0, 0);
            this.userRegButtonPanel.Location = new System.Drawing.Point(40, 151);
            this.userRegButtonPanel.Name = "userRegButtonPanel";
            this.userRegButtonPanel.RowCount = 1;
            this.userRegButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userRegButtonPanel.Size = new System.Drawing.Size(456, 39);
            this.userRegButtonPanel.TabIndex = 6;
            // 
            // userRegSubmitBtn
            // 
            this.userRegSubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userRegSubmitBtn.Location = new System.Drawing.Point(231, 3);
            this.userRegSubmitBtn.Name = "userRegSubmitBtn";
            this.userRegSubmitBtn.Size = new System.Drawing.Size(222, 25);
            this.userRegSubmitBtn.TabIndex = 1;
            this.userRegSubmitBtn.Text = "Submit";
            this.userRegSubmitBtn.UseVisualStyleBackColor = true;
            this.userRegSubmitBtn.Click += new System.EventHandler(this.userRegSubmitBtn_Click);
            // 
            // userRegBackBtn
            // 
            this.userRegBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userRegBackBtn.Location = new System.Drawing.Point(3, 3);
            this.userRegBackBtn.Name = "userRegBackBtn";
            this.userRegBackBtn.Size = new System.Drawing.Size(222, 25);
            this.userRegBackBtn.TabIndex = 0;
            this.userRegBackBtn.Text = "Back";
            this.userRegBackBtn.UseVisualStyleBackColor = true;
            this.userRegBackBtn.Click += new System.EventHandler(this.userRegBackBtn_Click);
            // 
            // userRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.userRegButtonPanel);
            this.Controls.Add(this.passwordConfirmRegTxt);
            this.Controls.Add(this.passwordRegTxt);
            this.Controls.Add(this.usernameRegTxt);
            this.Controls.Add(this.passwordConfirmRegLbl);
            this.Controls.Add(this.passwordRegLbl);
            this.Controls.Add(this.usernameRegLbl);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "userRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.userRegistration_Load);
            this.userRegButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameRegLbl;
        private System.Windows.Forms.Label passwordRegLbl;
        private System.Windows.Forms.Label passwordConfirmRegLbl;
        private System.Windows.Forms.TextBox usernameRegTxt;
        private System.Windows.Forms.TextBox passwordRegTxt;
        private System.Windows.Forms.TextBox passwordConfirmRegTxt;
        private System.Windows.Forms.TableLayoutPanel userRegButtonPanel;
        private System.Windows.Forms.Button userRegBackBtn;
        private System.Windows.Forms.Button userRegSubmitBtn;
    }
}