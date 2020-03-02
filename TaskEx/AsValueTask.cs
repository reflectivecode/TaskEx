using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async ValueTask AsValueTask(this Task task)
        {
            await task;
        }

#pragma warning disable 1998
        public static async ValueTask AsValueTask(this Action action)
        {
            action();
        }
#pragma warning restore 1998

        public static async ValueTask AsValueTask(this Func<ValueTask> action)
        {
            await action();
        }

        public static async ValueTask AsValueTask(this Func<Task> action)
        {
            await action();
        }

        public static async ValueTask<T> AsValueTask<T>(this Task<T> task)
        {
            return await task;
        }

#pragma warning disable 1998
        public static async ValueTask<T> AsValueTask<T>(this Func<T> action)
        {
            return action();
        }
#pragma warning restore 1998

        public static async ValueTask<T> AsValueTask<T>(this Func<ValueTask<T>> action)
        {
            return await action();
        }

        public static async ValueTask<T> AsValueTask<T>(this Func<Task<T>> action)
        {
            return await action();
        }
    }
}