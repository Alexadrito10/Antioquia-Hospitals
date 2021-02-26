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
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Defaults;

namespace Antioquia_Hospitals
{
    public partial class Interface : Form
    {
        
        private DataTable dT = new DataTable();
        private int counter;
        int[] regions;


        private double[] dLat;
        private double[] dLongi;
        private List<PointLatLng> puntos;
        private List<string> hospitals;
        private List<string> cities;


        GMapOverlay markers = new GMapOverlay("markers");
        public Interface()
        {

            InitializeComponent();
            
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
                while ((read = streamReader.ReadLine()) != null)
                {

                    string[] rowRaw = read.Split(',');


                    dT.Rows.Add(rowRaw);
                    database.DataSource = dT;



                }
                
                charts();
            }

            catch (Exception exp)
            {

            }



        }

        private void charts()
        {
            getNumRegions();
            pieChart1.Series.Clear();
            Func<ChartPoint, String> labelPoint = chartPoint => string.Format("{0}({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                 new PieSeries {
                Title = "Norte",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[0])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Nordeste",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[1])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Suroeste",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[2])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Occidente",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[3])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Oriente",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[4])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Urabá",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[5])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Bajo Cauca",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[6])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Magdalena Medio",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[7])},
                DataLabels = true,
                LabelPoint = labelPoint

                },
                 new PieSeries {
                Title = "Valle de Aburrá",
                Values = new ChartValues<ObservableValue>{ new ObservableValue(regions[8])},
                DataLabels = true,
                LabelPoint = labelPoint

                },


            };
            cartesianChart1.AxisY = new AxesCollection
            {
                 new Axis {
                Title = "Hospitales por region",
                Labels = new[]{"Norte","Nordeste", "Suroeste", "Occidente","Oriente","Urabá","Bajo Cauca","Magdalena Medio","Valle de Aburra"},
                Separator = new Separator{Step = 1}

                },


            };

            cartesianChart1.Series.Clear();
            
            cartesianChart2.AxisX = new AxesCollection
            {
                 new Axis {
                Title = "Hospitales por region",
                Labels = new[]{"Norte","Nordeste", "Suroeste", "Occidente","Oriente","Urabá","Bajo Cauca","Magdalena Medio","Valle de Aburra"},
                Separator = new Separator{Step = 1},
                

                },


            };

            cartesianChart2.Series.Clear();
            

            SeriesCollection sc1 = new SeriesCollection
                    {
                        new RowSeries
                        {
                            Title = "Cantidad",
                            Values = new ChartValues<int>{regions[0],regions[1], regions[2], regions[3], regions[4], regions[5], regions[6], regions[7], regions[8] },
                        },
                    };
            cartesianChart1.Series = sc1;
            SeriesCollection sc2 = new SeriesCollection
                    {
                        new ColumnSeries
                        {
                            Title = "Cantidad",
                            Values = new ChartValues<int>{regions[0],regions[1], regions[2], regions[3], regions[4], regions[5], regions[6], regions[7], regions[8] },
                        },
                    };
            
            cartesianChart2.Series = sc2;

        }

        private void getNumRegions()
        {
            regions = new int[9];
            string[] regionsS = dT.DefaultView.ToTable().Rows.Cast<DataRow>().Select(p => p.Field<string>("Nombre Región")).ToArray();
            int c = 0;
            while (c < regionsS.Length)
            {
                if(regionsS[c] == "Norte")
                {
                    regions[0]++;
                }
                else if (regionsS[c] == "Nordeste")
                {
                    regions[1]++;
                }
                else if (regionsS[c] == "Suroeste")
                {
                    regions[2]++;
                }
                else if (regionsS[c] == "Occidente")
                {
                    regions[3]++;
                }
                else if (regionsS[c] == "Oriente")
                {
                    regions[4]++;
                }
                else if (regionsS[c] == "Urabá")
                {
                    regions[5]++;
                }
                else if (regionsS[c] == "Bajo Cauca")
                {
                    regions[6]++;
                }
                else if (regionsS[c] == "Magdalena Medio")
                {
                    regions[7]++;
                }
                else if (regionsS[c] == "Valle de Aburrá")
                {
                    regions[8]++;
                }
                
                    c++;
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
            
            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "Nombre Municipio", textBoxMunicips.Text);
            cities = dT.DefaultView.ToTable().Rows.Cast<DataRow>().Select(p => p.Field<string>("Nombre Municipio")).ToList();
            hospitals = dT.DefaultView.ToTable().Rows.Cast<DataRow>().Select(p => p.Field<string>("Nombre Sede")).ToList();
            createListOfCoordinates(dT.DefaultView);
            createMarkers();
        }

        private void buttonOkVerifications_Click(object sender, EventArgs e)
        {
            
            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Dígito Verificación NIT", int.Parse(textBoxDigitMin.Text),int.Parse(textBoxDigitMax.Text));
            

        }

        private void gMap_Load (object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance; 
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.Overlays.Add(markers);

            gMap.Position = new PointLatLng(6.55, -75.817);
            

        }

        private void createMarkers()   
        {
           
            int i = 0;
            Console.WriteLine(dLat.Length+ "S");
            while (i<dLat.Length) 
            {
                
                PointLatLng pointLatLng1 = new PointLatLng(dLat[i], dLongi[i]);

               

                if (pointLatLng1 != null)
                {
                    Console.WriteLine(pointLatLng1.Lat + " lat "+ pointLatLng1.Lng+" long");
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Lat, pointLatLng1.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = hospitals[i] + "\n"+ cities[i]+ ", Antioquia, Colombia \n" + pointLatLng1.Lat + "\n" + pointLatLng1.Lng; // Esta linea es solo apariencia
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
        
           
            while(i<longi.Length)
            {
                int length1 = lat[i].Length;
                lat[i] = lat[i].Substring(2, length1-3);
               
                dLat[i] = double.Parse(lat[i], CultureInfo.InvariantCulture);
                int length2 = longi[i].Length;
                longi[i] = longi[i].Substring(0,length2-3);
                dLongi[i] = double.Parse(longi[i],CultureInfo.InvariantCulture);
               
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
                okButtonMunicips.Visible = false;
                okButtonVerifications.Visible = true;
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

