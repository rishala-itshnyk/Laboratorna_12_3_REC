namespace Laboratorna_12_3_REC.Tests;

public class Tests
{
    [Test]
    public void ContainsAdjacentEqualElements_ReturnsTrue()
    {
        int[] values = { 1, 2, 2, 3, 4 }; // Пара сусідніх елементів з однаковими значеннями (2, 2)
        LinkedList linkedList = new LinkedList();
        linkedList.CreateList(values);

        bool result = linkedList.ContainsAdjacentEqualElements();

        Assert.True(result);
    }

    [Test]
    public void ContainsAdjacentEqualElements_ReturnsFalse()
    {
        int[] values = { 1, 2, 3, 4, 5 }; // Немає пари сусідніх елементів з однаковими значеннями
        LinkedList linkedList = new LinkedList();
        linkedList.CreateList(values);

        bool result = linkedList.ContainsAdjacentEqualElements();

        Assert.False(result);
    }
}