using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Kwtc.Steam.Client.Models.Details;

namespace Kwtc.Steam.Client.Converters;

public class SteamAppRequirementsConverter : JsonConverter<SteamAppRequirementsModel?>
{
    public override SteamAppRequirementsModel? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.StartArray)
        {
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    return null;
                }
            }
        }

        if (reader.TokenType == JsonTokenType.StartObject)
        {
            return JsonSerializer.Deserialize<SteamAppRequirementsModel>(ref reader, options);
        }

        throw new ArgumentOutOfRangeException(nameof(reader));
    }

    public override void Write(Utf8JsonWriter writer, SteamAppRequirementsModel? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        JsonSerializer.Serialize(writer, value, options);
    }
}