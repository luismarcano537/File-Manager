using System;

namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("===== Gerenciamento de arquivos =====");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Editar arquivo");
            Console.WriteLine("3 - Salir");

            Console.Write("Informe a ação desejada: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1 : OpenFile(); break;
                case 2 : EditFile(); break;
                case 3 : Environment.Exit(0); break;
            }
        }
        
        static void OpenFile(){}

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("===== Edição de arquivos =====");
            Console.WriteLine("Digite para editar (Pressione ESC para sair): ");
            Console.WriteLine();
            string text = "";
            Console.WriteLine("----------");

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
            
        }
    }
}