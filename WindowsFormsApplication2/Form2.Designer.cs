namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.strtbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancelbtn.Image = global::WindowsFormsApplication2.Properties.Resources.error;
            this.Cancelbtn.Location = new System.Drawing.Point(585, 197);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(79, 76);
            this.Cancelbtn.TabIndex = 4;
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.stopbtn.Image = global::WindowsFormsApplication2.Properties.Resources.focus;
            this.stopbtn.Location = new System.Drawing.Point(585, 104);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(79, 77);
            this.stopbtn.TabIndex = 3;
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // strtbtn
            // 
            this.strtbtn.Image = global::WindowsFormsApplication2.Properties.Resources.face__1_;
            this.strtbtn.Location = new System.Drawing.Point(585, 12);
            this.strtbtn.Name = "strtbtn";
            this.strtbtn.Size = new System.Drawing.Size(79, 74);
            this.strtbtn.TabIndex = 2;
            this.strtbtn.UseVisualStyleBackColor = true;
            this.strtbtn.Click += new System.EventHandler(this.strtbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 299);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.strtbtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Cursor_Movement_By_Face_Gesture";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button strtbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button Cancelbtn;
    }
}