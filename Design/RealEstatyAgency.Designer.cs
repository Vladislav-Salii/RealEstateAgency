namespace Design
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnFlat = new System.Windows.Forms.Button();
            this.btnHouse = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnStorage);
            this.panelMenu.Controls.Add(this.btnFlat);
            this.panelMenu.Controls.Add(this.btnHouse);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 553);
            this.panelMenu.TabIndex = 0;
            // 
            // btnStorage
            // 
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorage.FlatAppearance.BorderSize = 0;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStorage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.ImageKey = "(отсутствует)";
            this.btnStorage.Location = new System.Drawing.Point(0, 227);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStorage.Size = new System.Drawing.Size(220, 76);
            this.btnStorage.TabIndex = 3;
            this.btnStorage.Text = "  Склади";
            this.btnStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnFlat
            // 
            this.btnFlat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFlat.FlatAppearance.BorderSize = 0;
            this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFlat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFlat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlat.ImageKey = "(отсутствует)";
            this.btnFlat.Location = new System.Drawing.Point(0, 151);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFlat.Size = new System.Drawing.Size(220, 76);
            this.btnFlat.TabIndex = 2;
            this.btnFlat.Text = "  Квартири";
            this.btnFlat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFlat.UseVisualStyleBackColor = true;
            this.btnFlat.Click += new System.EventHandler(this.btnFlat_Click);
            // 
            // btnHouse
            // 
            this.btnHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHouse.FlatAppearance.BorderSize = 0;
            this.btnHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHouse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHouse.Image = global::Design.Properties.Resources.house3;
            this.btnHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHouse.ImageKey = "(отсутствует)";
            this.btnHouse.Location = new System.Drawing.Point(0, 75);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHouse.Size = new System.Drawing.Size(220, 76);
            this.btnHouse.TabIndex = 1;
            this.btnHouse.Text = "  Будинки ";
            this.btnHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHouse.UseVisualStyleBackColor = true;
            this.btnHouse.Click += new System.EventHandler(this.btnHouse_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(912, 75);
            this.panelTitle.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Design.Properties.Resources.icons8_macos_закрыть_30;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 75);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(400, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Controls.Add(this.pictureBoxLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(912, 478);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Image = global::Design.Properties.Resources.logo2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(359, 112);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(219, 201);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Real estate company";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHouse;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

