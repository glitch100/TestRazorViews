using Microsoft.AspNetCore.Mvc.Razor;

namespace TestRazorWeb.Platform
{
    public abstract class BasicView<T> : RazorPage<T>
    {
        public IHardDependency Dep { get; }
    }
}
