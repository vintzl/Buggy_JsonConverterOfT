using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Buggy_JsonConverterOfT
{
    internal class CustomJsonConverter<T> : JsonConverter<T>
    {
        public CustomJsonConverter()
        {
        }
        public override bool CanConvert(Type typeToConvert)
        {
            return true;
        }
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}