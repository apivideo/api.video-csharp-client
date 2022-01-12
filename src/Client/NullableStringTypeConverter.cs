using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using ApiVideo.Model;

namespace ApiVideo.Client
{
    class NullableStringTypeConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(OptionalNullable<string>);
        }
        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            OptionalNullable<string> nullable = (OptionalNullable<string>)value;

            if (nullable.isDefined)
            {
                writer.WriteValue(nullable.value);
            }
        }
    }
}
