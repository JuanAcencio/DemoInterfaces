using PolimorfismoDeInclusion;
Console.WriteLine("Demostracion de polimorfismo de inlusion\n");

ClaseBase claseBase = new ClaseBase();
ClaseDerivada claseDeribada = new ClaseDerivada();
ClaseBase cbcd = new ClaseDerivada();

claseBase.Metodo1();
claseBase.Metodo2();
claseDeribada.Metodo1();
claseDeribada.Metodo2();
cbcd.Metodo1();
cbcd.Metodo1();
