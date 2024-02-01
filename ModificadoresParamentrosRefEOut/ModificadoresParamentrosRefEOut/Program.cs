using ModificadoresParamentrosRefEOut;

NewMethod();

static void NewMethod()
{
    int a = 10;
    int triplo;

    Calculadora.Triple(a, out triplo);
    Console.WriteLine(triplo);

    
}
