namespace laskuharjoituspeli
{
    partial class Form2
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
            this.form2textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // form2textbox
            // 
            this.form2textbox.Location = new System.Drawing.Point(31, 21);
            this.form2textbox.Name = "form2textbox";
            this.form2textbox.Size = new System.Drawing.Size(597, 355);
            this.form2textbox.TabIndex = 0;
            this.form2textbox.Text = "";
            this.form2textbox.TextChanged += new System.EventHandler(this.form2textbox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form2textbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox form2textbox;
    }
}