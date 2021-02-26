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
using System.Globalization;

namespace Antioquia_Hospitals
{
    public partial class Interface : Form
    {
        private DataManager dm;
        private DataTable dT = new DataTable();
        private int counter;



        private double[] dLat;
        private double[] dLongi;
        private List<PointLatLng> puntos;
        private List<string> hospitals;
        //private var hospitals;

        GMapOverlay markers = new GMapOverlay("markers");
        public Interface()
        {

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
                hospitals = dT.AsEnumerable().Select(p => p.Field<string>("Nombre Sede")).ToList();
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
            labelRegion.Visible = false;
            comboBoxRegions.Visible = false;
            okButtonRegion.Visible = false;
            labelMunicips.Visible = false;
            textBoxMunicips.Visible = false;
            okButtonMunicips.Visible = false;
            labelDigitVerif1.Visible = false;
            labelDigitVerif2.Visible = false;
            textBoxDigitMax.Visible = false;
            textBoxDigitMin.Visible = false;
            comboBoxRegions.Refresh();
            textBoxMunicips.Clear();
            textBoxDigitMax.Clear();
            textBoxDigitMin.Clear();
            filterComboBox.Refresh();
            markers.Clear();

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
            DataView dv = new DataView(dT);
            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "Nombre Municipio", textBoxMunicips.Text);
            createListOfCoordinates(dT.DefaultView);
            createMarkers();
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

            gMap.Position = new PointLatLng(6.55, -75.817);
            

        }

        private void createMarkers()   //Mostrar municipios de Colombia
        {
           
            int i = 0;
            Console.WriteLine(dLat.Length+ "S");
            while (i<dLat.Length) 
            {
                
                PointLatLng pointLatLng1 = new PointLatLng(dLat[i], dLongi[i]);

                //Las anteriores dos lineas proveen las funcionalidades para hacer la georeferenciación inversa

                if (pointLatLng1 != null)
                {
                    Console.WriteLine(pointLatLng1.Lat + " lat "+ pointLatLng1.Lng+" long");
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Lat, pointLatLng1.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = hospitals[i] + "\n" + pointLatLng1.Lat + "\n" + pointLatLng1.Lng; // Esta linea es solo apariencia
                    markers.Markers.Add(marker00);

                }
                i++;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void createListOfCoordinates(DataView dv)
        {
            dLat = null;
            dLongi = null;
            
            string[] lat = dv.ToTable().Rows.Cast<DataRow>().Select(p => p.Field<string>("Latitud")).ToArray();
            string[] longi = dv.ToTable().Rows.Cast<DataRow>().Select(s => s.Field<string>("Longitud")).ToArray();
            dLat = new double[lat.Length];
            dLongi = new double[longi.Length];
            int i = 0;
           // long pruf = long.Parse(lat[0]);
           // Console.WriteLine(pruf + " veam");
           
            while(i<longi.Length)
            {
                int length1 = lat[i].Length;
                lat[i] = lat[i].Substring(2, length1-3);
                //Console.WriteLine(lat[i]);
                dLat[i] = double.Parse(lat[i], CultureInfo.InvariantCulture);
                int length2 = longi[i].Length;
                longi[i] = longi[i].Substring(0,length2-3);
                dLongi[i] = double.Parse(longi[i],CultureInfo.InvariantCulture);
                //Console.WriteLine(longi[i]);
                i++;
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            String selection = filterComboBox.Text;

            if (selection.Equals("Región"))
            {
                labelRegion.Visible = true;
                comboBoxRegions.Visible = true;
                okButtonRegion.Visible = true;
                labelMunicips.Visible = false;
                textBoxMunicips.Visible = false;
                okButtonMunicips.Visible = false;
                labelDigitVerif1.Visible = false;
                labelDigitVerif2.Visible = false;
                textBoxDigitMax.Visible = false;
                textBoxDigitMin.Visible = false;




            }
            else if (selection.Equals("Municipio"))
            {
                labelRegion.Visible = false;
                comboBoxRegions.Visible = false;
                okButtonRegion.Visible = false;
                labelMunicips.Visible = true;
                textBoxMunicips.Visible = true;
                okButtonMunicips.Visible = true;
                labelDigitVerif1.Visible = false;
                labelDigitVerif2.Visible = false;
                textBoxDigitMax.Visible = false;
                textBoxDigitMin.Visible = false;

            }
            else if (selection.Equals("Digito de verificiación NIT")) 
            {
                labelRegion.Visible = false;
                comboBoxRegions.Visible = false;
                okButtonRegion.Visible = false;
                labelMunicips.Visible = false;
                textBoxMunicips.Visible = false;
                okButtonMunicips.Visible = true;
                labelDigitVerif1.Visible = true;
                labelDigitVerif2.Visible = true;
                textBoxDigitMax.Visible = true;
                textBoxDigitMin.Visible = true;
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

