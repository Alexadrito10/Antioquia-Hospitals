
namespace Antioquia_Hospitals
{
    partial class Interface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database = new System.Windows.Forms.DataGridView();
            this.noFilterButton = new System.Windows.Forms.Button();
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxMunicips = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.textBoxDigitMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDigitMax = new System.Windows.Forms.TextBox();
            this.okButtonRegion = new System.Windows.Forms.Button();
            this.okButtonMunicips = new System.Windows.Forms.Button();
            this.okButtonVerifications = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            this.SuspendLayout();
            // 
            // database
            // 
            this.database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database.Location = new System.Drawing.Point(22, 44);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(468, 283);
            this.database.TabIndex = 0;
            this.database.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // noFilterButton
            // 
            this.noFilterButton.Location = new System.Drawing.Point(513, 179);
            this.noFilterButton.Name = "noFilterButton";
            this.noFilterButton.Size = new System.Drawing.Size(75, 23);
            this.noFilterButton.TabIndex = 1;
            this.noFilterButton.Text = "Quitar filtros";
            this.noFilterButton.UseVisualStyleBackColor = true;
            this.noFilterButton.Click += new System.EventHandler(this.noFiltersButton_Click);
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Items.AddRange(new object[] {
            "Bajo Cauca",
            "Magdalena Medio",
            "Nordeste",
            "Norte",
            "Occidente",
            "Oriente",
            "Suroeste",
            "Urabá",
            "Valle de Aburrá"});
            this.comboBoxRegions.Location = new System.Drawing.Point(649, 44);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(125, 21);
            this.comboBoxRegions.TabIndex = 2;
            this.comboBoxRegions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por región";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxMunicips
            // 
            this.textBoxMunicips.Location = new System.Drawing.Point(649, 88);
            this.textBoxMunicips.Name = "textBoxMunicips";
            this.textBoxMunicips.Size = new System.Drawing.Size(125, 20);
            this.textBoxMunicips.TabIndex = 5;
            this.textBoxMunicips.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por municipio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filtrar por digito de verificación, desde";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(22, 343);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(468, 342);
            this.gMapControl1.TabIndex = 8;
            this.gMapControl1.Zoom = 0D;
            // 
            // textBoxDigitMin
            // 
            this.textBoxDigitMin.Location = new System.Drawing.Point(691, 129);
            this.textBoxDigitMin.Name = "textBoxDigitMin";
            this.textBoxDigitMin.Size = new System.Drawing.Size(83, 20);
            this.textBoxDigitMin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "hasta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxDigitMax
            // 
            this.textBoxDigitMax.Location = new System.Drawing.Point(819, 129);
            this.textBoxDigitMax.Name = "textBoxDigitMax";
            this.textBoxDigitMax.Size = new System.Drawing.Size(79, 20);
            this.textBoxDigitMax.TabIndex = 11;
            // 
            // okButtonRegion
            // 
            this.okButtonRegion.Location = new System.Drawing.Point(780, 44);
            this.okButtonRegion.Name = "okButtonRegion";
            this.okButtonRegion.Size = new System.Drawing.Size(75, 23);
            this.okButtonRegion.TabIndex = 12;
            this.okButtonRegion.Text = "Ok";
            this.okButtonRegion.UseVisualStyleBackColor = true;
            this.okButtonRegion.Click += new System.EventHandler(this.buttonOkRegion_Click);
            // 
            // okButtonMunicips
            // 
            this.okButtonMunicips.Location = new System.Drawing.Point(783, 85);
            this.okButtonMunicips.Name = "okButtonMunicips";
            this.okButtonMunicips.Size = new System.Drawing.Size(75, 23);
            this.okButtonMunicips.TabIndex = 14;
            this.okButtonMunicips.Text = "Ok";
            this.okButtonMunicips.UseVisualStyleBackColor = true;
            this.okButtonMunicips.Click += new System.EventHandler(this.buttonOkMunicips_Click);
            // 
            // okButtonVerifications
            // 
            this.okButtonVerifications.Location = new System.Drawing.Point(904, 127);
            this.okButtonVerifications.Name = "okButtonVerifications";
            this.okButtonVerifications.Size = new System.Drawing.Size(75, 23);
            this.okButtonVerifications.TabIndex = 15;
            this.okButtonVerifications.Text = "Ok";
            this.okButtonVerifications.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.okButtonVerifications);
            this.Controls.Add(this.okButtonMunicips);
            this.Controls.Add(this.okButtonRegion);
            this.Controls.Add(this.textBoxDigitMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDigitMin);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMunicips);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRegions);
            this.Controls.Add(this.noFilterButton);
            this.Controls.Add(this.database);
            this.Name = "Interface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView database;
        private System.Windows.Forms.Button noFilterButton;
        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxMunicips;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox textBoxDigitMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDigitMax;
        private System.Windows.Forms.Button okButtonRegion;
        private System.Windows.Forms.Button okButtonMunicips;
        private System.Windows.Forms.Button okButtonVerifications;
    }
}

