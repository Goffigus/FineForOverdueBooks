using System;
using static System.Console;
public class FineForOverdueBooks
{
    public static void Main()
    {
        while (true)
        {
            WriteLine("How many books are checked out by the patron?");
            int books = Convert.ToInt32(ReadLine());

            WriteLine("How many days have they been out?");
            int days = Convert.ToInt32(ReadLine());

            DisplayFine(books, days); 
        }
    }
    public static void DisplayFine(int books, int days)
    {
        double fine = 0;


        if(days > 7)
        {
            fine = books * .1 * 7; //first week of fines
            fine += books * .2 * (days - 7);
        }
        else
        {
            fine = books * .1 * days;
        }

        WriteLine("The fine for {0} book(s) for {1} day(s) is {2:C}", books, days, fine);

    }
}