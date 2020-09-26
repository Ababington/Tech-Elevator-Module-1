using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {

        public string TypeOfFruit { get; private set; }
        public int PiecesOfFruitLeft { get; private set; }
       


        public FruitTree(string typesOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typesOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
        }

        public bool PickFruit( int NumberOfPiecesToRemove)
        {
            bool pickFruit = true;
            
            if(PiecesOfFruitLeft >= NumberOfPiecesToRemove)
            {
                pickFruit = true;
                PiecesOfFruitLeft -= NumberOfPiecesToRemove;
            }
            else if(PiecesOfFruitLeft < 1)
            {
                pickFruit = false;
            }
            return pickFruit;   
        }
    }
}
//If there are enough pieces left on the tree, it "picks" the fruit and updates PiecesOfFruitLeft by subtracting numberOfPiecesToRemove from it.
//The method returns true if there were enough pieces left to pick. It returns false if no fruit was picked—that is, PiecesOfFruitLeft was less than numberOfPiecesToRemove.

