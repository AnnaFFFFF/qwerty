class Program {

    static void main(String[] args)
    {
        Calculate(5);

    }
    static void Calculate(int t) {
        int x = 6;
        int y = 7;
        int c = 11;

        int d = (c - (--y)) * x;
        Console.WriteLine($"x={x} y={y} c={c} d={d}");

    }
}
