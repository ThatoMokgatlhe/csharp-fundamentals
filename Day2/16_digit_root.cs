using System;

class Program {
    static void FindDigitRoot() {
        int number = int.Parse(Console.ReadLine());

        while (number >= 10) {
            int digitSum = 0;
            int temp = number;

            while (temp > 0) {
                digitSum += temp % 10;
                temp /= 10;
            }

            number = digitSum;
        }

        Console.WriteLine(number);
    }

    static void Main() {
        FindDigitRoot();
    }
}
