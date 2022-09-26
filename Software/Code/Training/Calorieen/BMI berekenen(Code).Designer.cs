namespace Calorieen
{
    partial class Form
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
            this.GB_geslacht = new System.Windows.Forms.GroupBox();
            this.RB_man = new System.Windows.Forms.RadioButton();
            this.RB_vrouw = new System.Windows.Forms.RadioButton();
            this.BTN_bereken = new System.Windows.Forms.Button();
            this.GB_levensstijl = new System.Windows.Forms.GroupBox();
            this.RB_nietActief = new System.Windows.Forms.RadioButton();
            this.RB_actief = new System.Windows.Forms.RadioButton();
            this.TB_leeftijd = new System.Windows.Forms.TextBox();
            this.LBL_leeftijd = new System.Windows.Forms.Label();
            this.GB_zwanger = new System.Windows.Forms.GroupBox();
            this.RB_nee = new System.Windows.Forms.RadioButton();
            this.RB_ja = new System.Windows.Forms.RadioButton();
            this.GB_geslacht.SuspendLayout();
            this.GB_levensstijl.SuspendLayout();
            this.GB_zwanger.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_geslacht
            // 
            this.GB_geslacht.Controls.Add(this.RB_vrouw);
            this.GB_geslacht.Controls.Add(this.RB_man);
            this.GB_geslacht.Location = new System.Drawing.Point(13, 13);
            this.GB_geslacht.Name = "GB_geslacht";
            this.GB_geslacht.Size = new System.Drawing.Size(100, 80);
            this.GB_geslacht.TabIndex = 0;
            this.GB_geslacht.TabStop = false;
            this.GB_geslacht.Text = "Geslacht";
            this.GB_geslacht.Enter += new System.EventHandler(this.GB_geslacht_Enter);
            // 
            // RB_man
            // 
            this.RB_man.AutoSize = true;
            this.RB_man.Location = new System.Drawing.Point(6, 21);
            this.RB_man.Name = "RB_man";
            this.RB_man.Size = new System.Drawing.Size(56, 21);
            this.RB_man.TabIndex = 1;
            this.RB_man.TabStop = true;
            this.RB_man.Text = "Man";
            this.RB_man.UseVisualStyleBackColor = true;
            this.RB_man.CheckedChanged += new System.EventHandler(this.RB_man_CheckedChanged);
            // 
            // RB_vrouw
            // 
            this.RB_vrouw.AutoSize = true;
            this.RB_vrouw.Location = new System.Drawing.Point(6, 48);
            this.RB_vrouw.Name = "RB_vrouw";
            this.RB_vrouw.Size = new System.Drawing.Size(68, 21);
            this.RB_vrouw.TabIndex = 2;
            this.RB_vrouw.TabStop = true;
            this.RB_vrouw.Text = "Vrouw";
            this.RB_vrouw.UseVisualStyleBackColor = true;
            this.RB_vrouw.CheckedChanged += new System.EventHandler(this.RB_vrouw_CheckedChanged);
            // 
            // BTN_bereken
            // 
            this.BTN_bereken.Location = new System.Drawing.Point(441, 70);
            this.BTN_bereken.Name = "BTN_bereken";
            this.BTN_bereken.Size = new System.Drawing.Size(75, 23);
            this.BTN_bereken.TabIndex = 1;
            this.BTN_bereken.Text = "Bereken";
            this.BTN_bereken.UseVisualStyleBackColor = true;
            this.BTN_bereken.Click += new System.EventHandler(this.BTN_bereken_Click);
            // 
            // GB_levensstijl
            // 
            this.GB_levensstijl.Controls.Add(this.RB_nietActief);
            this.GB_levensstijl.Controls.Add(this.RB_actief);
            this.GB_levensstijl.Location = new System.Drawing.Point(157, 13);
            this.GB_levensstijl.Name = "GB_levensstijl";
            this.GB_levensstijl.Size = new System.Drawing.Size(100, 80);
            this.GB_levensstijl.TabIndex = 3;
            this.GB_levensstijl.TabStop = false;
            this.GB_levensstijl.Text = "Levensstijl";
            this.GB_levensstijl.Enter += new System.EventHandler(this.GB_levensstijl_Enter);
            // 
            // RB_nietActief
            // 
            this.RB_nietActief.AutoSize = true;
            this.RB_nietActief.Location = new System.Drawing.Point(6, 48);
            this.RB_nietActief.Name = "RB_nietActief";
            this.RB_nietActief.Size = new System.Drawing.Size(92, 21);
            this.RB_nietActief.TabIndex = 2;
            this.RB_nietActief.TabStop = true;
            this.RB_nietActief.Text = "Niet actief";
            this.RB_nietActief.UseVisualStyleBackColor = true;
            this.RB_nietActief.CheckedChanged += new System.EventHandler(this.RB_nietActief_CheckedChanged);
            // 
            // RB_actief
            // 
            this.RB_actief.AutoSize = true;
            this.RB_actief.Location = new System.Drawing.Point(6, 21);
            this.RB_actief.Name = "RB_actief";
            this.RB_actief.Size = new System.Drawing.Size(64, 21);
            this.RB_actief.TabIndex = 1;
            this.RB_actief.TabStop = true;
            this.RB_actief.Text = "Actief";
            this.RB_actief.UseVisualStyleBackColor = true;
            this.RB_actief.CheckedChanged += new System.EventHandler(this.RB_actief_CheckedChanged);
            // 
            // TB_leeftijd
            // 
            this.TB_leeftijd.Location = new System.Drawing.Point(441, 34);
            this.TB_leeftijd.Name = "TB_leeftijd";
            this.TB_leeftijd.Size = new System.Drawing.Size(75, 22);
            this.TB_leeftijd.TabIndex = 4;
            this.TB_leeftijd.TextChanged += new System.EventHandler(this.TB_leeftijd_TextChanged);
            // 
            // LBL_leeftijd
            // 
            this.LBL_leeftijd.AutoSize = true;
            this.LBL_leeftijd.Location = new System.Drawing.Point(438, 13);
            this.LBL_leeftijd.Name = "LBL_leeftijd";
            this.LBL_leeftijd.Size = new System.Drawing.Size(54, 17);
            this.LBL_leeftijd.TabIndex = 5;
            this.LBL_leeftijd.Text = "Leeftijd";
            this.LBL_leeftijd.Click += new System.EventHandler(this.LBL_leeftijd_Click);
            // 
            // GB_zwanger
            // 
            this.GB_zwanger.Controls.Add(this.RB_nee);
            this.GB_zwanger.Controls.Add(this.RB_ja);
            this.GB_zwanger.Location = new System.Drawing.Point(305, 13);
            this.GB_zwanger.Name = "GB_zwanger";
            this.GB_zwanger.Size = new System.Drawing.Size(100, 80);
            this.GB_zwanger.TabIndex = 4;
            this.GB_zwanger.TabStop = false;
            this.GB_zwanger.Text = "Zwanger";
            // 
            // RB_nee
            // 
            this.RB_nee.AutoSize = true;
            this.RB_nee.Location = new System.Drawing.Point(6, 48);
            this.RB_nee.Name = "RB_nee";
            this.RB_nee.Size = new System.Drawing.Size(55, 21);
            this.RB_nee.TabIndex = 2;
            this.RB_nee.TabStop = true;
            this.RB_nee.Text = "Nee";
            this.RB_nee.UseVisualStyleBackColor = true;
            // 
            // RB_ja
            // 
            this.RB_ja.AutoSize = true;
            this.RB_ja.Location = new System.Drawing.Point(6, 21);
            this.RB_ja.Name = "RB_ja";
            this.RB_ja.Size = new System.Drawing.Size(44, 21);
            this.RB_ja.TabIndex = 1;
            this.RB_ja.TabStop = true;
            this.RB_ja.Text = "Ja";
            this.RB_ja.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 106);
            this.Controls.Add(this.GB_zwanger);
            this.Controls.Add(this.LBL_leeftijd);
            this.Controls.Add(this.TB_leeftijd);
            this.Controls.Add(this.GB_levensstijl);
            this.Controls.Add(this.BTN_bereken);
            this.Controls.Add(this.GB_geslacht);
            this.Name = "Form";
            this.Text = "Calorie";
            this.GB_geslacht.ResumeLayout(false);
            this.GB_geslacht.PerformLayout();
            this.GB_levensstijl.ResumeLayout(false);
            this.GB_levensstijl.PerformLayout();
            this.GB_zwanger.ResumeLayout(false);
            this.GB_zwanger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_geslacht;
        private System.Windows.Forms.RadioButton RB_vrouw;
        private System.Windows.Forms.RadioButton RB_man;
        private System.Windows.Forms.Button BTN_bereken;
        private System.Windows.Forms.GroupBox GB_levensstijl;
        private System.Windows.Forms.RadioButton RB_nietActief;
        private System.Windows.Forms.RadioButton RB_actief;
        private System.Windows.Forms.TextBox TB_leeftijd;
        private System.Windows.Forms.Label LBL_leeftijd;
        private System.Windows.Forms.GroupBox GB_zwanger;
        private System.Windows.Forms.RadioButton RB_nee;
        private System.Windows.Forms.RadioButton RB_ja;
    }
}

