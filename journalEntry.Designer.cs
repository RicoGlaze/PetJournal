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
            this.journalDataGrid = new System.Windows.Forms.DataGridView();
            this.petJournalDataBaseDataSet = new PetJournal.PetJournalDataBaseDataSet();
            this.petEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petEntriesTableAdapter = new PetJournal.PetJournalDataBaseDataSetTableAdapters.petEntriesTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalTitleTxt = new System.Windows.Forms.TextBox();
            this.journalTitleLbl = new System.Windows.Forms.Label();
            this.journalTableLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.journalEntryLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.journalTableDeleteBtn = new System.Windows.Forms.Button();
            this.journalTableLoadBtn = new System.Windows.Forms.Button();
            this.journalEntrySubmitBtn = new System.Windows.Forms.Button();
            this.journalEntryBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGrid)).BeginInit();
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
            // journalDataGrid
            // 
            this.journalDataGrid.AutoGenerateColumns = false;
            this.journalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.journalDataGrid.DataSource = this.petEntriesBindingSource;
            this.journalDataGrid.Location = new System.Drawing.Point(12, 12);
            this.journalDataGrid.MultiSelect = false;
            this.journalDataGrid.Name = "journalDataGrid";
            this.journalDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.journalDataGrid.Size = new System.Drawing.Size(304, 164);
            this.journalDataGrid.TabIndex = 1;
            this.journalDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
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
            // journalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 242);
            this.Controls.Add(this.journalEntryLayoutPnl);
            this.Controls.Add(this.journalTableLayoutPnl);
            this.Controls.Add(this.journalTitleLbl);
            this.Controls.Add(this.journalTitleTxt);
            this.Controls.Add(this.journalDataGrid);
            this.Controls.Add(this.journalEntryRichTxt);
            this.MaximumSize = new System.Drawing.Size(554, 281);
            this.MinimumSize = new System.Drawing.Size(357, 281);
            this.Name = "journalEntry";
            this.Text = "Journal Entry";
            this.Load += new System.EventHandler(this.journalEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petJournalDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petEntriesBindingSource)).EndInit();
            this.journalTableLayoutPnl.ResumeLayout(false);
            this.journalEntryLayoutPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox journalEntryRichTxt;
        private System.Windows.Forms.DataGridView journalDataGrid;
        private PetJournalDataBaseDataSet petJournalDataBaseDataSet;
        private System.Windows.Forms.BindingSource petEntriesBindingSource;
        private PetJournalDataBaseDataSetTableAdapters.petEntriesTableAdapter petEntriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox journalTitleTxt;
        private System.Windows.Forms.Label journalTitleLbl;
        private System.Windows.Forms.TableLayoutPanel journalTableLayoutPnl;
        private System.Windows.Forms.Button journalTableLoadBtn;
        private System.Windows.Forms.Button journalTableDeleteBtn;
        private System.Windows.Forms.TableLayoutPanel journalEntryLayoutPnl;
        private System.Windows.Forms.Button journalEntryBackBtn;
        private System.Windows.Forms.Button journalEntrySubmitBtn;
    }
}