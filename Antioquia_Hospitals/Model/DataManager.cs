using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

public class DataManager
{
	
	List<string> lista; //Aqui van los municipio

	public DataManager()
	{
    
		lista = new List<string>();

        string realpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Antioquia_Hospitals\\Data\\database.csv";
        Console.WriteLine(realpath + "HOLI");

        readInfo();

    }

    private void readInfo() {

        //System.Uri uri1 = new Uri(@"C:\\database.csv");

        //System.Uri uri2 = new Uri(@"C:\\Users\\aleja\\source\\repos\\Antioquia_Hospitals\\Antioquia_Hospitals\\Data\\");
        //Uri path = uri2.MakeRelativeUri(uri1);

        // string realpath = path.ToString();
        string realpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\database.csv";
        Console.WriteLine(realpath);
        var reader = new StreamReader(File.OpenRead(realpath));
        int count = 0;
        while (!reader.EndOfStream)
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
