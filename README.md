# camelCase Converter Unit Testing in C#
## Project Overview
This project demonstrates unit testing for a function that converts a string of space-separated words into camel case, where the first word is lowercase and each subsequent word starts with an uppercase letter, with unit tests to validate different scenarios.
## Purpose
- Converts space-separated words into camel case. <br />
- Handles empty strings and single-word inputs. <br />
- Ensures all words are correctly formatted. <br />

## Tech Stack
*Language:* C#<br />
*Testing Framework:*  NUnit<br />
*IDE:* Visual Studio<br />

## Unit Tests<br />
```Empty String Returns Empty String```: Ensures that the function returns an empty string when the input is empty.<br />
```Single Word Returns Lowercase Word```: Verifies that a single word is converted to lowercase.<br />
```Multiple Words Returns Camel Case```: Checks that multiple words are converted correctly into camel case format.<br />
```Multiple Words With Mixed Case Returns Camel Case```: Ensures that mixed case words are correctly converted to camel case.
