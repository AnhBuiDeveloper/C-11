//using GenericAttributes.Entities;
//using System.ComponentModel.DataAnnotations;
//using System.Linq.Expressions;
//using System.Reflection;

//namespace GenericAttributes.New
//{
//    internal class GenericUniqueAttribute<> : ValidationAttribute
//    {
//        public Type DataContextType { get; private set; }
//        public Type EntityType { get; private set; }
//        public string PropertyName { get; private set; }

//        public NonGenericUniqueAttribute(Type dataContextType, Type entityType, string propertyName)
//        {
//            DataContextType = dataContextType;
//            EntityType = entityType;
//            PropertyName = propertyName;
//        }

//        public override bool IsValid(object? value)
//        {
//            var stringValue = value as string;
//            if (string.IsNullOrWhiteSpace(stringValue))
//                return true;

//            var allItem = DataContextType.InvokeMember("GetAll",
//                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance, 
//                null, null, null) as object[];

//            return allItem is [.. var items] && items.Any(x => EntityType?.GetProperty(PropertyName)?.GetValue(x, null) as string == stringValue);
//        }
//    }
//}
