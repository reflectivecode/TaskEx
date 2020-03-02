using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task Catch(this Task task, Action action)
        {
            try
            {
                await task;
            }
            catch
            {
                action();
            }
        }

        public static async Task Catch<TException>(this Task task, Action action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                action();
            }
        }

        public static async Task Catch(this Task task, Action<Exception> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                action(e);
            }
        }

        public static async Task Catch<TException>(this Task task, Action<TException> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                action(e);
            }
        }

        public static async Task Catch(this Task task, Func<Task> action)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await action();
            }
        }

        public static async Task Catch<TException>(this Task task, Func<Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
            }
        }

        public static async Task Catch(this Task task, Func<Exception, Task> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
            }
        }

        public static async Task Catch<TException>(this Task task, Func<TException, Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
            }
        }

        public static async Task Catch(this Task task, Func<ValueTask> action)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await action();
            }
        }

        public static async Task Catch<TException>(this Task task, Func<ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
            }
        }

        public static async Task Catch(this Task task, Func<Exception, ValueTask> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
            }
        }

        public static async Task Catch<TException>(this Task task, Func<TException, ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<T> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                return action();
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<T> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return action();
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Exception, T> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return action(e);
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<TException, T> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return action(e);
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Task<T>> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await action();
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<Task<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await action();
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Exception, Task<T>> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await action(e);
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<TException, Task<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await action(e);
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<ValueTask<T>> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await action();
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<ValueTask<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await action();
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Exception, ValueTask<T>> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await action(e);
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<TException, ValueTask<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await action(e);
            }
        }

        public static async ValueTask Catch(this ValueTask task, Action action)
        {
            try
            {
                await task;
            }
            catch
            {
                action();
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Action action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                action();
            }
        }

        public static async ValueTask Catch(this ValueTask task, Action<Exception> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                action(e);
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Action<TException> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                action(e);
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<ValueTask> action)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await action();
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<Exception, ValueTask> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<TException, ValueTask> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<Task> action)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await action();
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await action();
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<Exception, Task> action)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await action(e);
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<TException, Task> action) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await action(e);
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<T> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                return action();
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<T> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return action();
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Exception, T> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return action(e);
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<TException, T> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return action(e);
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<ValueTask<T>> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await action();
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<ValueTask<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await action();
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Exception, ValueTask<T>> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await action(e);
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<TException, ValueTask<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await action(e);
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Task<T>> action)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await action();
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<Task<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await action();
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Exception, Task<T>> action)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await action(e);
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<TException, Task<T>> action) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await action(e);
            }
        }
    }
}