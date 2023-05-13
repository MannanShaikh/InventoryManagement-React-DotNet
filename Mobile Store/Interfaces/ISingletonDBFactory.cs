using Microsoft.Extensions.Configuration;

namespace Mobile_Store.Interfaces
{
    public interface ISingletonDBFactory
    {
        public string DbInstance();
    }
}
