# Práctica: sistema de métodos de pago - STRATEGY 

Vamos a implementar Strategy con un ejemplo diferente para comprobar que comprendes el patrón y no solo el ejemplo de los descuentos.
Situación. 

Una tienda permite pagar de distintas formas:
- Tarjeta de crédito.
- PayPal.
- Transferencia bancaria.
- 
Todos los métodos realizan un pago, pero cada uno tiene su propia lógica.

Tu reto en C#
Crea las siguientes piezas:

1. Interfaz IPaymentStrategy

Debe declarar este método:
void Pay(double amount);


2. Tres estrategias
- CreditCardPayment: muestra Pago de {amount} realizado con tarjeta de crédito.
- PayPalPayment: muestra Pago de {amount} realizado con PayPal.
- BankTransferPayment: muestra Pago de {amount} realizado mediante transferencia bancaria.
3. Clase PaymentService

Debe:
- Recibir una estrategia IPaymentStrategy mediante el constructor.
- Guardarla en un campo readonly.
- Tener un método ProcessPayment(double amount) que delegue el pago a la estrategia recibida.


4. Prueba
En tu Main, crea un PaymentService con PayPalPayment y procesa un pago de 150.

El resultado esperado será: Pago de 150 realizado con PayPal