using System;
using System.Collections.Generic;

class Program
{
    static List<int> FindPositions(string inputString, char target)
    {
        List<int> positions = new List<int>();

        for (int i = 0; i < inputString.Length; ++i)
        {
            if (inputString[i] == target)
            {
                positions.Add(i);
            }
        }

        return positions;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter a character to find: ");
        char targetChar = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Move to the next line after reading the character.

        List<int> foundPositions = FindPositions(inputString, targetChar);

        if (foundPositions.Count == 0)
        {
            Console.WriteLine($"The character '{targetChar}' was not found in the string.");
        }
        else
        {
            Console.Write($"The character '{targetChar}' was found at positions: ");
            foreach (int position in foundPositions)
            {
                Console.Write($"{position} ");
            }
            Console.WriteLine();
        }
    }
}