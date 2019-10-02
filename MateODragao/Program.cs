using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool JogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o dragao!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - iniciar jogo");
                System.Console.WriteLine (" 0 - sair do jogo");

                string opcaojogador = Console.ReadLine ();

                switch (opcaojogador) {
                    case "1":
                        Console.Clear ();
                        
                        Guerreiro guerreiro = CriarGuerreiro();

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "dragonildo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;
                        /* INICIO - primeiro dialogo */

                        Criardialogo( guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, vou te matar!");
                        Criardialogo(dragao.Nome, $"{dragao.Nome.ToUpper()}: kkkkkk! Humano tolinho. Quem pensas q es?");
                        FinalizarDialogo();

                        /* FIM - primeiro dialogo */
                        /* INICIO - segundo dialogo */
                        
                        Criardialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()} Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, seu desgracado!");
                        Criardialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}: vim de {guerreiro.CidadeNatal} para te derrotar e mostrar meu valor!");
                        Criardialogo(dragao.Nome, $"{dragao.Nome.ToUpper()}: quem? de onde? que seja irei te matar!");
                        FinalizarDialogo();
                        
                        /* FIM - segundo dialogo */

                        bool JogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int PoderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /* INICIO - da treta */
                        if (JogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("Turno do jogador");
                            System.Console.WriteLine ("Escolha sua acao");
                            System.Console.WriteLine ("1 - Atacar");
                            System.Console.WriteLine ("2 - Fugir");

                            string OpcaoBatalhaJogador = Console.ReadLine ();
                            switch (OpcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatotio = new Random ();
                                    int NumeroAleatorioJogador = geradorNumeroAleatotio.Next (0, 5);
                                    int NumeroAleatorioDragao = geradorNumeroAleatotio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: toma essa lagarto!!");
                                        dragao.Vida -= PoderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("---------------------");
                                        System.Console.WriteLine ($"HP dragao: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP guerreiro: {guerreiro.vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: erroooou, seu mongo kkkk!");
                                    }
                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: simbora fui");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ!");
                                    break;
                            }

                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.vida > 0 && jogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("*** Turno do dragao ***");
                                Random geradorNumeroAleatotio = new Random ();
                                int NumeroAleatorioJogador = geradorNumeroAleatotio.Next (0, 5);
                                int NumeroAleatorioDragao = geradorNumeroAleatotio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: chamuscou o fiofo? foi?");
                                    guerreiro.vida -= dragao.Forca;
                                    System.Console.WriteLine ("---------------------");
                                    System.Console.WriteLine ($"HP dragao: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP guerreiro: {guerreiro.vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: vem tranquilo, nao se afoba nao!");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Apete o ENTER para prosseguir");
                                Console.ReadLine ();
                                /* INICIO - turno jogador */
                                Console.Clear ();
                                System.Console.WriteLine ("Turno do jogador");
                                System.Console.WriteLine ("Escolha sua acao");
                                System.Console.WriteLine ("1 - Atacar");
                                System.Console.WriteLine ("2 - Fugir");

                                OpcaoBatalhaJogador = Console.ReadLine ();
                                switch (OpcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatotio = new Random ();
                                        NumeroAleatorioJogador = geradorNumeroAleatotio.Next (0, 5);
                                        NumeroAleatorioDragao = geradorNumeroAleatotio.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: toma essa lagarto!!");
                                            dragao.Vida -= PoderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ("---------------------");
                                            System.Console.WriteLine ($"HP dragao: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP guerreiro: {guerreiro.vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: erroooou, seu mongo kkkk!");
                                        }
                                        if (guerreiro.vida <= 0){
                                            System.Console.WriteLine("se fudeu!");
                                        }
                                        if (dragao.Vida <= 0){
                                            System.Console.WriteLine("el dragao murio!");
                                        }
                                        System.Console.WriteLine();
                                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                                        Console.ReadLine();
                                        Console.Clear();
                                        
                                        break;
                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: simbora fui");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ!");
                                        break;
                                }

                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                /* FIM - turno jogador */

                            }
                        }
                        /* FIM - da treta */
                        break;
                    case "0":
                        JogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;
                }
            } while (JogadorNaoDesistiu);

        }
    
        private static void Criardialogo(string nome, string frase)
        {
            
            System.Console.WriteLine($"{nome.ToUpper()}: {frase}!");
        }
    
        private static void FinalizarDialogo()
        {
            System.Console.WriteLine ();
            System.Console.WriteLine ("Aperte ENTER para prosseguir");
            Console.ReadLine ();
            Console.Clear();
        }

        private static Guerreiro CriarGuerreiro()
        {
            int numero = int.Parse("2");
            
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = " Denteco ";
            guerreiro.Sobrenome = "Sao Jorge";
            guerreiro.CidadeNatal = "Danfer";
            guerreiro.DataDeNascimento = DateTime.Parse ("20/10/1419");
            guerreiro.FerramentaAtaque = "cajado magico";
            guerreiro.FerramentaProteçao = "escudo";
            guerreiro.Forca = 3;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 2;
            guerreiro.vida = 20;
            
            return guerreiro;
        }
    }   
}