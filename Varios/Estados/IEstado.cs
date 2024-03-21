using Varios;

namespace VariosEstados;

internal interface IEstado
{
    void Acreditar(Cliente cliente, double Monto);

    void Debitar(Cliente cliente, double Monto);

    bool ValidarUso(Cliente cliente);

}
