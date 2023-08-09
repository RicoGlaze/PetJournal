namespace PetJournal
{
    partial class petRegistration
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
            this.petRegistrationBlobBox = new System.Windows.Forms.PictureBox();
            this.petRegistrationUploadBtn = new System.Windows.Forms.Button();
            this.petRegistrationNameLbl = new System.Windows.Forms.Label();
            this.petRegistrationAgeLbl = new System.Windows.Forms.Label();
            this.petRegistrationBreedLbl = new System.Windows.Forms.Label();
            this.petRegistrationNameTxt = new System.Windows.Forms.TextBox();
            this.petRegistrationAgeTxt = new System.Windows.Forms.TextBox();
            this.petRegistrationBreedTxt = new System.Windows.Forms.TextBox();
            this.petRegistrationRegisterBtn = new System.Windows.Forms.Button();
            this.petRegBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.petRegistrationBlobBox)).BeginInit();
            this.SuspendLayout();
            // 
            // petRegistrationBlobBox
            // 
            this.petRegistrationBlobBox.Location = new System.Drawing.Point(348, 12);
            this.petRegistrationBlobBox.Name = "petRegistrationBlobBox";
            this.petRegistrationBlobBox.Size = new System.Drawing.Size(178, 152);
            this.petRegistrationBlobBox.TabIndex = 0;
            this.petRegistrationBlobBox.TabStop = false;
            // 
            // petRegistrationUploadBtn
            // 
            this.petRegistrationUploadBtn.Location = new System.Drawing.Point(348, 182);
            this.petRegistrationUploadBtn.Name = "petRegistrationUploadBtn";
            this.petRegistrationUploadBtn.Size = new System.Drawing.Size(177, 37);
            this.petRegistrationUploadBtn.TabIndex = 1;
            this.petRegistrationUploadBtn.Text = "Upload";
            this.petRegistrationUploadBtn.UseVisualStyleBackColor = true;
            this.petRegistrationUploadBtn.Click += new System.EventHandler(this.petRegistrationUploadBtn_Click);
            // 
            // petRegistrationNameLbl
            // 
            this.petRegistrationNameLbl.AutoSize = true;
            this.petRegistrationNameLbl.Location = new System.Drawing.Point(12, 43);
            this.petRegistrationNameLbl.Name = "petRegistrationNameLbl";
            this.petRegistrationNameLbl.Size = new System.Drawing.Size(35, 13);
            this.petRegistrationNameLbl.TabIndex = 2;
            this.petRegistrationNameLbl.Text = "Name";
            // 
            // petRegistrationAgeLbl
            // 
            this.petRegistrationAgeLbl.AutoSize = true;
            this.petRegistrationAgeLbl.Location = new System.Drawing.Point(12, 76);
            this.petRegistrationAgeLbl.Name = "petRegistrationAgeLbl";
            this.petRegistrationAgeLbl.Size = new System.Drawing.Size(26, 13);
            this.petRegistrationAgeLbl.TabIndex = 3;
            this.petRegistrationAgeLbl.Text = "Age";
            // 
            // petRegistrationBreedLbl
            // 
            this.petRegistrationBreedLbl.AutoSize = true;
            this.petRegistrationBreedLbl.Location = new System.Drawing.Point(12, 109);
            this.petRegistrationBreedLbl.Name = "petRegistrationBreedLbl";
            this.petRegistrationBreedLbl.Size = new System.Drawing.Size(35, 13);
            this.petRegistrationBreedLbl.TabIndex = 4;
            this.petRegistrationBreedLbl.Text = "Breed";
            // 
            // petRegistrationNameTxt
            // 
            this.petRegistrationNameTxt.Location = new System.Drawing.Point(53, 40);
            this.petRegistrationNameTxt.Name = "petRegistrationNameTxt";
            this.petRegistrationNameTxt.Size = new System.Drawing.Size(154, 20);
            this.petRegistrationNameTxt.TabIndex = 5;
            // 
            // petRegistrationAgeTxt
            // 
            this.petRegistrationAgeTxt.Location = new System.Drawing.Point(53, 73);
            this.petRegistrationAgeTxt.Name = "petRegistrationAgeTxt";
            this.petRegistrationAgeTxt.Size = new System.Drawing.Size(154, 20);
            this.petRegistrationAgeTxt.TabIndex = 6;
            // 
            // petRegistrationBreedTxt
            // 
            this.petRegistrationBreedTxt.Location = new System.Drawing.Point(53, 106);
            this.petRegistrationBreedTxt.Name = "petRegistrationBreedTxt";
            this.petRegistrationBreedTxt.Size = new System.Drawing.Size(154, 20);
            this.petRegistrationBreedTxt.TabIndex = 7;
            // 
            // petRegistrationRegisterBtn
            // 
            this.petRegistrationRegisterBtn.Location = new System.Drawing.Point(130, 182);
            this.petRegistrationRegisterBtn.Name = "petRegistrationRegisterBtn";
            this.petRegistrationRegisterBtn.Size = new System.Drawing.Size(77, 37);
            this.petRegistrationRegisterBtn.TabIndex = 8;
            this.petRegistrationRegisterBtn.Text = "Register";
            this.petRegistrationRegisterBtn.UseVisualStyleBackColor = true;
            this.petRegistrationRegisterBtn.Click += new System.EventHandler(this.petRegistrationRegisterBtn_Click);
            // 
            // petRegBackBtn
            // 
            this.petRegBackBtn.Location = new System.Drawing.Point(53, 182);
            this.petRegBackBtn.Name = "petRegBackBtn";
            this.petRegBackBtn.Size = new System.Drawing.Size(77, 37);
            this.petRegBackBtn.TabIndex = 9;
            this.petRegBackBtn.Text = "Back";
            this.petRegBackBtn.UseVisualStyleBackColor = true;
            this.petRegBackBtn.Click += new System.EventHandler(this.petRegBackBtn_Click);
            // 
            // petRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.petRegBackBtn);
            this.Controls.Add(this.petRegistrationRegisterBtn);
            this.Controls.Add(this.petRegistrationBreedTxt);
            this.Controls.Add(this.petRegistrationAgeTxt);
            this.Controls.Add(this.petRegistrationNameTxt);
            this.Controls.Add(this.petRegistrationBreedLbl);
            this.Controls.Add(this.petRegistrationAgeLbl);
            this.Controls.Add(this.petRegistrationNameLbl);
            this.Controls.Add(this.petRegistrationUploadBtn);
            this.Controls.Add(this.petRegistrationBlobBox);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "petRegistration";
            this.Text = "Pet Registration";
            this.Load += new System.EventHandler(this.petRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petRegistrationBlobBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox petRegistrationBlobBox;
        private System.Windows.Forms.Button petRegistrationUploadBtn;
        private System.Windows.Forms.Label petRegistrationNameLbl;
        private System.Windows.Forms.Label petRegistrationAgeLbl;
        private System.Windows.Forms.Label petRegistrationBreedLbl;
        private System.Windows.Forms.TextBox petRegistrationNameTxt;
        private System.Windows.Forms.TextBox petRegistrationAgeTxt;
        private System.Windows.Forms.TextBox petRegistrationBreedTxt;
        private System.Windows.Forms.Button petRegistrationRegisterBtn;
        private System.Windows.Forms.Button petRegBackBtn;
    }
}