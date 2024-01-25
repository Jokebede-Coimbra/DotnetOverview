public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisterdAirMail = 2,
    Express = 3
}
internal class Program
{

    private static void Main(string[] args)
    {

        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 1;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        var methodName = "Express";
        var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        Console.WriteLine(shippingMethod);
    }
}