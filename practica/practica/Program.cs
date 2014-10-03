/*
 * Created by SharpDevelop.
 * User: ALUMNOS
 * Date: 02/10/2014
 * Time: 06:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica
{
	public class Program
	{
		
	
		public static void Main(string[] args)
		{
			int cantidad1,cantidad2,cantidad3,precio1,precio3;
			String desc,desc2,desc3;
			double precio2,iva=7.20;
			
			
			
			Console.WriteLine("ingrese cantidad de procucto");
	     
		      cantidad1=int.Parse (Console.ReadLine());
		    Console.WriteLine("ingrese descripcion del producto");
		      desc=Console.ReadLine();
		    Console.WriteLine("ingresa precio unitario");
		     
		    precio1=int.Parse (Console.ReadLine());
		    
		    Console.WriteLine("ingrese cantidad de procucto");
	     
		      cantidad2=int.Parse (Console.ReadLine());
		    Console.WriteLine("ingrese descripcion del producto");
		      desc2=Console.ReadLine();
		    Console.WriteLine("ingresa precio unitario");
		     
		    precio2=int.Parse (Console.ReadLine());
		    Console.WriteLine("ingrese cantidad de procucto");
	     
		      cantidad3=int.Parse (Console.ReadLine());
		    Console.WriteLine("ingrese descripcion del producto");
		      desc3=Console.ReadLine();
		    Console.WriteLine("ingresa precio unitario");
		     precio3=int.Parse (Console.ReadLine());
		     
		    double cuenta1,cuenta2,cuenta3;
		    cuenta1=cantidad1+precio1;
		    cuenta2=cantidad2+precio2;
		    cuenta3=cantidad3+precio3;
		    
		 
		    Console.WriteLine("el subtotal es",cuenta1+cuenta2+cuenta3);
			
		}
	}
}