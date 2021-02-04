namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            //loop int array adding the numbers from left to right and compare with the last index value if its higher continue adding form
            //right to left until that number be equal or higher than first one
            int sumLeft = 0, sumRight = 0;
            sumLeft = numbers[0];
            sumRight = numbers[numbers.Length];
            int topLoop = numbers.Length - 1;

            for (int indexLeft = 1 ; indexLeft <  topLoop; indexLeft++ )
            {
                //1,3,5,5,3
                //4,5,5,3

                if (sumLeft < sumRight)
                {
                    sumLeft += numbers[indexLeft];
                    
                }
                else if (sumLeft > sumRight)
                {
                    topLoop -= 1;
                    indexLeft -= 1;//downgrade value of indexLeft to continue on same index from left
                    sumRight += numbers[topLoop];
                    
                }
                else {
                    return numbers[indexLeft];
                }
                
            }
        return -1;
      }
    }
}
