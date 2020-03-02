using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task Finally(this Task task, Action onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                onCompletion();
            }
        }
        public static async Task Finally(this Task task, Func<Task> onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async Task Finally(this Task task, Func<ValueTask> onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async Task<T> Finally<T>(this Task<T> task, Action onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                onCompletion();
            }
        }

        public static async Task<T> Finally<T>(this Task<T> task, Func<Task> onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async Task<T> Finally<T>(this Task<T> task, Func<ValueTask> onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async ValueTask Finally(this ValueTask task, Action onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                onCompletion();
            }
        }

        public static async ValueTask Finally(this ValueTask task, Func<ValueTask> onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async ValueTask Finally(this ValueTask task, Func<Task> onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Action onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                onCompletion();
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Func<ValueTask> onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                await onCompletion();
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Func<Task> onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                await onCompletion();
            }
        }
    }
}