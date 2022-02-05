using System;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] matrix) 
        { 
            bool scorePresent = false; 
            for (int nrOfRows = 0; nrOfRows < matrix.GetLength(0); nrOfRows++) 
            { 
                RegularCandies candy = matrix[nrOfRows, 0]; 
                int count = 1; 
                for (int nrOfColumns = 1; nrOfColumns < matrix.GetLength(1); nrOfColumns++) 
                { 
                    if (matrix[nrOfRows, nrOfColumns] == candy) 
                     { 
                        count++; 
                        if (count >= 3)
                        {
                            scorePresent = true; 
                            break; 
                        } 
                     } 
                    else 
                    { 
                        candy = matrix[nrOfRows, nrOfColumns]; 
                        count = 1; 
                    } 
                } 
            } 
            return scorePresent; 
        }

       public static bool ScoreColumPresent(RegularCandies[,] playingField)
        {
            bool scorePresent = false;
            int count = 1;
            for (int nrOfRows = 0; nrOfRows < playingField.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < playingField.GetLength(1); nrOfColumns++)
                {
                    RegularCandies currentCandy = playingField[nrOfRows, nrOfColumns];

                    if (nrOfRows >= 2)
                    {
                        RegularCandies previousCandy = playingField[nrOfRows - 1, nrOfColumns];
                        if (previousCandy == currentCandy)
                        {
                            count++;
                            previousCandy = playingField[nrOfRows - 2, nrOfColumns];
                            if (previousCandy == currentCandy)
                            {
                                count++;
                                if (count == 3)
                                {
                                    scorePresent = true;
                                    break;
                                }
                            }

                        }
                        else
                        {

                            count = 1;
                        }
                    }


                }
            }
            return scorePresent;
        }
    }
}
