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

        public static async Task Finally(this Task task, Action<Task> onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                onCompletion(task);
            }
        }

        public static async ValueTask Finally(this ValueTask task, Action<ValueTask> onCompletion)
        {
            try
            {
                await (task = task.Preserve());
            }
            finally
            {
                onCompletion(task);
            }
        }

        public static async Task FinallyAwait(this Task task, Func<Task> onCompletion)
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

        public static async ValueTask FinallyAwait(this ValueTask task, Func<ValueTask> onCompletion)
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

        public static async Task FinallyAwait(this Task task, Func<Task, Task> onCompletion)
        {
            try
            {
                await task;
            }
            finally
            {
                await onCompletion(task);
            }
        }

        public static async ValueTask FinallyAwait(this ValueTask task, Func<ValueTask, ValueTask> onCompletion)
        {
            try
            {
                await (task = task.Preserve());
            }
            finally
            {
                await onCompletion(task);
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

        public static async Task<T> Finally<T>(this Task<T> task, Action<Task<T>> onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                onCompletion(task);
            }
        }

        public static async ValueTask<T> Finally<T>(this ValueTask<T> task, Action<ValueTask<T>> onCompletion)
        {
            try
            {
                return await (task = task.Preserve());
            }
            finally
            {
                onCompletion(task);
            }
        }

        public static async Task<T> FinallyAwait<T>(this Task<T> task, Func<Task> onCompletion)
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

        public static async ValueTask<T> FinallyAwait<T>(this ValueTask<T> task, Func<ValueTask> onCompletion)
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

        public static async Task<T> FinallyAwait<T>(this Task<T> task, Func<Task<T>, Task> onCompletion)
        {
            try
            {
                return await task;
            }
            finally
            {
                await onCompletion(task);
            }
        }

        public static async ValueTask<T> FinallyAwait<T>(this ValueTask<T> task, Func<ValueTask<T>, ValueTask> onCompletion)
        {
            try
            {
                return await (task = task.Preserve());
            }
            finally
            {
                await onCompletion(task);
            }
        }
    }
}