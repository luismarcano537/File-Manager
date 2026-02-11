using System;
using System.IO;

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

        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("===== Visualização de arquivos =====");
            Console.WriteLine("");
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
            
        }

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("===== Edição de arquivos =====");
            Console.WriteLine("Digite para editar (Pressione F1 para sair): ");
            Console.WriteLine();
            string text = "";
            Console.WriteLine("----------");

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.F1);

            SaveFile(text);
            
        }

        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("===== Salvar arquivo =====");
            Console.Write("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Salvo {path} com sucesso!");
            Console.ReadLine();
            Menu();

        }
    }
}