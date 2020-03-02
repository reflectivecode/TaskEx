using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task Finally(this Task task, Action action)
        {
            try
            {
                await task;
            }
            finally
            {
                action();
            }
        }
        public static async Task Finally(this Task task, Func<Task> action)
        {
            try
            {
                await task;
            }
            finally
            {
                await action();
            }
        }

        public static async Task Finally(this Task task, Func<ValueTask> action)
        {
            try
            {
                await task;
            }
            finally
            {
                await action();
            }
        }

        public static async Task<T> Finally<T>(this Task<T> task, Action action)
        {
            try
            {
                return await task;
            }
            finally
            {
                action();
            }
        }

        public static async Task<T> Finally<T>(this Task<T> task, Func<Task> action)
        {
            try
            {
                return await task;
            }
            finally
            {
                await action();
            }
        }

        public static async Task<T> Finally<T>(this Task<T> task, Func<ValueTask> action)
        {
            try
            {
                return await task;
            }
            finally
            {
                await action();
            }
        }

        public static async ValueTask Finally(this ValueTask task, Action action)
        {
            try
            {
                await task;
            }
            finally
            {
                action();
            }
        }

        public static async ValueTask Finally(this ValueTask task, Func<ValueTask> action)
        {
            try
            {
                await task;
            }
            finally
            {
                await action();
            }
        }

        public static async ValueTask Finally(this ValueTask task, Func<Task> action)
        {
            try
            {
                await task;
            }
            finally
            {
                await action();
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Action action)
        {
            try
            {
                return await task;
            }
            finally
            {
                action();
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Func<ValueTask> action)
        {
            try
            {
                return await task;
            }
            finally
            {
                await action();
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Func<Task> action)
        {
            try
            {
                return await task;
            }
            finally
            {
                await action();
            }
        }
    }
}