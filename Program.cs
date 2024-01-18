using moreC_Fun;
internal class Program
{
    private static void Main(string[] args)
    {
        //declare number of rolls, separate dice class where throw method lives
        //declare array that can be used as a result of the DiceThrower method
        int numRolls;
        ThrowDice td = new ThrowDice();
        int[] endResults;

        //Write intro
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
            "How many dice rolls would you like to simulate?");

        //obtain roll number as converted to integer
        numRolls = int.Parse(System.Console.ReadLine());

        //get roll results array
        endResults = td.DiceThrower(numRolls);

        //generate result text
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
            "Each \"*\" represents 1% of the total number of rolls.\n" +
            "Total number of rolls = " + numRolls + ".\n");

        //loop for histogram
        for (int iCount = 0; iCount < endResults.Length; iCount++)
        {
            //initiate stars string
            string histogramStars = "";

            //declare variable that can house each position result in the output array
            int rollResults = endResults[iCount];

            //calculate percentage and change back to integer
            float percentage = ((float)rollResults / (float)numRolls) * 100;
            percentage = (int)percentage;

            //gather stars based on percentage of 100
            for (int j = 0; j < percentage; j++)
            {
                histogramStars = histogramStars + "*";
            }

            //generate output for each roll plus the amount of stars associated with that number
            System.Console.WriteLine((iCount + 2) + ": " + histogramStars);
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}