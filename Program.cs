﻿using System;
class HelloWorld {
  static void Main() {
    
    IArray[] base_Array  = new IArray[4];
    
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");


    bool flag = bool.Parse(Console.ReadLine());
    
    elemenent_gen<int> int_value = new int_input();
    elemenent_gen<bool> bool_value = new bool_input();
    elemenent_gen<double> double_value = new double_input();
    elemenent_gen<string> string_value = new string_input();

    D1_arrays<int> intArray = new D1_arrays<int>(flag, int_value);
    intArray.ForEachAction( (x) => Console.WriteLine(x) );
    
    

  }
}