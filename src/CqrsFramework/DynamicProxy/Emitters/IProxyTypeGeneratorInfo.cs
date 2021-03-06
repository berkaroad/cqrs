using System;
using System.Reflection.Emit;

namespace CqrsFramework.DynamicProxy.Emitters
{
    public interface IProxyTypeGeneratorInfo
    {
        Type ProxiedType { get; }

        TypeBuilder Builder { get; }

        ProxyTypeGenerateWay Way { get; }

        FieldBuilder GetField(string fieldName);

        void AddField(FieldBuilder field);
    }
}