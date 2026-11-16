namespace windows_forms_threads_App
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.text_box_name = new System.Windows.Forms.TextBox();
            this.text_box_email = new System.Windows.Forms.TextBox();
            this.list_box_users = new System.Windows.Forms.ListBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.Orange;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_result.Location = new System.Drawing.Point(9, 7);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(133, 44);
            this.lbl_result.TabIndex = 0;
            this.lbl_result.Text = "Result";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_add.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.LightGray;
            this.button_add.Location = new System.Drawing.Point(164, 148);
            this.button_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 78);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.btn_result_click);
            // 
            // text_box_name
            // 
            this.text_box_name.Location = new System.Drawing.Point(16, 67);
            this.text_box_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_box_name.Multiline = true;
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.Size = new System.Drawing.Size(123, 59);
            this.text_box_name.TabIndex = 2;
            // 
            // text_box_email
            // 
            this.text_box_email.Location = new System.Drawing.Point(164, 67);
            this.text_box_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_box_email.Multiline = true;
            this.text_box_email.Name = "text_box_email";
            this.text_box_email.Size = new System.Drawing.Size(123, 59);
            this.text_box_email.TabIndex = 3;
            // 
            // list_box_users
            // 
            this.list_box_users.FormattingEnabled = true;
            this.list_box_users.Location = new System.Drawing.Point(466, 11);
            this.list_box_users.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_box_users.Name = "list_box_users";
            this.list_box_users.Size = new System.Drawing.Size(116, 238);
            this.list_box_users.TabIndex = 4;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button_update.Location = new System.Drawing.Point(16, 148);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(126, 78);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button_delete.Location = new System.Drawing.Point(17, 247);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(125, 70);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.list_box_users);
            this.Controls.Add(this.text_box_email);
            this.Controls.Add(this.text_box_name);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.lbl_result);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox text_box_name;
        private System.Windows.Forms.TextBox text_box_email;
        private System.Windows.Forms.ListBox list_box_users;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
    }
}

