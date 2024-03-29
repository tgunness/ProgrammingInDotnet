﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    /// <summary>
    /// Class containing all Constants that we'll use in CarDealership app
    /// ref: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-define-constants
    /// </summary>
    public static class Constants
    {
        public const string MainMenu =
@"
CAR APPLICATION
=================
Menu
1 - Display all Cars
2 - List car with best mileage
3 - List all Ford Cars
4 - Exit app

Enter Option:";

        public static string[] GetAsciiCars()
        {
            string[] ret = new string[5];
            ret[0] =
@"
    __            |\
 __/__\___________| \_
|   ___    |  ,|   ___`-.
|  /   \   |___/  /   \  `-.
|_| (O) |________| (O) |____|
   \___/          \___/
";

            ret[1] =
@"
     __            |\
  __/__\___________| \_
  |   ___    |  ,|   ___`-.
  |  /   \   |___/  /   \  `-.
..|_| (O) |________| (O) |____|
      \___/          \___/
";

            ret[2] =
@"
         __            |\
      __/__\___________| \_
     |   ___    |  ,|   ___`-.
     |  /   \   |___/  /   \  `-.
.....|_| (O) |________| (O) |____|
        \___/          \___/
";

            ret[3] =
@"
           __            |\
        __/__\___________| \_
       |   ___    |  ,|   ___`-.
       |  /   \   |___/  /   \  `-.
.......|_| (O) |________| (O) |____|
          \___/          \___/
";
            ret[4] =
@"
           __            |\
        __/__\___________| \_
       |   ___    |  ,|   ___`-.
       |  /   \   |___/  /   \  `-.
.......|_| (O) |________| (O) |____|   GOODBYE!!!
          \___/          \___/
";

            return ret;
        }



    }
}
