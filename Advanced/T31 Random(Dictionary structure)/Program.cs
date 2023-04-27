using System;
using System.Collections.Generic;
using System.Diagnostics;

class Person
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
}

class Program
{
    static Random random = new Random();

    static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] result = new char[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = chars[random.Next(chars.Length)];
        }
        return new string(result);
    }

    static void Main()
    {
        List<Person> personsList = new List<Person>();
        Dictionary<string, Person> personsDictionary = new Dictionary<string, Person>();

        // Generate 10000 random Person objects and add them to both List and Dictionary
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            Person person = new Person();
            person.FirstName = GenerateRandomString(4);
            person.Surname = GenerateRandomString(10);
            personsList.Add(person);
            // Check if the key is already in the dictionary before adding
            if (!personsDictionary.ContainsKey(person.FirstName))
            {
                personsDictionary.Add(person.FirstName, person);
            }
        }
        stopwatch.Stop();
        long addingTimeList = stopwatch.ElapsedMilliseconds;

        Console.WriteLine("List Collection:");
        Console.WriteLine($"- Adding time: {addingTimeList} ms");
        Console.WriteLine($"- Persons count: {personsList.Count}");
        Console.WriteLine($"- Random person: {personsList[random.Next(personsList.Count)].FirstName} {personsList[random.Next(personsList.Count)].Surname}");
        Console.WriteLine();

        Console.WriteLine("Dictionary Collection:");
        Console.WriteLine($"- Adding time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"- Persons count: {personsDictionary.Count}");
        Console.WriteLine($"- Random person: {personsDictionary[personsList[random.Next(personsList.Count)].FirstName].FirstName} {personsDictionary[personsList[random.Next(personsList.Count)].FirstName].Surname}");
        Console.WriteLine();

        // Search for 1000 random people by first name in Dictionary
        int personsToFind = 1000;
        stopwatch.Restart();
        for (int i = 0; i < personsToFind; i++)
        {
            string firstNameToFind = GenerateRandomString(4);
            if (personsDictionary.ContainsKey(firstNameToFind))
            {
                Person foundPerson = personsDictionary[firstNameToFind];
                Console.WriteLine($"Found person with {firstNameToFind} firstname: {foundPerson.FirstName} {foundPerson.Surname}");
            }
        }
        stopwatch.Stop();
        long findingTimeDictionary = stopwatch.ElapsedMilliseconds;

        Console.WriteLine();
        Console.WriteLine("Finding persons in collection (by first name):");
        Console.WriteLine($"- Persons tried to find: {personsToFind}");
        Console.WriteLine($"- Total finding time: {findingTimeDictionary} ms");
    }
}


// Speed: The Dictionary structure is generally faster for searching for a specific key (in this case, the first name) compared to a List. This is because the Dictionary uses a hash table internally, which allows for fast lookups based on the key