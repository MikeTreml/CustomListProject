
# CustomListProject

operator- overloaded method

Removes any object from the first CustomList<T> that is contained in the second CustomList<T>.
C#

Copy
public bool Remove (T item);

Parameters
The subractor CustomList<T> removes an ojbect from the subtracted that is equal to the subtractor object.

Returns:
CustomList<T>


Implements:
CustomList<T>-CustomList<T>

Example:
    
    
    customList1.Add(item1);
    customList2.Add(item2);
    customList1.Add(item3);
    customList2.Add(item1);
    customList1.Add(item5);
    customList2.Add(item6);
    correctAnswer.Add(item3);
    correctAnswer.Add(item5);
    result = customList1 - customList2;
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



