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
        List<Person> persons = new List<Person>();

        // Generate 10000 random Person objects
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            Person person = new Person();
            person.FirstName = GenerateRandomString(4);
            person.Surname = GenerateRandomString(10);
            persons.Add(person);
        }
        stopwatch.Stop();
        long addingTime = stopwatch.ElapsedMilliseconds;

        Console.WriteLine("List Collection:");
        Console.WriteLine($"- Adding time: {addingTime} ms");
        Console.WriteLine($"- Persons count: {persons.Count}");
        Console.WriteLine($"- Random person: {persons[random.Next(persons.Count)].FirstName} {persons[random.Next(persons.Count)].Surname}");
        Console.WriteLine();

        // Search for 1000 random people by first name
        int personsToFind = 1000;
        stopwatch.Restart();
        for (int i = 0; i < personsToFind; i++)
        {
            string firstNameToFind = GenerateRandomString(4);
            Person foundPerson = persons.Find(person => person.FirstName == firstNameToFind);
            if (foundPerson != null)
            {
                Console.WriteLine($"Found person with {firstNameToFind} firstname: {foundPerson.FirstName} {foundPerson.Surname}");
            }
        }
        stopwatch.Stop();
        long findingTime = stopwatch.ElapsedMilliseconds;

        Console.WriteLine();
        Console.WriteLine("Finding persons in collection (by first name):");
        Console.WriteLine($"- Persons tried to find: {personsToFind}");
        Console.WriteLine($"- Total finding time: {findingTime} ms");
    }
}
