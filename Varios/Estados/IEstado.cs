using Varios;

namespace VariosEstados;

internal interface IEstado
{
    void Acreditar(Cliente cliente, double monto);

    void Debitar(Cliente cliente, double monto);

    bool ValidarUso(Cliente cliente);

}
