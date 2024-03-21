using Varios;

namespace VariosEstados;

internal class Emergencia : IEstado
{
    public bool ValidarUso(Cliente cliente) => cliente.Saldo < 10000;
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.AcreditarEfectivo(monto);
    }

    public void Debitar(Cliente cliente, double monto)
    {
        if(cliente.Cuenta.SaldoCuenta > monto)
        {
            cliente.Cuenta.Debitar(monto);
        }
        else
            cliente.DebitarEfectivo(monto);
    }
        
        

    
}
