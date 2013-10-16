using System;
using System.IO;
using System.Collections;

namespace CSVParser
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{

			try {

				StreamReader reader = new StreamReader("/home/sdarkland/Repositorios/CSVParser/registro.csv");

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

			} catch(Exception e) {
				Console.WriteLine("Error \n No se encuentra registro");

			}
		}
	}
}
