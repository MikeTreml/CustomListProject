﻿
# CustomListProject

operator- overloaded method

Removes any object from the first CustomList<T> that is contained in the second CustomList<T>.

Parameters:
The subractor CustomList<T>(list2) removes an ojbect from the subtracted CustomList<T>(list1) that is equal to contained object in the subtractor CustomList<T>(list2).

Returns:
CustomList<T>


Implements:
CustomList<T>-CustomList<T>

Example:
    
    
    CustomList<int> one = new CustomList<int>();
    CustomList<int> two = new CustomList<int>();
    CustomList<int> result = new CustomList<int>();
    one.Add(1);
    one.Add(3);
    one.Add(5);
    
    two.Add(2);
    two.Add(1);
    two.Add(6);
    
    
    result = one - two;
    Console.WriteLine(result[0]+" , "+ result[1]);
    // 3 , 5



