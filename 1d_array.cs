using System;
sealed class D1_arrays<T> : Base_array{
    private T[] a;
    private elemenent_gen<T> _element_gen;
    public D1_arrays(bool flag, elemenent_gen<T> Element_gen) {
        _element_gen = Element_gen;
        Create_array(flag);
    }

    public override void Create_array(bool flag) {
        Console.WriteLine("Введите размер массива : ");
        int n = int.Parse(Console.ReadLine());
        a = new T[n];
        for (int i = 0; i < n; i++) {
            if (flag) {
                a[i] = _element_gen.Generate_Random();
            } else {
                a[i] = _element_gen.Generate_Key();
            }
        }
    }    

    public override void Change(bool flag) {
        Console.WriteLine("Массив изменен");
        Create_array(flag);
    }
    
    public override void Print() {
        Console.WriteLine("Одномерный массив");
        Console.WriteLine("Выводится размер и содержимое массива : ");
        Console.WriteLine(a.Length);
        for (int i = 0; i < a.Length; i++) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
    }
}