namespace SafakSayar
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEgitimBitis = new System.Windows.Forms.Label();
            this.lblEgitimBitis2 = new System.Windows.Forms.Label();
            this.lblHaftaBitis = new System.Windows.Forms.Label();
            this.lblHaftaBitis2 = new System.Windows.Forms.Label();
            this.lblGunBitis = new System.Windows.Forms.Label();
            this.lblGunBitis2 = new System.Windows.Forms.Label();
            this.lblMolaBitis = new System.Windows.Forms.Label();
            this.lblMolaBitis2 = new System.Windows.Forms.Label();
            this.timerMola = new System.Windows.Forms.Timer(this.components);
            this.timerGün = new System.Windows.Forms.Timer(this.components);
            this.timerHafta = new System.Windows.Forms.Timer(this.components);
            this.timerEgitim = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(270, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Şafak Sayar\'ı Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEgitimBitis
            // 
            this.lblEgitimBitis.AutoSize = true;
            this.lblEgitimBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgitimBitis.Location = new System.Drawing.Point(13, 116);
            this.lblEgitimBitis.Name = "lblEgitimBitis";
            this.lblEgitimBitis.Size = new System.Drawing.Size(268, 20);
            this.lblEgitimBitis.TabIndex = 1;
            this.lblEgitimBitis.Text = "Eğitimin Bitimine Kalan Süre : ";
            // 
            // lblEgitimBitis2
            // 
            this.lblEgitimBitis2.AutoSize = true;
            this.lblEgitimBitis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgitimBitis2.ForeColor = System.Drawing.Color.Red;
            this.lblEgitimBitis2.Location = new System.Drawing.Point(356, 116);
            this.lblEgitimBitis2.Name = "lblEgitimBitis2";
            this.lblEgitimBitis2.Size = new System.Drawing.Size(0, 20);
            this.lblEgitimBitis2.TabIndex = 2;
            // 
            // lblHaftaBitis
            // 
            this.lblHaftaBitis.AutoSize = true;
            this.lblHaftaBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaftaBitis.Location = new System.Drawing.Point(13, 178);
            this.lblHaftaBitis.Name = "lblHaftaBitis";
            this.lblHaftaBitis.Size = new System.Drawing.Size(271, 20);
            this.lblHaftaBitis.TabIndex = 1;
            this.lblHaftaBitis.Text = "Haftanın Bitimine Kalan Süre : ";
            // 
            // lblHaftaBitis2
            // 
            this.lblHaftaBitis2.AutoSize = true;
            this.lblHaftaBitis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaftaBitis2.ForeColor = System.Drawing.Color.Red;
            this.lblHaftaBitis2.Location = new System.Drawing.Point(356, 178);
            this.lblHaftaBitis2.Name = "lblHaftaBitis2";
            this.lblHaftaBitis2.Size = new System.Drawing.Size(0, 20);
            this.lblHaftaBitis2.TabIndex = 2;
            // 
            // lblGunBitis
            // 
            this.lblGunBitis.AutoSize = true;
            this.lblGunBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunBitis.Location = new System.Drawing.Point(12, 240);
            this.lblGunBitis.Name = "lblGunBitis";
            this.lblGunBitis.Size = new System.Drawing.Size(254, 20);
            this.lblGunBitis.TabIndex = 1;
            this.lblGunBitis.Text = "Günün Bitimine Kalan Süre : ";
            // 
            // lblGunBitis2
            // 
            this.lblGunBitis2.AutoSize = true;
            this.lblGunBitis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunBitis2.ForeColor = System.Drawing.Color.Red;
            this.lblGunBitis2.Location = new System.Drawing.Point(355, 240);
            this.lblGunBitis2.Name = "lblGunBitis2";
            this.lblGunBitis2.Size = new System.Drawing.Size(0, 20);
            this.lblGunBitis2.TabIndex = 2;
            // 
            // lblMolaBitis
            // 
            this.lblMolaBitis.AutoSize = true;
            this.lblMolaBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMolaBitis.Location = new System.Drawing.Point(12, 298);
            this.lblMolaBitis.Name = "lblMolaBitis";
            this.lblMolaBitis.Size = new System.Drawing.Size(184, 20);
            this.lblMolaBitis.TabIndex = 1;
            this.lblMolaBitis.Text = "Molaya Kalan Süre : ";
            // 
            // lblMolaBitis2
            // 
            this.lblMolaBitis2.AutoSize = true;
            this.lblMolaBitis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMolaBitis2.ForeColor = System.Drawing.Color.Red;
            this.lblMolaBitis2.Location = new System.Drawing.Point(355, 298);
            this.lblMolaBitis2.Name = "lblMolaBitis2";
            this.lblMolaBitis2.Size = new System.Drawing.Size(0, 20);
            this.lblMolaBitis2.TabIndex = 2;
            // 
            // timerMola
            // 
            this.timerMola.Interval = 1000;
            this.timerMola.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerGün
            // 
            this.timerGün.Interval = 1000;
            this.timerGün.Tick += new System.EventHandler(this.timerGün_Tick);
            // 
            // timerHafta
            // 
            this.timerHafta.Interval = 1000;
            this.timerHafta.Tick += new System.EventHandler(this.timerHafta_Tick);
            // 
            // timerEgitim
            // 
            this.timerEgitim.Interval = 1000;
            this.timerEgitim.Tick += new System.EventHandler(this.timerEgitim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 343);
            this.Controls.Add(this.lblMolaBitis2);
            this.Controls.Add(this.lblGunBitis2);
            this.Controls.Add(this.lblHaftaBitis2);
            this.Controls.Add(this.lblEgitimBitis2);
            this.Controls.Add(this.lblMolaBitis);
            this.Controls.Add(this.lblGunBitis);
            this.Controls.Add(this.lblHaftaBitis);
            this.Controls.Add(this.lblEgitimBitis);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEgitimBitis;
        private System.Windows.Forms.Label lblEgitimBitis2;
        private System.Windows.Forms.Label lblHaftaBitis;
        private System.Windows.Forms.Label lblHaftaBitis2;
        private System.Windows.Forms.Label lblGunBitis;
        private System.Windows.Forms.Label lblGunBitis2;
        private System.Windows.Forms.Label lblMolaBitis;
        private System.Windows.Forms.Label lblMolaBitis2;
        private System.Windows.Forms.Timer timerMola;
        private System.Windows.Forms.Timer timerGün;
        private System.Windows.Forms.Timer timerHafta;
        private System.Windows.Forms.Timer timerEgitim;
    }
}

