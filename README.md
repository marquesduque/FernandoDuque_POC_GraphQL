# ASP.NET Core GraphQL Example

```
> ./run.sh
> browse to http://localhost:3000/ui/playground
```

#LISTAR CLIENTE
query{
  cliente_by_id(id:"1"){
    id,
    nome,
    saldo
  }
}
#Sacar
mutation  {
  sacar(cliente: { id: "1", saldo: 1}) {
    id,
    nome,
    saldo
  }
}

#Depositar
mutation  {
  depositar(cliente: { id: "1", saldo: 1}) {
    id,
    nome,
    saldo
  }
}
