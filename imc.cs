using System;
					
public class Program
{
	public static void Main()
	{
		//declaração de variaveis
		double peso;
		double altura;
		double resultado;
		
		//solicitar informação de peso + altura e os calculos 
		
		Console.WriteLine("Escreva seu peso em kg");
		peso = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Escreva sua altura em metros");
		altura = Convert.ToDouble(Console.ReadLine());
		resultado = peso / (altura * altura);
		Console.WriteLine(resultado);

		//estrutura condicional
		
		if (resultado < 18.5)
        {
            Console.WriteLine("Você está com o peso baixo");
        }
        else if (resultado < 25)
        {
            Console.WriteLine("Você está com o peso normal");
        }
        else if (resultado < 30)
        {
            Console.WriteLine("Você está com sobrepeso");
        }
		
		else if (resultado > 30)
		{
   		 Console.WriteLine("Você está com obesidade");
		}
	}
}