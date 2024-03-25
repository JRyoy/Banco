using Varios;

namespace VariosEstados;

internal class Ahorrista : IEstado
{
    public bool ValidarUso(Cliente cliente) => cliente.Saldo > 50000;
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.AcreditarEfectivo(monto*0.5);
        cliente.Cuenta.Acreditar(monto *0.5);
    }

    public void Debitar(Cliente cliente, double monto)
    {
        if (cliente.Saldo > monto)
            cliente.DebitarEfectivo(monto);
        else
            cliente.Cuenta.Debitar(monto);
    }

}
