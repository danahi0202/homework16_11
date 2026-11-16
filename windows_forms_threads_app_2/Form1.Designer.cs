namespace windows_forms_threads_app_2
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
            this.list_box_users = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // list_box_users
            // 
            this.list_box_users.FormattingEnabled = true;
            this.list_box_users.ItemHeight = 16;
            this.list_box_users.Location = new System.Drawing.Point(13, 13);
            this.list_box_users.Name = "list_box_users";
            this.list_box_users.Size = new System.Drawing.Size(388, 420);
            this.list_box_users.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_box_users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_box_users;
    }
}

