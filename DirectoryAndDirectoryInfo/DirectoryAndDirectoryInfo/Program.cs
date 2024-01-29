internal class Program
{
    private static void Main(string[] args)
    {
        Directory.CreateDirectory(@"D:\C#_projetos\folder1");

        // var files = Directory.GetFiles(@"d:\C#_projetos\DirectoryAndDirectoryInfo", "*.*", SearchOption.AllDirectories);
        // foreach (var file in files)
        // {
        //   Console.WriteLine(file);
        // }

        var directories = Directory.GetDirectories(@"d:\C#_projetos\C#", "*.*", SearchOption.AllDirectories);
        foreach (var directory in directories)
        {
            Console.WriteLine(directory);
        }

        Directory.Exists("...");

        var directoryInfo = new DirectoryInfo("...");
        directoryInfo.GetFiles();
        directoryInfo.GetDirectories();

    }

}