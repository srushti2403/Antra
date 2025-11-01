// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World!");

public class MyStack<T>
{
    private List<T> items = new List<T>();

    public int Count()
    {
        return items.Count;
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        int lastIndex = items.Count - 1;
        T value = items[lastIndex];
        items.RemoveAt(lastIndex);
        return value;
    }
}
