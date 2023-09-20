using System;
using System.Collections.Generic;

public class Program {
    
    static Dictionary<string,
    Listt<string>>
    livrosPorCategoria = newDictionary<string, List<string>>
    {
        {"Ficção", new List<string> {"O Conto da Aia", "Duna", "1984"}},
        {"História", new List<string> {"Sapiens", "A Breve História do Tempo", "Os Romanov"}},
        {"Ciência", new List<string> {"Uma Breve História do Tempo", "Os Gene Egoísta", "Cosmos"}},
        {"Autoajuda", new List<string> {"O Poder do Hábito", "A Arte da Felicidade", "Mindset"}},
        {"Infantojuvenil" new List<string> {"Harry Potter", "Percy Jackson", "Jogos Vorazes"}}
    };

    public static void Main(){
        Console.WriteLine("Chatbot Livraria Letras & e Histórias: Olá! Como posso ajudá-lo? (recomendar/verificar disponibilidade/lançamento)");
        while (true)
        {
            Console.Write("Cliente: ");
                string respostaCliente = Console.ReadLine().ToLower();

                switch(respostaCliente)
                {
                    case "recomendar":
                    RecomendarLivros();
                    break;
                    case "verificar disponibilidade":
                    VerificarDisponibilidade();
                    break;
                    case "lançamentos":
                    MostrarLançamentos();
                    break;
                    case "sair":

                    Console.WriteLine("Chatbot Livraria Letras & e Histórias: Obrigado por visitar a nossa livraria! Volte Sempre!");
                    return;
                    default;

                    Console.WriteLine("Chatbot Livraria Letras & Histórias: Desculpe, não entendi! Pode tentar novamente?");
                    break;
                }
        }
    }

    static void RecomendarLivros(){
        Console.WriteLine("Chatbot Livraria Letras & Histórias: Qual categoria de livro você está interessado(a)? (Ficção/História/Ciência/Autoajuda/Infatojuvenil)");
        string categoria = Console.ReadLine().ToLower();
            if (livrosPorCategoria.ContainsKey(categoria)) {
                Console.WriteLine($ "Chatbot Livraria Letras & Histórias: Aqui estão algumas recomendações para a categoria {categoria}: ")/
                    foreach (var livro in livrosPorCategoria[categoria]){
                        Console.WriteLine($ " - {livro}");
                    }
            }
            else {
                Console.WriteLine("Chatbot Livraria Letras & Histórias: Desculpe, não temos essa categoria. Tente outra!");
            }
    }

    static void VerificarDisponibilidade(){
        Console.WriteLine("Chatbot Livraria Letras & Histórias: Qual livro você está procurando?");
            string livro = Console.ReadLine();

            bool encontrado = false;
            foreach(var categoria in livrosPorCategoria)
            {
                if (categoria.Value.Contains(livros))
                {
                    Console.WriteLine($ "Chatbot Livraria Letras & Histórias: Sim, temos o livros '{livro}' na categoria {categoria.Key}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado){
                Console.WriteLine($"Chatbot Livraria Letras & Histórias: Desculpe, no momento não temos o livro '{livro}' em estoque.");
            }
    }

    static void MostrarLançamentos(){
        Console.WriteLine("Chatbot Livraria Letras & Histórias: Aqui estão alguns dos nossos lançamentos: ");
        Console.WriteLine("- A Ordem do Tempo");
        Console.WriteLine("- Os primos");
        Console.WriteLine("- O Universo Numa Casca de Noz");
    }
}