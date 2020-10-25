namespace HTML2PHP
{
    partial class ExtensionChanger_form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.select_html_folder_btn = new System.Windows.Forms.Button();
            this.html_files_lbl = new System.Windows.Forms.Label();
            this.convert_to_php_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newExtension = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // select_html_folder_btn
            // 
            this.select_html_folder_btn.AllowDrop = true;
            this.select_html_folder_btn.BackColor = System.Drawing.Color.DarkGray;
            this.select_html_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_html_folder_btn.Location = new System.Drawing.Point(35, 96);
            this.select_html_folder_btn.Name = "select_html_folder_btn";
            this.select_html_folder_btn.Size = new System.Drawing.Size(147, 54);
            this.select_html_folder_btn.TabIndex = 0;
            this.select_html_folder_btn.Text = "Select folder";
            this.select_html_folder_btn.UseVisualStyleBackColor = false;
            this.select_html_folder_btn.Click += new System.EventHandler(this.select_html_folder_btn_Click);
            // 
            // html_files_lbl
            // 
            this.html_files_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.html_files_lbl.Location = new System.Drawing.Point(35, 165);
            this.html_files_lbl.Name = "html_files_lbl";
            this.html_files_lbl.Size = new System.Drawing.Size(321, 49);
            this.html_files_lbl.TabIndex = 1;
            this.html_files_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convert_to_php_btn
            // 
            this.convert_to_php_btn.BackColor = System.Drawing.Color.DarkGray;
            this.convert_to_php_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_to_php_btn.Location = new System.Drawing.Point(209, 96);
            this.convert_to_php_btn.Name = "convert_to_php_btn";
            this.convert_to_php_btn.Size = new System.Drawing.Size(147, 54);
            this.convert_to_php_btn.TabIndex = 2;
            this.convert_to_php_btn.Text = "Convert";
            this.convert_to_php_btn.UseVisualStyleBackColor = false;
            this.convert_to_php_btn.Click += new System.EventHandler(this.convert_to_php_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Replace";
            // 
            // currentExtension
            // 
            this.currentExtension.BackColor = System.Drawing.Color.DarkGray;
            this.currentExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentExtension.Location = new System.Drawing.Point(159, 29);
            this.currentExtension.Name = "currentExtension";
            this.currentExtension.Size = new System.Drawing.Size(55, 29);
            this.currentExtension.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "with";
            // 
            // newExtension
            // 
            this.newExtension.BackColor = System.Drawing.Color.DarkGray;
            this.newExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newExtension.Location = new System.Drawing.Point(259, 29);
            this.newExtension.Name = "newExtension";
            this.newExtension.Size = new System.Drawing.Size(55, 29);
            this.newExtension.TabIndex = 6;
            // 
            // ExtensionChanger_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(396, 228);
            this.Controls.Add(this.newExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert_to_php_btn);
            this.Controls.Add(this.html_files_lbl);
            this.Controls.Add(this.select_html_folder_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtensionChanger_form";
            this.Text = "Extension Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_html_folder_btn;
        private System.Windows.Forms.Label html_files_lbl;
        private System.Windows.Forms.Button convert_to_php_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newExtension;
    }
}

