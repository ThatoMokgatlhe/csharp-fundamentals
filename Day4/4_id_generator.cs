using System;
Console.Write(Id.Gen());
static class Id {
    static int n = 1000;
    public static int Gen() => n++;
}
