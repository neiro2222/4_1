using System;
sealed class int_input : elemenent_gen<int>
{
    private Random random = new Random();

    public int Generate_Random() {
        return random.Next(0, 100);
    }

    public int Generate_Key() {
        return int.Parse(Console.ReadLine());
    }
}