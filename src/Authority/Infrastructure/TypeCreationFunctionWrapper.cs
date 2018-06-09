using System;

namespace Authority.Infrastructure
{
    public class TypeCreationFunctionWrapper : IActivateTypes
    {
        private readonly Func<Type, object> _creator;
        public TypeCreationFunctionWrapper(Func<Type,object> creator) => _creator = creator;
        public object CreateType(Type t) => _creator(t);
    }
}