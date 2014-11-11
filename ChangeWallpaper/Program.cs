using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ChangeWallpaper
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINIFILE = 0x1;
        public const int SPIF_SENDWININICHANGE = 0x2;
        static void Main(string[] args)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 1, Marshal.StringToBSTR(args[0]), SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
