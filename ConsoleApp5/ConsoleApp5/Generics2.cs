namespace ConsoleApp5;

public class Generics2
{
    public static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine(list.Find(2));             // 30
        Console.WriteLine(list.Contains(20));        // True

        list.InsertAt(99, 1);                        // [10, 99, 20, 30, 40]
        Console.WriteLine(list.Find(1));             // 99

        Console.WriteLine(list.Remove(3));           // removes 30
        Console.WriteLine(list.Find(2));             // 20

        list.DeleteAt(0);                            // remove 10
        Console.WriteLine(list.Contains(10));        // False

        list.Clear();
        Console.WriteLine(list.Count);               // 0
    }
}

public class MyList<T>
{
    private T[] _data;
    private int _count;
    public int Count => _count;

    public MyList()
    {
        _data = new T[4];
        _count = 0;
    }

    public void Add(T element)
    {
        EnsureCapacity();
        _data[_count] = element;
        _count++;
    }

    public T Remove(int index)
    {
        ValidateIndex(index);
        T removed = _data[index];

        for (int i = index; i < _count - 1; i++)
        {
            _data[i] = _data[i + 1];
        }

        _count--;
        return removed;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Equals(_data[i], element)) return true;
        }
        return false;
    }

    public void Clear()
    {
        _data = new T[4];
        _count = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _count) throw new ArgumentOutOfRangeException();

        EnsureCapacity();

        for (int i = _count; i > index; i--)
        {
            _data[i] = _data[i - 1];
        }

        _data[index] = element;
        _count++;
    }

    public void DeleteAt(int index)
    {
        ValidateIndex(index);

        for (int i = index; i < _count - 1; i++)
        {
            _data[i] = _data[i + 1];
        }

        _count--;
    }

    public T Find(int index)
    {
        ValidateIndex(index);
        return _data[index];
    }

    private void EnsureCapacity()
    {
        if (_count == _data.Length)
        {
            T[] newArray = new T[_data.Length * 2];
            Array.Copy(_data, newArray, _data.Length);
            _data = newArray;
        }
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException();
    }
}