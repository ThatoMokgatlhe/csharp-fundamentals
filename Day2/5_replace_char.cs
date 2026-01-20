using System;

class Program {
    static void ReplaceCharacter() {
        string originalWord = Console.ReadLine();
        char oldCharacter = Console.ReadLine()[0];
        char newCharacter = Console.ReadLine()[0];

        string updatedWord = originalWord.Replace(oldCharacter, newCharacter);
        Console.WriteLine(updatedWord);
    }

    static void Main() {
        ReplaceCharacter();
    }
}
