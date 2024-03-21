using Varios.Estados;

namespace Varios;

internal interface IEstado
{
    void Acreditar(Cliente cliente, double Monto);

    void Debitar(Cliente cliente, double Monto);

    internal void ValidarUso(Cliente cliente)
    {

        if (cliente.Saldo < 10000)
        {
            
        }
        if (cliente.Saldo >10000 && cliente.Saldo<50000)
        {
            
        }
        if (cliente.Saldo>50000)
        {
            
        }


    }

}
