namespace Ejercicio1Minutos
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Introduce el numero de minutos trabajados");
            int minutos = Convert.ToInt32(Console.ReadLine());
            int dias = minutos / (8 * 60);
            int horas = (minutos % (8 * 60)) / 60;
            int minutosRestantes = minutos % 60;

            //He usado cosas que he visto en youtube
            if (dias > 0) Console.WriteLine($"{dias} dia{(dias > 1 ? "s" : "")}");
            if (horas > 0) Console.WriteLine($"{horas} hora{(horas > 1 ? "s" : "")}");
            if (minutosRestantes > 0) Console.WriteLine($"{minutosRestantes} minuto{(minutosRestantes > 1 ? "s" : "")}");
        }
    }
}
