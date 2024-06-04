using System.Text.Json.Serialization;

namespace WebAPI_C_.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
