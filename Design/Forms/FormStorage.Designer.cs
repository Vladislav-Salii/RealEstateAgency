namespace Design.Forms
{
    partial class FormStorage
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
            this.comboBoxOfRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.EnteredAreaOfStorage = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.EnteredPriceOfStorage = new System.Windows.Forms.TextBox();
            this.filteredBoxOfStorage = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.EnteredPriceOfStorageTo = new System.Windows.Forms.TextBox();
            this.EnteredAreaOfStorageTo = new System.Windows.Forms.TextBox();
            this.addInformOfStorage1 = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxOfRegion
            // 
            this.comboBoxOfRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOfRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfRegion.FormattingEnabled = true;
            this.comboBoxOfRegion.Items.AddRange(new object[] {
            "Вінницька",
            "Київська",
            "Всі"});
            this.comboBoxOfRegion.Location = new System.Drawing.Point(341, 154);
            this.comboBoxOfRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOfRegion.Name = "comboBoxOfRegion";
            this.comboBoxOfRegion.Size = new System.Drawing.Size(136, 24);
            this.comboBoxOfRegion.TabIndex = 36;
            this.comboBoxOfRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfRegion_SelectedIndexChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegion.Location = new System.Drawing.Point(202, 154);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(117, 17);
            this.lblRegion.TabIndex = 35;
            this.lblRegion.Text = "Оберіть область";
            // 
            // EnteredAreaOfStorage
            // 
            this.EnteredAreaOfStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredAreaOfStorage.Location = new System.Drawing.Point(341, 123);
            this.EnteredAreaOfStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredAreaOfStorage.Name = "EnteredAreaOfStorage";
            this.EnteredAreaOfStorage.Size = new System.Drawing.Size(65, 22);
            this.EnteredAreaOfStorage.TabIndex = 32;
            this.EnteredAreaOfStorage.TextChanged += new System.EventHandler(this.EnteredAreaOfStorage_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArea.Location = new System.Drawing.Point(202, 123);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(103, 17);
            this.lblArea.TabIndex = 31;
            this.lblArea.Text = "Введіть площу";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(202, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 17);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Введіть ціну";
            // 
            // EnteredPriceOfStorage
            // 
            this.EnteredPriceOfStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredPriceOfStorage.Location = new System.Drawing.Point(341, 95);
            this.EnteredPriceOfStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredPriceOfStorage.Name = "EnteredPriceOfStorage";
            this.EnteredPriceOfStorage.Size = new System.Drawing.Size(65, 22);
            this.EnteredPriceOfStorage.TabIndex = 29;
            this.EnteredPriceOfStorage.TextChanged += new System.EventHandler(this.EnteredPriceOfStorage_TextChanged);
            // 
            // filteredBoxOfStorage
            // 
            this.filteredBoxOfStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filteredBoxOfStorage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.filteredBoxOfStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filteredBoxOfStorage.FormattingEnabled = true;
            this.filteredBoxOfStorage.ItemHeight = 18;
            this.filteredBoxOfStorage.Items.AddRange(new object[] {
            ""});
            this.filteredBoxOfStorage.Location = new System.Drawing.Point(529, 95);
            this.filteredBoxOfStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteredBoxOfStorage.Name = "filteredBoxOfStorage";
            this.filteredBoxOfStorage.Size = new System.Drawing.Size(225, 238);
            this.filteredBoxOfStorage.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Image = global::Design.Properties.Resources.search_1;
            this.btnSearch.Location = new System.Drawing.Point(341, 185);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 51);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EnteredPriceOfStorageTo
            // 
            this.EnteredPriceOfStorageTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredPriceOfStorageTo.Location = new System.Drawing.Point(411, 95);
            this.EnteredPriceOfStorageTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredPriceOfStorageTo.Name = "EnteredPriceOfStorageTo";
            this.EnteredPriceOfStorageTo.Size = new System.Drawing.Size(65, 22);
            this.EnteredPriceOfStorageTo.TabIndex = 37;
            // 
            // EnteredAreaOfStorageTo
            // 
            this.EnteredAreaOfStorageTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredAreaOfStorageTo.Location = new System.Drawing.Point(411, 123);
            this.EnteredAreaOfStorageTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredAreaOfStorageTo.Name = "EnteredAreaOfStorageTo";
            this.EnteredAreaOfStorageTo.Size = new System.Drawing.Size(65, 22);
            this.EnteredAreaOfStorageTo.TabIndex = 38;
            // 
            // addInformOfStorage1
            // 
            this.addInformOfStorage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addInformOfStorage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInformOfStorage1.Image = global::Design.Properties.Resources.add_inform_icon_32;
            this.addInformOfStorage1.Location = new System.Drawing.Point(529, 337);
            this.addInformOfStorage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addInformOfStorage1.Name = "addInformOfStorage1";
            this.addInformOfStorage1.Size = new System.Drawing.Size(225, 50);
            this.addInformOfStorage1.TabIndex = 39;
            this.addInformOfStorage1.Text = "Додаткова інформація";
            this.addInformOfStorage1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addInformOfStorage1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addInformOfStorage1.UseVisualStyleBackColor = true;
            this.addInformOfStorage1.Click += new System.EventHandler(this.addInformOfStorage1_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.SystemColors.Control;
            this.lblFrom.Location = new System.Drawing.Point(338, 67);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(28, 17);
            this.lblFrom.TabIndex = 40;
            this.lblFrom.Text = "Від";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(408, 67);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 17);
            this.lblTo.TabIndex = 41;
            this.lblTo.Text = "До";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFile.Image = global::Design.Properties.Resources.file_icon_3;
            this.btnFile.Location = new System.Drawing.Point(200, 185);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(135, 51);
            this.btnFile.TabIndex = 42;
            this.btnFile.Text = "Сохранить";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.addInformOfStorage1);
            this.Controls.Add(this.EnteredAreaOfStorageTo);
            this.Controls.Add(this.EnteredPriceOfStorageTo);
            this.Controls.Add(this.comboBoxOfRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.EnteredAreaOfStorage);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.EnteredPriceOfStorage);
            this.Controls.Add(this.filteredBoxOfStorage);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStorage";
            this.Text = "Склади";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOfRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox EnteredAreaOfStorage;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox EnteredPriceOfStorage;
        private System.Windows.Forms.ListBox filteredBoxOfStorage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox EnteredPriceOfStorageTo;
        private System.Windows.Forms.TextBox EnteredAreaOfStorageTo;
        private System.Windows.Forms.Button addInformOfStorage1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnFile;
    }
}