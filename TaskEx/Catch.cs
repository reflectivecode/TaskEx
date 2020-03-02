﻿using System;
using System.Threading.Tasks;

namespace ReflectiveCode.TaskEx
{
    public static partial class TaskEx
    {
        public static async Task Catch(this Task task, Action onFailure)
        {
            try
            {
                await task;
            }
            catch
            {
                onFailure();
            }
        }

        public static async Task Catch<TException>(this Task task, Action onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                onFailure();
            }
        }

        public static async Task Catch(this Task task, Action<Exception> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                onFailure(e);
            }
        }

        public static async Task Catch<TException>(this Task task, Action<TException> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                onFailure(e);
            }
        }

        public static async Task Catch(this Task task, Func<Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await onFailure();
            }
        }

        public static async Task Catch<TException>(this Task task, Func<Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await onFailure();
            }
        }

        public static async Task Catch(this Task task, Func<Exception, Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
            }
        }

        public static async Task Catch<TException>(this Task task, Func<TException, Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e);
            }
        }

        public static async Task Catch(this Task task, Func<ValueTask> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await onFailure();
            }
        }

        public static async Task Catch<TException>(this Task task, Func<ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await onFailure();
            }
        }

        public static async Task Catch(this Task task, Func<Exception, ValueTask> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
            }
        }

        public static async Task Catch<TException>(this Task task, Func<TException, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e);
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<T> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                return onFailure();
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<T> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return onFailure();
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Exception, T> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return onFailure(e);
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<TException, T> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return onFailure(e);
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Task<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await onFailure();
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<Task<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await onFailure();
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Exception, Task<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await onFailure(e);
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<TException, Task<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await onFailure(e);
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<ValueTask<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await onFailure();
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<ValueTask<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await onFailure();
            }
        }

        public static async Task<T> Catch<T>(this Task<T> task, Func<Exception, ValueTask<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await onFailure(e);
            }
        }

        public static async Task<T> Catch<T, TException>(this Task<T> task, Func<TException, ValueTask<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await onFailure(e);
            }
        }

        public static async ValueTask Catch(this ValueTask task, Action onFailure)
        {
            try
            {
                await task;
            }
            catch
            {
                onFailure();
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Action onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                onFailure();
            }
        }

        public static async ValueTask Catch(this ValueTask task, Action<Exception> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                onFailure(e);
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Action<TException> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                onFailure(e);
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<ValueTask> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await onFailure();
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await onFailure();
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<Exception, ValueTask> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<TException, ValueTask> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e);
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
                await onFailure();
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException)
            {
                await onFailure();
            }
        }

        public static async ValueTask Catch(this ValueTask task, Func<Exception, Task> onFailure)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                await onFailure(e);
            }
        }

        public static async ValueTask Catch<TException>(this ValueTask task, Func<TException, Task> onFailure) where TException : Exception
        {
            try
            {
                await task;
            }
            catch (TException e)
            {
                await onFailure(e);
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<T> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                return onFailure();
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<T> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return onFailure();
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Exception, T> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return onFailure(e);
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<TException, T> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return onFailure(e);
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<ValueTask<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await onFailure();
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<ValueTask<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await onFailure();
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Exception, ValueTask<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await onFailure(e);
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<TException, ValueTask<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await onFailure(e);
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Task<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch
            {
                return await onFailure();
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<Task<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException)
            {
                return await onFailure();
            }
        }

        public static async ValueTask<T> Catch<T>(this ValueTask<T> task, Func<Exception, Task<T>> onFailure)
        {
            try
            {
                return await task;
            }
            catch (Exception e)
            {
                return await onFailure(e);
            }
        }

        public static async ValueTask<T> Catch<T, TException>(this ValueTask<T> task, Func<TException, Task<T>> onFailure) where TException : Exception
        {
            try
            {
                return await task;
            }
            catch (TException e)
            {
                return await onFailure(e);
            }
        }
    }
}