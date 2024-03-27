using System;
sealed class bool_input : elemenent_gen<bool>
{
    private Random random = new Random();

    public bool Generate_Random() {
        int a = random.Next(0, 1);
        if (a == 0) {
            return true;
        } else {
            return false;
        }
    }

    public bool Generate_Key() {
        return bool.Parse(Console.ReadLine());
    }
}