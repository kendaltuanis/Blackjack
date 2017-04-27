namespace Blackjack.Vistas
{
    partial class Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            this.tilePedirCarta = new MetroFramework.Controls.MetroTile();
            this.pnlBotones = new MetroFramework.Controls.MetroPanel();
            this.tilePlantarse = new MetroFramework.Controls.MetroTile();
            this.tileDoblar = new MetroFramework.Controls.MetroTile();
            this.trackFichas = new MetroFramework.Controls.MetroTrackBar();
            this.pnlCartasCasa = new System.Windows.Forms.Panel();
            this.lblFichas = new MetroFramework.Controls.MetroLabel();
            this.pnlCartasJugador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileApostar = new MetroFramework.Controls.MetroTile();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDeck = new System.Windows.Forms.Label();
            this.picSeguro = new System.Windows.Forms.PictureBox();
            this.lblPensando = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasDeLaPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebarajarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSi = new System.Windows.Forms.Label();
            this.pBArriba = new System.Windows.Forms.PictureBox();
            this.pbDebajo = new System.Windows.Forms.PictureBox();
            this.picFichas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pickFichasDoblar = new System.Windows.Forms.PictureBox();
            this.pnlBotones.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeguro)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickFichasDoblar)).BeginInit();
            this.SuspendLayout();
            // 
            // tilePedirCarta
            // 
            this.tilePedirCarta.ActiveControl = null;
            this.tilePedirCarta.BackColor = System.Drawing.Color.LightGray;
            this.tilePedirCarta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tilePedirCarta.Location = new System.Drawing.Point(9, 12);
            this.tilePedirCarta.Name = "tilePedirCarta";
            this.tilePedirCarta.Size = new System.Drawing.Size(110, 35);
            this.tilePedirCarta.TabIndex = 7;
            this.tilePedirCarta.Text = "Pedir Carta";
            this.tilePedirCarta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePedirCarta.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePedirCarta.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tilePedirCarta.UseCustomBackColor = true;
            this.tilePedirCarta.UseCustomForeColor = true;
            this.tilePedirCarta.UseSelectable = true;
            this.tilePedirCarta.Click += new System.EventHandler(this.tilePedirCarta_Click_1);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.Gray;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotones.Controls.Add(this.tilePlantarse);
            this.pnlBotones.Controls.Add(this.tileDoblar);
            this.pnlBotones.Controls.Add(this.tilePedirCarta);
            this.pnlBotones.HorizontalScrollbarBarColor = true;
            this.pnlBotones.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBotones.HorizontalScrollbarSize = 10;
            this.pnlBotones.Location = new System.Drawing.Point(110, 467);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(375, 58);
            this.pnlBotones.TabIndex = 12;
            this.pnlBotones.UseCustomBackColor = true;
            this.pnlBotones.UseCustomForeColor = true;
            this.pnlBotones.VerticalScrollbarBarColor = true;
            this.pnlBotones.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBotones.VerticalScrollbarSize = 10;
            this.pnlBotones.Visible = false;
            // 
            // tilePlantarse
            // 
            this.tilePlantarse.ActiveControl = null;
            this.tilePlantarse.BackColor = System.Drawing.Color.LightGray;
            this.tilePlantarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tilePlantarse.Location = new System.Drawing.Point(255, 12);
            this.tilePlantarse.Name = "tilePlantarse";
            this.tilePlantarse.Size = new System.Drawing.Size(110, 35);
            this.tilePlantarse.TabIndex = 6;
            this.tilePlantarse.Text = "Plantarse";
            this.tilePlantarse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePlantarse.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePlantarse.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tilePlantarse.UseCustomBackColor = true;
            this.tilePlantarse.UseCustomForeColor = true;
            this.tilePlantarse.UseSelectable = true;
            this.tilePlantarse.Click += new System.EventHandler(this.tilePlantarse_Click);
            // 
            // tileDoblar
            // 
            this.tileDoblar.ActiveControl = null;
            this.tileDoblar.BackColor = System.Drawing.Color.DarkGray;
            this.tileDoblar.Enabled = false;
            this.tileDoblar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tileDoblar.Location = new System.Drawing.Point(131, 12);
            this.tileDoblar.Name = "tileDoblar";
            this.tileDoblar.Size = new System.Drawing.Size(110, 35);
            this.tileDoblar.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDoblar.TabIndex = 7;
            this.tileDoblar.Text = "Doblar";
            this.tileDoblar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileDoblar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileDoblar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileDoblar.UseCustomBackColor = true;
            this.tileDoblar.UseCustomForeColor = true;
            this.tileDoblar.UseSelectable = true;
            this.tileDoblar.Click += new System.EventHandler(this.tileDoblar_Click);
            // 
            // trackFichas
            // 
            this.trackFichas.BackColor = System.Drawing.Color.DimGray;
            this.trackFichas.Location = new System.Drawing.Point(1, 462);
            this.trackFichas.Maximum = 50;
            this.trackFichas.Minimum = 2;
            this.trackFichas.Name = "trackFichas";
            this.trackFichas.Size = new System.Drawing.Size(154, 35);
            this.trackFichas.SmallChange = 2;
            this.trackFichas.Style = MetroFramework.MetroColorStyle.Orange;
            this.trackFichas.TabIndex = 4;
            this.trackFichas.Text = "metroTrackBar1";
            this.trackFichas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackFichas.UseCustomBackColor = true;
            this.trackFichas.Value = 2;
            this.trackFichas.ValueChanged += new System.EventHandler(this.trackFichas_ValueChanged);
            // 
            // pnlCartasCasa
            // 
            this.pnlCartasCasa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlCartasCasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCartasCasa.Location = new System.Drawing.Point(22, 40);
            this.pnlCartasCasa.Name = "pnlCartasCasa";
            this.pnlCartasCasa.Size = new System.Drawing.Size(323, 129);
            this.pnlCartasCasa.TabIndex = 3;
            // 
            // lblFichas
            // 
            this.lblFichas.AutoSize = true;
            this.lblFichas.BackColor = System.Drawing.Color.DimGray;
            this.lblFichas.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFichas.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFichas.ForeColor = System.Drawing.Color.White;
            this.lblFichas.Location = new System.Drawing.Point(52, 455);
            this.lblFichas.Name = "lblFichas";
            this.lblFichas.Size = new System.Drawing.Size(52, 15);
            this.lblFichas.TabIndex = 6;
            this.lblFichas.Text = "Fichas: 2";
            this.lblFichas.UseCustomBackColor = true;
            this.lblFichas.UseCustomForeColor = true;
            // 
            // pnlCartasJugador
            // 
            this.pnlCartasJugador.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlCartasJugador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCartasJugador.Location = new System.Drawing.Point(162, 302);
            this.pnlCartasJugador.Name = "pnlCartasJugador";
            this.pnlCartasJugador.Size = new System.Drawing.Size(323, 129);
            this.pnlCartasJugador.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 1);
            this.panel1.TabIndex = 0;
            // 
            // tileApostar
            // 
            this.tileApostar.ActiveControl = null;
            this.tileApostar.BackColor = System.Drawing.Color.LightGray;
            this.tileApostar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tileApostar.Location = new System.Drawing.Point(22, 489);
            this.tileApostar.Name = "tileApostar";
            this.tileApostar.Size = new System.Drawing.Size(110, 35);
            this.tileApostar.TabIndex = 5;
            this.tileApostar.Text = "Repartir";
            this.tileApostar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileApostar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileApostar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileApostar.UseCustomBackColor = true;
            this.tileApostar.UseCustomForeColor = true;
            this.tileApostar.UseSelectable = true;
            this.tileApostar.Click += new System.EventHandler(this.tileApostar_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlMain.Controls.Add(this.lblDeck);
            this.pnlMain.Controls.Add(this.picSeguro);
            this.pnlMain.Controls.Add(this.lblPensando);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.menuStrip1);
            this.pnlMain.Controls.Add(this.lblSi);
            this.pnlMain.Location = new System.Drawing.Point(-1, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(497, 530);
            this.pnlMain.TabIndex = 13;
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(331, 431);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(0, 12);
            this.lblDeck.TabIndex = 15;
            // 
            // picSeguro
            // 
            this.picSeguro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.picSeguro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSeguro.BackgroundImage")));
            this.picSeguro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSeguro.Location = new System.Drawing.Point(414, 344);
            this.picSeguro.Name = "picSeguro";
            this.picSeguro.Size = new System.Drawing.Size(51, 43);
            this.picSeguro.TabIndex = 14;
            this.picSeguro.TabStop = false;
            // 
            // lblPensando
            // 
            this.lblPensando.AutoSize = true;
            this.lblPensando.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensando.Location = new System.Drawing.Point(248, 200);
            this.lblPensando.Name = "lblPensando";
            this.lblPensando.Size = new System.Drawing.Size(145, 33);
            this.lblPensando.TabIndex = 4;
            this.lblPensando.Text = "Pensando";
            this.lblPensando.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(-12, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(503, 79);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(20, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 63);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "El seguro se paga 2 a 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "El BlackJack se paga 3 a 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "La banca se planta con 17";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.partidasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.reiniciarToolStripMenuItem.Text = "Nuevo juego";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // partidasToolStripMenuItem
            // 
            this.partidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadísticasDeLaPartidaToolStripMenuItem,
            this.rebarajarToolStripMenuItem});
            this.partidasToolStripMenuItem.Name = "partidasToolStripMenuItem";
            this.partidasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.partidasToolStripMenuItem.Text = "Partidas ";
            // 
            // estadísticasDeLaPartidaToolStripMenuItem
            // 
            this.estadísticasDeLaPartidaToolStripMenuItem.Name = "estadísticasDeLaPartidaToolStripMenuItem";
            this.estadísticasDeLaPartidaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.estadísticasDeLaPartidaToolStripMenuItem.Text = "Estadísticas de la Partida";
            this.estadísticasDeLaPartidaToolStripMenuItem.Click += new System.EventHandler(this.estadísticasDeLaPartidaToolStripMenuItem_Click);
            // 
            // rebarajarToolStripMenuItem
            // 
            this.rebarajarToolStripMenuItem.Name = "rebarajarToolStripMenuItem";
            this.rebarajarToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.rebarajarToolStripMenuItem.Text = "Rebarajar";
            this.rebarajarToolStripMenuItem.Click += new System.EventHandler(this.rebarajarToolStripMenuItem_Click);
            // 
            // lblSi
            // 
            this.lblSi.AutoSize = true;
            this.lblSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSi.Font = new System.Drawing.Font("Sitka Heading", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSi.Location = new System.Drawing.Point(95, 200);
            this.lblSi.Name = "lblSi";
            this.lblSi.Size = new System.Drawing.Size(0, 16);
            this.lblSi.TabIndex = 0;
            // 
            // pBArriba
            // 
            this.pBArriba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pBArriba.BackgroundImage = global::Blackjack.Properties.Resources.deck_portada;
            this.pBArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBArriba.Location = new System.Drawing.Point(374, 53);
            this.pBArriba.Name = "pBArriba";
            this.pBArriba.Size = new System.Drawing.Size(76, 103);
            this.pBArriba.TabIndex = 9;
            this.pBArriba.TabStop = false;
            this.pBArriba.WaitOnLoad = true;
            // 
            // pbDebajo
            // 
            this.pbDebajo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbDebajo.BackgroundImage = global::Blackjack.Properties.Resources.deck_portada;
            this.pbDebajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDebajo.Location = new System.Drawing.Point(387, 53);
            this.pbDebajo.Name = "pbDebajo";
            this.pbDebajo.Size = new System.Drawing.Size(76, 103);
            this.pbDebajo.TabIndex = 10;
            this.pbDebajo.TabStop = false;
            this.pbDebajo.WaitOnLoad = true;
            // 
            // picFichas
            // 
            this.picFichas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.picFichas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFichas.BackgroundImage")));
            this.picFichas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFichas.Location = new System.Drawing.Point(-59, 347);
            this.picFichas.Name = "picFichas";
            this.picFichas.Size = new System.Drawing.Size(51, 43);
            this.picFichas.TabIndex = 7;
            this.picFichas.TabStop = false;
            this.picFichas.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.BackgroundImage = global::Blackjack.Properties.Resources.circulo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(70, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pickFichasDoblar
            // 
            this.pickFichasDoblar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pickFichasDoblar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pickFichasDoblar.BackgroundImage")));
            this.pickFichasDoblar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pickFichasDoblar.Location = new System.Drawing.Point(-59, 345);
            this.pickFichasDoblar.Name = "pickFichasDoblar";
            this.pickFichasDoblar.Size = new System.Drawing.Size(51, 43);
            this.pickFichasDoblar.TabIndex = 14;
            this.pickFichasDoblar.TabStop = false;
            this.pickFichasDoblar.Visible = false;
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 533);
            this.ControlBox = false;
            this.Controls.Add(this.pickFichasDoblar);
            this.Controls.Add(this.picFichas);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pBArriba);
            this.Controls.Add(this.pbDebajo);
            this.Controls.Add(this.lblFichas);
            this.Controls.Add(this.tileApostar);
            this.Controls.Add(this.trackFichas);
            this.Controls.Add(this.pnlCartasJugador);
            this.Controls.Add(this.pnlCartasCasa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pantalla";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.pnlBotones.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeguro)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickFichasDoblar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile tilePedirCarta;
        private MetroFramework.Controls.MetroPanel pnlBotones;
        private MetroFramework.Controls.MetroTile tilePlantarse;
        private System.Windows.Forms.PictureBox pbDebajo;
        private MetroFramework.Controls.MetroTrackBar trackFichas;
        private System.Windows.Forms.Panel pnlCartasCasa;
        private MetroFramework.Controls.MetroLabel lblFichas;
        private System.Windows.Forms.PictureBox pBArriba;
        private System.Windows.Forms.Panel pnlCartasJugador;
        private System.Windows.Forms.PictureBox picFichas;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile tileApostar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidasToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPensando;
        private System.Windows.Forms.PictureBox picSeguro;
        private System.Windows.Forms.ToolStripMenuItem estadísticasDeLaPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebarajarToolStripMenuItem;
        private System.Windows.Forms.Label lblDeck;
        private MetroFramework.Controls.MetroTile tileDoblar;
        private System.Windows.Forms.PictureBox pickFichasDoblar;
    }
}