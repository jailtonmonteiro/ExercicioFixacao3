Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, nome do titular da conta, e o valor de deposito inicial que o titular depositou ao abrir a conta. Este valor de deposito inicial, entretanto, é opcional, ou seja: se o titular não tiver o dinheiro a depositar no momento de abrir sua conta, o deposito não será feito e o saldo incial da conta será, naturalmente, zero.

Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado(pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).

Por fim o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado o banco cobra uma taxa de R$ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para pagar a taxa.

Voce deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de  deposito inicial. Em seguida realizar um deposito e depois um saque, sempre mostrando os dados da conta a cada operação.

CLASSES

		Account

	- _nome: string
	- Number: int
	- Balance: double

	+ Deposit(): void
	+ Withdraw(): void
	+ printData(): void

USO DE:

* CLASSES
* ATRIBUTOS
* METODOS
* MODIFICADORES DE ACESSO
* CONTRUTORES
* ENCAPSULAMENTO
