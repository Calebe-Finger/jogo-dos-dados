namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        /*Versão 2 - Controle da posição do jogador 
        Requisitos:

        Armazenar a posição do jogador na pista e atualizar o valor após o lançamento do dado
        Exibir a posição atual do jogador na pista
        Defina a linha de chegada em 30 verifique se o jogador alcançou ou ultrapassou a linha de chegada
        Permitir que o jogador realize várias jogadas*/

        static void Main(string[] args)
        {
            const int limiteLinhaDeChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                bool JogoEstaEmAndamento = true;

                while (JogoEstaEmAndamento)
                {
                    //Exibição do Cabeçalho
                    ExibirCabecalho();

                    //Lançamento do dado
                    int resultado = LancarDado();

                    //Incrementar posição
                    posicaoUsuario += resultado;

                    //Exibição do resultado
                    ExibirResultado(resultado);

                    //Exibir a posição atual
                    ExibirPosicaoAtual(posicaoUsuario);

                    //Verificação se o usuário crusou a linha de chegada
                    if (posicaoUsuario >= limiteLinhaDeChegada)
                    {
                        ExibirVitoria();
                        JogoEstaEmAndamento = false;
                    }
                }

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

        private static void ExibirPosicaoAtual(int posicaoUsuario)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"A sua posição atual é: {posicaoUsuario}");
            Console.WriteLine("------------------------------");

            Console.ReadLine();
        }

        private static void ExibirVitoria()
        {
            Console.WriteLine("Parabéns você chegou na linha de chegada!");
            Console.ReadLine();
        }

        static string OpcaoContinuar()
        {
            Console.WriteLine("Deseja continuar? (S/N)");
            string continuar = Console.ReadLine()!.ToUpper();

            return continuar;
        }
    }
}
