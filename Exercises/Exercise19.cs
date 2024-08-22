using System;
namespace Exercises
{
    /* 
     
        Computed properties - DailyAccountState class

        The goal of this exercise is to finish the implementation of the "DailyAccountState" class.
        This class represents a daily data of a bank account. It has two properties:

         - "InitialState", representing the sum of money in the account at the beginning of the day

         - "SumOfOperations", representing the total of incomes and outcomes from the account.

        So, for example, we can have an account that had "2000$" (or other currency) at
        the beginning of the day, and the sum of operations for this account and day is
        "-200$". This means, at the end of the day, there is "1800$" in the account.


        Add two public computed properties to this class:

         - "EndOfDayState", returning the sum of "InitialState" and "SumOfOperations"

         - "Report", returning a string in the following format:
             "Day: 15, month: 3, year: 2025, initial state: 2000, end of day state: 1800".
              Day, month, and year shall be taken from the current date.
              The initial state and end of day state shall match what is stored in the object.
     
     */
    public class DailyAccountState
    {
        private int _initialState;
        private int _sumOfOperations;


        public int InitialState
        {

            get
            {
                return _initialState;
            }

            set
            {
                _initialState = value;
            }
        }

        public int SumOfOperations
        {
            get
            {
                return _sumOfOperations;
            }
            set
            {
                _sumOfOperations = value;
            }
        }

        public int EndOfDayState
        {
            get
            {
                return _sumOfOperations + _initialState;
            }
        }

        public string Report
        {
            get
            {
                DateTime currentDateTime = DateTime.Now;
                return $"Day: {currentDateTime.Day}, month: {currentDateTime.Month}, year: {currentDateTime.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
            }
        }

        public DailyAccountState(int initialState, int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }

        //your code goes here
    }
}

