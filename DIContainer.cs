using System;
namespace Щур_В_О_КПО_1;

public class DIContainer
{
    private readonly Dictionary<Type, object> _instances = new Dictionary<Type, object>();

    public void Register<T>(T instance)
    {
        _instances[typeof(T)] = instance;
    }

    public T Resolve<T>()
    {
        if (_instances.TryGetValue(typeof(T), out var instance))
        {
            return (T)instance;
        }
        throw new InvalidOperationException($"Тип {typeof(T)} не зарегистрирован в контейнере :(");
    }
}