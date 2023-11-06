
(https://github.com/DylanCahuMDS/RealHelloWorld/tree/PHP/helloWorld.gif)

# Random Letter Hello World

This PHP program generates a variation of the "Hello World" phrase by replacing the letters with randomly chosen letters from the alphabet.

## Requirements

PHP 8.2 or higher version

## Installation

1. Clone the git repository or download the source code
2. Open the project and run by using the cmd command : "php ./index.php"

## How it works

The program uses the `Random` class to choose random letters from the alphabet. It contains the following steps:

1. Initialization of two character arrays, "HelloWorld" and "Alphabet", containing the strings "hello world" and the lowercase alphabet, respectively.
2. Initialization of a third character array, "Display", of the same size as "HelloWorld".
3. A "for" loop iterates through each element of "HelloWorld". If the element is the fifth element, a white space is inserted into "Display". For all other elements, a letter from the alphabet is chosen at random with `Random()`. If the chosen letter matches the letter in "HelloWorld", it is stored in "Display". If it doesn't match, the program continues to choose random letters until it finds a match.
4. For the first elements of "HelloWorld" (0 and 6), the corresponding letter in "Display" is capitalized to form the first letters of each word. For all other elements of "HelloWorld", the corresponding letter in "Display" is stored in lowercase.
5. The final message is displayed on the screen, then the program waits for the user to press a key to end.
