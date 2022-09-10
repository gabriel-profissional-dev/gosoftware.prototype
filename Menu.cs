using System;

namespace gosoftware
{
    public static class Menu
    {
        public static void MenuOpcao()
        {
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Clientes");
            Console.WriteLine("2 - Cursos");
            Console.WriteLine("3 - Funcionários");
            
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: Clientes.MeuCliente(); break;
                case 2: Cursos.MeusCursos(); break;
                case 3: Funcionarios.MeusFuncionarios(); break;

                default: MenuOpcao(); break;
            }
            

        }

    }
}