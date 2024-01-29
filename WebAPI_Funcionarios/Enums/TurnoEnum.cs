using System.Text.Json.Serialization;

namespace WebAPI_Funcionarios.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manha = 1,
        Tarde  = 2,
        Noite = 3
    }
}
