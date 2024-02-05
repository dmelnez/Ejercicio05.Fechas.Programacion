namespace Ejercicio05.Fechas.Programacion
{

    class Program
    {

        public static void Main(string[] args)
        {



            Console.WriteLine("FECHA 01: ");
            DateTime fecha01 = Convert.ToDateTime(Console.ReadLine());
            

            Console.WriteLine("FECHA 02: ");
            DateTime fecha02 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan fechaDiferenciada = fecha01 - fecha02;

            int dias = fechaDiferenciada.Days;
            Console.WriteLine("DIAS: " + dias);

            int horas = fechaDiferenciada.Hours;
            Console.WriteLine("HORAS: " + horas);

            int minutos = fechaDiferenciada.Minutes;
            Console.WriteLine("MINUTOS: " + minutos);

            int segundos = fechaDiferenciada.Seconds;
            Console.WriteLine("SEGUNDOS: " + segundos);



        }




    }


}