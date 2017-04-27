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
            this.lblPensando = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlCartasCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCartasCasa
            // 
            this.pnlCartasCasa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCartasCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCartasCasa.Controls.Add(this.lblTitle);
            this.pnlCartasCasa.Location = new System.Drawing.Point(229, 12);
            this.pnlCartasCasa.Name = "pnlCartasCasa";
            this.pnlCartasCasa.Size = new System.Drawing.Size(476, 225);
            this.pnlCartasCasa.TabIndex = 4;
            this.pnlCartasCasa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCartasCasa_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(421, 193);
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
            this.pBArriba.Location = new System.Drawing.Point(52, 39);
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
            this.pbDebajo.Location = new System.Drawing.Point(65, 39);
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
            this.panel1.Location = new System.Drawing.Point(12, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 159);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jugador";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPensando);
            this.panel2.Location = new System.Drawing.Point(229, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 48);
            this.panel2.TabIndex = 9;
            // 
            // lblPensando
            // 
            this.lblPensando.AutoSize = true;
            this.lblPensando.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensando.Location = new System.Drawing.Point(146, 6);
            this.lblPensando.Name = "lblPensando";
            this.lblPensando.Size = new System.Drawing.Size(145, 33);
            this.lblPensando.TabIndex = 0;
            this.lblPensando.Text = "Pensando";
            this.lblPensando.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 523);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 1);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Apostar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kendall Umaña Alvarado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apuesta máxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apuesta mínima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "2 Fichas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "50 Fichas";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(487, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 89);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(12, 473);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 89);
            this.panel5.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(507, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "Pedir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(487, 472);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Listo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 601);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBArriba);
            this.Controls.Add(this.pbDebajo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCartasCasa);
            this.MinimumSize = new System.Drawing.Size(519, 601);
            this.Name = "Juego";
            this.pnlCartasCasa.ResumeLayout(false);
            this.pnlCartasCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblPensando;
    }
}