
GenericStack<int> intStacks = new GenericStack<int>();
// int i1 = intStacks.Pop();
// Console.WriteLine(i1);
intStacks.Push(10);
intStacks.Push(13);
intStacks.Push(14);
intStacks.Push(13);
intStacks.Push(16);
intStacks.Display();
int _ = intStacks.Pop();
intStacks.Display();
int __ = intStacks.Pop();
intStacks.Display();

GenericStack<string> stringStacks = new GenericStack<string>();
stringStacks.Push("Banana");
stringStacks.Push("Pineaple");
stringStacks.Push("Pear");
stringStacks.Push("Apple");
stringStacks.Push("Mango");
stringStacks.Display();

string s1 = stringStacks.Pop();
Console.WriteLine(s1);

stringStacks.Display();

GenericStack<Person> personStacks = new GenericStack<Person>();
personStacks.Push(new Person("John", "Doe", 34, 53000));
personStacks.Push(new Person("Samuel", "Jack", 54, 78000));
personStacks.Push(new Person("Ritchie", "Lionnel", 67, 87000));
personStacks.Push(new Person("Priya", "Satih", 23, 65000));
personStacks.Push(new Person("Gates", "Billie", 32, 34000));
personStacks.Push(new Person("Roulou", "Kaily", 19, 46000));
personStacks.Push(new Person("Vodonon", "Damien", 45, 110000));
personStacks.Display();

var p1 = personStacks.Pop();
Console.WriteLine(p1);

personStacks.Display();

Person p2 = personStacks.Pop();
Console.WriteLine(p2);

personStacks.Display();