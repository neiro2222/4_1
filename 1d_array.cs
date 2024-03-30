using System;
using System.Collections;
using System.Linq;
sealed class D1_arrays<T> : Base_array, IComparer{
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

    public void PUSH(T x) {
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

    public void POP(T x) {
        int ind = 0;
        T[] tmp = new T[n];
        int j = 0;
        for (int i = 0; i < n; i++) {
            if (!x.Equals(a[i])) {
                tmp[j] = a[i];
                j++;
            }
        }
        n = j;
        capacity = 2 * n + 1;
        Array.Resize(ref a, capacity);
        for (int i = 0; i < n; i++) {
            a[i] = tmp[i];
        }
    }

    
    public T[] Take(int ind) {
        T[] new_array = new T[n];
        for (int i = ind; i < n; i++) {
            new_array[i-ind] = a[i];
        }
        return new_array;
    }
    public T min() {
        return a.Min(); 
    }

    public T max() {
        return a.Max();
    }

    public void SORT() {
        Array.Sort(a);
    }
    
    public int CountAmount(Func<T, bool> cond) {
        T[] newArray = Where(cond);
        return newArray.Length;
    }

    public int Amount() {
        return n;
    }

    public bool Check_one(Func<T, bool> cond) {
        T[] newArray = Where(cond);
        if (newArray.Length > 0) {
            return true;
        } else {
            return false;
        }
    }

    public bool Check_all(Func<T, bool> cond) {
        T[] newArray = Where(cond);
        if (newArray.Length == n) {
            return true;
        } else {
            return false;
        }
    }

    public bool In(T x) {
        for (int i = 0; i < n; i++) {
            if (x.Equals(a[i])) {
                return true;
            }
        }
        return false;
    }

    public T first(Func<T, bool> condition) {
        for (int i = 0; i < n; i++) {
            if (condition(a[i])) {
                return a[i];
            }
        }
        return a[n-1];
    }

    public void ActionForAll(Func<T, T> condition) {
        for (int i = 0; i < n; i++) {
            a[i] = condition(a[i]);
        }

        Print();

    }

    public void Reverse() {
        for (int i = 0; i < n; i++) {
            T tmp = a[i];
            a[i] = a[n-i-1];
            a[n-i-1] = tmp;
        }
    }

    public T[] Where(Func<T, bool> condition)
    {
        T[] newArray = new T[a.Length];
        int count = 0;
        for (int i = 0; i < newArray.Length; i++)
        {
            if (condition(a[i]))
            {
                newArray[count] = a[i];
                count++;
            }
        }
        Array.Resize(ref newArray, count);
        return newArray;
    }

    int IComparer.Compare( Object x, Object y )  {
          return( (new CaseInsensitiveComparer()).Compare( y, x ) );
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

    public void ForEachAction(Action<T> action)
    {
        for (int i = 0; i < a.Length; i++)
        {
            action(a[i]);
        }
    }
    //delegate bool IsEqual(int x);
}