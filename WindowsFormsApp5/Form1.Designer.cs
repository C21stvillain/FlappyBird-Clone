
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.alt = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.ust = new System.Windows.Forms.PictureBox();
            this.bok = new System.Windows.Forms.PictureBox();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bok)).BeginInit();
            this.SuspendLayout();
            // 
            // alt
            // 
            this.alt.Image = ((System.Drawing.Image)(resources.GetObject("alt.Image")));
            this.alt.Location = new System.Drawing.Point(350, 405);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(187, 194);
            this.alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alt.TabIndex = 0;
            this.alt.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(12, 605);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(776, 62);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 1;
            this.zemin.TabStop = false;
            // 
            // ust
            // 
            this.ust.Image = ((System.Drawing.Image)(resources.GetObject("ust.Image")));
            this.ust.Location = new System.Drawing.Point(526, 12);
            this.ust.Name = "ust";
            this.ust.Size = new System.Drawing.Size(187, 181);
            this.ust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ust.TabIndex = 2;
            this.ust.TabStop = false;
            // 
            // bok
            // 
            this.bok.Image = ((System.Drawing.Image)(resources.GetObject("bok.Image")));
            this.bok.Location = new System.Drawing.Point(47, 257);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(103, 96);
            this.bok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bok.TabIndex = 3;
            this.bok.TabStop = false;
            // 
            // zaman
            // 
            this.zaman.Enabled = true;
            this.zaman.Interval = 20;
            this.zaman.Tick += new System.EventHandler(this.zamanEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: 0";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(694, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "RESTART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.ust);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.alt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bok Tutmaca";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alt;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox ust;
        private System.Windows.Forms.PictureBox bok;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

