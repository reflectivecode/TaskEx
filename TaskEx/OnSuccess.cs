using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task<T> OnSuccess<T>(this Task<T> task, Action onSuccess)
        {
            var result = await task;
            onSuccess();
            return result;
        }

        public static async ValueTask<T> OnSuccess<T>(this ValueTask<T> task, Action onSuccess)
        {
            var result = await task;
            onSuccess();
            return result;
        }

        public static async Task<T> OnSuccess<T>(this Task<T> task, Action<T> onSuccess)
        {
            var result = await task;
            onSuccess(result);
            return result;
        }

        public static async ValueTask<T> OnSuccess<T>(this ValueTask<T> task, Action<T> onSuccess)
        {
            var result = await task;
            onSuccess(result);
            return result;
        }

        public static async Task<T> OnSuccess<T>(this Task<T> task, Action<T, Task<T>> onSuccess)
        {
            var result = await task;
            onSuccess(result, task);
            return result;
        }

        public static async ValueTask<T> OnSuccess<T>(this Task<T> task, Action<T, ValueTask<T>> onSuccess)
        {
            var result = await task;
            onSuccess(result, new ValueTask<T>(result));
            return result;
        }

        public static async Task<T> OnSuccessAwait<T>(this Task<T> task, Func<Task> onSuccess)
        {
            var result = await task;
            await onSuccess();
            return result;
        }

        public static async ValueTask<T> OnSuccessAwait<T>(this ValueTask<T> task, Func<ValueTask> onSuccess)
        {
            var result = await task;
            await onSuccess();
            return result;
        }

        public static async Task<T> OnSuccessAwait<T>(this Task<T> task, Func<T, Task> onSuccess)
        {
            var result = await task;
            await onSuccess(result);
            return result;
        }

        public static async ValueTask<T> OnSuccessAwait<T>(this ValueTask<T> task, Func<T, ValueTask> onSuccess)
        {
            var result = await task;
            await onSuccess(result);
            return result;
        }

        public static async Task<T> OnSuccessAwait<T>(this Task<T> task, Func<T, Task<T>, Task> onSuccess)
        {
            var result = await task;
            await onSuccess(result, task);
            return result;
        }

        public static async ValueTask<T> OnSuccessAwait<T>(this ValueTask<T> task, Func<T, ValueTask<T>, ValueTask> onSuccess)
        {
            var result = await task;
            await onSuccess(result, new ValueTask<T>(result));
            return result;
        }
    }
}