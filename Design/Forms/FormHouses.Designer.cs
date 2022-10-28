namespace Design.Forms
{
    partial class FormHouses
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
            this.filteredBoxOfHouse = new System.Windows.Forms.ListBox();
            this.EnteredPriceOfHouse = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.EnteredAreaOfHouse = new System.Windows.Forms.TextBox();
            this.lblFloat = new System.Windows.Forms.Label();
            this.EnteredFloarOfHouse = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.comboBoxOfRegion = new System.Windows.Forms.ComboBox();
            this.EnteredPriceOfHouseTo = new System.Windows.Forms.TextBox();
            this.EnteredAreaOfHouseTo = new System.Windows.Forms.TextBox();
            this.EnteredFloatOfHouseTo = new System.Windows.Forms.TextBox();
            this.addInformOfHouse = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filteredBoxOfHouse
            // 
            this.filteredBoxOfHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filteredBoxOfHouse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.filteredBoxOfHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filteredBoxOfHouse.FormattingEnabled = true;
            this.filteredBoxOfHouse.ItemHeight = 18;
            this.filteredBoxOfHouse.Items.AddRange(new object[] {
            ""});
            this.filteredBoxOfHouse.Location = new System.Drawing.Point(529, 95);
            this.filteredBoxOfHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteredBoxOfHouse.Name = "filteredBoxOfHouse";
            this.filteredBoxOfHouse.Size = new System.Drawing.Size(225, 238);
            this.filteredBoxOfHouse.TabIndex = 4;
            // 
            // EnteredPriceOfHouse
            // 
            this.EnteredPriceOfHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredPriceOfHouse.Location = new System.Drawing.Point(341, 95);
            this.EnteredPriceOfHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredPriceOfHouse.Name = "EnteredPriceOfHouse";
            this.EnteredPriceOfHouse.Size = new System.Drawing.Size(65, 22);
            this.EnteredPriceOfHouse.TabIndex = 5;
            this.EnteredPriceOfHouse.TextChanged += new System.EventHandler(this.EnteredPriceOfHouse_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(202, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 17);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Введіть ціну";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArea.Location = new System.Drawing.Point(202, 123);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(103, 17);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Введіть площу";
            // 
            // EnteredAreaOfHouse
            // 
            this.EnteredAreaOfHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredAreaOfHouse.Location = new System.Drawing.Point(341, 123);
            this.EnteredAreaOfHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredAreaOfHouse.Name = "EnteredAreaOfHouse";
            this.EnteredAreaOfHouse.Size = new System.Drawing.Size(65, 22);
            this.EnteredAreaOfHouse.TabIndex = 8;
            this.EnteredAreaOfHouse.TextChanged += new System.EventHandler(this.EnteredAreaOfHouse_TextChanged);
            // 
            // lblFloat
            // 
            this.lblFloat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFloat.AutoSize = true;
            this.lblFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFloat.Location = new System.Drawing.Point(202, 154);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(125, 17);
            this.lblFloat.TabIndex = 20;
            this.lblFloat.Text = "Кількість поверхів";
            // 
            // EnteredFloarOfHouse
            // 
            this.EnteredFloarOfHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredFloarOfHouse.Location = new System.Drawing.Point(341, 154);
            this.EnteredFloarOfHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredFloarOfHouse.Name = "EnteredFloarOfHouse";
            this.EnteredFloarOfHouse.Size = new System.Drawing.Size(65, 22);
            this.EnteredFloarOfHouse.TabIndex = 21;
            this.EnteredFloarOfHouse.TextChanged += new System.EventHandler(this.EnteredFloatOfHouse_TextChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegion.Location = new System.Drawing.Point(202, 185);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(117, 17);
            this.lblRegion.TabIndex = 22;
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
            this.comboBoxOfRegion.Size = new System.Drawing.Size(136, 24);
            this.comboBoxOfRegion.TabIndex = 23;
            this.comboBoxOfRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfRegion_SelectedIndexChanged);
            // 
            // EnteredPriceOfHouseTo
            // 
            this.EnteredPriceOfHouseTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredPriceOfHouseTo.Location = new System.Drawing.Point(411, 95);
            this.EnteredPriceOfHouseTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredPriceOfHouseTo.Name = "EnteredPriceOfHouseTo";
            this.EnteredPriceOfHouseTo.Size = new System.Drawing.Size(65, 22);
            this.EnteredPriceOfHouseTo.TabIndex = 24;
            // 
            // EnteredAreaOfHouseTo
            // 
            this.EnteredAreaOfHouseTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredAreaOfHouseTo.Location = new System.Drawing.Point(411, 123);
            this.EnteredAreaOfHouseTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredAreaOfHouseTo.Name = "EnteredAreaOfHouseTo";
            this.EnteredAreaOfHouseTo.Size = new System.Drawing.Size(65, 22);
            this.EnteredAreaOfHouseTo.TabIndex = 25;
            // 
            // EnteredFloatOfHouseTo
            // 
            this.EnteredFloatOfHouseTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnteredFloatOfHouseTo.Location = new System.Drawing.Point(411, 154);
            this.EnteredFloatOfHouseTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnteredFloatOfHouseTo.Name = "EnteredFloatOfHouseTo";
            this.EnteredFloatOfHouseTo.Size = new System.Drawing.Size(65, 22);
            this.EnteredFloatOfHouseTo.TabIndex = 26;
            // 
            // addInformOfHouse
            // 
            this.addInformOfHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addInformOfHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInformOfHouse.Image = global::Design.Properties.Resources.add_inform_icon_32;
            this.addInformOfHouse.Location = new System.Drawing.Point(529, 337);
            this.addInformOfHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addInformOfHouse.Name = "addInformOfHouse";
            this.addInformOfHouse.Size = new System.Drawing.Size(225, 50);
            this.addInformOfHouse.TabIndex = 27;
            this.addInformOfHouse.Text = "Додаткова інформація";
            this.addInformOfHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addInformOfHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addInformOfHouse.UseVisualStyleBackColor = true;
            this.addInformOfHouse.Click += new System.EventHandler(this.addInformOfHouse_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.SystemColors.Control;
            this.lblFrom.Location = new System.Drawing.Point(338, 67);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(28, 17);
            this.lblFrom.TabIndex = 34;
            this.lblFrom.Text = "Від";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(408, 67);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 17);
            this.lblTo.TabIndex = 35;
            this.lblTo.Text = "До";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFile.Image = global::Design.Properties.Resources.file_icon_3;
            this.btnFile.Location = new System.Drawing.Point(200, 219);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(135, 51);
            this.btnFile.TabIndex = 36;
            this.btnFile.Text = "Сохранить";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Image = global::Design.Properties.Resources.search_1;
            this.btnSearch.Location = new System.Drawing.Point(341, 219);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 51);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.addInformOfHouse);
            this.Controls.Add(this.EnteredFloatOfHouseTo);
            this.Controls.Add(this.EnteredAreaOfHouseTo);
            this.Controls.Add(this.EnteredPriceOfHouseTo);
            this.Controls.Add(this.comboBoxOfRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.EnteredFloarOfHouse);
            this.Controls.Add(this.lblFloat);
            this.Controls.Add(this.EnteredAreaOfHouse);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.EnteredPriceOfHouse);
            this.Controls.Add(this.filteredBoxOfHouse);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHouses";
            this.Text = "Будинки";
            this.Load += new System.EventHandler(this.FormHouses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox filteredBoxOfHouse;
        private System.Windows.Forms.TextBox EnteredPriceOfHouse;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox EnteredAreaOfHouse;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.TextBox EnteredFloarOfHouse;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox comboBoxOfRegion;
        private System.Windows.Forms.TextBox EnteredPriceOfHouseTo;
        private System.Windows.Forms.TextBox EnteredAreaOfHouseTo;
        private System.Windows.Forms.TextBox EnteredFloatOfHouseTo;
        private System.Windows.Forms.Button addInformOfHouse;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnFile;
    }
}