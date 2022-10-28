namespace Design.Forms
{
    partial class FormFlats
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.comboBoxOfRegion = new System.Windows.Forms.ComboBox();
            this.EnteredFloatOfFlats = new System.Windows.Forms.TextBox();
            this.EnteredAreaOfFlats = new System.Windows.Forms.TextBox();
            this.EnteredPriceOfFlats = new System.Windows.Forms.TextBox();
            this.filteredBoxOfFlats = new System.Windows.Forms.ListBox();
            this.EnteredPriceOfFlatsTo = new System.Windows.Forms.TextBox();
            this.EnteredAreaOfFlatsTo = new System.Windows.Forms.TextBox();
            this.EnteredFloatOfFlatsTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.AddInformOfFlats1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(210, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Введіть ціну";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArea.Location = new System.Drawing.Point(210, 123);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(103, 17);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Введіть площу";
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoom.Location = new System.Drawing.Point(210, 154);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(112, 17);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Кількість кімнат";
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegion.Location = new System.Drawing.Point(210, 185);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(117, 17);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Оберіть область";
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
            this.comboBoxOfRegion.Location = new System.Drawing.Point(341, 182);
            this.comboBoxOfRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOfRegion.Name = "comboBoxOfRegion";
            this.comboBoxOfRegion.Size = new System.Drawing.Size(137, 24);
            this.comboBoxOfRegion.TabIndex = 29;
            this.comboBoxOfRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfRegion_SelectedIndexChanged);
            // 
            // EnteredFloatOfFlats
            // 
            this.EnteredFloatOfFlats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredFloatOfFlats.Location = new System.Drawing.Point(341, 154);
            this.EnteredFloatOfFlats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredFloatOfFlats.Name = "EnteredFloatOfFlats";
            this.EnteredFloatOfFlats.Size = new System.Drawing.Size(67, 22);
            this.EnteredFloatOfFlats.TabIndex = 28;
            this.EnteredFloatOfFlats.TextChanged += new System.EventHandler(this.EnteredFloatOfFlats_TextChanged);
            // 
            // EnteredAreaOfFlats
            // 
            this.EnteredAreaOfFlats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredAreaOfFlats.Location = new System.Drawing.Point(341, 123);
            this.EnteredAreaOfFlats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredAreaOfFlats.Name = "EnteredAreaOfFlats";
            this.EnteredAreaOfFlats.Size = new System.Drawing.Size(67, 22);
            this.EnteredAreaOfFlats.TabIndex = 27;
            this.EnteredAreaOfFlats.TextChanged += new System.EventHandler(this.EnteredAreaOfFlats_TextChanged);
            // 
            // EnteredPriceOfFlats
            // 
            this.EnteredPriceOfFlats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredPriceOfFlats.Location = new System.Drawing.Point(341, 95);
            this.EnteredPriceOfFlats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredPriceOfFlats.Name = "EnteredPriceOfFlats";
            this.EnteredPriceOfFlats.Size = new System.Drawing.Size(67, 22);
            this.EnteredPriceOfFlats.TabIndex = 26;
            this.EnteredPriceOfFlats.TextChanged += new System.EventHandler(this.EnteredPriceOfFlats_TextChanged);
            // 
            // filteredBoxOfFlats
            // 
            this.filteredBoxOfFlats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filteredBoxOfFlats.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.filteredBoxOfFlats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filteredBoxOfFlats.FormattingEnabled = true;
            this.filteredBoxOfFlats.ItemHeight = 18;
            this.filteredBoxOfFlats.Items.AddRange(new object[] {
            ""});
            this.filteredBoxOfFlats.Location = new System.Drawing.Point(529, 95);
            this.filteredBoxOfFlats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteredBoxOfFlats.Name = "filteredBoxOfFlats";
            this.filteredBoxOfFlats.Size = new System.Drawing.Size(225, 238);
            this.filteredBoxOfFlats.TabIndex = 25;
            // 
            // EnteredPriceOfFlatsTo
            // 
            this.EnteredPriceOfFlatsTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredPriceOfFlatsTo.Location = new System.Drawing.Point(411, 95);
            this.EnteredPriceOfFlatsTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredPriceOfFlatsTo.Name = "EnteredPriceOfFlatsTo";
            this.EnteredPriceOfFlatsTo.Size = new System.Drawing.Size(67, 22);
            this.EnteredPriceOfFlatsTo.TabIndex = 30;
            // 
            // EnteredAreaOfFlatsTo
            // 
            this.EnteredAreaOfFlatsTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredAreaOfFlatsTo.Location = new System.Drawing.Point(411, 123);
            this.EnteredAreaOfFlatsTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredAreaOfFlatsTo.Name = "EnteredAreaOfFlatsTo";
            this.EnteredAreaOfFlatsTo.Size = new System.Drawing.Size(67, 22);
            this.EnteredAreaOfFlatsTo.TabIndex = 31;
            // 
            // EnteredFloatOfFlatsTo
            // 
            this.EnteredFloatOfFlatsTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredFloatOfFlatsTo.Location = new System.Drawing.Point(411, 154);
            this.EnteredFloatOfFlatsTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredFloatOfFlatsTo.Name = "EnteredFloatOfFlatsTo";
            this.EnteredFloatOfFlatsTo.Size = new System.Drawing.Size(67, 22);
            this.EnteredFloatOfFlatsTo.TabIndex = 32;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.SystemColors.Control;
            this.lblFrom.Location = new System.Drawing.Point(338, 67);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(28, 17);
            this.lblFrom.TabIndex = 33;
            this.lblFrom.Text = "Від";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(408, 67);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 17);
            this.lblTo.TabIndex = 34;
            this.lblTo.Text = "До";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFile.Image = global::Design.Properties.Resources.file_icon_3;
            this.btnFile.Location = new System.Drawing.Point(200, 219);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(135, 51);
            this.btnFile.TabIndex = 37;
            this.btnFile.Text = "Сохранить";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // AddInformOfFlats1
            // 
            this.AddInformOfFlats1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddInformOfFlats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddInformOfFlats1.Image = global::Design.Properties.Resources.add_inform_icon_32;
            this.AddInformOfFlats1.Location = new System.Drawing.Point(529, 337);
            this.AddInformOfFlats1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddInformOfFlats1.Name = "AddInformOfFlats1";
            this.AddInformOfFlats1.Size = new System.Drawing.Size(225, 50);
            this.AddInformOfFlats1.TabIndex = 35;
            this.AddInformOfFlats1.Text = "Додаткова інформація";
            this.AddInformOfFlats1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddInformOfFlats1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddInformOfFlats1.UseVisualStyleBackColor = true;
            this.AddInformOfFlats1.Click += new System.EventHandler(this.AddInformOfFlats1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Image = global::Design.Properties.Resources.search_1;
            this.btnSearch.Location = new System.Drawing.Point(341, 219);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 51);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormFlats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 553);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.AddInformOfFlats1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.EnteredFloatOfFlatsTo);
            this.Controls.Add(this.EnteredAreaOfFlatsTo);
            this.Controls.Add(this.EnteredPriceOfFlatsTo);
            this.Controls.Add(this.comboBoxOfRegion);
            this.Controls.Add(this.EnteredFloatOfFlats);
            this.Controls.Add(this.EnteredAreaOfFlats);
            this.Controls.Add(this.EnteredPriceOfFlats);
            this.Controls.Add(this.filteredBoxOfFlats);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPrice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFlats";
            this.Text = "Квартири";
            this.Load += new System.EventHandler(this.FormFlats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox comboBoxOfRegion;
        private System.Windows.Forms.TextBox EnteredFloatOfFlats;
        private System.Windows.Forms.TextBox EnteredAreaOfFlats;
        private System.Windows.Forms.TextBox EnteredPriceOfFlats;
        private System.Windows.Forms.ListBox filteredBoxOfFlats;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox EnteredPriceOfFlatsTo;
        private System.Windows.Forms.TextBox EnteredAreaOfFlatsTo;
        private System.Windows.Forms.TextBox EnteredFloatOfFlatsTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button AddInformOfFlats1;
        private System.Windows.Forms.Button btnFile;
    }
}