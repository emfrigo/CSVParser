using System;
using System.IO;
using System.Collections;

namespace CSVParser
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			String archivo;
			//"/home/sdarkland/Repositorios/CSVParser/registro.csv"

			Console.Write("Ingrese ruta del archivo a leer: ");
			archivo = Console.ReadLine();
			 new MainClass().Lector(archivo);

		}

		public void Lector(string ruta){
		try {

				StreamReader reader = new StreamReader(ruta);

				String linea = reader.ReadLine();
				ArrayList lista = new ArrayList();
	
				while (linea != null) 
					{
					Persona persona = new Persona();
					String[] campos = linea.Split(',');

					persona.id = int.Parse(campos[0]);
					persona.nombre = campos[1];
					persona.domicilio = campos[2];
					persona.telefono = campos[3];

					lista.Add(persona);
					linea = reader.ReadLine();

					}

					reader.Close();

				for(int i = 0; i <= lista.Count-1 ; i++)
				{
					Persona per = (Persona)lista[i];

				Console.WriteLine("|" + per.id + "|" + per.nombre + "|" + per.domicilio + "|" + per.telefono + "|");
	
				}


			} catch(Exception e) {

				Console.WriteLine("Error \n No se encuentra registro");

			}
		}

	}
}
