﻿using System;
using System.Reflection.Emit;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");


    bool flag = bool.Parse(Console.ReadLine());

    elemenent_gen<int> int_value = new int_input();
    elemenent_gen<bool> bool_value = new bool_input();
    elemenent_gen<double> double_value = new double_input();
    elemenent_gen<string> string_value = new string_input();

    D1_arrays<int> intArray = new D1_arrays<int>(flag, int_value);

    for (int i = 0; i < 8; i++) {
      intArray.PUSH(i);
    }

    for (int i = 8; i < 8; i++) {
      intArray.POP_VALUE(i);
    }

    intArray.SORT();

    Console.WriteLine(intArray.CountAmount((x) => Math.Abs(x) < 100));

    Console.WriteLine(intArray.Check_one((x) => Math.Sqrt(x) > 100));

    Console.WriteLine(intArray.Check_all((x) => x * x == 100));

    Console.WriteLine(intArray.In(10));

    Console.WriteLine(intArray.First((x) => x == 0));

    intArray.Reverse();

    Console.WriteLine(intArray.Min_Max());

    intArray.ForEachAction( x => x * 2);
  }
}