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

    base_Array[0] = new D1_arrays<int>(flag, int_value);     
    base_Array[1] = new D1_arrays<string>(flag, string_value);
    base_Array[2] = new D1_arrays<double>(flag, double_value);
    base_Array[3] = new D1_arrays<bool>(flag, bool_value);
  
    for (int i = 0; i < base_Array.Length; i++) {
      base_Array[i].Print();
    }
    
    base_Array[0].Change(flag);
    base_Array[0].Print();

    IPrinter[] printer = new IPrinter[5];

    printer[0] = base_Array[0];     
    printer[1] = base_Array[1];
    printer[2] = base_Array[2];
    printer[3] = base_Array[3];

    for (int i = 0; i < printer.Length; i++) {
      printer[i].Print();
    }

  }
}