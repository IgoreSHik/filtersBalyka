using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filtersBalyka.Utils
{
    public class CustomFilterAttributes : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            int a = 0;
            var result = context.Result;
            if (result is PageResult)
            {
                var page = ((PageResult)result);
                page.ViewData["filterMessage"] = "Komunikat z CustomFilterAttributes!!!";
            }
        }
    }
}