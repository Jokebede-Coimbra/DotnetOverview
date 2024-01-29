internal class Program
{
    private static void Main(string[] args)
    {
        var path = @"D:\C#_projetos\C#\WorkingWithFiles\WorkingWithFiles.sln";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex);

        Console.WriteLine("Extension: " + Path.GetExtension(path));
        Console.WriteLine("File Name: " + Path.GetFileName(path));
        Console.WriteLine("File name without Extension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
    }
}