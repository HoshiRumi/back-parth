using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDomain.mModels.mBase
{
    public class ResponseMsg<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }

        public static ResponseMsg<T> Ok(T data, string msg = "Success") =>
            new() { Success = true, Data = data, Message = msg };

        public static ResponseMsg<T> Fail(string msg) =>
            new() { Success = false, Message = msg };
    }
}