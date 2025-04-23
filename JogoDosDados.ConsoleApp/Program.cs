namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        /*Versão 1 - Estrutura básica e simulação de dados 
        Requisitos:

        Exibir um banner para o jogo de dados
        Implementar a geração de números aleatórios para simular um dado (1-6)
        Exibir o resultado do lançamento do dado
        Permitir que o usuário pressione Enter para lançar o dado*/
        static void Main(string[] args)
        {

            while (true)
            {
                //Exibição do Cabeçalho
                ExibirCabecalho();

                //Lançamento do dado
                int resultado = LancarDado();

                //Exibição do resultado
                ExibirResultado(resultado);

                //Opção continuar
                string continuar = OpcaoContinuar();

                if (continuar != "S")
                {
                    break;
                }
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Pressione ENTER para rolar o dado: ");
            Console.ReadLine();
        }

        static int LancarDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }

        static void ExibirResultado(int resultado)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"O valor sorteado foi: {resultado}");
            Console.WriteLine("------------------------------");
        }

        static string OpcaoContinuar()
        {
            Console.WriteLine("Deseja continuar? (S/N)");
            string continuar = Console.ReadLine()!.ToUpper();

            return continuar;
        }
    }
}
