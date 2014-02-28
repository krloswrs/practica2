/*
 * Created by SharpDevelop.
 * User: krlos
 * Date: 28/02/2014
 * Time: 11:14 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	class Program
	{
		public static void Main(string[] args)
			{
			double valor1,valor2,valor3;
			//double a,b,c;
			double iva = 1.16;
			
			Console.WriteLine("valor 1");
			float a = float.Parse(Console.ReadLine());
			valor1 =  a * iva;
				
			Console.WriteLine("valor 2");
			float b = float.Parse(Console.ReadLine());
			valor2 =  b * iva;
			
			Console.WriteLine("valor 3");
		    float c = float.Parse(Console.ReadLine());
		    valor3 =  c * iva;
		    
		    Console.WriteLine("el primer valor es:" +valor1);
		    Console.WriteLine("el primer valor es:" +valor2);
		    Console.WriteLine("el primer valor es:" +valor3);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}