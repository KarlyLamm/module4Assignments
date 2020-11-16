/*
 Author: Karly Lamm
Date: November 10th, 2020
Lindenwood University - C# class
Application description: Using methods to user input, and display library fine amount
 */
using System;
using static System.Console;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int overdueBooks, daysOverdue;
            WriteLine("Enter number of books that are overdue: ");
            overdueBooks = int.Parse(ReadLine());
            
            WriteLine($"Enter number of days that the {overdueBooks} books overdue: ");
            daysOverdue = int.Parse(ReadLine());

            displayLibraryFine(overdueBooks, daysOverdue);
        //   int bookFine = displayLibraryFine(int overdueBooks, int daysOverdue);
        }
        static void displayLibraryFine(double books,double days) {
            double fine = 0;
            if (days <= 7)
            {
                fine = days*books*.10;

            }
            else {
                fine = books*(.7 + (days - 7) * .20);

            }
            WriteLine($"The fine for {books} books, for {days} days overdue is {fine.ToString("C")}");
        }
    }
}
