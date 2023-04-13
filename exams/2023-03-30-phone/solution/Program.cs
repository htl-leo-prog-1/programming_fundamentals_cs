if (args.Length == 0)
{
    Console.WriteLine("Missing phone number, please try again");
    return;
}

for(int i = 0; i < args.Length; i++)
{
    string phone = args[i];

    // Remove all slashes and dashes
    phone = phone.Replace("/", "").Replace("-", "");

    if (!IsValidPhoneNumber(phone))
    {
        Console.WriteLine($"Invalid phone number: {phone}");
        continue;
    }
    
    if (IsEmergencyNumber(phone))
    {
        Console.WriteLine($"Emergency number: {phone}");
        continue;
    }

    SplitPhoneNumber(phone, out string areaCode, out string number);
    Console.WriteLine($"Area code: {areaCode}, Number: {number}");
}

bool IsEmergencyNumber(string phone)
{
    return phone is "112" or "122" or "133" or "144";
}

bool TryRemovePrefix(ref string phone)
{
    if (phone.StartsWith("+43")) { phone = phone.Substring(3); }
    else if (phone.StartsWith("0043")) { phone = phone.Substring(4); }
    else if (phone.StartsWith("0")) { phone = phone.Substring(1); }
    else return false;
    return true;
}

bool IsValidPhoneNumber(string phone)
{
    if (!TryRemovePrefix(ref phone)) { return IsEmergencyNumber(phone); }
    
    // Make sure that the remaining phone number only contains digits
    for (int i = 0; i < phone.Length; i++)
    {
        if (!char.IsDigit(phone[i]))
        {
            return false;
        }
    }

    // Phone number and must be at least 6 digits long
    return phone.Length >= 6;
}

void SplitPhoneNumber(string phone, out string areaCode, out string number)
{
    TryRemovePrefix(ref phone);

    int areaCodeLength = 4;
    if (phone[0] == '1') { areaCodeLength = 1; }
    else 
    {
        string phoneStart = phone.Substring(0, 3);
        if (phoneStart is "316" or "512" or "463" or "732" or "662" or "660" or "699"
            or "664" or "676" or "650" or "680" or "681" or "665" or "688" or "677"
            or "670" or "690")
        {
            areaCodeLength = 3;
        }
    }

    areaCode = phone.Substring(0, areaCodeLength);
    number = phone.Substring(areaCodeLength);
}
