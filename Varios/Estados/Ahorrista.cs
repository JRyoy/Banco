namespace Varios.Estados;

internal class Ahorrista : IEstado
{
    public void Acreditar(Cliente cliente, double Monto)
    {
        cliente.Saldo += Monto*0.5;
        cliente.cuenta.SaldoCuenta += Monto * 0.5;
    }

    public void Debitar(Cliente cliente, double Monto)
    {
        if(cliente.Saldo > Monto){cliente.Saldo-=Monto;}
        else
            cliente.cuenta.SaldoCuenta-=Monto;
    }

}
