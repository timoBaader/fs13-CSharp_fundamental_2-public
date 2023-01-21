﻿using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Challenge 1
        int[][] arr1 = { new int[] { 1, 2 }, new int[] { 2, 1, 5 } };
        int[] arr1Common = CommonItems(arr1);
        Debug.WriteLine(arr1Common);

        //Challenge 2
        int[][] arr2 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
        var result2 = InverseJagged(arr2);
        Debug.WriteLine(result2);

        //Challenge 3
        int[][] arr3 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
        var result3 = CalculateDiff(arr3);
        Debug.WriteLine(result3);

        //Challenge 4
        int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] arr4Inverse = InverseRec(arr4);
        /* write method to print arr4Inverse */

        //Challenge 5
        Demo("hello", 1, 2, "world");

        //Challenge 6

        //Challenge 7
        string firstName, middleName, lastName;
        ParseNames("Mary Elizabeth Smith", firstName, middleName, lastName);
        Console.WriteLine($"First name: {firstName}, middle name: {middleName}, last name: {lastName}");

        //Challenge 8
        GuessingGame();
    }

    /*
    Challenge 1. Given a jagged array of integers (two dimensions).
    Find the common elements in the nested arrays.
    Example: int[][] arr = { new int[] {1, 2}, new int[] {2, 1, 5}}
    Expected result: int[] {1,2} since 1 and 2 are both available in sub arrays.
    */
    static int[] CommonItems(int[][] jaggedArray)
    {
        int[] result = new int[jaggedArray[0].Length]; ;

        for (int i = 0; i < jaggedArray[0].Length; i++)
        {
            for (int j = 0; j < jaggedArray[1].Length; j++)
            {
                if (jaggedArray[0][i] == jaggedArray[1][j])
                {
                    result[i] = jaggedArray[0][i];
                }
            }
        }
        return result;
    }

    /* 
    Challenge 2. Inverse the elements of a jagged array.
    For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
    Expected result: int[][] arr = {new int[]{2, 1}, new int[]{3, 2, 1}}
     */
    static int[][] InverseJagged(int[][] jaggedArray)
    {
        var result = new int[jaggedArray.Length][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            var subResult = new int[jaggedArray[i].Length];
            for (int j = jaggedArray[i].Length - 1; j >= 0; j--)
            {
                subResult[jaggedArray[i].Length - j - 1] = jaggedArray[i][j];
            }
            result[i] = subResult;
        }
        return result;
    }

    /* 
    Challenge 3.Find the difference between 2 consecutive elements of an array.
    For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
    Expected result: int[][] arr = {new int[] {-1}, new int[]{-1, -1}}
     */
    static int[][] CalculateDiff(int[][] jaggedArray)
    {
        var result = new int[jaggedArray.Length][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            var subResult = new int[jaggedArray[i].Length - 1];
            for (int j = 0; j < jaggedArray[i].Length - 1; j++)
            {
                subResult[j] = jaggedArray[i][j] - jaggedArray[i][j + 1];
            }
            result[i] = subResult;
        }
        return result;
    }

    /* 
    Challenge 4. Inverse column/row of a rectangular array.
    For example, given: int[,] arr = {{1,2,3}, {4,5,6}}
    Expected result: {{1,2},{3,4},{5,6}}
     */
    static int[,] InverseRec(int[,] recArray)
    {
        int rows = recArray.GetLength(0); // 2
        int columns = recArray.GetLength(1); // 3

        var result = new int[columns, rows];
        int[] temp = new int[rows * columns];
        int counter = 0;

        // read all the values and store them in a temporary array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                temp[counter + j] = recArray[i, j];
            }
            counter = 3;
        }
        // fill the result array with values
        counter = 0;
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result[i, j] = temp[counter + j];
            }
            counter += 2;
        }
        return result;
    }

    /* 
    Challenge 5. Write a function that accepts a variable number of params of any of these types: 
    string, number. 
    - For strings, join them in a sentence. 
    - For numbers then sum them up. 
    - Finally print everything out. 
    Example: Demo("hello", 1, 2, "world") 
    Expected result: hello world; 3 */
    static void Demo()
    {

    }

    /* Challenge 6. Write a function to swap 2 objects but only if they are of the same type 
    and if they’re string, lengths have to be more than 5. 
    If they’re numbers, they have to be more than 18. */
    static void SwapTwo()
    {

    }

    /* Challenge 7. Write a function to parse the first name, middle name, last name given a string. 
    The names will be returned by using out modifier */
    static void ParseNames(
        string input,
        out string firstName,
        out string middleName,
        out string lastName)
    {

    }

    /* Challenge 8. Write a function that does the guessing game. 
    The function will think of a random integer number (lets say within 100) 
    and ask the user to input a guess. 
    It’ll repeat the asking until the user puts the correct answer. */
    static void GuessingGame()
    {

    }
}
