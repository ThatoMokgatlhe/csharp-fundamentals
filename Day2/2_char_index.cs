using System;

class Program {
    static void GetCharacterAtIndex() {
        string word = Console.ReadLine();
        int position = int.Parse(Console.ReadLine());
        char chosenCharacter = word[position];
        Console.WriteLine(chosenCharacter);
    }

    static void Main() {
        GetCharacterAtIndex();
    }
}
