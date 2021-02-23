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



        private List<PointLatLng> puntos;

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
            }
            catch (Exception exp)
            {
                //Console.WriteLine(exp.Message);
                //Console.WriteLine(exp.ToString());

            }



        }
        //  dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Municipio", cbFilter.Text);
        private void noFiltersButton_Click(object sender, EventArgs e)
        {
            dT.Clear();
            dT.DefaultView.RowFilter = string.Empty;
            database.DataSource = dT;
            // Console.WriteLine("Aqui estoy");

            loadDataBase(false);
            //Console.WriteLine(counter);
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
            Console.WriteLine("Aqui estoy lex");
            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "Dígito Verificación NIT", int.Parse(textBoxDigitMin.Text),int.Parse(textBoxDigitMax.Text));
           
            // dT.DefaultView.RowFilter = "Dígito Verificación NIT > '" + int.Parse(textBoxDigitMin.Text) + "' AND Dígito Verificación NIT < '" + int.Parse(textBoxDigitMax.Text)+"'";

        }
    }
}

