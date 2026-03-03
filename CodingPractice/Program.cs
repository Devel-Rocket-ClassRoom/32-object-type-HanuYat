using System;

// README.md를 읽고 코드를 작성하세요.

object obj1 = 42;
object obj2 = 3.14;
object obj3 = "Hello";
object obj4 = true;

Console.WriteLine(obj1);
Console.WriteLine(obj2);
Console.WriteLine(obj3);
Console.WriteLine(obj4);
Console.WriteLine();

Stack stack = new Stack();

stack.Push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);

stack.Push(3);
int num = (int)stack.Pop();
Console.WriteLine(num);
Console.WriteLine();

int i = 1234;
object o = i;
Console.WriteLine(o);
Console.WriteLine();

object ob = 1234;
int j = (int)ob;
Console.WriteLine(j);
Console.WriteLine();

int k = 42;
object ob2 = k;
Console.WriteLine(ob2);
Console.WriteLine();

Point point = new Point { X = 10, Y = 20 };
IDisplayable d = point;
Console.WriteLine(d.GetType().Name);
Console.WriteLine();

int three = 3;
object ob3 = three;
three = 5;
Console.WriteLine($"원본: {three}");
Console.WriteLine($"박싱된 값: {ob3}");
Console.WriteLine();

int ft = 42;
object ob42 = ft;
int ftw = (int)ob42;
Console.WriteLine($"언박싱 성공: {ftw}");

try
{
    long l = (long)ob42;
}

catch (InvalidCastException)
{
    Console.WriteLine($"잘못된 타입으로 언박싱 시도");
}

long lo = (long)ftw;
Console.WriteLine($"올바른 변환: {lo}");
Console.WriteLine();

int sum = 0;
for (int n = 0; n < 1000; n++)
{
    object obn = n;
    sum += (int)obn;
}
Console.WriteLine($"박싱 사용: {sum}");

int sum2 = 0;
for (int n = 0; n < 1000; n++)
{
    sum2 += n;
}
Console.WriteLine($"직접 처리: {sum2}");
Console.WriteLine();

GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(42);
int value = intStack.Pop();
Console.WriteLine(value);
Console.WriteLine();

int t = 0;
string s2 = "";
char c2 = 'A';
double d2 = 3.14;
object o2 = new object();

Console.WriteLine(t.GetType());
Console.WriteLine(s2.GetType());
Console.WriteLine(c2.GetType());
Console.WriteLine(d2.GetType());
Console.WriteLine(o2.GetType());
Console.WriteLine();

Console.WriteLine(typeof(int));
Console.WriteLine(typeof(string));
Console.WriteLine(typeof(double));
Console.WriteLine();

Point p = new Point();

Console.WriteLine(p.GetType().Name);
Console.WriteLine(typeof(Point2).Name);
Console.WriteLine(p.GetType() == typeof(Point));
Console.WriteLine(p.X.GetType().Name);
Console.WriteLine(p.Y.GetType().FullName);
Console.WriteLine();

int fourTwo = 42;
double pi = 3.14;
bool isTrue = true;

Console.WriteLine(fourTwo.ToString());
Console.WriteLine(pi.ToString());
Console.WriteLine(isTrue.ToString());
Console.WriteLine();

Panda panda = new Panda { Name = "Petey" };
Console.WriteLine(panda.ToString());
Console.WriteLine(panda);
Console.WriteLine();

Player player  = new Player { Name = "Hero", Level = 10, Health = 100};
Console.WriteLine(player);
Console.WriteLine();

string S1 = "Hello";
string S2 = "Hello";
string S3 = S1;
Console.WriteLine($"S1.Equals(S2): {S1.Equals(S2)}");
Console.WriteLine($"ReferenceEquals(S1, S2): {ReferenceEquals(S1, S2)}");
Console.WriteLine($"ReferenceEquals(S1, S3): {ReferenceEquals(S1, S3)}");

Object objOne = new Object();
Object objTwo = new Object();
Object objThree = objOne;
Console.WriteLine($"objOne.Equals(objTwo): {objOne.Equals(objTwo)}");
Console.WriteLine($"ReferenceEquals(objOne, objTwo): {ReferenceEquals(objOne, objTwo)}");
Console.WriteLine($"ReferenceEquals(objOne, objThree): {ReferenceEquals(objOne, objThree)}");