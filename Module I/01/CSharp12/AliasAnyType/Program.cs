using Point = (int x, int y);
using StringList = System.Collections.Generic.List<string>;
using Values = int[];
using IsMember = bool;
using Person = (string firstName, string lastName);

void Draw(Point point)
{
    Console.WriteLine(point.x + " " + point.y);
}

void LoopOverStrings(StringList list)
{
    foreach (string str in list)
    {
        Console.WriteLine(str);
    }
}

void DisplayPerson(Person person, IsMember isMember)
{
    Console.WriteLine(person.firstName + " " + person.lastName + "; Member: " + isMember);
}

void LoopOverValues(Values values)
{
    foreach (int str in values)
    {
        Console.WriteLine(str);
    }
}

Draw((3, 7));
LoopOverStrings(new StringList { "one", "two", "three" });
DisplayPerson(("John", "Doe"), true);
LoopOverValues(new [] { 1, 2, 3, 4, 5 });