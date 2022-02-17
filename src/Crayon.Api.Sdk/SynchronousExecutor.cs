using System;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk
{
    public static class SynchronousExecutor 
    {
        /// <summary>
        /// Executes an asynchronous method synchronously in a way that prevents deadlocks in UI applications.
        /// </summary>
        internal static T SynchronousExecute<T>(Func<Task<T>> operation)
        {
            try
            {
                return Task.Run(async () => await operation()).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerException != null)
                {
                    throw ex.InnerException;
                }

                throw;
            }
        }
    }
}