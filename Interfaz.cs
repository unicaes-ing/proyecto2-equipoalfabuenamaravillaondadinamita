using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final_2
{
    class Interfaz
    {
        //
        string[] sala = new string[4];
        string[,] matrizFila2 = new string[10, 10];
        string[,] matrizFila3 = new string[10, 10];
        string[,] matrizFila1 = new string[10, 10];
        //
        int fila, columna;

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════╗");
            Console.WriteLine("║      GO - CINE                  ║");
            Console.WriteLine("╚═════════════════════════════════╝");
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║            SELECCIONE UNA OPCIÓN            ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║   1. COMPRAR BOLETOS                        ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║   2. ESTADÍSTICAS DE VENTA                  ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║   3. CONFIGURACIÓN                          ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║   4. SALIR                                  ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("╔═══════════╗");
            Console.WriteLine("║           ║");
            Console.WriteLine("╚═══════════╝");
            Console.SetCursorPosition(5, 19);

        }

        public void interfazI()
        {
            var funciones = new Funciones();

            Console.WriteLine();
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               ╔═══ ╔══╗    ╔═══ ═╦═ ╔═╗ ╗ ╔═══                                                                                                ║");
            Console.WriteLine("║               ║ ═╗ ║  ║ ══ ║     ║  ║ ║ ║ ╠══                                                                                                 ║");
            Console.WriteLine("║               ╚══╝ ╚══╝    ╚═══ ═╩═ ╚ ╚═╝ ╚═══                                                                                                ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("╔═══════════════════════════════╗  ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                               ║  ║                                                                                                            ║");
            Console.WriteLine("║                               ║  ║                                                                                                            ║");
            Console.WriteLine("║                               ║  ║                                                           *PROGRAMACIÓN SUJETA A CAMBIOS SIN PREVIO AVISO  ║");
            Console.WriteLine("║                               ║  ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("║                               ║  ╔═══════╦════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                               ║  ║  /║   ║                                     /            ╔═══╗      ╔═══╗      ╔═══╗                       ║");
            Console.WriteLine("║                               ║  ║   ║   ║      ╔══╗ ╔═══ ╔   ╗    ╔    ╔═══ ╔══╗ ╔═╗ ╗     ║ 1 ║      ║ 2 ║      ║ 3 ║                       ║");
            Console.WriteLine("║                               ║  ║  ═╩═  ║      ╠═╦╝ ╠══  ╚═╦═╝    ║    ╠══  ║  ║ ║ ║ ║     ╠═══╩═══╗  ╠═══╩═══╗  ╠═══╩═══╗     DOB           ║");
            Console.WriteLine("║                               ║  ╠═══════╝      ╚ ╚  ╚═══   ╚      ╚═══ ╚═══ ╚══╝ ╚ ╚═╝     ║ 07:15 ║  ║ 13:00 ║  ║ 17:05 ║    ╔══════════════╣");
            Console.WriteLine("╠═══════════════════════════════╣  ║                                                          ╚═══════╝  ╚═══════╝  ╚═══════╝    ║ A ║ 120 min  ║");
            Console.WriteLine("╠═══════════════════════════════╣  ╚═════════════════════════════════════════════════════════════════════════════════════════════╩══════════════╝");
            Console.WriteLine("║ Tipo de proyección            ║  ╔═══════╦════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╠═══════════════════════════════╣  ║  ══╗  ║                                                  ╔═══╗      ╔═══╗      ╔═══╗                       ║");
            Console.WriteLine("║ FORMATO:                      ║  ║  ╔═╝  ║      ╔═╗╔═╗ ╔   ╗ ╔    ╔══╗ ╔═╗ ╗                ║ 1 ║      ║ 2 ║      ║ 3 ║                       ║");
            Console.WriteLine("║  _/ 2D                        ║  ║  ╚══  ║      ║ ╚╝ ║ ║   ║ ║    ╠══╣ ║ ║ ║                ╠═══╩═══╗  ╠═══╩═══╗  ╠═══╩═══╗     DOB           ║");
            Console.WriteLine("║  _/ DIGITAL                   ║  ╠═══════╝      ╚    ╝ ╚═══╝ ╚═══ ╚  ╝ ╚ ╚═╝                ║ 09:30 ║  ║ 12:45 ║  ║ 16:05 ║    ╔══════════════╣");
            Console.WriteLine("║                               ║  ║                                                          ╚═══════╝  ╚═══════╝  ╚═══════╝    ║ A ║ 120 min  ║");
            Console.WriteLine("║ IDIOMA:                       ║  ╚═════════════════════════════════════════════════════════════════════════════════════════════╩══════════════╝");
            Console.WriteLine("║  _/ DOBLADA                   ║  ╔═══════╦════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  _/ ESPAÑOL                   ║  ║  ══╗  ║                                                  ╔═══╗      ╔═══╗      ╔═══╗                       ║");
            Console.WriteLine("║  _/ SUBTITULADA               ║  ║  ══╣  ║      ╔═╗╔═╗ ╔══╗ ╔══╗ ╔═╗ ╗ ╔══╗                 ║ 1 ║      ║ 2 ║      ║ 3 ║                       ║");
            Console.WriteLine("╠═══════════════════════════════╣  ║  ══╝  ║      ║ ╚╝ ║ ║  ║ ╠══╣ ║ ║ ║ ╠══╣                 ╠═══╩═══╗  ╠═══╩═══╗  ╠═══╩═══╗     DOB           ║");
            Console.WriteLine("╠═══════════════════════════════╣  ╠═══════╝      ╚    ╝ ╚══╝ ╚  ╝ ╚ ╚═╝ ╚  ╝                 ║ 11:05 ║  ║ 14:30 ║  ║ 18:15 ║    ╔══════════════╣");
            Console.WriteLine("║      /Elija una opción/       ║  ║                                                          ╚═══════╝  ╚═══════╝  ╚═══════╝    ║ A ║ 120 min  ║");
            Console.WriteLine("║                               ║  ╚═════════════════════════════════════════════════════════════════════════════════════════════╩══════════════╝");
            Console.WriteLine("║  PELÍCULA:                    ║  ╔═══════╦════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                               ║  ║ ║  ║  ║                                                  ╔═══╗      ╔═══╗      ╔═══╗                       ║");
            Console.WriteLine("║  HORARIO:                     ║  ║ ╚══╣  ║      ═╦═ ═╦═   ▄   ╔═══ ╔══╗ ╔══╗                ║ 1 ║      ║ 2 ║      ║ 3 ║                       ║");
            Console.WriteLine("║                               ║  ║    ║  ║       ║   ║        ╠══  ╚══╗ ║  ║                ╠═══╩═══╗  ╠═══╩═══╗  ╠═══╩═══╗     SUB           ║");
            Console.WriteLine("║                               ║  ╠═══════╝      ═╩═  ║    ▀   ╚═══ ╚══╝ ╚══╝                ║ 00:30 ║  ║ 19:00 ║  ║ 22:45 ║    ╔══════════════╣");
            Console.WriteLine("║                               ║  ║                                                          ╚═══════╝  ╚═══════╝  ╚═══════╝    ║ C ║ 169 min  ║");
            Console.WriteLine("╚═══════════════════════════════╝  ╚═════════════════════════════════════════════════════════════════════════════════════════════╩══════════════╝");
            funciones.PeliHora();
        }

        public void interfazII()
        {
            var funciones = new Funciones();
            Console.WriteLine("");
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               ╔═══ ╔══╗    ╔═══ ═╦═ ╔═╗ ╗ ╔═══                                                                                                ║");
            Console.WriteLine("║               ║ ═╗ ║  ║ ══ ║     ║  ║ ║ ║ ╠══                                                                                                 ║");
            Console.WriteLine("║               ╚══╝ ╚══╝    ╚═══ ═╩═ ╚ ╚═╝ ╚═══                                                                                                ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════╗ ╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                      ║ ║                                                      ║");
            Console.WriteLine("║        COMPRA Y RESERVA TUS BOLETOS                                                  ║ ║                                                      ║");
            Console.WriteLine("║                                                                                      ║ ║                                                      ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════════════╣ ║        ╔════════════════════════════════════╗        ║");
            Console.WriteLine("║                                                                                      ║ ║        ║              SUBTOTAL:             ║        ║");
            Console.WriteLine("║                                                                                      ║ ║        ╠════════════════════════════════════╣        ║");
            Console.WriteLine("║        CINE:   GO-CINE, Santa Ana                                                    ║ ║        ║                                    ║        ║");
            Console.WriteLine("║                                                                                      ║ ║        ║                                    ║        ║");
            Console.WriteLine("║        PELÍCULA:                                                                     ║ ║        ║                                    ║        ║");
            Console.WriteLine("║                                                                                      ║ ║        ║            IVA INCLUIDO            ║        ║");
            Console.WriteLine("║        FECHA:                                                                        ║ ║        ║                                    ║        ║");
            Console.WriteLine("║                                                                                      ║ ║        ╚════════════════════════════════════╝        ║");
            Console.WriteLine("║        FUNCIÓN:                                                                      ║ ║                                                      ║");
            Console.WriteLine("║                                                                                      ║ ║                                                      ║");
            Console.WriteLine("║                                                                                      ║ ║                                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════╝ ╚══════════════════════════════════════════════════════╝");
            funciones.CoorDatosPeli();
        }

        public void interfazIII()
        {
            var funciones = new Funciones();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                                                               ║");
            Console.WriteLine("║                                ╔═══╗    ╔═════╗    ╔═══╗        ╔═══════╗                                                                     ║");
            Console.WriteLine("║            ADULTOS             ║ + ║   |║     ║|   ║ - ║        ║       ║    $4.25                                                            ║");
            Console.WriteLine("║                                ╚═══╝    ╚═════╝    ╚═══╝        ╚═══════╝                                                                     ║");
            Console.WriteLine("║                                                                                                                                               ║");
            Console.WriteLine("║                                ╔═══╗    ╔═════╗    ╔═══╗        ╔═══════╗                                                                     ║");
            Console.WriteLine("║            NIÑOS               ║ + ║   |║     ║|   ║ - ║        ║       ║    $3.25                                                            ║");
            Console.WriteLine("║                                ╚═══╝    ╚═════╝    ╚═══╝        ╚═══════╝                                                                     ║");
            Console.WriteLine("║                                                                                                                                               ║");
            Console.WriteLine("║                                ╔═══╗    ╔═════╗    ╔═══╗        ╔═══════╗                                                                     ║");
            Console.WriteLine("║            ADULTOS MAYORES     ║ + ║   |║     ║|   ║ - ║        ║       ║    $2.25                                                            ║");
            Console.WriteLine("║                                ╚═══╝    ╚═════╝    ╚═══╝        ╚═══════╝                                                                     ║");
            Console.WriteLine("║                                                                                                                                               ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }

        public void Salas()
        {
            for (int i = 0; i < 4; i++)
            {

            }
        }

        public void MostrarMatrizSillasFIla1()
        {
            Console.Clear();
            int num1 = 0, num2 = 0;
            int x = 10, y = 5;
            Console.SetBufferSize(300, 300);
            for (int f = 0; f < 10; f++)
            {
                num1++;
                for (int c = 0; c < 10; c++)
                {
                    num2++;
                    //Estética de los números de las sillas
                    if (num1 == 10 && num2 != 10)
                    {
                        matrizFila1[f, c] = "╔╗" + num1 + ":0" + num2 + "╔╗ ";
                    }
                    else
                    {
                        if (num1 != 10 && num2 == 10)
                        {
                            matrizFila1[f, c] = "╔╗0" + num1 + ":" + num2 + "╔╗ ";
                        }
                        else
                        {
                            if (num1 == 10 && num2 == 10)
                            {
                                matrizFila1[f, c] = "╔╗" + num1 + ":" + num2 + "╔╗ ";
                            }
                            else
                            {
                                matrizFila1[f, c] = "╔╗0" + num1 + ":0" + num2 + "╔╗ ";
                            }
                        }
                    }
                    //Fin de la estética
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(matrizFila1[f, c]);
                    x += 10;
                }
                y += 4;
                x = 10;
                num2 = num2 - 10;
            }
        }

        //Muestra la sala con sus sillas
        public void MostrarMatrizSillasFila2()
        {
            Console.SetBufferSize(300, 300);
            int x = 10, y = 6;
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    matrizFila2[f, c] = "║╚═════╝║ ";
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(matrizFila2[f, c]);
                    x += 10;
                }
                y += 4;
                x = 10;
            }
        }

        public void MostrarMatrizSillasFila3()
        {
            Console.SetBufferSize(300, 300);
            int x = 10, y = 7;
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    matrizFila3[f, c] = "╚═══════╝ ";
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(matrizFila3[f, c]);
                    x += 10;
                }
                y += 4;
                x = 10;
            }
        }

        public void SalaCine()
        {
            MostrarMatrizSillasFIla1();
            MostrarMatrizSillasFila2();
            MostrarMatrizSillasFila3();
            
            Console.ReadKey();
        }

        public void ColorSillasVerde1()
        {
            Console.WriteLine("Fila ");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Columna ");
            columna = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(matrizFila1[fila-1, columna-1]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(matrizFila2[fila-1, columna-1]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(matrizFila3[fila-1, columna-1]);
  
        }

        public void LlenarSillas()
        {
            for(int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    

                }
            }
        }

    }
}
