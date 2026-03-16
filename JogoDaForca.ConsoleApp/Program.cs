using System.Security.Cryptography;

namespace JogoDaForca.ConsoleApp;

/*
Requisitos
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
    assim como as letras erradas.
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
    acaba.
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

class Program
{
    static void Main(string[] args)
    {
        while (true == true)
        {
            // Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("---------------------------------");

            // Lógica do Jogo da Forca
            // 1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
            // Escolher uma palavra aleatória
            string palavraAleatoria = "CAJA";

            Console.WriteLine(palavraAleatoria);

            // 2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
            // assim como as letras erradas.
            char[] letrasAcertadas = new char[palavraAleatoria.Length];

            for (int caractere = 0; caractere < letrasAcertadas.Length; caractere++)
            {
                letrasAcertadas[caractere] = '_';
            }

            bool jogadorAcertouPalavra = false;

            while (jogadorAcertouPalavra == false)
            {
                Console.WriteLine(letrasAcertadas);

                Console.Write("Digite uma letra: ");
                string? strLetra = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(strLetra))
                {
                    Console.WriteLine("Digite um caractere válido.");
                    Console.ReadLine();
                    continue;
                }

                char letraChute = char.ToUpper(Convert.ToChar(strLetra));

                for (int contador = 0; contador < palavraAleatoria.Length; contador++)
                {
                    char letraAtual = palavraAleatoria[contador];

                    if (letraChute == letraAtual)
                    {
                        letrasAcertadas[contador] = letraAtual;
                    }
                }

                jogadorAcertouPalavra = palavraAleatoria == string.Join("", letrasAcertadas);
            }

            Console.Write("Deseja continuar o jogo? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }

    static string EscolherPalavraAleatoria()
    {
        string[] palavras = [
            "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "AÇAÍ",
            "ARAÇÁ",
            "ABACATE",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJÁ",
            "CAJU",
            "CARAMBOLA",
            "CUPUAÇU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MAÇÃ",
            "MANGABA",
            "MANGA",
            "MARACUJÁ",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
        ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        return palavraAleatoria;
    }
}
