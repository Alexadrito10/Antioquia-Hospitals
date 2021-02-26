
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
            this.labelRegion = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxMunicips = new System.Windows.Forms.TextBox();
            this.labelMunicips = new System.Windows.Forms.Label();
            this.labelDigitVerif1 = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.textBoxDigitMin = new System.Windows.Forms.TextBox();
            this.labelDigitVerif2 = new System.Windows.Forms.Label();
            this.textBoxDigitMax = new System.Windows.Forms.TextBox();
            this.okButtonRegion = new System.Windows.Forms.Button();
            this.okButtonMunicips = new System.Windows.Forms.Button();
            this.okButtonVerifications = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
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
            this.comboBoxRegions.Visible = false;
            this.comboBoxRegions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(506, 44);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(82, 13);
            this.labelRegion.TabIndex = 3;
            this.labelRegion.Text = "Filtrar por región";
            this.labelRegion.Visible = false;
            this.labelRegion.Click += new System.EventHandler(this.label1_Click);
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
            this.textBoxMunicips.Visible = false;
            this.textBoxMunicips.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMunicips
            // 
            this.labelMunicips.AutoSize = true;
            this.labelMunicips.Location = new System.Drawing.Point(506, 91);
            this.labelMunicips.Name = "labelMunicips";
            this.labelMunicips.Size = new System.Drawing.Size(97, 13);
            this.labelMunicips.TabIndex = 6;
            this.labelMunicips.Text = "Filtrar por municipio";
            this.labelMunicips.Visible = false;
            this.labelMunicips.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDigitVerif1
            // 
            this.labelDigitVerif1.AutoSize = true;
            this.labelDigitVerif1.Location = new System.Drawing.Point(506, 132);
            this.labelDigitVerif1.Name = "labelDigitVerif1";
            this.labelDigitVerif1.Size = new System.Drawing.Size(185, 13);
            this.labelDigitVerif1.TabIndex = 7;
            this.labelDigitVerif1.Text = "Filtrar por digito de verificación, desde";
            this.labelDigitVerif1.Visible = false;
            this.labelDigitVerif1.Click += new System.EventHandler(this.label3_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(22, 369);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 20;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(503, 368);
            this.gMap.TabIndex = 8;
            this.gMap.Zoom = 13D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // textBoxDigitMin
            // 
            this.textBoxDigitMin.Location = new System.Drawing.Point(691, 129);
            this.textBoxDigitMin.Name = "textBoxDigitMin";
            this.textBoxDigitMin.Size = new System.Drawing.Size(83, 20);
            this.textBoxDigitMin.TabIndex = 9;
            this.textBoxDigitMin.Visible = false;
            // 
            // labelDigitVerif2
            // 
            this.labelDigitVerif2.AutoSize = true;
            this.labelDigitVerif2.Location = new System.Drawing.Point(780, 132);
            this.labelDigitVerif2.Name = "labelDigitVerif2";
            this.labelDigitVerif2.Size = new System.Drawing.Size(33, 13);
            this.labelDigitVerif2.TabIndex = 10;
            this.labelDigitVerif2.Text = "hasta";
            this.labelDigitVerif2.Visible = false;
            this.labelDigitVerif2.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxDigitMax
            // 
            this.textBoxDigitMax.Location = new System.Drawing.Point(819, 129);
            this.textBoxDigitMax.Name = "textBoxDigitMax";
            this.textBoxDigitMax.Size = new System.Drawing.Size(79, 20);
            this.textBoxDigitMax.TabIndex = 11;
            this.textBoxDigitMax.Visible = false;
            // 
            // okButtonRegion
            // 
            this.okButtonRegion.Location = new System.Drawing.Point(780, 44);
            this.okButtonRegion.Name = "okButtonRegion";
            this.okButtonRegion.Size = new System.Drawing.Size(75, 23);
            this.okButtonRegion.TabIndex = 12;
            this.okButtonRegion.Text = "Ok";
            this.okButtonRegion.UseVisualStyleBackColor = true;
            this.okButtonRegion.Visible = false;
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
            this.okButtonMunicips.Visible = false;
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
            this.okButtonVerifications.Visible = false;
            this.okButtonVerifications.Click += new System.EventHandler(this.buttonOkVerifications_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Región",
            "Municipio",
            "Digito de verificiación NIT"});
            this.filterComboBox.Location = new System.Drawing.Point(985, 44);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 16;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(886, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Seleccione el filtro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Para visualizar los hospitales debes buscarlos por municipio  en la parte de filt" +
    "ros";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(904, 432);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(464, 293);
            this.cartesianChart1.TabIndex = 19;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(531, 486);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(352, 211);
            this.pieChart1.TabIndex = 20;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(607, 156);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(751, 260);
            this.cartesianChart2.TabIndex = 21;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.okButtonVerifications);
            this.Controls.Add(this.okButtonMunicips);
            this.Controls.Add(this.okButtonRegion);
            this.Controls.Add(this.textBoxDigitMax);
            this.Controls.Add(this.labelDigitVerif2);
            this.Controls.Add(this.textBoxDigitMin);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.labelDigitVerif1);
            this.Controls.Add(this.labelMunicips);
            this.Controls.Add(this.textBoxMunicips);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.comboBoxRegions);
            this.Controls.Add(this.noFilterButton);
            this.Controls.Add(this.database);
            this.Name = "Interface";
            this.Text = "Antioquia Hospitals";
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView database;
        private System.Windows.Forms.Button noFilterButton;
        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxMunicips;
        private System.Windows.Forms.Label labelMunicips;
        private System.Windows.Forms.Label labelDigitVerif1;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.TextBox textBoxDigitMin;
        private System.Windows.Forms.Label labelDigitVerif2;
        private System.Windows.Forms.TextBox textBoxDigitMax;
        private System.Windows.Forms.Button okButtonRegion;
        private System.Windows.Forms.Button okButtonMunicips;
        private System.Windows.Forms.Button okButtonVerifications;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
    }
}

