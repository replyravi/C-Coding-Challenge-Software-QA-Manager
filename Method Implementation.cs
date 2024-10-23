public static string OldPhonePad(string input)
{
    if (string.IsNullOrEmpty(input))
        return "";

    string result = "";
    char lastKey = '\0';
    int pressCount = 0;

    // Iterate over each character in the input string
    for (int i = 0; i < input.Length; i++)
    {
        char currentKey = input[i];

        if (currentKey == '#')
        {
            // End of input
            break;
        }
        else if (currentKey == '*')
        {
            // Backspace: remove the last character from the result if present
            if (result.Length > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }
            lastKey = '\0';
            pressCount = 0;
        }
        else if (currentKey == ' ')
        {
            // Reset when there is a space (pause) between inputs
            lastKey = '\0';
            pressCount = 0;
        }
        else if (KeyMap.ContainsKey(currentKey))
        {
            if (currentKey == lastKey)
            {
                // Increment press count if the same key is pressed consecutively
                pressCount++;
            }
            else
            {
                // Reset for a new key
                lastKey = currentKey;
                pressCount = 1;
            }

            // Get the corresponding letters for the current key
            string letters = KeyMap[currentKey];
            int index = (pressCount - 1) % letters.Length;

            // Update the result string with the correct letter
            if (result.Length > 0 && result[^1] == letters[index])
            {
                // Replace the last character if it's the same key
                result = result.Substring(0, result.Length - 1) + letters[index];
            }
            else
            {
                result += letters[index];
            }
        }
    }

    return result;
}
