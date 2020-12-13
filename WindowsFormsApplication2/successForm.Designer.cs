namespace WindowsFormsApplication2
{
    partial class successForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(successForm));
            this.successText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // successText
            // 
            this.successText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.successText.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.successText.Location = new System.Drawing.Point(52, 28);
            this.successText.Name = "successText";
            this.successText.ReadOnly = true;
            this.successText.Size = new System.Drawing.Size(439, 61);
            this.successText.TabIndex = 0;
            this.successText.Text = "Ура! Победа!";
            this.successText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 280);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formClose
            // 
            this.formClose.Location = new System.Drawing.Point(151, 419);
            this.formClose.Name = "formClose";
            this.formClose.Size = new System.Drawing.Size(234, 36);
            this.formClose.TabIndex = 2;
            this.formClose.Text = "ok";
            this.formClose.UseVisualStyleBackColor = true;
            this.formClose.Click += new System.EventHandler(this.formClose_Click);
            // 
            // successForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 467);
            this.Controls.Add(this.formClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.successText);
            this.Name = "successForm";
            this.Text = "successForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox successText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button formClose;
    }
}