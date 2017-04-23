namespace Blackjack.Vistas
{
    partial class Juego
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
            this.pnlCartasCasa = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pBArriba = new System.Windows.Forms.PictureBox();
            this.pbDebajo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCartasCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCartasCasa
            // 
            this.pnlCartasCasa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCartasCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCartasCasa.Controls.Add(this.lblTitle);
            this.pnlCartasCasa.Location = new System.Drawing.Point(252, 12);
            this.pnlCartasCasa.MaximumSize = new System.Drawing.Size(287, 225);
            this.pnlCartasCasa.Name = "pnlCartasCasa";
            this.pnlCartasCasa.Size = new System.Drawing.Size(237, 225);
            this.pnlCartasCasa.TabIndex = 4;
            this.pnlCartasCasa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCartasCasa_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(94, 170);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 19);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Casa";
            // 
            // pBArriba
            // 
            this.pBArriba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pBArriba.BackgroundImage = global::Blackjack.Properties.Resources.deck_portada;
            this.pBArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBArriba.Location = new System.Drawing.Point(62, 37);
            this.pBArriba.Name = "pBArriba";
            this.pBArriba.Size = new System.Drawing.Size(114, 156);
            this.pBArriba.TabIndex = 6;
            this.pBArriba.TabStop = false;
            this.pBArriba.WaitOnLoad = true;
            // 
            // pbDebajo
            // 
            this.pbDebajo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbDebajo.BackgroundImage = global::Blackjack.Properties.Resources.deck_portada;
            this.pbDebajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDebajo.Location = new System.Drawing.Point(75, 37);
            this.pbDebajo.Name = "pbDebajo";
            this.pbDebajo.Size = new System.Drawing.Size(114, 156);
            this.pbDebajo.TabIndex = 7;
            this.pbDebajo.TabStop = false;
            this.pbDebajo.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 147);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Casa";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 48);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.BackgroundImage = global::Blackjack.Properties.Resources.fichas;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(6, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 60);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = global::Blackjack.Properties.Resources.fichas;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(123, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 60);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 71);
            this.panel3.TabIndex = 10;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBArriba);
            this.Controls.Add(this.pbDebajo);
            this.Controls.Add(this.pnlCartasCasa);
            this.MaximumSize = new System.Drawing.Size(519, 601);
            this.MinimumSize = new System.Drawing.Size(519, 601);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.pnlCartasCasa.ResumeLayout(false);
            this.pnlCartasCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCartasCasa;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pBArriba;
        private System.Windows.Forms.PictureBox pbDebajo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
    }
}