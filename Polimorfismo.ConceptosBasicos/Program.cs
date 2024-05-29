using Polimorfismo.ConceptosBasicos;

Console.WriteLine("Demostracion de conceptos basicos del polimorfismo.\n");
ClaseBase claseBase = new ClaseBase();
ClaseDerivada claseDerivada = new ClaseDerivada();
ClaseBase cbcd = new ClaseDerivada();

claseBase.Metodo1();
claseBase.Metodo2();
claseDerivada.Metodo1();
claseDerivada.Metodo2();
cbcd.Metodo1();
cbcd.Metodo1();

