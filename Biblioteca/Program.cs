namespace Biblioteca;

class Program
{
	static void Main(string[] args)
	{
		Menu menu = new Menu();
		bool MostrarMenu = true;
		
		while (MostrarMenu)
		{
			MostrarMenu = menu.MainMenu()
		}
		
	do
	
	{
		MainMenu();
		
	}while(MostrarMenu)
		
		
		
		
		
		
		
		/*Biblioteca biblioteca= new Biblioteca();
		
		// adicionar cliente
		biblioteca.clientes.Add(new Cliente{Id = 1, Nome = "Jorge e Mateus", 
		DataNascimento = new DateTime(1980, 01, 01), Telefone = "62999999"});
		
		// adicionar livro
		biblioteca.livros.Add(new Livro{Id = 1, Titulo ="Dom Casmurro", 
		Autor = "Machado de Assis", Disponivel = true});
		
		// Emprestar livro
		biblioteca.EmprestarLivro(1, 1);
		biblioteca.DevolverLivro(1, 1);
		biblioteca.EmprestarLivro(1, 2);
		
		/*static void IniciarBiblioteca(Biblioteca biblioteca)
		{
			biblioteca.EmprestarLivro(2,2);
		}*/
	}
}
