namespace PetJournal
{
    partial class userDash
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
            this.userDashPetPanelBtn = new System.Windows.Forms.TableLayoutPanel();
            this.userDashPetRegisterBtn = new System.Windows.Forms.Button();
            this.userDashPetPanelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDashPetPanelBtn
            // 
            this.userDashPetPanelBtn.ColumnCount = 1;
            this.userDashPetPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userDashPetPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userDashPetPanelBtn.Controls.Add(this.userDashPetRegisterBtn, 0, 0);
            this.userDashPetPanelBtn.Location = new System.Drawing.Point(10, 12);
            this.userDashPetPanelBtn.Name = "userDashPetPanelBtn";
            this.userDashPetPanelBtn.RowCount = 2;
            this.userDashPetPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userDashPetPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userDashPetPanelBtn.Size = new System.Drawing.Size(103, 218);
            this.userDashPetPanelBtn.TabIndex = 0;
            // 
            // userDashPetRegisterBtn
            // 
            this.userDashPetRegisterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDashPetRegisterBtn.Location = new System.Drawing.Point(3, 3);
            this.userDashPetRegisterBtn.Name = "userDashPetRegisterBtn";
            this.userDashPetRegisterBtn.Size = new System.Drawing.Size(97, 48);
            this.userDashPetRegisterBtn.TabIndex = 0;
            this.userDashPetRegisterBtn.Text = "Add Pet";
            this.userDashPetRegisterBtn.UseVisualStyleBackColor = true;
            this.userDashPetRegisterBtn.Click += new System.EventHandler(this.userDashPetRegisterBtn_Click);
            // 
            // userDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.userDashPetPanelBtn);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "userDash";
            this.Text = "Dashboard";
            this.userDashPetPanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userDashPetPanelBtn;
        private System.Windows.Forms.Button userDashPetRegisterBtn;
    }
}