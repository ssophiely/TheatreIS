using Google.Protobuf.WellKnownTypes;
using System.Reflection;

namespace SharedUtils;

public static class Mapper
{
    public static T1 Convert<T1, T2>(this T2 inObj)
        where T1 : class, new()
        where T2 : class, new()
    {
        T1 outObj = new();

        PropertyInfo[] inProperties = inObj.GetType().GetProperties();
        PropertyInfo[] outProperties = outObj.GetType().GetProperties();

        foreach (var prop in inProperties)
        {
            var value = prop.GetValue(inObj);

            if (value != null && !Equals(value, Activator.CreateInstance(prop.PropertyType)))
            {
                var outProp = outProperties.First(p => p.Name == prop.Name);
                outProp.SetValue(outObj, value);
            }
        }

        return outObj;
    }

    public static void UpdateObject<T1, T2>(this T1 obj, T2 updProps)
    where T1 : class, new()
    where T2 : class, new()
    {
        PropertyInfo[] updProperties = updProps.GetType().GetProperties();
        PropertyInfo[] properties = obj.GetType().GetProperties();

        foreach (var prop in updProperties)
        {
            var value = prop.GetValue(updProps);

            if (value != null && !Equals(value, Activator.CreateInstance(prop.PropertyType)))
            {
                var objProp = properties.First(p => p.Name == prop.Name);
                objProp.SetValue(obj, value);
            }
        }
    }
}
