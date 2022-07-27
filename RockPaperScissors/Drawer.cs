using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Drawer : IDrawer
    {


        public void DrawWelcomeScreen()
        {
            string welcomScreen = @" 
__      __       .__                               
                                    /  \    /  \ ____ |  |   ____  ____   _____   ____  
                                    \   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \ 
                                     \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/ 
                                        \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >
                                             \/       \/          \/            \/     \/ ";

            Console.WriteLine(welcomScreen);
        }
    }
}
