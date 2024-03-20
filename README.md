# Banco
```mermaid
classDiagram

class Cuenta{
    +Cbu:int
    +SaldoCuenta:double 
    +cliente:Clienta
    +Acreditar(double Monto)
    +Debitar(double Monto)
}
Cliente *-- Cuenta
class Cliente{

    +Nombre:string
    +Apellido:string
    +Saldo:double
    +cuenta:Cuenta
    +Acreditar(double Monto)
    +Debitar(double Monto)

}
Cliente --> IEstrategia

class  IEstrategia{
    <Interface>

    +Acreditar(Cliente cliente,double Monto)
    +Debitar(Cliente cliente,double Monto)
}
Cauto..|>IEstrategia
Emergencia..|>IEstrategia
ahorrista..|>IEstrategia
class Cauto{
    +Cliente:cliente
    +Monto:double

}
class Emergencia{
    +Cliente:cliente
    +Monto:double
}
class ahorrista{
    +Cliente:cliente
    +Monto:double

}



```