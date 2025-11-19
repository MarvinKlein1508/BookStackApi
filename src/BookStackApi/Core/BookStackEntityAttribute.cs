using System.Reflection;

namespace BookStackApi.Core
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BookStackEntityAttribute : Attribute
    {
        public string Path { get; }

        public BookStackEntityAttribute(string path)
        {
            Path = path.Trim(new char[1] { '/' });
        }

        public static BookStackEntityAttribute? GetAttribute(Type type)
        {
            return type.GetCustomAttribute<BookStackEntityAttribute>();
        }
    }



}
