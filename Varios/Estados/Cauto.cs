using Varios;

namespace VariosEstados;

internal class Cauto : IEstado
{
    bool IEstado.ValidarUso(Cliente cliente)=>cliente.Saldo >10000 && cliente.Saldo<50000;
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.AcreditarEfectivo(monto *0.8);
        cliente.Cuenta.Acreditar(monto*0.2);
    }

    public void Debitar(Cliente cliente, double monto)
    {
        if(cliente.Cuenta.SaldoCuenta > monto)
        {
            cliente.DebitarEfectivo(monto*0.8);
            cliente.Cuenta.Debitar(monto*0.2);
        }
    }

}
