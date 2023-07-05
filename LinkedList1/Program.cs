using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        LinkedList<Players> players = new LinkedList<Players>();
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            players.AddLast(Input());
        }

        LinkedListNode<Players> checkPlayer = new LinkedListNode<Players>(Input());

        LinkedListNode<Players> node;
        node = players.First;
        bool isFind = false;
        
        while (node != null)
        {
            if (string.Compare(node.Value.Name, checkPlayer.Value.Name ) == 0
                && string.Compare(node.Value.Password, checkPlayer.Value.Password ) == 0)
            {
                isFind = true;
                break;
            }

            node = node.Next;
        }

        if (isFind)
        {
            Console.WriteLine("Доступ разрешен!");
        }
        else
        {
            Console.WriteLine("Неправильный логин или пароль"); 
        }
    }

    public static Players Input()
    {
        string tempPlayerName = Console.ReadLine();
        string tempPlayerPassword = Console.ReadLine();
        Players tempPlayer = new Players(tempPlayerName, tempPlayerPassword);
        
        return tempPlayer;
    }
}

public class Players
{
    public string Name;
    public string Password;

    public Players(string name, string password)
    {
        Name = name;
        Password = password;
    }
}