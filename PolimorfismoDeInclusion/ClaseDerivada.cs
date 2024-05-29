namespace PolimorfismoDeInclusion
{
    public class ClaseDerivada:ClaseBase
    {
        public override void Metodo1()
        {
            Console.WriteLine("Metodo1() en ClaseDeribada");
        }
        public new void Metodo2()
        {
            Console.WriteLine("Metodo2() en ClaseDeribada");
        }
    }
}
