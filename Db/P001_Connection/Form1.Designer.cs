namespace P001_Connection
{
    partial class Form1
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
            this.tb3 = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.groupBox_update = new System.Windows.Forms.GroupBox();
            this.tb3u = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.tb2u = new System.Windows.Forms.TextBox();
            this.tb1u = new System.Windows.Forms.TextBox();
            this.btnP = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_insert.SuspendLayout();
            this.groupBox_update.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.button_delete.Location = new System.Drawing.Point(683, 42);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(105, 30);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox_insert
            // 
            this.groupBox_insert.Controls.Add(this.tb3);
            this.groupBox_insert.Controls.Add(this.button_insert);
            this.groupBox_insert.Controls.Add(this.tb2);
            this.groupBox_insert.Controls.Add(this.tb1);
            this.groupBox_insert.Location = new System.Drawing.Point(409, 42);
            this.groupBox_insert.Name = "groupBox_insert";
            this.groupBox_insert.Size = new System.Drawing.Size(260, 251);
            this.groupBox_insert.TabIndex = 2;
            this.groupBox_insert.TabStop = false;
            this.groupBox_insert.Text = "Új focista beillesztése";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(6, 97);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(248, 22);
            this.tb3.TabIndex = 3;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(6, 209);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(122, 36);
            this.button_insert.TabIndex = 2;
            this.button_insert.Text = "Rögzít";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(6, 69);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(248, 22);
            this.tb2.TabIndex = 1;
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
            this.groupBox_update.Controls.Add(this.label3);
            this.groupBox_update.Controls.Add(this.label2);
            this.groupBox_update.Controls.Add(this.label1);
            this.groupBox_update.Controls.Add(this.tb3u);
            this.groupBox_update.Controls.Add(this.button_update);
            this.groupBox_update.Controls.Add(this.tb2u);
            this.groupBox_update.Controls.Add(this.tb1u);
            this.groupBox_update.Location = new System.Drawing.Point(12, 42);
            this.groupBox_update.Name = "groupBox_update";
            this.groupBox_update.Size = new System.Drawing.Size(399, 251);
            this.groupBox_update.TabIndex = 3;
            this.groupBox_update.TabStop = false;
            this.groupBox_update.Text = "Focista adatainak frissítése";
            this.groupBox_update.Enter += new System.EventHandler(this.groupBox_update_Enter);
            // 
            // tb3u
            // 
            this.tb3u.Location = new System.Drawing.Point(143, 97);
            this.tb3u.Name = "tb3u";
            this.tb3u.Size = new System.Drawing.Size(248, 22);
            this.tb3u.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(6, 209);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(122, 36);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Frissít";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // tb2u
            // 
            this.tb2u.Location = new System.Drawing.Point(143, 69);
            this.tb2u.Name = "tb2u";
            this.tb2u.Size = new System.Drawing.Size(248, 22);
            this.tb2u.TabIndex = 1;
            // 
            // tb1u
            // 
            this.tb1u.Location = new System.Drawing.Point(143, 41);
            this.tb1u.Name = "tb1u";
            this.tb1u.Size = new System.Drawing.Size(248, 22);
            this.tb1u.TabIndex = 0;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(259, 20);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(248, 62);
            this.btnP.TabIndex = 4;
            this.btnP.Text = "Poszt";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click_1);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(6, 20);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(208, 62);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "Csapat";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(690, 420);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 29);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Bejelentkezés";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Születési év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vezetéknév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keresztnév";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Controls.Add(this.btnP);
            this.groupBox1.Location = new System.Drawing.Point(18, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Csapatok és Posztok módosítása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.groupBox_update);
            this.Controls.Add(this.groupBox_insert);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.comboBox_contries);
            this.Name = "Form1";
            this.Text = "Focista + Log in";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox_insert.ResumeLayout(false);
            this.groupBox_insert.PerformLayout();
            this.groupBox_update.ResumeLayout(false);
            this.groupBox_update.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_contries;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox_insert;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.GroupBox groupBox_update;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox tb2u;
        private System.Windows.Forms.TextBox tb1u;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb3u;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

