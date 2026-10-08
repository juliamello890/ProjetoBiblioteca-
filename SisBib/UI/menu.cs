using System;
using System.Collections.Generic;
using SisBib.Business;
using SisBib.Models;

namespace SisBib.UI
{
    public class MenuConsole
    {
        private LivroService _livroService = new
        LivroService();

        public void ExibirMenu()
        {
            bool rodando = true;

            while (rodando){
                Console.Clear();

                Console.WriteLine(" SISTEMA DE
BIBLIOTECA ESCOLAR ");

                Console.WriteLine("1 - Cadastrar
Novo Livro");

                Console.WriteLine("2 - Listar Coleção");

                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao){

                    case "1":
                        ExecutarCadastro();
                        break;

                    case "2":
                        ExecutarListagem();
                        break;

                    case "0":
                        rodando = false;

                        Console.WriteLine("Encerran
do o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção
inválida! Pressione qualquer tecla para
continuar.");

                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    private void ExecutarCadastro()
    {
        Console.Clear();
