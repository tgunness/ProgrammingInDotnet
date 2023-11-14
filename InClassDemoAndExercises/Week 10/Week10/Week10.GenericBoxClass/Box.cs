using System;

public class Box<T>
{
    private T content;

    public override string ToString()
    {
        return base.ToString();
    }

    public int GetZero()
    {
        return 0;
    }

    public void AddItem(T item)
    {
        content = item;
    }

    public T GetItem()
    {
        return content;
    }
}
