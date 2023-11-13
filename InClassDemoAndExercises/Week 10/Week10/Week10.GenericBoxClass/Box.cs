public class Box<T>
{
    private T content;

    public void AddItem(T item)
    {
        content = item;
    }

    public T GetItem()
    {
        return content;
    }
}
