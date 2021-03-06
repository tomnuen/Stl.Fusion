using System;

namespace Stl.DependencyInjection
{
    [Serializable]
    public abstract class ServiceImplementationAttributeBase : ServiceAttributeBase
    {
        public Type? ServiceType { get; set; }

        public ServiceImplementationAttributeBase(Type? serviceType = null)
            => ServiceType = serviceType;
    }
}
