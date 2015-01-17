using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Button
    {
        public String sign;
        public Button(String sign)
        {
            this.sign = sign;
        }

        public static String game(int x, int y, String[][] gameArray, Boolean[] check)
        {
            if (check[0] == false)
            {
                gameArray[x][y] = "X";
                check[0] = true;
            } else {
                gameArray[x][y] = "O";
                check[0] = false;
            }
            return gameArray[x][y];
        }
        public static void newGame(String[][] gameArray)
        {
            for (int i = 0; i < gameArray.Length; i++)
            {
                for(int j = 0; j < gameArray[i].Length; j++)
                {
                    gameArray[i][j] = "";
                }
            }
            
        }
        public static bool CheckWin(String[][] gameArray)
        {
            bool flag = false;
            for (int i = 0; i < gameArray.Length; i++)
            {
                String temp;
                temp = gameArray[i][0];
                    for (int j = i; j < gameArray[i].Length; j++)
                    {
                        if(temp == gameArray[i][j] && !String.IsNullOrEmpty(gameArray[i][j]))
                        {
                            flag = true;
                        }
                        else if (temp != gameArray[i][j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                                    
            }
            return flag;
        }
        public static bool verticalCheckWin(String[][] gameArray)
        {
            bool flag = false;
            for (int i = 0; i < gameArray.Length; i++)
            {
                String temp = gameArray[0][i];
                for (int j = 0; j < 3; j++)
                {
                    if (temp == gameArray[j][i] && !String.IsNullOrEmpty(gameArray[j][i]))
                    {
                        flag = true;
                    }
                    else if (temp != gameArray[j][i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            return flag;
        }

        public static bool DiagonalCheckWin1(String[][] gameArray)
        {
            bool flag = false;
          
            String temp = gameArray[0][0];
            for(int i = 1; i < gameArray.Length; i++)
            {
                if (temp == gameArray[i][i] && !String.IsNullOrEmpty(gameArray[i][i]) && String.IsNullOrEmpty(temp))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
         }
        public static bool DiagonalCheckWin2(String[][] gameArray)
        {
            bool flag = false;
            String temp = gameArray[0][2];
            for (int i = 0; i < gameArray.Length; i++ )
            {
                if (gameArray[i][gameArray.Length - 1 - i] == temp && !String.IsNullOrEmpty(gameArray[i][gameArray.Length - 1 - i]) && String.IsNullOrEmpty(temp))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
                return flag;
        }

   
    }
}
