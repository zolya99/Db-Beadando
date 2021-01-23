namespace P001_Connection
{
    partial class Form3
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
            this.comboBox_contries = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_insert = new System.Windows.Forms.GroupBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.groupBox_update = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.tb1u = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_insert.SuspendLayout();
            this.groupBox_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_contries
            // 
            this.comboBox_contries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_contries.FormattingEnabled = true;
            this.comboBox_contries.Location = new System.Drawing.Point(12, 12);
            this.comboBox_contries.Name = "comboBox_contries";
            this.comboBox_contries.Size = new System.Drawing.Size(653, 24);
            this.comboBox_contries.TabIndex = 0;
            this.comboBox_contries.SelectedValueChanged += new System.EventHandler(this.comboBox_contries_SelectedValueChanged);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(687, 52);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(101, 30);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox_insert
            // 
            this.groupBox_insert.Controls.Add(this.button_insert);
            this.groupBox_insert.Controls.Add(this.tb1);
            this.groupBox_insert.Location = new System.Drawing.Point(405, 42);
            this.groupBox_insert.Name = "groupBox_insert";
            this.groupBox_insert.Size = new System.Drawing.Size(260, 118);
            this.groupBox_insert.TabIndex = 2;
            this.groupBox_insert.TabStop = false;
            this.groupBox_insert.Text = "Új poszt hozzáadása";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(6, 69);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(122, 36);
            this.button_insert.TabIndex = 2;
            this.button_insert.Text = "Rögzít";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(6, 41);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(248, 22);
            this.tb1.TabIndex = 0;
            // 
            // groupBox_update
            // 
            this.groupBox_update.Controls.Add(this.label1);
            this.groupBox_update.Controls.Add(this.button_update);
            this.groupBox_update.Controls.Add(this.tb1u);
            this.groupBox_update.Location = new System.Drawing.Point(12, 42);
            this.groupBox_update.Name = "groupBox_update";
            this.groupBox_update.Size = new System.Drawing.Size(387, 118);
            this.groupBox_update.TabIndex = 3;
            this.groupBox_update.TabStop = false;
            this.groupBox_update.Text = "Poszt nevének módsítása";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(6, 69);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(122, 36);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Frissít";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // tb1u
            // 
            this.tb1u.Location = new System.Drawing.Point(133, 41);
            this.tb1u.Name = "tb1u";
            this.tb1u.Size = new System.Drawing.Size(248, 22);
            this.tb1u.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poszt neve:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 169);
            this.Controls.Add(this.groupBox_update);
            this.Controls.Add(this.groupBox_insert);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.comboBox_contries);
            this.Name = "Form3";
            this.Text = "Poszt";
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.groupBox_insert.ResumeLayout(false);
            this.groupBox_insert.PerformLayout();
            this.groupBox_update.ResumeLayout(false);
            this.groupBox_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_contries;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox_insert;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.GroupBox groupBox_update;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox tb1u;
        private System.Windows.Forms.Label label1;
    }
}

