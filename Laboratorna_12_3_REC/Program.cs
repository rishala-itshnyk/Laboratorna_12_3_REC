using System;

public class Node
{
    public int Data { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
    }
}

public class LinkedList
{
    public Node Head { get; private set; }
    public Node Tail { get; private set; }

    // Функція для створення списку на основі масиву значень
    public void CreateList(int[] values)
    {
        foreach (var value in values)
        {
            AddToEnd(value);
        }
    }

    // Функція для додавання елемента в кінець списку
    public void AddToEnd(int data)
    {
        var newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
    }

    // Рекурсивна функція для визначення, чи список містить пару сусідніх елементів з однаковими значеннями
    private bool ContainsAdjacentEqualElementsRecursive(Node current)
    {
        if (current == null || current.Next == null)
        {
            return false;
        }

        if (current.Data == current.Next.Data)
        {
            return true;
        }

        return ContainsAdjacentEqualElementsRecursive(current.Next);
    }

    public bool ContainsAdjacentEqualElements()
    {
        return ContainsAdjacentEqualElementsRecursive(Head);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] values = { 1, 2, 3, 3, 5, 6, 7, 8, 9 }; // Приклад списку з парою сусідніх однакових елементів

        LinkedList linkedList = new LinkedList();
        linkedList.CreateList(values);

        Console.WriteLine("Список елементів:");
        foreach (var value in values)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();

        bool hasAdjacentEqual = linkedList.ContainsAdjacentEqualElements();
        Console.WriteLine("Чи містить список пару сусідніх елементів з однаковими значеннями: " + hasAdjacentEqual);

        Console.ReadLine();
    }
}
