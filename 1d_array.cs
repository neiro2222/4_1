using System;
sealed class D1_arrays<T> : Base_array{
    private T[] a;
    private int n, capacity;
    private elemenent_gen<T> _element_gen;
    public D1_arrays(bool flag, elemenent_gen<T> Element_gen) {
        _element_gen = Element_gen;
        Create_array(flag);
    }

    public override void Create_array(bool flag) {
        Console.WriteLine("Введите размер массива : ");
        n = int.Parse(Console.ReadLine());
        capacity = 2 * n + 1;
        a = new T[capacity];
        for (int i = 0; i < n; i++) {
            if (flag) {
                a[i] = _element_gen.Generate_Random();
            } else {
                a[i] = _element_gen.Generate_Key();
            }
        }
    }    

    public override void PUSH(T x) {
        if (n < capacity) {
            a[n] = x;
        } else {
            capacity = n * 2 + 1;
            T[] tmp = new T[n];
            tmp = a;
            Array.Resize(ref a, n * 2 + 1);
            for (int i = 0; i < n; i++) {
                a[i] = tmp[i];
            }
            a[n] = x;
        }
        n++;
    }

    public override void POP(T x) {
        int ind = 0;
        for (int i = 0; i < n; i++) {
            if (a[i] == x) {

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


    static int Compare<T, TResult>(T item1, T item2, Func<T, TResult> projection)
    {
        Comparer<TResult> comparer = Comparer<TResult>.Default;
        return comparer.Compare(projection(item1), projection(item2));
    }
    delegate bool IsEqual(int x);
}