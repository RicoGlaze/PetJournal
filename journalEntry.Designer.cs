namespace PetJournal
{
    partial class journalEntry
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
            this.components = new System.ComponentModel.Container();
            this.journalEntryRichTxt = new System.Windows.Forms.RichTextBox();
            this.petEntriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petJournalDataBaseDataSet1 = new PetJournal.PetJournalDataBaseDataSet1();
            this.petJournalDataBaseDataSet = new PetJournal.PetJournalDataBaseDataSet();
            this.petEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petEntriesTableAdapter = new PetJournal.PetJournalDataBaseDataSetTableAdapters.petEntriesTableAdapter();
            this.journalTitleTxt = new System.Windows.Forms.TextBox();
            this.journalTitleLbl = new System.Windows.Forms.Label();
            this.journalTableLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.journalEntryBackBtn = new System.Windows.Forms.Button();
            this.journalTableLoadBtn = new System.Windows.Forms.Button();
            this.journalTableDeleteBtn = new System.Windows.Forms.Button();
            this.journalEntryLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.journalEntrySubmitBtn = new System.Windows.Forms.Button();
            this.petEntriesTableAdapter1 = new PetJournal.PetJournalDataBaseDataSet1TableAdapters.petEntriesTableAdapter();
            this.journalListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.petEntriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petJournalDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petJournalDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petEntriesBindingSource)).BeginInit();
            this.journalTableLayoutPnl.SuspendLayout();
            this.journalEntryLayoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // journalEntryRichTxt
            // 
            this.journalEntryRichTxt.Location = new System.Drawing.Point(322, 54);
            this.journalEntryRichTxt.Name = "journalEntryRichTxt";
            this.journalEntryRichTxt.Size = new System.Drawing.Size(204, 122);
            this.journalEntryRichTxt.TabIndex = 0;
            this.journalEntryRichTxt.Text = "";
            // 
            // petEntriesBindingSource1
            // 
            this.petEntriesBindingSource1.DataMember = "petEntries";
            this.petEntriesBindingSource1.DataSource = this.petJournalDataBaseDataSet1;
            // 
            // petJournalDataBaseDataSet1
            // 
            this.petJournalDataBaseDataSet1.DataSetName = "PetJournalDataBaseDataSet1";
            this.petJournalDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petJournalDataBaseDataSet
            // 
            this.petJournalDataBaseDataSet.DataSetName = "PetJournalDataBaseDataSet";
            this.petJournalDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petEntriesBindingSource
            // 
            this.petEntriesBindingSource.DataMember = "petEntries";
            this.petEntriesBindingSource.DataSource = this.petJournalDataBaseDataSet;
            // 
            // petEntriesTableAdapter
            // 
            this.petEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // journalTitleTxt
            // 
            this.journalTitleTxt.Location = new System.Drawing.Point(382, 16);
            this.journalTitleTxt.Name = "journalTitleTxt";
            this.journalTitleTxt.Size = new System.Drawing.Size(113, 20);
            this.journalTitleTxt.TabIndex = 2;
            // 
            // journalTitleLbl
            // 
            this.journalTitleLbl.AutoSize = true;
            this.journalTitleLbl.Location = new System.Drawing.Point(322, 19);
            this.journalTitleLbl.Name = "journalTitleLbl";
            this.journalTitleLbl.Size = new System.Drawing.Size(54, 13);
            this.journalTitleLbl.TabIndex = 3;
            this.journalTitleLbl.Text = "Entry Title";
            // 
            // journalTableLayoutPnl
            // 
            this.journalTableLayoutPnl.ColumnCount = 2;
            this.journalTableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.journalTableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.journalTableLayoutPnl.Controls.Add(this.journalEntryBackBtn, 0, 1);
            this.journalTableLayoutPnl.Controls.Add(this.journalTableLoadBtn, 1, 0);
            this.journalTableLayoutPnl.Controls.Add(this.journalTableDeleteBtn, 0, 0);
            this.journalTableLayoutPnl.Location = new System.Drawing.Point(13, 183);
            this.journalTableLayoutPnl.Name = "journalTableLayoutPnl";
            this.journalTableLayoutPnl.RowCount = 2;
            this.journalTableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.journalTableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.journalTableLayoutPnl.Size = new System.Drawing.Size(303, 57);
            this.journalTableLayoutPnl.TabIndex = 4;
            // 
            // journalEntryBackBtn
            // 
            this.journalEntryBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalEntryBackBtn.Location = new System.Drawing.Point(3, 33);
            this.journalEntryBackBtn.Name = "journalEntryBackBtn";
            this.journalEntryBackBtn.Size = new System.Drawing.Size(145, 21);
            this.journalEntryBackBtn.TabIndex = 2;
            this.journalEntryBackBtn.Text = "Back";
            this.journalEntryBackBtn.UseVisualStyleBackColor = true;
            this.journalEntryBackBtn.Click += new System.EventHandler(this.journalEntryBackBtn_Click);
            // 
            // journalTableLoadBtn
            // 
            this.journalTableLoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalTableLoadBtn.Location = new System.Drawing.Point(154, 3);
            this.journalTableLoadBtn.Name = "journalTableLoadBtn";
            this.journalTableLoadBtn.Size = new System.Drawing.Size(146, 24);
            this.journalTableLoadBtn.TabIndex = 1;
            this.journalTableLoadBtn.Text = "Load";
            this.journalTableLoadBtn.UseVisualStyleBackColor = true;
            this.journalTableLoadBtn.Click += new System.EventHandler(this.journalTableLoadBtn_Click);
            // 
            // journalTableDeleteBtn
            // 
            this.journalTableDeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalTableDeleteBtn.Location = new System.Drawing.Point(3, 3);
            this.journalTableDeleteBtn.Name = "journalTableDeleteBtn";
            this.journalTableDeleteBtn.Size = new System.Drawing.Size(145, 24);
            this.journalTableDeleteBtn.TabIndex = 0;
            this.journalTableDeleteBtn.Text = "Delete";
            this.journalTableDeleteBtn.UseVisualStyleBackColor = true;
            this.journalTableDeleteBtn.Click += new System.EventHandler(this.journalTableDeleteBtn_Click);
            // 
            // journalEntryLayoutPnl
            // 
            this.journalEntryLayoutPnl.ColumnCount = 1;
            this.journalEntryLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.journalEntryLayoutPnl.Controls.Add(this.journalEntrySubmitBtn, 0, 0);
            this.journalEntryLayoutPnl.Location = new System.Drawing.Point(325, 182);
            this.journalEntryLayoutPnl.Name = "journalEntryLayoutPnl";
            this.journalEntryLayoutPnl.RowCount = 1;
            this.journalEntryLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.journalEntryLayoutPnl.Size = new System.Drawing.Size(201, 29);
            this.journalEntryLayoutPnl.TabIndex = 5;
            // 
            // journalEntrySubmitBtn
            // 
            this.journalEntrySubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalEntrySubmitBtn.Location = new System.Drawing.Point(3, 3);
            this.journalEntrySubmitBtn.Name = "journalEntrySubmitBtn";
            this.journalEntrySubmitBtn.Size = new System.Drawing.Size(195, 23);
            this.journalEntrySubmitBtn.TabIndex = 0;
            this.journalEntrySubmitBtn.Text = "Submit";
            this.journalEntrySubmitBtn.UseVisualStyleBackColor = true;
            this.journalEntrySubmitBtn.Click += new System.EventHandler(this.journalEntrySubmitBtn_Click);
            // 
            // petEntriesTableAdapter1
            // 
            this.petEntriesTableAdapter1.ClearBeforeFill = true;
            // 
            // journalListBox
            // 
            this.journalListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalListBox.FormattingEnabled = true;
            this.journalListBox.Location = new System.Drawing.Point(16, 29);
            this.journalListBox.MultiColumn = true;
            this.journalListBox.Name = "journalListBox";
            this.journalListBox.Size = new System.Drawing.Size(296, 147);
            this.journalListBox.TabIndex = 6;
            // 
            // journalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.journalListBox);
            this.Controls.Add(this.journalEntryLayoutPnl);
            this.Controls.Add(this.journalTableLayoutPnl);
            this.Controls.Add(this.journalTitleLbl);
            this.Controls.Add(this.journalTitleTxt);
            this.Controls.Add(this.journalEntryRichTxt);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "journalEntry";
            this.Text = "Journal Entry";
            this.Load += new System.EventHandler(this.journalEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petEntriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petJournalDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petJournalDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petEntriesBindingSource)).EndInit();
            this.journalTableLayoutPnl.ResumeLayout(false);
            this.journalEntryLayoutPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox journalEntryRichTxt;
        private PetJournalDataBaseDataSet petJournalDataBaseDataSet;
        private System.Windows.Forms.BindingSource petEntriesBindingSource;
        private PetJournalDataBaseDataSetTableAdapters.petEntriesTableAdapter petEntriesTableAdapter;
        private System.Windows.Forms.TextBox journalTitleTxt;
        private System.Windows.Forms.Label journalTitleLbl;
        private System.Windows.Forms.TableLayoutPanel journalTableLayoutPnl;
        private System.Windows.Forms.Button journalTableLoadBtn;
        private System.Windows.Forms.Button journalTableDeleteBtn;
        private System.Windows.Forms.TableLayoutPanel journalEntryLayoutPnl;
        private System.Windows.Forms.Button journalEntryBackBtn;
        private System.Windows.Forms.Button journalEntrySubmitBtn;
        private PetJournalDataBaseDataSet1 petJournalDataBaseDataSet1;
        private System.Windows.Forms.BindingSource petEntriesBindingSource1;
        private PetJournalDataBaseDataSet1TableAdapters.petEntriesTableAdapter petEntriesTableAdapter1;
        private System.Windows.Forms.ListBox journalListBox;
    }
}