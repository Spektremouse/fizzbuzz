using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        private int mLength;
        private int mFizzMultiple = 3;
        private int mBuzzMultiple = 5;        
        private const string mFizz = "Fizz";
        private const string mBuzz = "Buzz";       
        private const string mFizzBuzz = "FizzBuzz";
        private FizzBuzzer() { }

        /// <summary>
        /// Constructor for a FizzBuzz instance.
        /// </summary>
        /// <param name="length"></param>
        public FizzBuzzer(int length = 100)
        {
            mLength = length;
        }

        /// <summary>
        /// The number to which FizzBuzz will loop.
        /// </summary>
        public int Length
        {
            get { return mLength; }
            set { mLength = value; }
        }

        /// <summary>
        /// The multiple to be used for Fizz.
        /// </summary>
        public int FizzMultiple
        {
            get { return mFizzMultiple; }
            set { mFizzMultiple = value; }
        }

        /// <summary>
        /// The multiple to be used for Buzz.
        /// </summary>
        public int BuzzMultiple
        {
            get { return mBuzzMultiple; }
            set { mBuzzMultiple = value; }
        }

        /// <summary>
        /// Checks that an integer is a FizzMultiple.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True when the integer is a FizzMultiple</returns>
        public bool IsFizz(int number)
        {
            if (number % mFizzMultiple == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks that an integer is a BuzzMultiple.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True when the integer is a BuzzMultiple</returns>
        public bool IsBuzz(int number)
        {
            if (number % mBuzzMultiple == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks that an integer is a FizzMultiple and a BuzzMultiple.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True when the integer is a FizzMultiple and a BuzzMultiple</returns>
        public bool IsFizzBuzz(int number)
        {
            if (IsFizz(number) && IsBuzz(number))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Resets the Length, Fizz and Buzz multiples to default values.
        /// </summary>
        public void Reset()
        {
            FizzMultiple = 3;
            BuzzMultiple = 5;
            Length = 100;
        }

        static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            //Can be further customized for more FizzBuzz Results!
            //fb.Length = 200;
            //fb.FizzMultiple = 4;
            //fb.BuzzMultiple = 10;

            for (int i = 1; i <= fb.Length; i++)
            {
                if (fb.IsFizzBuzz(i))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fb.IsBuzz(i))
                {
                    Console.WriteLine("Buzz");
                }
                else if (fb.IsFizz(i))
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
