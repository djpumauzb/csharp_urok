// === Rabota s tekstom
// Dan tekst. V tekste nujno vse problemi zamenit cehrtochkami,
// malenkie bukvi "k" zamenit na bolshimi "K"
// a bolshie "C" zamenit na maleknkim "c"

// Yasno li zadacha ?)

string text = "- Ya dumayu. - skazal knyaz', ulibayac', - chto,"
            + "ejeli bi vas poslali vmesto nashego milogo Vincengrerode,"
            + "vi bi vzyali pritupom soglasie prusskogo korolya."
            + "Vi tak krasnorechivi. Bi dadite mne chayu?";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'S', 's');
Console.WriteLine(newText);
Console.WriteLine();