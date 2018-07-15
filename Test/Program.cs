using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            MazzeGen();
            Console.ReadLine();                                        //Applicatiop can shut down after act, that line cautions it
        }
        
        
        static void MazzeGen()
        {
            #region _setUp

            int cell;
            int line;
                
            Console.Write(" ");
            
            int[,] array = new[,] {                                    //2D array to create grid 
                {1, 2, 3, 4, 5, 6, 7, 8},             //1
                {1, 2, 3, 4, 5, 6, 7, 8},             //2
                {1, 2, 3, 4, 5, 6, 7, 8},             //3
                {1, 2, 3, 4, 5, 6, 7, 8},             //4
                {1, 2, 3, 4, 5, 6, 7, 8},             //5
                {1, 2, 3, 4, 5, 6, 7, 8},             //6
                {1, 2, 3, 4, 5, 6, 7, 8},             //7
                {1, 2, 3, 4, 5, 6, 7, 8},             //8
            };
            for (int i = 0; i < 6; i++)                                //Ceiling
            {
                Console.Write("__");
            }

            #endregion
            
            #region _testRegion

            Console.Write("\n");                                       //Skip to test body
            
            for (int y = 0; y < 8; y++)                                //Test body loop
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write("{0}", array[y,x]);                  //Debug for grid
                                                                       //Creating semple, its simple Logics & creating actual grid 
                    if (array[y, x] > 1 && array[y, x] < 8)
                    {
                        Console.Write("__");                           //Floor 
                    }
                    else if(array[y, x] == 1 || array[y, x] == 8)
                    {
                        Console.Write("|");                            //Walls
                    }
                }
                
                Console.Write("\n");
            }

            Console.Write("\n");
            
            #endregion

            #region _mainBody

            for (int y = 0; y < 8; y++)
            {
                Random randNumbCell = new Random();                //Creating radom num for mazze gen
                cell = randNumbCell.Next(1, 6);
                Random randNumbLine = new Random();                //Creating radom num for mazze gen
                line = randNumbCell.Next(0, 7);
                
                array[y,line] = cell;
            }
            
            for (int y = 0; y < 8; y++)
            {   
                for (int x = 0; x < 8; x++)
                {   
                    Console.Write("{0}", array[y,x]);                  //Debug for grid
                    
                    if (array[y, x] == 1 || array[y, x] == 8)
                    {
                        Console.Write("|"); 
                    }
                    if (array[y, x] == cell)
                    {
                        Console.Write(" |");                           //Floor 
                    }
                    else if (array[y, x] != cell && array[y, x] != 8 && array[y, x] != 1)
                    {
                        Console.Write("__");
                    }
                }
                Console.Write("\n");
            }
            #endregion
        }
    }
}
