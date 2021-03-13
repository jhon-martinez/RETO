using System;

namespace RETO1
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do

            {
                Console.Clear();

                Marco();
                Console.SetCursorPosition(50, 6); Console.Write("1. Quienes Somos ");
                Console.SetCursorPosition(50, 7); Console.Write("2. Menu Aplicacion");
                Console.SetCursorPosition(50, 8); Console.Write("0. Salir");
                Console.SetCursorPosition(50, 8); Console.Write("Digite una opcion ");
                opcion = Convert.Toint32(Console.ReadLine);


                switch (opcion)
                {
                    case 1:
                        QuienesSomos();
                        break;
                    case 2:
                        MenuAplicacion();
                        break;
                    case 0:
                        Console.WriteLine(" !!! Gracias por usar el programa ");
                        break;
                    default:
                        Console.WriteLine("opcion invalida ");
                        break;
                }

            } while (opcion > 0); while (opcion > 0) ;

        }


        static void QuienesSomos()

        {

            Console.Clear();
            Marco();
            Console.WriteLine("Quienes somos ");
            Console.WriteLine("Presiona cualquier tecla para continuar:  ");
            Console.ReadKey();
        }


        static void MenuAplicacion()
        {
            Console.Clear();
            Marco();
            Console.WriteLine("Menu Aplicacion");
            Console.WriteLine("Presiona cualquier tecla para continuar:  ");
            Console.ReadKey();




            Console.SetCursorPosition(50, 6); Console.Write("1.Agregar personaje  ");
            Console.SetCursorPosition(50, 7); Console.Write("2.Listar personaje ");
            Console.SetCursorPosition(50, 8); Console.Write("3.Buscar personaje ");
            Console.SetCursorPosition(50, 8); Console.Write("4.Salir a menu principal  ");
            opcion = Convert.Toint32(Console.ReadLine);
        }

        static void Marco()

        { 
            for (int i = 1; i <= 110; i++)
            {   
                Console.SetCursorPosition(1, i);  Console.WriteLine("=");
                Console.SetCursorPosition(110, i); Console.WriteLine("=");
            }

            for (int i = 1; i <= 25; i++)

            {
                Console.SetCursorPosition(1, i); Console.WriteLine("║");
                Console.SetCursorPosition(110, i); Console.WriteLine("║");
            }

                Console.SetCursorPosition(1, 1);  Console.WriteLine("╔"); 
                Console.SetCursorPosition(110, 1);  Console.WriteLine("╗");
                Console.SetCursorPosition(1, 25);  Console.WriteLine("╚");
                Console.SetCursorPosition(110, 25);  Console.WriteLine("╗");



     }
    
    


            
           
}


























