namespace DemoInterfaces
{
    internal class Empleado:Persona,IAsalariable
    {
        public readonly decimal EstimuloPorAniosTrabajados = 50.0M;
        public readonly int MinimodeAniosSinRecibirEstimulo = 5;
        public readonly int NumeroDeDiasDelPeriodo = 15;

        public string Rfc { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public decimal SalarioDiario { get; set; }

        public Empleado(string nombre, string apellidos, string rfc, DateTime fechadeingreso, decimal salarioDiario) : base(nombre, apellidos)
        {
            Rfc = rfc;
            FechaDeIngreso = fechadeingreso;
            SalarioDiario = salarioDiario;

        }

        public decimal CalcularSalarioFijoDelPeriodo(int numeroDeDiasTrabajados)
        {
            return SalarioDiario * numeroDeDiasTrabajados;
        }

        public decimal CalcularEstimuloPorAntiguedad()
        {
            int aniosLaborando = 0;
            decimal estimulo = 0.0M;

            if (FechaDeIngreso < DateTime.Now)
            {
                DateTime momentoCero = new DateTime(1, 1, 1);
                TimeSpan lapso = DateTime.Now - FechaDeIngreso;
                aniosLaborando = (momentoCero + lapso).Year - 1;
            }
            if (aniosLaborando > MinimodeAniosSinRecibirEstimulo)
            {
                estimulo = (aniosLaborando - MinimodeAniosSinRecibirEstimulo) * EstimuloPorAniosTrabajados;
            }
            return estimulo;

        }
        public decimal CalcularSalario()
        {
            return CalcularSalarioFijoDelPeriodo(NumeroDeDiasDelPeriodo) + CalcularEstimuloPorAntiguedad();
        }
    }
}
