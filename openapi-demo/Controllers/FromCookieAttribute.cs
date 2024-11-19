using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace openapi_demo.Controllers
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FromCookieAttribute : Attribute, IBindingSourceMetadata, IModelNameProvider
    {
        public static readonly BindingSource bindingSource = new BindingSource("Cookie", "Cookie", false, true);

        public FromCookieAttribute(string name)
        {
            Name = name;
        }

        public BindingSource BindingSource => bindingSource;

        public string Name { get; init; }
    }
}
