using System;
using System.Collections.Generic;

namespace Biblioteca;

public class Menu
{
	
	public static bool MainMenu()
	{
		
		
		
		Console.Clear();
		Console.WriteLine("Emprestar livro");
		Console.WriteLine("Devolver Livro");
		Console.WriteLine("Adicionar Livro");
		Console.WriteLine("Adicionar Cliente");
		Console.WriteLine("Sair");
		
		switch(Console.ReadLine())
		{
			case "1":
			
			Biblioteca.EmprestarLivro(Console.ReadLine(), Console.ReadLine());
			
			return true;
			case "2":
			
			DevolverLivro(Console.ReadLine(), Console.ReadLine()); 
			
			return true;
			case "3":
			
			return true;
			case "4":
			
			return true;
			case "5":
			
			return false;
		}
	}
}