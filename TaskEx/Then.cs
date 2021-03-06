﻿using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task Then(this Task task, Action onSuccess)
        {
            await task;
            onSuccess();
        }

        public static async ValueTask Then(this ValueTask task, Action onSuccess)
        {
            await task;
            onSuccess();
        }

        public static async Task Then(this Task task, Action<Task> onSuccess)
        {
            await task;
            onSuccess(task);
        }

        public static async ValueTask Then(this ValueTask task, Action<ValueTask> onSuccess)
        {
            await task;
            onSuccess(default);
        }

        public static async Task ThenAwait(this Task task, Func<Task> onSuccess)
        {
            await task;
            await onSuccess();
        }

        public static async ValueTask ThenAwait(this ValueTask task, Func<ValueTask> onSuccess)
        {
            await task;
            await onSuccess();
        }

        public static async Task ThenAwait(this Task task, Func<Task, Task> onSuccess)
        {
            await task;
            await onSuccess(task);
        }

        public static async ValueTask ThenAwait(this ValueTask task, Func<ValueTask, ValueTask> onSuccess)
        {
            await task;
            await onSuccess(default);
        }

        public static async Task<T> Then<T>(this Task task, Func<T> onSuccess)
        {
            await task;
            return onSuccess();
        }

        public static async ValueTask<T> Then<T>(this ValueTask task, Func<T> onSuccess)
        {
            await task;
            return onSuccess();
        }

        public static async Task<T> Then<T>(this Task task, Func<Task, T> onSuccess)
        {
            await task;
            return onSuccess(task);
        }

        public static async ValueTask<T> Then<T>(this ValueTask task, Func<ValueTask, T> onSuccess)
        {
            await task;
            return onSuccess(default);
        }

        public static async Task<T> ThenAwait<T>(this Task task, Func<Task<T>> onSuccess)
        {
            await task;
            return await onSuccess();
        }

        public static async ValueTask<T> ThenAwait<T>(this ValueTask task, Func<ValueTask<T>> onSuccess)
        {
            await task;
            return await onSuccess();
        }

        public static async Task<T> ThenAwait<T>(this Task task, Func<Task, Task<T>> onSuccess)
        {
            await task;
            return await onSuccess(task);
        }

        public static async ValueTask<T> ThenAwait<T>(this ValueTask task, Func<ValueTask, ValueTask<T>> onSuccess)
        {
            await task;
            return await onSuccess(default);
        }

        public static async Task Then<T>(this Task<T> task, Action onSuccess)
        {
            await task;
            onSuccess();
        }

        public static async ValueTask Then<T>(this ValueTask<T> task, Action onSuccess)
        {
            await task;
            onSuccess();
        }

        public static async Task Then<T>(this Task<T> task, Action<T> onSuccess)
        {
            onSuccess(await task);
        }

        public static async ValueTask Then<T>(this ValueTask<T> task, Action<T> onSuccess)
        {
            onSuccess(await task);
        }

        public static async Task Then<T>(this Task<T> task, Action<T, Task<T>> onSuccess)
        {
            onSuccess(await task, task);
        }

        public static async ValueTask Then<T>(this ValueTask<T> task, Action<T, ValueTask<T>> onSuccess)
        {
            onSuccess(await (task = task.Preserve()), task);
        }

        public static async Task ThenAwait<T>(this Task<T> task, Func<Task> onSuccess)
        {
            await task;
            await onSuccess();
        }

        public static async ValueTask ThenAwait<T>(this ValueTask<T> task, Func<ValueTask> onSuccess)
        {
            await task;
            await onSuccess();
        }

        public static async Task ThenAwait<T>(this Task<T> task, Func<T, Task> onSuccess)
        {
            await onSuccess(await task);
        }

        public static async ValueTask ThenAwait<T>(this ValueTask<T> task, Func<T, ValueTask> onSuccess)
        {
            await onSuccess(await task);
        }

        public static async Task ThenAwait<T>(this Task<T> task, Func<T, Task<T>, Task> onSuccess)
        {
            await onSuccess(await task, task);
        }

        public static async ValueTask ThenAwait<T>(this ValueTask<T> task, Func<T, ValueTask<T>, ValueTask> onSuccess)
        {
            await onSuccess(await (task = task.Preserve()), task);
        }

        public static async Task<TOut> Then<TIn, TOut>(this Task<TIn> task, Func<TIn, TOut> onSuccess)
        {
            return onSuccess(await task);
        }

        public static async ValueTask<TOut> Then<TIn, TOut>(this ValueTask<TIn> task, Func<TIn, TOut> onSuccess)
        {
            return onSuccess(await task);
        }

        public static async Task<TOut> Then<TIn, TOut>(this Task<TIn> task, Func<TIn, Task<TIn>, TOut> onSuccess)
        {
            return onSuccess(await task, task);
        }

        public static async ValueTask<TOut> Then<TIn, TOut>(this ValueTask<TIn> task, Func<TIn, ValueTask<TIn>, TOut> onSuccess)
        {
            return onSuccess(await (task = task.Preserve()), task);
        }

        public static async Task<TOut> ThenAwait<TIn, TOut>(this Task<TIn> task, Func<TIn, Task<TOut>> onSuccess)
        {
            return await onSuccess(await task);
        }

        public static async ValueTask<TOut> ThenAwait<TIn, TOut>(this ValueTask<TIn> task, Func<TIn, ValueTask<TOut>> onSuccess)
        {
            return await onSuccess(await task);
        }

        public static async Task<TOut> ThenAwait<TIn, TOut>(this Task<TIn> task, Func<TIn, Task<TIn>, Task<TOut>> onSuccess)
        {
            return await onSuccess(await task, task);
        }

        public static async ValueTask<TOut> ThenAwait<TIn, TOut>(this ValueTask<TIn> task, Func<TIn, ValueTask<TIn>, ValueTask<TOut>> onSuccess)
        {
            return await onSuccess(await (task = task.Preserve()), task);
        }
    }
}