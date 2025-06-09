namespace DesignPatternsDemo.Console.Patterns.Adapter
{
    public interface IJsonParser<T>
    {
        T Parse(string data);
        String ConvertToJson(T obj);
    }
}