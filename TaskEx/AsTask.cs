using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
#pragma warning disable 1998
        public static async Task AsTask(this Action action)
        {
            action();
        }
#pragma warning restore 1998

        public static async Task AsTask(this Func<Task> action)
        {
            await action();
        }

        public static async Task AsTask(this Func<ValueTask> action)
        {
            await action();
        }

        public static async Task<T> AsTask<T>(this ValueTask<T> task)
        {
            return await task;
        }

#pragma warning disable 1998
        public static async Task<T> AsTask<T>(this Func<T> action)
        {
            return action();
        }
#pragma warning restore 1998

        public static async Task<T> AsTask<T>(this Func<Task<T>> action)
        {
            return await action();
        }

        public static async Task<T> AsTask<T>(this Func<ValueTask<T>> action)
        {
            return await action();
        }
    }
}