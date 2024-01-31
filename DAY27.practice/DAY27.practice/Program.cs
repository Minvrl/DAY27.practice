#region Generic collections

using System.Collections;
using System.Globalization;
using System.IO.Pipes;

List<byte> ages = new List<byte>();
ages.Add(18);
ages.Add(73);
ages.Add(8);

Console.WriteLine(ages.Capacity);

var otherAges = new List<byte>()
{
    18,
    32
};

ages.AddRange(otherAges);
Console.WriteLine(ages.Contains(18)); 

foreach (var age in ages)
    Console.WriteLine(age);

SortedList<string,double> mehsullar = new SortedList<string,double>();
mehsullar.Add("limon", 3.99);
mehsullar.Add("sut", 2.99);
mehsullar.Add("banan", 8.34);

double limonPrice;
mehsullar.TryGetValue("limon",out limonPrice);
Console.WriteLine(limonPrice);

Dictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "One");
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

string reqemStr = Console.ReadLine();
int reqem = Convert.ToInt32(reqemStr);  

string value;
if (numberNames.TryGetValue(reqem, out value))
{
    Console.WriteLine(value);
}
else
{
    Console.WriteLine("Bu reqem sistemde yoxdur");
}


Queue<string> queue = new Queue<string>();
queue.Enqueue("Ravil");
queue.Enqueue("Hesen");
queue.Enqueue("Aliye");
queue.Enqueue("Lamiye");

queue.Dequeue();
queue.EnsureCapacity(7);

foreach(string person in queue)
    Console.WriteLine(person);


Stack<string> stack = new Stack<string>();
stack.Push("book1");
stack.Push("book2");
stack.Push("book3");

string book4 = Console.ReadLine();

stack.Push(book4);

stack.Peek();




foreach (string book in stack)
    Console.WriteLine(book);


#endregion

#region Non-Generic

Hashtable table = new Hashtable();

table.Add("mulayim", 11);
table.Add(127, 110);
table.Add(74, "kitab");

Console.WriteLine(table["kitab"]);

Stack nonGenStack = new Stack();
nonGenStack.Push(37);
nonGenStack.Push("dshdsfrerf");
nonGenStack.Push('%');
nonGenStack.Push('/');

Console.WriteLine(nonGenStack.Count);

Queue nonGenqueue = new Queue();
nonGenqueue.Enqueue(17);
nonGenqueue.Enqueue("milk");
nonGenqueue.Enqueue('!');

nonGenqueue.Clear();

SortedList nonGenSortedList = new SortedList();

nonGenSortedList.Add("limon", 1.6);
nonGenSortedList.Add("sut", 700);
nonGenSortedList.Add("bulky", 3.7);
nonGenSortedList.Add("cay", "yoxdur");

Console.WriteLine(nonGenSortedList["cay"]);


ArrayList arlist = new ArrayList();
var aarlist = new ArrayList()
{
    "this","is","another",5,'%',"method","for","adding","."
};

arlist.Add(89);
arlist.Add("Hello people");
arlist.Add('#');


int[] arr = { 100, 200, 300, 400 };

Queue myQ = new Queue();
myQ.Enqueue("Hello");
myQ.Enqueue("World!");

arlist.AddRange(arlist);  
arlist.AddRange(arr); 
arlist.AddRange(myQ); 

#endregion
