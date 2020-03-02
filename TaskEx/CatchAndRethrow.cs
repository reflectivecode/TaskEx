using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task CatchAndRethrow(this Task task, Action action)
        {
            try
            {
                await task;
            }
            catch
            {
                action();
                throw;
            }
        }

        public static async Task CatchAndRethrow<TException>(this Task task, Action action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                action();
                throw;
            }
        }

        public static async Task CatchAndRethrow(this Task task, Action<Exception> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                action(e);
                throw;
            }
        }

        public static async Task CatchAndRethrow<TException>(this Task task, Action<TException> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                action(e);
                throw;
            }
        }

        public static async Task CatchAndRethrow(this Task task, Func<Task> action)
        {
            try
            {
                await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async Task CatchAndRethrow<TException>(this Task task, Func<Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async Task CatchAndRethrow(this Task task, Func<Exception, Task> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task CatchAndRethrow<TException>(this Task task, Func<TException, Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task CatchAndRethrow(this Task task, Func<ValueTask> action)
        {
            try
            {
                await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async Task CatchAndRethrow<TException>(this Task task, Func<ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async Task CatchAndRethrow(this Task task, Func<Exception, ValueTask> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task CatchAndRethrow<TException>(this Task task, Func<TException, ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Action action)
        {
            try
            {
                return await task;
            }
            catch
            {
                action();
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Action action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                action();
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Action<Exception> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                action(e);
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Action<TException> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                action(e);
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<Task> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<Task> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<Exception, Task> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<TException, Task> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<ValueTask> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<ValueTask> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T>(this Task<T> task, Func<Exception, ValueTask> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async Task<T> CatchAndRethrow<T, TException>(this Task<T> task, Func<TException, ValueTask> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow(this ValueTask task, Action action)
        {
            try
            {
                await task;
            }
            catch
            {
                action();
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Action action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                action();
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow(this ValueTask task, Action<Exception> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                action(e);
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Action<TException> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                action(e);
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<ValueTask> action)
        {
            try
            {
                await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<Exception, ValueTask> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<TException, ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<Task> action)
        {
            try
            {
                await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow(this ValueTask task, Func<Exception, Task> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask CatchAndRethrow<TException>(this ValueTask task, Func<TException, Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Action action)
        {
            try
            {
                return await task;
            }
            catch
            {
                action();
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Action action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                action();
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Action<Exception> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                action(e);
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Action<TException> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                action(e);
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<ValueTask> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<ValueTask> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<Exception, ValueTask> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<TException, ValueTask> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<Task> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                await action();
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<Task> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                await action();
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T>(this ValueTask<T> task, Func<Exception, Task> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                await action(e);
                throw;
            }
        }

        public static async ValueTask<T> CatchAndRethrow<T, TException>(this ValueTask<T> task, Func<TException, Task> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                await action(e);
                throw;
            }
        }
    }
}