using System;

public class DataManager

{

    
    //Disclaimer, this class is adapted from the user SanchezFelipe01/Gmaps_Example on git hub

    //Deberan poner la ruta de su pc
    private const string PATH = "D:\\Documentos\\VisualStudioWorkSpace\\GmapsBeta\\Gmaps\\Data\\data.csv";
    List<string> lista; //Aqui van los municipios

    public DataManager()
    {

        lista = new List<string>();
        readInfo();

    }

    private void readInfo()
    {

        var reader = new StreamReader(File.OpenRead(PATH));
        int count = 0;
        while (!reader.EndOfStream && count < 100)
        {

            var line = reader.ReadLine();
            var arreglo = line.Split(',');

            lista.Add(arreglo[4] + ", Colombia"); //Se concatena el nombre del municipio con la cadena ", Colombia"
            count++;                              //Para más precisión pueden concatenar el departamento.  
        }

    }

    public List<string> getLista()
    {

        return lista;

    }

}
}
