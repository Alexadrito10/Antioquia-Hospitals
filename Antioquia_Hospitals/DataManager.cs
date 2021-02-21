using System;

public class DataManager
{
	
	List<string> lista; //Aqui van los municipios

	public DataManager()
	{

		lista = new List<string>();
		readInfo();

	}

    private void readInfo()

        System.Uri uri1 = new Uri(@"C:\database.csv");

    System.Uri uri2 = new Uri(@"C:\Users\aleja\source\repos\Antioquia_Hospitals\");
    Uri path = uri2.MakeRelativeUri(uri1);
    

        var reader = new StreamReader(File.OpenRead(path));
        int count = 0;
        while (!reader.EndOfStream && count < 100)
        {

            var line = reader.ReadLine();
            var arreglo = line.Split(',');

            lista.Add(arreglo[6] +", "+ arreglo[3]+ ", Antioquia, Colombia"); 
            count++;                             
        }

    }

    public List<string> getLista()
    {

        return lista;

    }

}
