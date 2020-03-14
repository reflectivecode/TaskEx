using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task OnFailure(this Task task, Action onFailure)
        {
            try
            {
                await task;
            }
            catch
            {
                onFailure();
                throw;
            }
        }

        public static async ValueTask OnFailure(this ValueTask task, Action onFailure)
        {
            try
            {
                await task;
            }
            catch
            {
                onFailure();
                throw;
            }
        }

        public static async Task OnFailure<TException>(this Task task, Action onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                onFailure();
                throw;
            }
        }

        public static async ValueTask OnFailure<TException>(this ValueTask task, Action onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                onFailure();
                throw;
            }
        }

        public static async Task OnFailure(this Task task, Action<Exception> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async ValueTask OnFailure(this ValueTask task, Action<Exception> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async Task OnFailure<TException>(this Task task, Action<TException> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async ValueTask OnFailure<TException>(this ValueTask task, Action<TException> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async Task OnFailure(this Task task, Action<Exception, Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask OnFailure(this ValueTask task, Action<Exception, ValueTask> onFailure)
        {
            try
            {
                await (task = task.Preserve());
            }
            catch (Exception e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async Task OnFailure<TException>(this Task task, Action<TException, Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask OnFailure<TException>(this ValueTask task, Action<TException, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await (task = task.Preserve());
            }
            catch (TException e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async Task OnFailureAwait(this Task task, Func<Task> onFailure)
        {
            try
            {
                await task;
            }
            catch
            {
                await onFailure();
                throw;
            }
        }

        public static async ValueTask OnFailureAwait(this ValueTask task, Func<ValueTask> onFailure)
        {
            try
            {
                await task;
            }
            catch
            {
                await onFailure();
                throw;
            }
        }

        public static async Task OnFailureAwait<TException>(this Task task, Func<Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await onFailure();
                throw;
            }
        }

        public static async ValueTask OnFailureAwait<TException>(this ValueTask task, Func<ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await onFailure();
                throw;
            }
        }

        public static async Task OnFailureAwait(this Task task, Func<Exception, Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async ValueTask OnFailureAwait(this ValueTask task, Func<Exception, ValueTask> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async Task OnFailureAwait<TException>(this Task task, Func<TException, Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async ValueTask OnFailureAwait<TException>(this ValueTask task, Func<TException, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async Task OnFailureAwait(this Task task, Func<Exception, Task, Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask OnFailureAwait(this ValueTask task, Func<Exception, ValueTask, ValueTask> onFailure)
        {
            try
            {
                await (task = task.Preserve());
            }
            catch (Exception e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async Task OnFailureAwait<TException>(this Task task, Func<TException, Task, Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask OnFailureAwait<TException>(this ValueTask task, Func<TException, ValueTask, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await (task = task.Preserve());
            }
            catch (TException e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async Task<T> OnFailure<T>(this Task<T> task, Action onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                onFailure();
                throw;
            }
        }

        public static async ValueTask<T> OnFailure<T>(this ValueTask<T> task, Action onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                onFailure();
                throw;
            }
        }

        public static async Task<T> OnFailure<T, TException>(this Task<T> task, Action onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                onFailure();
                throw;
            }
        }

        public static async ValueTask<T> OnFailure<T, TException>(this ValueTask<T> task, Action onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                onFailure();
                throw;
            }
        }

        public static async Task<T> OnFailure<T>(this Task<T> task, Action<Exception> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async ValueTask<T> OnFailure<T>(this ValueTask<T> task, Action<Exception> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async Task<T> OnFailure<T, TException>(this Task<T> task, Action<TException> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async ValueTask<T> OnFailure<T, TException>(this ValueTask<T> task, Action<TException> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                onFailure(e);
                throw;
            }
        }

        public static async Task<T> OnFailure<T>(this Task<T> task, Action<Exception, Task<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask<T> OnFailure<T>(this ValueTask<T> task, Action<Exception, ValueTask<T>> onFailure)
        {
            try
            {
                return await (task = task.Preserve());
            }
            catch (Exception e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async Task<T> OnFailure<T, TException>(this Task<T> task, Action<TException, Task<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask<T> OnFailure<T, TException>(this ValueTask<T> task, Action<TException, ValueTask<T>> onFailure) where TException : Exception
        {
            try
            {
                return await (task = task.Preserve());
            }
            catch (TException e)
            {
                onFailure(e, task);
                throw;
            }
        }

        public static async Task<T> OnFailureAwait<T>(this Task<T> task, Func<Task> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                await onFailure();
                throw;
            }
        }

        public static async ValueTask<T> OnFailureAwait<T>(this ValueTask<T> task, Func<ValueTask> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                await onFailure();
                throw;
            }
        }

        public static async Task<T> OnFailureAwait<T, TException>(this Task<T> task, Func<Task> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                await onFailure();
                throw;
            }
        }

        public static async ValueTask<T> OnFailureAwait<T, TException>(this ValueTask<T> task, Func<ValueTask> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                await onFailure();
                throw;
            }
        }

        public static async Task<T> OnFailureAwait<T>(this Task<T> task, Func<Exception, Task> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async ValueTask<T> OnFailureAwait<T>(this ValueTask<T> task, Func<Exception, ValueTask> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async Task<T> OnFailureAwait<T, TException>(this Task<T> task, Func<TException, Task> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async ValueTask<T> OnFailureAwait<T, TException>(this ValueTask<T> task, Func<TException, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await onFailure(e);
                throw;
            }
        }

        public static async Task<T> OnFailureAwait<T>(this Task<T> task, Func<Exception, Task<T>, Task> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask<T> OnFailureAwait<T>(this ValueTask<T> task, Func<Exception, ValueTask<T>, ValueTask> onFailure)
        {
            try
            {
                return await (task = task.Preserve());
            }
            catch (Exception e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async Task<T> OnFailureAwait<T, TException>(this Task<T> task, Func<TException, Task<T>, Task> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await onFailure(e, task);
                throw;
            }
        }

        public static async ValueTask<T> OnFailureAwait<T, TException>(this ValueTask<T> task, Func<TException, ValueTask<T>, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                return await (task = task.Preserve());
            }
            catch (TException e)
            {
                await onFailure(e, task);
                throw;
            }
        }
    }
}