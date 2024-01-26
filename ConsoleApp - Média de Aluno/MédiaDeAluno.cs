using System.Threading.Channels;
using System;
using System.Reflection.PortableExecutable;

class CalculoDeMedia
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao meu programa de cálculo de médias!\n");

        //Declaramos os tipos das variáveis antes das validações
        string nome1;
        double nota1, nota2, nota3;

        // Aqui validamos se o nome está corretamente escrito
        do
        {
            Console.Write("Digite o nome do abençoado: ");
            nome1 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome1) || ContemNumeros(nome1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome inválido! Certifique-se de digitar um nome sem números e não vazio.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        } while (string.IsNullOrWhiteSpace(nome1) || ContemNumeros(nome1));

        static bool ContemNumeros(string texto)
        {
            foreach (char caractere in texto)
            {
                if (char.IsDigit(caractere))
                {
                    return true; 
                }
            }
            return false;
        }

        //Os outos do while são para validar se as notas são corretas
        do
        {
            Console.Write($"Digite a primeira nota do {nome1}: ");
            string input = Console.ReadLine();
            if(double.TryParse(input ,out nota1))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nota inválida, tente novamente!");
                Console.ForegroundColor = ConsoleColor.Gray;
            } 
        } while (true);

        do
        {
            Console.Write($"Digite a segunda nota do {nome1}: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out nota2))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nota inválida, tente novamente!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        } while (true);

        do
        {
            Console.Write($"Digite a terceira nota do {nome1}: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out nota3))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nota inválida, tente novamente!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        } while (true);

        var media = (nota1 + nota2 + nota3) / 3;
        try
        {
            if (media >= 7.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Aluno {nome1} passou com média de {media:F1} pontos!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Deu ruim {nome1}, fechou com {media:F1} pontos. (nota de corte: 7)");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        catch { }
        finally
        {
            Console.WriteLine("Obrigado!");
        }



    }
}





