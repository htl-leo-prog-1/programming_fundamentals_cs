{
    int shift;
    if (args.Length != 2 || !int.TryParse(args[1], out shift))
    {
        Console.WriteLine("Usage: CaesarCipher [ encrypt | decrypt ] <shift>");
        return;
    }

    do
    {
        var line = Console.ReadLine();
        if (line == null) { break; }

        switch (args[0])
        {
            case "encrypt":
                Console.WriteLine(Encrypt(line, shift));
                break;
            case "decrypt":
                Console.WriteLine(Decrypt(line, shift));
                break;
            default:
                Console.WriteLine("Usage: CaesarCipher [ encrypt | decrypt ] <shift>");
                return;
        }
    }
    while (true);
}

/// <summary>
/// Encrypt a given string with a Caesar cipher.
/// </summary>
/// <param name="text">The string to encrypt.</param>
/// <param name="shift">The number of characters to shift.</param>
/// <returns>The encrypted string.</returns>
/// <remarks>
/// We only encrypt letters, all other characters are left as is.
/// </remarks>
string Encrypt(string text, int shift)
{
    string result = string.Empty;
    foreach (char c in text)
    {
        if (char.IsLetter(c))
        {
            char d = char.IsUpper(c) ? 'A' : 'a';
            int shifted = c + shift;
            result += char.ConvertFromUtf32(((shifted - d) % 26) + d);
        }
        else
        {
            result += c;
        }
    }
    return result;
}

/// <summary>
/// Decrypt a given ciphertext using a Caesar cipher.
/// </summary>
/// <param name="ciphertext">The ciphertext to decrypt.</param>
/// <param name="shift">The number of characters to shift.</param>
/// <returns>The decrypted string.</returns>
/// <remarks>
/// We only decrypt letters, all other characters are left as is.
/// </remarks>
string Decrypt(string ciphertext, int shift)
{
    return Encrypt(ciphertext, 26 - shift);
}
