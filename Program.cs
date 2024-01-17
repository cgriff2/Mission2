using Mission2;

using System.Collections;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    private static void Main(string[] args)
    {
        RollDie roll = new RollDie();

        int numRolls = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        numRolls = int.Parse(System.Console.ReadLine());

        int[] resultArray = roll.DiceRoll(numRolls);

        int count2s = 0;
        int count3s = 0;
        int count4s = 0;
        int count5s = 0;
        int count6s = 0;
        int count7s = 0;
        int count8s = 0;
        int count9s = 0;
        int count10s = 0;
        int count11s = 0;
        int count12s = 0;

        foreach (int number in resultArray)
        {
            if (number == 2)
            {
                count2s++;
            }
            else if (number == 3)
            {
                count3s++;
            }
            else if (number == 4)
            {
                count4s++;
            }
            else if (number == 5)
            {
                count5s++;
            }
            else if (number == 6)
            {
                count6s++;
            }
            else if (number == 7)
            {
                count7s++;
            }
            else if (number == 8)
            {
                count8s++;
            }
            else if (number == 9)
            {
                count9s++;
            }
            else if (number == 10)
            {
                count10s++;
            }
            else if (number == 11)
            {
                count11s++;
            }
            else
            {
                count12s++;
            }
        }

        count2s = count2s * 100 / numRolls;
        count3s = count3s * 100 / numRolls;
        count4s = count4s * 100 / numRolls;
        count5s = count5s * 100 / numRolls;
        count6s = count6s * 100 / numRolls;
        count7s = count7s * 100 / numRolls;
        count8s = count8s * 100 / numRolls;
        count9s = count9s * 100 / numRolls;
        count10s = count10s * 100 / numRolls;
        count11s = count11s * 100 / numRolls;
        count12s = count12s * 100 / numRolls;

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n" +
            "Each \"*\" represents 1% of the total number of rolls. \n Total number of rolls = " +
            numRolls.ToString() + ".");

        int percent = 0;
        
        for (int iCount = 2; iCount < 13; iCount++)
        {
            string s = "";
            if (iCount == 2)
            {
                percent = count2s;
            }
            else if (iCount == 3)
            {
                percent = count3s;
            }
            else if (iCount == 4)
            {
                percent = count4s;
            }
            else if (iCount == 5)
            {
                percent = count5s;
            }
            else if (iCount == 6)
            {
                percent = count6s;
            }
            else if (iCount == 7)
            {
                percent = count7s;
            }
            else if (iCount == 8)
            {
                percent = count8s;
            }
            else if (iCount == 9)
            {
                percent = count9s;
            }
            else if (iCount == 10)
            {
                percent = count10s;
            }
            else if (iCount == 11)
            {
                percent = count11s;
            }
            else
            {
                percent = count12s;
            }

            s += new string('*', percent);
            System.Console.WriteLine($"{iCount}:\t {s}");
        }
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye! ");
    }
}