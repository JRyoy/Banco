namespace Varios.Estados;

internal class Cauto : IEstado
{
    public void Acreditar(Cliente cliente, double Monto)
    {
        cliente.Saldo += Monto*0.8;
        cliente.cuenta.SaldoCuenta += Monto * 0.2;
    }

    public void Debitar(Cliente cliente, double Monto)
    {
        if(cliente.cuenta.SaldoCuenta > Monto)
        {
            cliente.Saldo -= Monto*0.8 ;
            cliente.cuenta.SaldoCuenta-=Monto*0.8;
        }
    }

}
