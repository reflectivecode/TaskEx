using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task CatchAndRethrow(this Task task, Action onFailure)
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

        public static async Task CatchAndRethrow<TException>(this Task task, Action onFailure) where TException : Exception
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

        public static async Task CatchAndRethrow(this Task task, Action<Exception> onFailure)
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

        public static async Task CatchAndRethrow<TException>(this Task task, Action<TException> onFailure) where TException : Exception
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

        public static async Task CatchAndRethrow(this Task task, Func<Task> onFailure)
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

        public static async Task CatchAndRethrow<TException>(this Task task, Func<Task> onFailure) where TException : Exception
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

        public static async Task CatchAndRethrow(this Task task, Func<Exception, Task> onFailure)
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

        public static async Task CatchAndRethrow<TException>(this Task task, Func<TException, Task> onFailure) where TException : Exception
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

        public static async Task CatchAndRethrow(this Task task, Func<ValueTask> onFailure)
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

        public static async Task CatchAndRethrow<TException>(this Task task, Func<ValueTask> onFailure) where TException : Exception
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

        public static async Task CatchAndRethrow(this Task task, Func<Exception, ValueTask> onFailure)
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

        public static async Task CatchAndRethrow<TException>(this Task task, Func<TException, ValueTask> onFailure) where TException : Exception
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

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Action onFailure)
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

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Action onFailure) where TException : Exception
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

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Action<Exception> onFailure)
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

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Action<TException> onFailure) where TException : Exception
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

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<Task> onFailure)
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

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<Task> onFailure) where TException : Exception
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

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<Exception, Task> onFailure)
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

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<TException, Task> onFailure) where TException : Exception
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

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<ValueTask> onFailure)
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

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<ValueTask> onFailure) where TException : Exception
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

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<Exception, ValueTask> onFailure)
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

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<TException, ValueTask> onFailure) where TException : Exception
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

        public static async ValueTask CatchAndRethrow(this ValueTask task, Action onFailure)
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

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Action onFailure) where TException : Exception
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

        public static async ValueTask CatchAndRethrow(this ValueTask task, Action<Exception> onFailure)
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

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Action<TException> onFailure) where TException : Exception
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

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<ValueTask> onFailure)
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

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<ValueTask> onFailure) where TException : Exception
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

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<Exception, ValueTask> onFailure)
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

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<TException, ValueTask> onFailure) where TException : Exception
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

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<Task> onFailure)
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

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<Task> onFailure) where TException : Exception
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

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<Exception, Task> onFailure)
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

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<TException, Task> onFailure) where TException : Exception
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

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Action onFailure)
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

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Action onFailure) where TException : Exception
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

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Action<Exception> onFailure)
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

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Action<TException> onFailure) where TException : Exception
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

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<ValueTask> onFailure)
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

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<ValueTask> onFailure) where TException : Exception
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

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<Exception, ValueTask> onFailure)
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

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<TException, ValueTask> onFailure) where TException : Exception
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

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<Task> onFailure)
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

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<Task> onFailure) where TException : Exception
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

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<Exception, Task> onFailure)
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

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<TException, Task> onFailure) where TException : Exception
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
    }
}