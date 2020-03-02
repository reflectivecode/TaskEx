using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static void Wait(this ValueTask task)
        {
            if (task.IsCompletedSuccessfully) return;
            task.AsTask().Wait();
        }
    }
}