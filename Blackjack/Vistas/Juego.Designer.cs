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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlCartasCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(94, 170);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 20);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 71);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Apostar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Doblar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Split";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 562);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}