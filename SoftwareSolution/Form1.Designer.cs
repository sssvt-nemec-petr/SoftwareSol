namespace SoftwareSolution
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.Provider = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.provider_box = new System.Windows.Forms.TextBox();
            this.version_box = new System.Windows.Forms.TextBox();
            this.datum_box = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(61, 47);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Provider
            // 
            this.Provider.AutoSize = true;
            this.Provider.Location = new System.Drawing.Point(61, 84);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(46, 13);
            this.Provider.TabIndex = 1;
            this.Provider.Text = "Provider";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(62, 121);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 2;
            this.Version.Text = "Version";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(62, 161);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(69, 13);
            this.ReleaseDate.TabIndex = 3;
            this.ReleaseDate.Text = "ReleaseDate";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(144, 44);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 20);
            this.name_box.TabIndex = 4;
            // 
            // provider_box
            // 
            this.provider_box.Location = new System.Drawing.Point(144, 84);
            this.provider_box.Name = "provider_box";
            this.provider_box.Size = new System.Drawing.Size(100, 20);
            this.provider_box.TabIndex = 5;
            // 
            // version_box
            // 
            this.version_box.Location = new System.Drawing.Point(144, 121);
            this.version_box.Name = "version_box";
            this.version_box.Size = new System.Drawing.Size(100, 20);
            this.version_box.TabIndex = 6;
            // 
            // datum_box
            // 
            this.datum_box.Location = new System.Drawing.Point(144, 161);
            this.datum_box.Name = "datum_box";
            this.datum_box.Size = new System.Drawing.Size(100, 20);
            this.datum_box.TabIndex = 7;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 197);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(41, 23);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(59, 197);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(59, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(124, 197);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(51, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(181, 197);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(63, 23);
            this.btn_display.TabIndex = 11;
            this.btn_display.Text = "display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 176);
            this.dataGridView1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.datum_box);
            this.Controls.Add(this.version_box);
            this.Controls.Add(this.provider_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Provider);
            this.Controls.Add(this.Name);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Provider;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox provider_box;
        private System.Windows.Forms.TextBox version_box;
        private System.Windows.Forms.TextBox datum_box;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

