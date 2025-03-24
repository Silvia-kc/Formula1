// See https://aka.ms/new-console-template for more information
using Formula1.Controllers;
using Formula1.View;

namespace Formula1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Display display = new Display();
            await display.ShowMenu();
        }
    }
}
