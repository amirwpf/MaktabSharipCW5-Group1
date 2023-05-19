using CW_4_1.Entities;

var above30 = PeopleList.people.Where(p => p.Age > 30 && p.Gender == 0).ToArray();
var peopleInShiraz = PeopleList.people.Where(x => x.City == "shiraz").Select(x=>x.Name).ToArray();
var peopleAgeSorted = PeopleList.people.OrderBy(x => x.Age).ToArray();

foreach (var item in above30)
{
    Console.WriteLine("1-"+item.ToString());
}

foreach (var item in peopleAgeSorted)
{
    Console.WriteLine("2-"+item.ToString());
}

foreach (var item in peopleInShiraz)
{
    Console.WriteLine("3-" + item);
}