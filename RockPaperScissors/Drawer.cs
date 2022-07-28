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


        public void DrawRockPaperScissors()
        {
            string logo = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0'            .kMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWx.           .oNMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMX0:           .dNMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMk:.           ;XMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk:,..        .xWMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMX0l.....   .,xNMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0o'         :KMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMX:.           lNMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0;             .dWMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKo.               '0MMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMK;.               .cXMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMNc...             ,xNMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMk''.     ...     ;kNMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWd..    .,c,    .c0NMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMKc'     ,:.   .ld0MMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMNx.  ..:;   .:,.xMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMWNXK0OkkxxxkXMMMMMMMNl    .,...;;..xMMMMMMMMMMMMMMMMMMMMMMMM
XNWMMMN0dc;'..       'kMMMMMMMMXo.    ....  ,0MMMMMMMMMMMMMMMMMMMMMMMM
.,okdc,.          ..,cdxxkkO0KKXX0dl:.    .c0WMMMMMMMMMMMMMMMMMMMMMMMM
                            .....';:cdkdod0WMMMMMMMMMMMMMMMMMMMMMMMMMM
                         .....    ...lXMWXXWMMMMMMMMMMMMMMMMMMMMMMMMMM
                          ..........'oXWk,.;oONWMMMMMMMMMMMMMMMMMMMMMM
                        ............;OMMXo.   'cxKWMMMMMMMMMMMMMMMMMMM
    .               ..........'cllookNMMMW0o'    .:xKWMMMMMMMMMMMMMMMM
.',xKOdl;'..         .....';:ckNMMMMMMNXNWMMNkc.    .:dKWMMMMMMMMMMMMM
NNNWMMMMWNX0OkxddddxkOO0KXNWWMMMMMMMWx,.';cok0XKkc.    .:dkOKNWMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk;.     ..,:ll;.       .':okKWMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0dc,.                    .,lx0
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKkl'                      
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWd.                      
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,........              
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXl.   ...,'             
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNk,     ....           
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk;......         .,. 
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0dc:,,'......'o0Nk";
            Console.WriteLine(logo);
        }
    }
}
