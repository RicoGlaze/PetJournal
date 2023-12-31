﻿namespace PetJournal
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.userDashPetRegisterBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.userDashPetBlob = new System.Windows.Forms.PictureBox();
            this.userDashTimelineTable = new System.Windows.Forms.TableLayoutPanel();
            this.userDashAddEntryBtn = new System.Windows.Forms.Button();
            this.breedHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userDashPetPanelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDashPetBlob)).BeginInit();
            this.userDashTimelineTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDashPetPanelBtn
            // 
            this.userDashPetPanelBtn.ColumnCount = 1;
            this.userDashPetPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userDashPetPanelBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userDashPetPanelBtn.Controls.Add(this.listBox1, 0, 1);
            this.userDashPetPanelBtn.Controls.Add(this.userDashPetRegisterBtn, 0, 0);
            this.userDashPetPanelBtn.Location = new System.Drawing.Point(10, 12);
            this.userDashPetPanelBtn.Name = "userDashPetPanelBtn";
            this.userDashPetPanelBtn.RowCount = 2;
            this.userDashPetPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.userDashPetPanelBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.userDashPetPanelBtn.Size = new System.Drawing.Size(103, 218);
            this.userDashPetPanelBtn.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 160);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // userDashPetRegisterBtn
            // 
            this.userDashPetRegisterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDashPetRegisterBtn.Location = new System.Drawing.Point(3, 3);
            this.userDashPetRegisterBtn.Name = "userDashPetRegisterBtn";
            this.userDashPetRegisterBtn.Size = new System.Drawing.Size(97, 44);
            this.userDashPetRegisterBtn.TabIndex = 0;
            this.userDashPetRegisterBtn.Text = "Add Pet";
            this.userDashPetRegisterBtn.UseVisualStyleBackColor = true;
            this.userDashPetRegisterBtn.Click += new System.EventHandler(this.userDashPetRegisterBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.breedHead,
            this.ageHead});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(119, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(280, 62);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // userDashPetBlob
            // 
            this.userDashPetBlob.Location = new System.Drawing.Point(405, 129);
            this.userDashPetBlob.Name = "userDashPetBlob";
            this.userDashPetBlob.Size = new System.Drawing.Size(121, 96);
            this.userDashPetBlob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDashPetBlob.TabIndex = 2;
            this.userDashPetBlob.TabStop = false;
            // 
            // userDashTimelineTable
            // 
            this.userDashTimelineTable.ColumnCount = 1;
            this.userDashTimelineTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.userDashTimelineTable.Controls.Add(this.userDashAddEntryBtn, 0, 0);
            this.userDashTimelineTable.Location = new System.Drawing.Point(120, 65);
            this.userDashTimelineTable.Name = "userDashTimelineTable";
            this.userDashTimelineTable.RowCount = 1;
            this.userDashTimelineTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userDashTimelineTable.Size = new System.Drawing.Size(51, 92);
            this.userDashTimelineTable.TabIndex = 3;
            // 
            // userDashAddEntryBtn
            // 
            this.userDashAddEntryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDashAddEntryBtn.Location = new System.Drawing.Point(3, 3);
            this.userDashAddEntryBtn.Name = "userDashAddEntryBtn";
            this.userDashAddEntryBtn.Size = new System.Drawing.Size(45, 86);
            this.userDashAddEntryBtn.TabIndex = 0;
            this.userDashAddEntryBtn.Text = "Add Entry";
            this.userDashAddEntryBtn.UseVisualStyleBackColor = true;
            this.userDashAddEntryBtn.Click += new System.EventHandler(this.userDashAddEntryBtn_Click);
            // 
            // breedHead
            // 
            this.breedHead.Text = "Breed";
            this.breedHead.Width = 150;
            // 
            // ageHead
            // 
            this.ageHead.Text = "Age";
            this.ageHead.Width = 150;
            // 
            // userDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.userDashTimelineTable);
            this.Controls.Add(this.userDashPetBlob);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.userDashPetPanelBtn);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "userDash";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.userDash_Load);
            this.userDashPetPanelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDashPetBlob)).EndInit();
            this.userDashTimelineTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userDashPetPanelBtn;
        private System.Windows.Forms.Button userDashPetRegisterBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox userDashPetBlob;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel userDashTimelineTable;
        private System.Windows.Forms.Button userDashAddEntryBtn;
        private System.Windows.Forms.ColumnHeader breedHead;
        private System.Windows.Forms.ColumnHeader ageHead;
    }
}