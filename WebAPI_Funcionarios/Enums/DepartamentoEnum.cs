using System.Text.Json.Serialization;

namespace WebAPI_Funcionarios.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH = 1, 
        Financeiro = 2,
        Compras = 3,
        Atendimento = 4,
        Zeladoria = 5,

    }
}
