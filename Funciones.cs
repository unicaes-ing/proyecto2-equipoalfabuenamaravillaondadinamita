using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proyecto_Final_2
{
    class Funciones
    {
        //
        public static double IngreoA, IngresoN, IngresoAM, TotalIngreso;

        //Boletos
        public static int A, N, AM;
        //Total a pagar
        public static double SubTotal, TA, TN, TAM;
        //Película
        public static int Ophorario;
        public static int OpPeli;
        //Matriz de sillas
        public static string[,] sillas = new string[10, 10];
        //Datos de la película
        public string datoPeli, datoHora;
        //
        public int OpHorarioEstadistica;

        public struct EstructuraReyLeon
        {
            public int ReyLeonNiño;
            public int ReyLeonAdulto;
            public int ReyLeonAdultoMayor;

        }

        public struct EstructuraMulan
        {
            public int MulanNiño;
            public int MulanAdulto;
            public int MulanAdultoMayor;

        }

        public struct EstructuraMoana
        {
            public int MoanaNiño;
            public int MoanaAdulto;
            public int MoanaAdultoMayor;

        }

        public struct EstructuraIt
        {

            public int ItNiño;
            public int ItAdulto;
            public int ItAdultoMayor;
        }

        public void BoletosMoana()
        {
            Console.SetCursorPosition(45, 26);
            EstructuraMoana Adulto = new EstructuraMoana();

            ValiRecoBoletos(Adulto.MoanaAdulto, 45, 26);
            SubTotal = TA;
            CoorRecoBoletos(TA, 68, 26);


            Console.SetCursorPosition(45, 30);
            EstructuraMoana Niño = new EstructuraMoana();
            ValiRecoBoletos(Niño.MoanaNiño, 45, 30);
            SubTotal = TA + TN;
            CoorRecoBoletos(TN, 68, 30);

            Console.SetCursorPosition(45, 34);
            EstructuraMoana AdultoM = new EstructuraMoana();
            ValiRecoBoletos(AdultoM.MoanaAdultoMayor, 45, 34);
            SubTotal = TA + TN + TAM;
            CoorRecoBoletos(TAM, 68, 34);
            IngreoA = A * 4.25;
            IngresoN = N * 3.25;
            IngresoAM = AM * 2.25;

            TotalIngreso = IngresoAM + IngresoN + IngreoA;

        }

        public void BoletosIT()
        {
            Console.SetCursorPosition(45, 26);
            EstructuraIt Adulto = new EstructuraIt();
            ValiRecoBoletos(Adulto.ItAdulto, 45, 26);
            SubTotal = TA;
            CoorRecoBoletos(TA, 68, 26);

            Console.SetCursorPosition(45, 30);
            EstructuraIt Niño = new EstructuraIt();
            ValiRecoBoletos(Niño.ItNiño, 45, 30);
            SubTotal = TA + TN;
            CoorRecoBoletos(TN, 68, 30);

            Console.SetCursorPosition(45, 34);
            EstructuraIt AdultoM = new EstructuraIt();
            ValiRecoBoletos(AdultoM.ItAdultoMayor, 45, 34);
            SubTotal = TA + TN + TAM;
            CoorRecoBoletos(TAM, 68, 34);
            IngreoA = A * 4.25;
            IngresoN = N * 3.25;
            IngresoAM = AM * 2.25;

            TotalIngreso = IngresoAM + IngresoN + IngreoA;
        }

        public void BoletosMulan()
        {
            Console.SetCursorPosition(45, 26);
            EstructuraMulan Adulto = new EstructuraMulan();
            ValiRecoBoletos(Adulto.MulanAdulto, 45, 26);
            SubTotal = TA;
            CoorRecoBoletos(TA, 68, 26);

            Console.SetCursorPosition(45, 30);
            EstructuraMulan Niño = new EstructuraMulan();
            ValiRecoBoletos(Niño.MulanNiño, 45, 30);
            SubTotal = TA + TN;
            CoorRecoBoletos(TN, 68, 30);

            Console.SetCursorPosition(45, 34);
            EstructuraMulan AdultoM = new EstructuraMulan();
            ValiRecoBoletos(AdultoM.MulanAdultoMayor, 45, 34);
            SubTotal = TA + TN + TAM;
            CoorRecoBoletos(TAM, 68, 34);
            IngreoA = A * 4.25;
            IngresoN = N * 3.25;
            IngresoAM = AM * 2.25;

            TotalIngreso = IngresoAM + IngresoN + IngreoA;
        }

        public void BoletosReyLeon()
        {
            Console.SetCursorPosition(45, 26);
            EstructuraReyLeon Adulto = new EstructuraReyLeon();
            ValiRecoBoletos(Adulto.ReyLeonAdulto, 45, 26);
            SubTotal = TA;
            CoorRecoBoletos(TA, 68, 26);

            Console.SetCursorPosition(45, 30);
            EstructuraReyLeon Niño = new EstructuraReyLeon();
            ValiRecoBoletos(Niño.ReyLeonNiño, 45, 30);
            SubTotal = TA + TN;
            CoorRecoBoletos(TN, 68, 30);

            Console.SetCursorPosition(45, 34);
            EstructuraReyLeon AdultoM = new EstructuraReyLeon();
            ValiRecoBoletos(AdultoM.ReyLeonAdultoMayor, 45, 34);
            SubTotal = TA + TN + TAM;
            CoorRecoBoletos(TAM, 68, 34);
            IngreoA = A * 4.25;
            IngresoN = N * 3.25;
            IngresoAM = AM * 2.25;

            TotalIngreso = IngresoAM + IngresoN + IngreoA;
        }

        //Valida los boletos tomando como parámetros las coordenadas y la variable correspondiente a "Adultos, Niños y Adultos mayores"
        public void ValiRecoBoletos(int Temp, int x, int y)
        {
            REPETIR:
            if (int.TryParse(Console.ReadLine(), out Temp))
            {
                //Este switch ocupa como parámetro la coordenada en top (y) para que determine a qué variable se le dará el valor 
                if (Temp > 0 && Temp < 11)
                {
                    switch (y)
                    {
                        case 26:
                            A = Temp;
                            TA = Temp * 4.25;
                            break;
                        case 30:
                            N = Temp;
                            TN = Temp * 3.25;
                            break;
                        case 34:
                            AM = Temp;
                            TAM = Temp * 4.25;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    AuxValiRecoBoletos(x, y);
                    Console.SetCursorPosition(x,y);
                    goto REPETIR;
                }
            }
            else
            {
                AuxValiRecoBoletos(x, y);
                Console.SetCursorPosition(x, y);
                goto REPETIR;
            }
        }

        //Valida tomando como parámetros las coordenadas
        public void AuxValiRecoBoletos(int x, int y)
        {
            Console.SetCursorPosition(x-1, y);
            Console.WriteLine("(/)");
            Thread.Sleep(400);
            Console.SetCursorPosition(x-1, y);
            Console.WriteLine("   ");
        }

        //Esta función escribe el SubTotal en las coordenadas correspondientes
        public void CoorRecoBoletos(double tempSub, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(114,14);
            Console.WriteLine("{0:C2}", SubTotal);

            Console.SetCursorPosition(x,y);
            Console.WriteLine("{0:C2}",tempSub);
        }

        public void PeliHora()
        {
        //Verifica la película
        OpP:
            Console.SetCursorPosition(13, 32);
            if (int.TryParse(Console.ReadLine(), out OpPeli))
            {

                if (OpPeli > 0 && OpPeli < 5)
                {

                }
                else
                {
                    Confirm(true);
                    goto OpP;
                }
            }
            else
            {
                Confirm(true);
                goto OpP;
            }

        //Verifica el horario
        OpH:
            Console.SetCursorPosition(12, 34);
            if (int.TryParse(Console.ReadLine(), out Ophorario))
            {
                if (Ophorario > 0 && Ophorario < 5)
                {

                }
                else
                {
                    Confirm(false);
                    goto OpH;
                }
            }
            else
            {
                Confirm(false);
                goto OpH;
            }
            Console.SetCursorPosition(3, 36);
            Console.WriteLine("Presione [ENTER]");
            Console.ReadKey();
            Console.Clear();
        }

        //Auxiliar estético para verificar película y horario.
        static void Confirm(bool conf)
        {
            if (conf == true)
            {
                Console.SetCursorPosition(13, 32);
                Console.WriteLine("(/)       ");
                Thread.Sleep(400);
                Console.SetCursorPosition(13, 32);
                Console.WriteLine("            ");
            }
            else
            {
                Console.SetCursorPosition(12, 34);
                Console.WriteLine("(/)       ");
                Thread.Sleep(400);
                Console.SetCursorPosition(12, 34);
                Console.WriteLine("            ");
            }
        }

        //Determina la película y el horario escogido
        public void DatosPeli()
        {
            var interfaz = new Interfaz();
            switch (OpPeli)
            {
                case 1:
                    datoPeli = "Rey León";
                    switch (Ophorario)
                    {
                        case 1:
                            datoHora = "07:15";
                            interfaz.interfazIII();
                            BoletosReyLeon();
                            break;
                        case 2:
                            datoHora = "13:00";
                            interfaz.interfazIII();
                            BoletosReyLeon();
                            break;
                        case 3:
                            datoHora = "17:05";
                            interfaz.interfazIII();
                            BoletosReyLeon();

                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    datoPeli = "Mulan";
                    switch (Ophorario)
                    {
                        case 1:
                            datoHora = "09:30";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        case 2:
                            datoHora = "12:45";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        case 3:
                            datoHora = "16:05";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    datoPeli = "Moana";
                    switch (Ophorario)
                    {
                        case 1:
                            datoHora = "11:05";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        case 2:
                            datoHora = "14:30";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        case 3:
                            datoHora = "18:15";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    datoPeli = "IT : ESO";
                    switch (Ophorario)
                    {
                        case 1:
                            datoHora = "00:30";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        case 2:
                            datoHora = "19:00";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        case 3:
                            datoHora = "22:45";
                            interfaz.interfazIII();
                            BoletosMulan();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        //Muestra el horario y película escogidos
        public void CoorDatosPeli()
        {
            Console.SetCursorPosition(19,15);
            Console.WriteLine(datoPeli);
            Console.SetCursorPosition(18,19);
            Console.WriteLine(datoHora);
        }

        public void FuncionConLaQueNosEstamosComplicandoMasDeLaCuenta()
        {
            var estadistica = new Estadistica();
            estadistica.Estadistic(A, N, AM, IngreoA, IngresoN, IngresoAM, TotalIngreso);
        }

    }
}
