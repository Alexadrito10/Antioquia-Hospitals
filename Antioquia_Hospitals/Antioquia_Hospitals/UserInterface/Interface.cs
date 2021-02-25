using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.IO;

namespace Antioquia_Hospitals
{
    public partial class Interface : Form
    {
        private DataManager dm;
        private DataTable dT = new DataTable();
        private int counter;



        private List<double> dLat;
        private List<double> dLongi
        private List<PointLatLng> puntos;
        private var hospitals;

        GMapOverlay markers = new GMapOverlay("markers");
        public Interface()
        {
             dLat = new List<double>();
             dLongi = new List<double>();
            InitializeComponent();
         
            dm = new DataManager();
            loadDataBase(true);
            
            puntos = new List<PointLatLng>();
            counter = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        { }


        private void loadDataBase(bool reload)
        {
            try
            {
                // string realpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\database.csv";
                string realpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\database.csv";
                //Console.WriteLine(realpath);
                StreamReader streamReader = new StreamReader(realpath);
                counter++;
                string read;
                string[] titles;

                if ((titles = streamReader.ReadLine().Split(',')) != null && reload)
                {

                    dT.Columns.Add(titles[0]);
                    dT.Columns.Add(titles[1]);
                    dT.Columns.Add(titles[2]);
                    dT.Columns.Add(titles[3]);
                    dT.Columns.Add(titles[4]);
                    dT.Columns.Add(titles[5]);
                    dT.Columns.Add(titles[6]);
                    dT.Columns.Add(titles[7]);
                    dT.Columns.Add(titles[8]);
                    dT.Columns.Add(titles[9]);
                    dT.Columns.Add(titles[10]);
                    dT.Columns.Add(titles[11]);
                    dT.Columns.Add("Latitud");
                    dT.Columns.Add("Longitud");

                }

                //bool titles=true;

                //Console.WriteLine("Esta es el streamReader: "+streamReader.ReadLine());
                while ((read = streamReader.ReadLine()) != null)
                {

                    string[] rowRaw = read.Split(',');

                    //Console.WriteLine("Esta es la variable read :"+ read);


                    dT.Rows.Add(rowRaw);
                    database.DataSource = dT;



                }
                var hospitals = dT.AsEnumerable().Select(p => p.Field<string>("Nombre Sede")).ToList();
            }
            catch (Exception exp)
            {
                //Console.WriteLine(exp.Message);
                //Console.WriteLine(exp.ToString());

            }



        }
      
        private void noFiltersButton_Click(object sender, EventArgs e)
        {
            dT.Clear();
            dT.DefaultView.RowFilter = string.Empty;
            database.DataSource = dT;

            loadDataBase(false);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonOkRegion_Click(object sender, EventArgs e)
        {
            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Región", comboBoxRegions.Text);

        }

        private void buttonOkMunicips_Click(object sender, EventArgs e)
        {

            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "Nombre Municipio", textBoxMunicips.Text);

        }

        private void buttonOkVerifications_Click(object sender, EventArgs e)
        {
            
            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Dígito Verificación NIT", int.Parse(textBoxDigitMin.Text),int.Parse(textBoxDigitMax.Text));
           
           
        }

        private void gMap_Load (object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance;  //Proveedor del servicio
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.Overlays.Add(markers);

            gMap.Position = new PointLatLng(3.42158, -76.5205);
            createListOfCoordinates();
            markers();
        }

        private void markers()   //Mostrar municipios de Colombia
        {
           
            int i = 0;
            while (i<dLat.Count) 
            {
                GeoCoderStatusCode statusCode;
                PointLatLng pointLatLng1 = new PointLatLng(dLat[i], dLongi[i]);

                //Las anteriores dos lineas proveen las funcionalidades para hacer la georeferenciación inversa

                if (pointLatLng1 != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = hospitals[i] + "\n" + pointLatLng1.Value.Lat + "\n" + pointLatLng1.Value.Lng; // Esta linea es solo apariencia
                    markers.Markers.Add(marker00);

                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void createListOfCoordinates()
        {
           var lat =  dT.AsEnumerable().Select(p=> p.Field<string>("Latitud")).ToList();
           var longi = dT.AsEnumerable().Select(p => p.Field<string>("Longitud")).ToList();
            int i = 0;
            while(i<lat.Count)
            {

                lat[i] = lat[i].Replace("(", "");
                dLat[i] = double.Parse(lat[i]);
                longi[i] = longi[i].Replace(")", "");
                dLongi = double.Parse(longi[i]);
                i++;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            String selection = filterComboBox.Text;

            if (selection.Equals("Región")) {
                labelRegion.Visible = true;
                comboBoxRegions.Visible = true;
                okButtonRegion.Visible = true;
                labelMunicips.Visible = false;
                textBoxMunicips.Visible = false;
                okButtonMunicips.Visible = false;
                


            }else if (selection.Equals("Municipio")) 
            {
                labelRegion.Visible = true;
                comboBoxRegions.Visible = true;
                okButtonRegion.Visible = true;
                labelMunicips.Visible = false;
                textBoxMunicips.Visible = false;
                okButtonMunicips.Visible = false;

            }


        }
    }
}

