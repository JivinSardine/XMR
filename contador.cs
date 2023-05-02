using System;
class x{
	static void Main(){
		Console.WriteLine("Bem vindo ao contador!\nAperte enter para continuar");
		Console.ReadKey();
		Console.Clear();
		
		Console.WriteLine("Digite o texto: ");
		string texto=Console.ReadLine();
		Console.Clear();

		Console.WriteLine("A quantidade de letras e espaços nesse texto é: {0}.",texto.Length);
		Console.ReadKey();
	}
}