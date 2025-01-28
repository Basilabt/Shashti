using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace Shashti.Utility
{
    internal sealed class clsScreen
    {

        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);



        public static int getScreenX()
        {   
            int screenWidth = GetSystemMetrics(0);  // SM_CXSCREEN = 0
            return screenWidth;
        }

        public static int getScreenY()
        {
            int screenHeight = GetSystemMetrics(1); // SM_CYSCREEN = 1
            return screenHeight;
        }


    }
}
