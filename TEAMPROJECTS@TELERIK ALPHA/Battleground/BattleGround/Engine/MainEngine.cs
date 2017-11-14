using ProjectBattleGround.UserFolder;
using ProjectBattleGround.UserFolder.UserContracts;
using ProjectBattleGround.UserInterfaceBuilder;
using System;
using ProjectBattleGround.Players.Contracts;
using ProjectBattleGround.Players;
using ProjectBattleGround.BattleFieldGenerator;

namespace ProjectBattleGround.Engine
{
    public static class MainEngine
    {
        //starts the game
        public static void StartGame()
        {
            CurrentInterface.BuildStartScreen();
            Console.ReadLine();
            IPlayer redPlayer = new RedPlayer(CreatePlayer("RED PLAYER"));
            IPlayer bluePlayer = new BluePlayer(CreatePlayer("BLUE PLAYER"));
            BattleField battleField = new BattleField(redPlayer, bluePlayer);
            while(redPlayer.ReturnArmySize()>0 && bluePlayer.ReturnArmySize() > 0)
            {
                PlayerPlaysHisTurn(redPlayer, bluePlayer, battleField, redPlayer, bluePlayer, "Red Player");
                battleField = new BattleField(redPlayer, bluePlayer);
                if (bluePlayer.ReturnArmySize() == 0)
                {
                    //TODO MAKE A WIN SCREEN FOR RED
                    CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
                    Console.WriteLine("                                                                    RED WINS");
                    break;
                }
                PlayerPlaysHisTurn(redPlayer, bluePlayer, battleField, bluePlayer, redPlayer, "Blue Player");
                battleField = new BattleField(redPlayer, bluePlayer);
                if (redPlayer.ReturnArmySize() == 0)
                {
                    //TODO MAKE A WIN SCREEN FOR BLUE
                    CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
                    Console.WriteLine("                                                                    BLUE WINS");
                    break;
                }
            }

        }

        // every player makes his move 
        private static void PlayerPlaysHisTurn(IPlayer redPlayer, IPlayer bluePlayer, BattleField battleField, IPlayer attackingPlayer, IPlayer defendingPlayer, string unitMessage)
        {
            CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, unitMessage);
            int selecteAttackingdUnitIndex = ReturnSelectedUnitIndex(redPlayer, bluePlayer, battleField, unitMessage, attackingPlayer);
            CurrentInterface.SelectTypeOfMove(redPlayer, bluePlayer, battleField);
            string unitTypeOfMove = ReturnSelectedTypeOfMove(redPlayer, bluePlayer, battleField, attackingPlayer);
            switch (unitTypeOfMove)
            {
                case "1":
                    CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, unitMessage);
                    int selectedUnitToBeAttackedIndex = ReturnSelectedUnitIndex(redPlayer, bluePlayer, battleField, unitMessage, defendingPlayer);
                    while (defendingPlayer.PlayerArmy[selectedUnitToBeAttackedIndex].Health == 0)
                    {
                        selectedUnitToBeAttackedIndex = ReturnSelectedUnitIndex(redPlayer, bluePlayer, battleField, unitMessage, attackingPlayer);
                    }
                    defendingPlayer.PlayerArmy[selectedUnitToBeAttackedIndex].TakeDamage(attackingPlayer.PlayerArmy[selecteAttackingdUnitIndex]);
                    break;
                case "2":
                    attackingPlayer.PlayerArmy[selecteAttackingdUnitIndex].Heal(attackingPlayer.PlayerArmy[1] as Healer);
                    break;
                case "3":
                    CurrentInterface.SelectNewPositionForUnit(redPlayer, bluePlayer, battleField);
                    string coordinates = ReturnNewSelectedPossition(redPlayer, bluePlayer, battleField, attackingPlayer.PlayerArmy[selecteAttackingdUnitIndex]);
                    int rowPosition = (int)(Char.ToUpper(coordinates[0])) - 64 - 1;
                    int colPosition = int.Parse(coordinates[1].ToString()) - 1;
                    attackingPlayer.PlayerArmy[selecteAttackingdUnitIndex].CurrentPossition(rowPosition, colPosition);
                    break;
            }
        }

        //rturns a selected possition for units
        private static string ReturnNewSelectedPossition(IPlayer redPlayer, IPlayer bluePlayer, BattleField battleField, IBattleUnit selectedBattleUnit)
        {
            string userInput = Console.ReadLine();
            while (userInput.Length != 2)
            {
                CurrentInterface.SelectNewPositionForUnit(redPlayer, bluePlayer, battleField, "You have selected an invalid possition");
                userInput = Console.ReadLine();
            }
            int colPosition=0;
            char rowPositionChar = Char.ToUpper(userInput[0]);
            if (!(Char.IsLetter(rowPositionChar) && (int)rowPositionChar >64 && (int)rowPositionChar < 68) ||            // checks the ascII codes 
                !(int.TryParse(userInput[1].ToString(), out colPosition) && (colPosition > 0 && colPosition < 9)))
            {
                CurrentInterface.SelectNewPositionForUnit(redPlayer, bluePlayer, battleField, "You have selected an invalid possition");
                userInput =  ReturnNewSelectedPossition(redPlayer, bluePlayer, battleField, selectedBattleUnit);
            }
            int rowPosition = (int)rowPositionChar - 65;
            colPosition--;
            if(Math.Sqrt(Math.Pow(rowPosition-selectedBattleUnit.UnitPossition.VerticalPossition,2)) > 1 ||
              Math.Sqrt(Math.Pow(colPosition - selectedBattleUnit.UnitPossition.HorizontalPossition, 2)) > 1)            //checks if the unit is moving 2 much
            {
                CurrentInterface.SelectNewPositionForUnit(redPlayer, bluePlayer, battleField, "You can only move one square per turn");
                userInput= ReturnNewSelectedPossition(redPlayer, bluePlayer, battleField, selectedBattleUnit);
            }
            if(battleField.ReturnUnitInPossition(rowPosition,colPosition)!=' ')                  //checks if unit is moving to a filled square 
            {
                CurrentInterface.SelectNewPositionForUnit(redPlayer, bluePlayer, battleField, "There is a unit in that square.");
                 userInput=ReturnNewSelectedPossition(redPlayer, bluePlayer, battleField, selectedBattleUnit);
            }
            return userInput;
        }

        //player selects a type of move and returns that type of move 
        private static string ReturnSelectedTypeOfMove(IPlayer redPlayer, IPlayer bluePlayer, BattleField battleField, IPlayer attackingUnit)
        {
            string userInput = Console.ReadLine();
            while (userInput != "1" && userInput != "2" && userInput != "3")
            {
                CurrentInterface.SelectTypeOfMove(redPlayer, bluePlayer, battleField, "Not a valid move.");
                userInput = Console.ReadLine();
            }
            if(userInput=="2" && attackingUnit.PlayerArmy[1].Health == 0)
            {
                CurrentInterface.SelectTypeOfMove(redPlayer, bluePlayer, battleField, "This team has no healer for the units to heal.");
                userInput = ReturnSelectedTypeOfMove(redPlayer, bluePlayer, battleField, attackingUnit);
            }
            return userInput;
        }

        //selects a Unit and these methods take a lot of arguments cuz they use the gameStartScreen interface and it takes 3 arguments on its own
        private static int ReturnSelectedUnitIndex(IPlayer redPlayer, IPlayer bluePlayer, BattleField battleField, string userName, IPlayer selectedPlayer)
        {
            string userInput = Console.ReadLine();
            int selectedUnit;
            int.TryParse(userInput, out selectedUnit);
            while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, userName, "This is not a Unit");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out selectedUnit);
            }
            selectedUnit = selectedUnit - 1;
            if (selectedPlayer.PlayerArmy[selectedUnit].Health==0)
            {
                CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, userName, "This Unit has no HP");
                selectedUnit = ReturnSelectedUnitIndex(redPlayer, bluePlayer, battleField, userName, selectedPlayer);
            }
            return selectedUnit;
        }
        
        // prints the battlefield 
        private static void PrintGameInterface(BattleField battleField, IPlayer redPlayer, IPlayer bluePlayer)
        {
            battleField = new BattleField(redPlayer, bluePlayer);
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
            Console.ReadLine();
        }

        //creates the user that is selected by the player and returns it
        private static IUser CreatePlayer(string outputMessage)
        {
            CurrentInterface.ChooseARace(outputMessage);
            IUser createdUser = ChooseAPlayerType(outputMessage);
            return createdUser;
        }

        //loops until the player chooses a correct type and returns a user form the selected class
        private static IUser ChooseAPlayerType(string playerName)
        {
            string userInput = Console.ReadLine();
            IUser createdUser;
            while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                CurrentInterface.ChooseARace(playerName, true);
                userInput = Console.ReadLine();
            }
            switch (userInput)
            {
                case "1":
                    createdUser = new UserAlien();
                    break;
                case "2":
                    createdUser = new UserCat();
                    break;
                case "3":
                    createdUser = new UserDoge();
                    break;
                case "4":
                    createdUser = new UserGoblin();
                    break;
                default:
                    throw new Exception("Fatal Error!");
            }
            return createdUser;
        }
    }
}
