namespace BanDesktopShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] apps = File.ReadAllLines("shortcuts.txt");

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string commonDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
            
            foreach (string app in apps)
            {
                File.Delete(Path.Combine(desktopPath, app));
                File.Delete(Path.Combine(commonDesktopPath, app));
            }   
        }
    }
}