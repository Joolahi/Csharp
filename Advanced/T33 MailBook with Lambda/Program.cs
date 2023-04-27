using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Friend class to represent a friend with name and email
class Friend
{
    public string Name { get; set; }
    public string Email { get; set; }

    // Constructor
    public Friend(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

// MailBook collection class to manage friends
class MailBook
{
    private List<Friend> _friends; // List to store friends

    // Constructor
    public MailBook()
    {
        _friends = new List<Friend>();
        LoadFriendsFromFile(); // Load friends from file during initialization
    }

    // ReadOnly property to get list of friends
    public IReadOnlyList<Friend> Friends => _friends;

    // Method to load friends from file
    private void LoadFriendsFromFile()
    {
        try
        {
            using (var reader = new StreamReader("friend.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(';');
                    var friend = new Friend(parts[0], parts[1]);
                    _friends.Add(friend);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error while reading from file: " + ex.Message);
        }
    }

    // Method to save friends to file
    private void SaveFriendsToFile()
    {
        try
        {
            using (var writer = new StreamWriter("friend.csv"))
            {
                foreach (var friend in _friends)
                {
                    writer.WriteLine($"{friend.Name};{friend.Email}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error while writing to file: " + ex.Message);
        }
    }

    // Method to display all friends
    public void DisplayAllFriends()
    {
        Console.WriteLine("All friends:");
        foreach (var friend in _friends)
        {
            Console.WriteLine($"{friend.Name} {friend.Email}");
        }
    }

    // Method to search for friends by name
    public void SearchFriendsByName(string name)
    {
        var results = _friends.Where(friend => friend.Name.Contains(name)).ToList();
        if (results.Count > 0)
        {
            Console.WriteLine($"Search results for '{name}':");
            foreach (var friend in results)
            {
                Console.WriteLine($"{friend.Name} {friend.Email}");
            }
        }
        else
        {
            Console.WriteLine($"No results found for '{name}'.");
        }
    }

    // Method to add a new friend
    public void AddFriend(string name, string email)
    {
        var friend = new Friend(name, email);
        _friends.Add(friend);
        SaveFriendsToFile(); // Save friends to file after adding a new friend
    }
}

class Program
{
    static void Main()
    {
        MailBook mailBook = new MailBook();

        // Display number of names read from file
        Console.WriteLine($"{mailBook.Friends.Count} names in the address book.");

        // Display all friends
        mailBook.DisplayAllFriends();

        // Search for friends by name
        Console.Write("Enter the name or part of the name of the person you are looking for > ");
        string searchName = Console.ReadLine();
        mailBook.SearchFriendsByName(searchName);

        // Add a new friend
        Console.WriteLine("Enter details of a new friend:");
        Console.Write("Name: ");
        string newFriendName = Console.ReadLine();
        Console.Write("Email: ");
        string newFriendEmail = Console.ReadLine();
        mailBook.AddFriend(newFriendName, newFriendEmail);

        Console.WriteLine("Program completed successfully. Press any key to continue...");
        Console.ReadKey();
    }
}
