using System;
using System.IO;

namespace archivos
{
	public class Archivo
	{
		private string path;
		
		public Archivo (String path)
		{
			this.path = path;
		}
		
		public void setPath(String path){
			this.path = path;
		}
		
		public void leer(){
			String linea;
			try 
				{
					//Se indica el archivo a leer
					StreamReader lector = new StreamReader(this.path);
	
					//Lee la primera linea del archivo
					linea = lector.ReadLine();
	
					//Continua leyendo hasta que se termina el archivo
					while (linea != null) 
					{
						//Escribe la linea en la consola
						Console.WriteLine(linea);
						//Lee la siguiente linea
						linea = lector.ReadLine();
					}
	
					//cierra el lector
					lector.Close();
					Console.ReadLine();
				}
				catch(Exception e)
				{
					Console.WriteLine("Exception: " + e.Message);
				}
			   	finally 
				{
					Console.WriteLine("Cerrando la lectura.");
				}
		}
		
		public void escribir(String[] contenido){
			try 
			{

				//Se indica el archivo a leer
				StreamWriter escritor = new StreamWriter(this.path, true);

				foreach(String linea in contenido){
					//Escribe una linea
					escritor.WriteLine(linea);
				}
				//Cierra escritor
				escritor.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally 
			{
				Console.WriteLine("Cerrando la escritura.");
			}
		}
	}
}

