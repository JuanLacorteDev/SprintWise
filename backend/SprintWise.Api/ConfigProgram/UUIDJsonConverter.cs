using MiNET.Utils;
using System.Text.Json;
using System.Text.Json.Serialization;

public class UUIDJsonConverter : JsonConverter<UUID>
{
    public override UUID Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new UUID(reader.GetString());
    }

    public override void Write(Utf8JsonWriter writer, UUID value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}
