public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var elem in collection)
        {
            if (predicate(elem)) result.Add(elem);
        }
        return result;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var elem in collection)
        {
            if (!predicate(elem)) result.Add(elem);
        }
        return result;    
    }
}