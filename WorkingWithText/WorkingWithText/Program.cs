using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var fullName = "Coimbra Nascimento ";
        Console.WriteLine("Trim: '{0}'", fullName.Trim());
        Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

        var index = fullName.IndexOf(' ');
        var firstName = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);
        Console.WriteLine("FirstName: " + firstName);
        Console.WriteLine("LastName: " + lastName);

        var names = fullName.Split(' ');
        Console.WriteLine("FirstName: " + names[0]);
        Console.WriteLine("LastName: " + names[1]);


        Console.WriteLine(fullName.Replace("Coimbra", "Jkbd"));

        if (String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid");

        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age);

        float price = 29.95f;
        Console.WriteLine(price.ToString("C0"));


        //*************************StringBuilder*****************************
        var builder = new StringBuilder();
        builder
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10);

        builder.Replace('-', '*');

        builder.Remove(0, 10);

        builder.Insert(0, new string('-', 10));
        Console.WriteLine(builder);
    }
}