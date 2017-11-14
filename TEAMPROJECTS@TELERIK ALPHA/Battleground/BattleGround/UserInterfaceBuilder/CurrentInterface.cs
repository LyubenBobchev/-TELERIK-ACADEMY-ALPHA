using System;
using ProjectBattleGround.BattleFieldGenerator;
using ProjectBattleGround.Players.Contracts;



namespace ProjectBattleGround.UserInterfaceBuilder
{
    public class CurrentInterface
    {
        // writes a big a** game on the console.
        public static void GameNameGraphics()
        {
            Console.Clear();
             string buildGameNameGraphic = String.Format(@"
         ██████╗  █████╗ ████████╗████████╗██╗     ███████╗ ██████╗ ██████╗  ██████╗ ██╗   ██╗███╗   ██╗██████╗ 
         ██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██║     ██╔════╝██╔════╝ ██╔══██╗██╔═══██╗██║   ██║████╗  ██║██╔══██╗
         ██████╔╝███████║   ██║      ██║   ██║     █████╗  ██║  ███╗██████╔╝██║   ██║██║   ██║██╔██╗ ██║██║  ██║
         ██╔══██╗██╔══██║   ██║      ██║   ██║     ██╔══╝  ██║   ██║██╔══██╗██║   ██║██║   ██║██║╚██╗██║██║  ██║
         ██████╔╝██║  ██║   ██║      ██║   ███████╗███████╗╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝██║ ╚████║██████╔╝
         ╚═════╝ ╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚═════╝ 
                                                                                                            
                                                                                                                                                                                    
");
            Console.Write(buildGameNameGraphic);
        }

        //creates the start screen using GameNameGraphics
        public static void BuildStartScreen()
        {
            CurrentInterface.GameNameGraphics();
            string buildStartScreen = String.Format(@"








                                                        START GAME");
            Console.Write(buildStartScreen);

        }

        // wrongChoice indicates if there has been a wrong choice from the user if used with true will put a wrong choice indicator on the screen
        public static void ChooseARace(string player, bool wrongChoice = false)
        {
            CurrentInterface.GameNameGraphics();
            string mistakeMesage;
            if (wrongChoice)
            {
                mistakeMesage = "WRONG INPUT";
            }
            else
            {
                mistakeMesage = "";
            }
            string chooseRace = String.Format(@"





       1-ALIEN                          2-CAT                            3-DOGE                       4-GOBLIN

   Healer: +15 Healing            Archer: +10 Damage              Knight: +25 Health            Magician: +20 Helath

                                                       {0}

                                                 {1} SELECT RACE:",
                                                     mistakeMesage,
                                                     player);
            Console.Write(chooseRace);
        }

        // the uppe user interface with a battle board and a stats window (still has a long way to go. remove this part of note whe done please)
        public static void GameStartScreen(IPlayer redPlayer, IPlayer bluePlayer,BattleField battlefield)
        {
            Console.Clear();
            string startScreen = String.Format(@"  _______________________                      	 ___1_______2_______3_______4_______5_______6_______7_______8___
 |       RED PLAYER      |                      |       |       |       |       |       |       |       |       |
 | Knight-{0} HP /{4} DMG |                     A|   {16}   |   {17}   |   {18}   |   {19}   |   {20}   |   {21}   |   {22}   |   {23}   |
 | Archer-{1} HP /{5} DMG |                      |_______|_______|_______|_______|_______|_______|_______|_______|
 | Healer-{2} HP /{6} DMG |                      |       |       |       |       |       |       |       |       |
 | Mage  -{3} HP /{7} DMG |                     B|   {24}   |   {25}   |   {26}   |   {27}   |   {28}   |   {29}   |   {30}   |   {31}   |
 |-----------------------|                      |_______|_______|_______|_______|_______|_______|_______|_______|
 |       BLUE PLAYER     |                      |       |       |       |       |       |       |       |       |
 | Knight-{8} HP /{12} DMG |                     C|   {32}   |   {33}   |   {34}   |   {35}   |   {36}   |   {37}   |   {38}   |   {39}   |
 | Archer-{9} HP /{13} DMG |                      |_______|_______|_______|_______|_______|_______|_______|_______|
 | Healer-{10} HP /{14} DMG |
 | Mage  -{11} HP /{15} DMG |
 |_______________________|



    _____________________________________________________________________________________________________________",
    //players army stats 

    //health of red player army
    redPlayer.PlayerArmy[2].ReturnHealthInANumberOfSpaces(3),
    redPlayer.PlayerArmy[0].ReturnHealthInANumberOfSpaces(3),
    redPlayer.PlayerArmy[1].ReturnHealthInANumberOfSpaces(3),
    redPlayer.PlayerArmy[3].ReturnHealthInANumberOfSpaces(3),

    // dmg of red player army
    redPlayer.PlayerArmy[2].ReturnDamagePointsInANumberOfSpaces(2),
    redPlayer.PlayerArmy[0].ReturnDamagePointsInANumberOfSpaces(2),
    redPlayer.PlayerArmy[1].ReturnDamagePointsInANumberOfSpaces(2),
    redPlayer.PlayerArmy[3].ReturnDamagePointsInANumberOfSpaces(2),

    //health of blue player army
    bluePlayer.PlayerArmy[2].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy[0].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy[1].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy[3].ReturnHealthInANumberOfSpaces(3),

    // dmg of blue player army
    bluePlayer.PlayerArmy[2].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy[0].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy[1].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy[3].ReturnDamagePointsInANumberOfSpaces(2),

    //spots on the battleground
    //first row
    battlefield.ReturnUnitInPossition(0, 0),
    battlefield.ReturnUnitInPossition(0, 1),
    battlefield.ReturnUnitInPossition(0, 2),
    battlefield.ReturnUnitInPossition(0, 3),
    battlefield.ReturnUnitInPossition(0, 4),
    battlefield.ReturnUnitInPossition(0, 5),
    battlefield.ReturnUnitInPossition(0, 6),
    battlefield.ReturnUnitInPossition(0, 7),
    //second row
    battlefield.ReturnUnitInPossition(1, 0),
    battlefield.ReturnUnitInPossition(1, 1),
    battlefield.ReturnUnitInPossition(1, 2),
    battlefield.ReturnUnitInPossition(1, 3),
    battlefield.ReturnUnitInPossition(1, 4),
    battlefield.ReturnUnitInPossition(1, 5),
    battlefield.ReturnUnitInPossition(1, 6),
    battlefield.ReturnUnitInPossition(1, 7),
    //third row
    battlefield.ReturnUnitInPossition(2, 0),
    battlefield.ReturnUnitInPossition(2, 1),
    battlefield.ReturnUnitInPossition(2, 2),
    battlefield.ReturnUnitInPossition(2, 3),
    battlefield.ReturnUnitInPossition(2, 4),
    battlefield.ReturnUnitInPossition(2, 5),
    battlefield.ReturnUnitInPossition(2, 6),
    battlefield.ReturnUnitInPossition(2, 7)
);
            Console.Write(startScreen);
        }
        
        // makes the player select a unit
        public static void SelectBattleUnit(IPlayer redPlayer, IPlayer bluePlayer, BattleField battlefield, string playerName, string wrongChoice="")
        {
            CurrentInterface.GameStartScreen (redPlayer,  bluePlayer, battlefield );
            string buildSelectUnitScreen = String.Format(@"

            1:Archer                   2:Healer                   3:knight                   4:Mage
            
                                                 {0}  

                                              {1} select unit:",
            wrongChoice,
            playerName);
            Console.Write(buildSelectUnitScreen);
        }

        //makes a player select move attack or get healed
        public static void SelectTypeOfMove(IPlayer redPlayer, IPlayer bluePlayer, BattleField battleField, string wrongChoice=" ")
        {
            CurrentInterface.GameStartScreen (redPlayer,  bluePlayer, battleField);
            string buildSelectUnitScreen = String.Format(@"

            1 - Attack                                  2 - Heal                                3 - Move 
            
                                                      {0}  

                                                  Select a type of move:",
                                              wrongChoice);
            Console.Write(buildSelectUnitScreen);
        }

        //selects where to go next
        public static void SelectNewPositionForUnit(IPlayer redPlayer, IPlayer bluePlayer, BattleField battlefield, string wrongChoice = "")
        {
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battlefield);
            string buildSelectUnitScreen = String.Format(@"
            
                                 Select new possition in the fromat - A4 , B6, C5

                                        {0}  

                                              Select possition:",
            wrongChoice);
            Console.Write(buildSelectUnitScreen);
        }
    }
}
