using UnorderedArray;

UnorderedArrayExample unorderedArray = new UnorderedArrayExample(5);
unorderedArray.Insert(5);
unorderedArray.Insert(10);
unorderedArray.Insert(15);
unorderedArray.Print();
Console.WriteLine("Removing 10..");
unorderedArray.Remove(10);
unorderedArray.Print(); 

int index = unorderedArray.IndexOf(15);
Console.WriteLine("Index of 15: " + index); 