using System;
using System.Collections.Generic;
using System.Text;

namespace MRCryptocompareClient.Infrastructure.Response
{
    public class ListResponse<T> : BaseResponse
        where T : class
    {
        public List<T> Data { get; set; }
    }
}
