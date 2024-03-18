using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public static class Utils
    {
        public struct Result
        {
            public readonly bool Success => e == null;
            public readonly bool Failure => e != null;
            public Exception? e;
            public readonly void Catch(Action<Exception> catcher)
            {
                if (e != null)
                    catcher(e);
            }
        }

        public static Result Try(Action task)
        {
            try
            {
                task();
            }
            catch (Exception ex)
            {
                return new Result { e = ex };
            }
            return new Result();
        }

    }
}
