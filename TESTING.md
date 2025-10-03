# Testing Philosophy and Summary

## Testing Philosophy
The test suite was designed to be **clear, comprehensive, and maintainable**, following the Arrange-Act-Assert (AAA) pattern. Each function—`CountVowels`, `IsLeapYear`, and `IsPalindromeNumber`—has its own set of tests covering normal inputs, edge cases, and error scenarios. Parameterized tests were used where appropriate to reduce duplication and efficiently test multiple input variations.  

Test cases were chosen based on the **logical behavior and potential pitfalls** of each function. For `CountVowels`, we tested strings with uppercase, lowercase, mixed case, empty strings, and special characters. For `IsLeapYear`, we included years divisible by 4, 100, and 400, as well as invalid years to trigger exceptions. For `IsPalindromeNumber`, we tested positive palindromes, negative numbers, single digits, numbers ending in zero, and large numbers.  

Tests were organized by function to make it easy to find and maintain them. Parameterized tests group similar scenarios together, while individual tests handle exceptions and special cases, ensuring readability and clear coverage of all logical branches.

---

## Coverage Analysis
The unit tests are designed to **catch potential bad data and incorrect inputs**. They validate function behavior for empty strings, invalid years, negative numbers, and other edge cases. Exceptions are explicitly tested, and the palindrome function logic has been thoroughly verified for tricky inputs like numbers ending with zero or negative numbers.  

Some scenarios are outside the scope of the assignment, such as Unicode characters for vowels or numbers exceeding `int.MaxValue`. These were not tested, but the current suite effectively covers all expected and most edge-case inputs, providing high confidence in the correctness of the functions.  

---

## Test Summary
- **Total tests written:** 32+  
- **Breakdown by function:**  
  - `CountVowels`: 8 tests  
  - `IsLeapYear`: 10 tests (including exception cases)  
  - `IsPalindromeNumber`: 14 tests  
- **Challenges encountered:**  
  - Handling `null` in parameterized tests for `CountVowels`  
  - Ensuring `IsPalindromeNumber` correctly handled negative numbers and trailing zeros without string conversion  
  - Achieving ≥90% code coverage for all logical branches
