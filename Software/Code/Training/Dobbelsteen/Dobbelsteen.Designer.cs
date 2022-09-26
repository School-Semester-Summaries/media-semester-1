namespace Dobbelsteen
{
    partial class Dobbelsteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dobbelsteen));
            this.DS1 = new System.Windows.Forms.PictureBox();
            this.DS2 = new System.Windows.Forms.PictureBox();
            this.DS3 = new System.Windows.Forms.PictureBox();
            this.DS4 = new System.Windows.Forms.PictureBox();
            this.DS5 = new System.Windows.Forms.PictureBox();
            this.DS6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS6)).BeginInit();
            this.SuspendLayout();
            // 
            // DS1
            // 
            this.DS1.InitialImage = global::Dobbelsteen.Properties.Resources.DS1;
            this.DS1.Location = new System.Drawing.Point(23, 12);
            this.DS1.Name = "DS1";
            this.DS1.Size = new System.Drawing.Size(200, 200);
            this.DS1.TabIndex = 0;
            this.DS1.TabStop = false;
            this.DS1.Click += new System.EventHandler(this.DS1_Click);
            // 
            // DS2
            // 
            this.DS2.InitialImage = ((System.Drawing.Image)(resources.GetObject("DS2.InitialImage")));
            this.DS2.Location = new System.Drawing.Point(271, 12);
            this.DS2.Name = "DS2";
            this.DS2.Size = new System.Drawing.Size(200, 200);
            this.DS2.TabIndex = 1;
            this.DS2.TabStop = false;
            this.DS2.Click += new System.EventHandler(this.DS2_Click);
            // 
            // DS3
            // 
            this.DS3.InitialImage = ((System.Drawing.Image)(resources.GetObject("DS3.InitialImage")));
            this.DS3.Location = new System.Drawing.Point(526, 12);
            this.DS3.Name = "DS3";
            this.DS3.Size = new System.Drawing.Size(200, 200);
            this.DS3.TabIndex = 2;
            this.DS3.TabStop = false;
            this.DS3.Click += new System.EventHandler(this.DS3_Click);
            // 
            // DS4
            // 
            this.DS4.InitialImage = ((System.Drawing.Image)(resources.GetObject("DS4.InitialImage")));
            this.DS4.Location = new System.Drawing.Point(23, 229);
            this.DS4.Name = "DS4";
            this.DS4.Size = new System.Drawing.Size(200, 200);
            this.DS4.TabIndex = 3;
            this.DS4.TabStop = false;
            this.DS4.Click += new System.EventHandler(this.DS4_Click);
            // 
            // DS5
            // 
            this.DS5.InitialImage = ((System.Drawing.Image)(resources.GetObject("DS5.InitialImage")));
            this.DS5.Location = new System.Drawing.Point(271, 229);
            this.DS5.Name = "DS5";
            this.DS5.Size = new System.Drawing.Size(200, 200);
            this.DS5.TabIndex = 4;
            this.DS5.TabStop = false;
            this.DS5.Click += new System.EventHandler(this.DS5_Click);
            // 
            // DS6
            // 
            this.DS6.InitialImage = ((System.Drawing.Image)(resources.GetObject("DS6.InitialImage")));
            this.DS6.Location = new System.Drawing.Point(526, 229);
            this.DS6.Name = "DS6";
            this.DS6.Size = new System.Drawing.Size(200, 200);
            this.DS6.TabIndex = 5;
            this.DS6.TabStop = false;
            this.DS6.Click += new System.EventHandler(this.DS6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dobbelsteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DS6);
            this.Controls.Add(this.DS5);
            this.Controls.Add(this.DS4);
            this.Controls.Add(this.DS3);
            this.Controls.Add(this.DS2);
            this.Controls.Add(this.DS1);
            this.Name = "Dobbelsteen";
            this.Text = "Dobbelsteen";
            this.Load += new System.EventHandler(this.Dobbelsteen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DS1;
        private System.Windows.Forms.PictureBox DS2;
        private System.Windows.Forms.PictureBox DS3;
        private System.Windows.Forms.PictureBox DS4;
        private System.Windows.Forms.PictureBox DS5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox DS6;
    }
}

