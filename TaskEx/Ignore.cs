using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static void Ignore(this Task task) { }

        public static void Ignore(this ValueTask task) { }

        public static void Ignore<T>(this ValueTask<T> task) { }
    }
}
