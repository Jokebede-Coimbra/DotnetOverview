using ModificadoresParamentrosRefEOut;

NewMethod();

static void NewMethod()
{
    Console.WriteLine("Modificador out");
    int a = 10;
    int triplo;

    Calculadora.Triple(a, out triplo);
    Console.WriteLine(triplo);

    Console.WriteLine("Modificador ref");

    int b = 10;
    Calculadora2.Triple2(ref a);
    Console.WriteLine(a);


}
