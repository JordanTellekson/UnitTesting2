using System;

namespace UnitTesting.Services
{
    public class UtilityService
    {
        /// <summary>
        /// Count the number of English vowels (a, e, i, o, u) in the input.
        /// Case-insensitive. Non-letter characters are ignored.
        /// Returns 0 for null or empty input.
        /// </summary>
        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int count = 0;
            foreach (char ch in input)
            {
                if (!char.IsLetter(ch))
                    continue;

                char lower = char.ToLowerInvariant(ch);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Determine whether the given year is a leap year according to Gregorian rules.
        /// Throws ArgumentException if year < 1.
        /// </summary>
        public bool IsLeapYear(int year)
        {
            if (year < 1)
                throw new ArgumentException("Year must be 1 or greater.", nameof(year));

            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return (year % 4 == 0);
        }

        /// <summary>
        /// Determine whether an integer is a palindrome (reads the same forward and back).
        /// Negative numbers are NOT palindromes. Single-digit numbers are palindromes.
        /// Uses arithmetic operations only (no string conversion).
        /// </summary>
        public bool IsPalindromeNumber(int number)
        {
            if (number < 0) return false;
            if (number >= 0 && number <= 9) return true; // single-digit

            // numbers ending in 0 are not palindromes unless the number is 0
            if (number % 10 == 0) return number == 0;

            int original = number;
            long reversed = 0; // use long to avoid overflow when reversing digits

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return reversed == original;
        }
    }
}