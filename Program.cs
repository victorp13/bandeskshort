namespace BanDesktopShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.Delete(Path.Combine(desktopPath, "Discord.lnk"));       
            File.Delete(Path.Combine(desktopPath, "Postman.lnk"));       
        }
    }
}