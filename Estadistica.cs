using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final_2
{
    class Estadistica
    {
        public int OpHorarioEstadistica;

        public void mensaje(int aA, int nN, int amM, double ingresoa, double ingreson, double ingresoam,  double TI)
        {
            Console.Clear();
            //Console.WriteLine("La cantidad total de personas que asistieron a esta funcion: {0}");
            Console.WriteLine("Adultos: {0}", aA);
            Console.WriteLine("Niños: {0}", nN);
            Console.WriteLine("Adulto mayor: {0}", amM);
            Console.WriteLine("Total de ingresos generados: {0:C2}", TI);
            Console.ReadKey();
            Console.Clear();
        }
        public void Estadistic(int a, int n, int am, double ingresoaA, double ingresonN, double ingresoamM, double TII)
        {


            Console.Clear();
            Console.WriteLine("Elegia la pelicula que quiera saber su estadistica");
            Console.WriteLine("1) Rey leon");
            Console.WriteLine("2) Mulan");
            Console.WriteLine("3) Moana");
            Console.WriteLine("4) It : eso");
            int OpPeiluclaEstadistica = Convert.ToInt32(Console.ReadLine());
            switch (OpPeiluclaEstadistica)
            {

                case 1:

                    Console.Clear();
                    Console.WriteLine("Eliga el horario del que quiera saber su estadistica:");
                    Console.WriteLine("1) 7:15");
                    Console.WriteLine("2) 13:00");
                    Console.WriteLine("3) 17:05");
                    OpHorarioEstadistica = Convert.ToInt32(Console.ReadLine());
                    switch (OpHorarioEstadistica)
                    {
                        case 1:

                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 2:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 3:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        default:
                            break;
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Eliga el horario del que quiera saber su estadistica: ");
                    Console.WriteLine("1) 9:30");
                    Console.WriteLine("2) 12:45");
                    Console.WriteLine("3) 16:05");
                    OpHorarioEstadistica = Convert.ToInt32(Console.ReadLine());
                    switch (OpHorarioEstadistica)
                    {
                        case 1:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 2:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 3:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        default:
                            break;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Eliga el horario del que quiera saber su estadistica: ");
                    Console.WriteLine("1) 11:05");
                    Console.WriteLine("2) 14:30");
                    Console.WriteLine("3) 18:15");
                    OpHorarioEstadistica = Convert.ToInt32(Console.ReadLine());
                    switch (OpHorarioEstadistica)
                    {
                        case 1:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 2:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 3:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        default:
                            break;
                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Eliga el horario del que quiera saber su estadistica: ");
                    Console.WriteLine("1) 00:30");
                    Console.WriteLine("2) 19:00");
                    Console.WriteLine("3) 22:45");
                    OpHorarioEstadistica = Convert.ToInt32(Console.ReadLine());
                    switch (OpHorarioEstadistica)
                    {
                        case 1:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 2:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        case 3:
                            mensaje(a, n, am, ingresoaA, ingresonN, ingresoamM, TII);
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

        }


    }
}
