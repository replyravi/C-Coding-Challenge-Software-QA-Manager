# OldPhonePad Simulation
# Overview: 
This project simulates the behavior of an old phone keypad, which uses numeric keys (2-9) to generate alphabetic characters. Each numeric key is associated with multiple letters, and pressing a key multiple times cycles through these letters. The program also supports special keys:for backspace, removing the last character.
To indicate the end of the input sequence.
A space ( ) represents a pause, allowing two characters from the same key in succession.
The method OldPhonePad is designed to convert the input sequence into its corresponding output based on these rules.

# Features: 
Converts numeric key sequences into text based on an old phone keypad layout.
Handles special characters like * (backspace) and # (end of input).
Supports spaces to pause and allow different letters from the same key.
Edge case handling, including no input and continuous backspace.

# Code Structure
* Method
csharp
Code C
public static string OldPhonePad(string input)
Parameters: input (string) – the sequence of key presses on the old phone keypad.
Returns: A string representing the translated characters based on the sequence.

* Example Keypad Layout
makefile
Code C
2: A, B, C
3: D, E, F
4: G, H, I
5: J, K, L
6: M, N, O
7: P, Q, R, S
8: T, U, V
9: W, X, Y, Z
# Installation and Usage

* Prerequisites
.NET SDK installed on your machine. You can download it from https://dotnet.microsoft.com/download.
* How to Run
Clone the repository:
bash
Copy code
git clone https://github.com/replyravi/C-Coding-Challenge-Software-QA-Manager/blob/main/OldPhone.cs
Navigate to the project directory:
bash
Copy code
cd OldPhonePadSimulation
Compile and run the code:
bash
Copy code
dotnet run

* Example Usage
The following examples demonstrate how to use the OldPhonePad method:

csharp
Copy code
Console.WriteLine(OldPhonePad("33#"));           // Output: E
Console.WriteLine(OldPhonePad("227*#"));         // Output: B
Console.WriteLine(OldPhonePad("4433555 555666#")); // Output: HELLO
Console.WriteLine(OldPhonePad("8 88777444666*664#")); // Output: TOOL

# Test Cases
GitHub: https://github.com/replyravi/C-Coding-Challenge-Software-QA-Manager/blob/main/Test%20case%20OldPhonePad%20method%20implementation.docx
The solution includes a set of test cases to verify the method's behavior:

Test Case ID	Input	Expected Output	Description
TC001	33#	E	Single key pressed twice.
TC002	4433555 555666#	HELLO	Mixed digits and pauses.
TC003	227*#	B	Test backspace functionality.
TC004	8 88777444666*664#	TOOL	Complex input with pauses and backspace.
TC005	#	"" (empty string)	Edge case: no input before the #.
TC006	666 6#	MN	Multiple letters from the same key with pause.
TC007	777*77*#	P	Continuous backspaces removing characters properly.
# Development Notes
* Edge Cases
No input: If the method receives an empty input or a sequence with just #, it returns an empty string.
Backspace without characters: If a backspace (*) is pressed when there are no characters, it does nothing.
Consecutive key presses: If the same key is pressed without a space, the method cycles through the associated letters.
* Assumptions
The input always ends with a # character, as per the problem specification.
The keys 0 and 1 are not used in this implementation, as they have no corresponding letters.

Email: ravishankersinghreply@gmail.com
GitHub: https://github.com/replyravi/C-Coding-Challenge-Software-QA-Manager
