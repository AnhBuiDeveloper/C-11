﻿using GenericAttributes.Current;
using GenericAttributes.Entities;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace GenericAttributes.New
{
    internal class GenericUniqueAttribute<TDataContext, TEntity> : ValidationAttribute
        where TDataContext : DataContext
        where TEntity : Entity
    {
        public Type DataContextType { get; private set; }
        public Type EntityType { get; private set; }
        public string PropertyName { get; private set; }

        public GenericUniqueAttribute(string propertyName)
        {
            DataContextType = typeof(TDataContext);
            EntityType = typeof(TEntity);
            PropertyName = propertyName;
        }

        public override bool IsValid(object? value)
        {
            var stringValue = value as string;
            if (string.IsNullOrWhiteSpace(stringValue))
                return true;

            var allItem = DataContextType.InvokeMember("GetAll",
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance,
                null, null, null) as object[];

            return allItem is [.. var items] && items.Any(x => EntityType?.GetProperty(PropertyName)?.GetValue(x, null) as string == stringValue);
        }
    }
}
