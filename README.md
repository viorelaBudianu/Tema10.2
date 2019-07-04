Ex 1: Strings problem:

Given a string S, return the "reversed" string where all characters that are not a letter stay in the same place, and all letters reverse their positions.

Example 1:
Input: "ab-cd"

Output: "dc-ba"

Example 2:
Input: "a-bC-dEf-ghIj"

Output: "j-Ih-gfE-dCba"

Example 3:
Input: “”

Output: Thrown an exception 

Example 4:
Input: "Test1ng-Leet=code-Q!"

Output: "Qedo1ct-eeLg=ntse-T!"

----------------------------------------------------------------------------

Ex 2: Calculator

Add, Mul, Sub, Div

Add - 4 tests

Mul - 4 tests

Sub - 4 test

Div - 4 test - check exception when divide / 0

Bonus: Generic calculator.

----------------------------------------------------------------------------

Ex 3: Goat Latin

A sentence S is given, composed of words separated by spaces. Each word consists of lowercase and uppercase letters only.



We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.)

The rules of Goat Latin are as follows:



If a word begins with a vowel (a, e, i, o, or u), append "ma" to the end of the word.

For example, the word 'apple' becomes 'applema'.



If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add "ma".

For example, the word "goat" becomes "oatgma".



Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.

For example, the first word gets "a" added to the end, the second word gets "aa" added to the end and so on.

Return the final sentence representing the conversion from S to Goat Latin. 



Example 1:
Input: "I speak Goat Latin"

Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"

Example 2:
Input: "The quick brown fox jumped over the lazy dog"

Output: "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa"

Add unit tests.
