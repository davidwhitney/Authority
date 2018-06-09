using System;

namespace Authority.Infrastructure
{
    public interface IActivateTypes
    {
        object CreateType(Type t);
    }
}