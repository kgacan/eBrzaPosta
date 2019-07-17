using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.Helper
{
    public class Enums
    {
        public enum Status
        {
            [Description("Kreirana")]
            Kreirana = 1,
            [Description("Preuzeta")]
            Preuzeta = 2,
            [Description("U Tranzitu")]
            UTranzitu = 3,
            [Description("Dostavljena")]
            Dostavljena = 4
        }

        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "description");
            // or return default(T);
        }
    }
}
