using System;
using System.Threading;

namespace Proyecto_Final_2
{
    public class Program
    {
        //Menú principal
        public static int OpcMP;
        
        static void Main(string[] args)
        {
            MenuPrincipal();
            OpMenuPrincipal();
        }

        static void MenuPrincipal()
        {
            var interfaz = new Interfaz();
            MenuP:
            interfaz.Menu();

            if (int.TryParse(Console.ReadLine(), out OpcMP))
            {
                if (OpcMP > 0 && OpcMP < 5)
                {

                }
                else
                {
                    Console.SetCursorPosition(4, 19);
                    Console.WriteLine("(/)");
                    Thread.Sleep(400);
                    Console.Clear();
                    goto MenuP;
                }
            }
            else
            {
                Console.SetCursorPosition(4, 19);
                Console.WriteLine("(/)");
                Thread.Sleep(400);
                Console.Clear();
                goto MenuP;
            }
        }

        static void OpMenuPrincipal()
        {
            var interfaz = new Interfaz();
            var funciones = new Funciones();
            var estadistica = new Funciones();
            switch (OpcMP)
            {
                case 1:
                    Console.Clear();
                    interfaz.interfazI();
                    interfaz.interfazII();
                    funciones.DatosPeli();
                    interfaz.SalaCine();
                    Console.ReadKey();
                    MenuPrincipal();
                    OpMenuPrincipal();
                    break;

                case 2:
                    Console.Clear();
                    estadistica.FuncionConLaQueNosEstamosComplicandoMasDeLaCuenta();

                    MenuPrincipal();
                    OpMenuPrincipal();
                    break;

                case 3:
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("!GRACIAS POR VISITARNOS¡");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
