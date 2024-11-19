using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace openapi_demo.Controllers
{
    public class CookieValueProviderFactory : IValueProviderFactory
    {
        public Task CreateValueProviderAsync(ValueProviderFactoryContext context)
        {
            context.ValueProviders.Add(new CookieValueProvider(FromCookieAttribute.bindingSource, context.ActionContext));
            return Task.CompletedTask;
        }
    }
}
