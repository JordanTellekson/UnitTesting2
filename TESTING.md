# Testing Philosophy and Summary

## Testing Philosophy
The test suite was designed for **clarity and completeness** using the Arrange-Act-Assert (AAA) pattern. Each function’s tests cover normal, edge, and error cases. Parameterized tests were used to reduce repetition and group similar inputs, while separate tests handle exceptions or special scenarios.

Test cases were chosen to cover logical branches: `CountVowels` handles case and special characters, `IsLeapYear` covers divisibility and invalid years, and `IsPalindromeNumber` handles negatives, single digits, trailing zeros, and large numbers. Tests are organized by function for readability and maintainability.

---

## Coverage Analysis
Unit tests catch potential bad data by explicitly testing invalid, empty, or extreme inputs. Exceptions are tested for invalid years, and palindrome logic is verified for all digit patterns. Some edge scenarios, like Unicode vowels or numbers beyond `int.MaxValue`, were not included due to assignment scope. Overall, the suite provides strong confidence in correct behavior.

---

## Test Summary
- **Total tests:** 32
- **Breakdown:**  
  - `CountVowels`: 8 tests  
  - `IsLeapYear`: 10 tests  
  - `IsPalindromeNumber`: 14 tests  
- **Challenges:** Handling `null` in parameterized tests, testing negative numbers/trailing zeros for palindromes, achieving ≥90% code coverage.
