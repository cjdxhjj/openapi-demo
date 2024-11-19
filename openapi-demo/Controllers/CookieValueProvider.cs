using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace openapi_demo.Controllers
{
    public class CookieValueProvider : BindingSourceValueProvider
    {
        private readonly IRequestCookieCollection _cookies;
        public CookieValueProvider(BindingSource bindingSource, ActionContext context) : base(bindingSource)
        {
            _cookies = context.HttpContext.Request.Cookies;
        }

        public override bool ContainsPrefix(string prefix)
        {
            return _cookies.ContainsKey(prefix);
        }

        public override ValueProviderResult GetValue(string key)
        {
            return _cookies.TryGetValue(key, out var value) ? new ValueProviderResult(value) : ValueProviderResult.None;
        }
    }
}
