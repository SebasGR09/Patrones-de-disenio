# Práctica: fábrica de notificaciones en C#

**Situación:** Estás desarrollando un sistema que puede enviar notificaciones por correo electrónico o SMS. Queremos que una fábrica cree la notificación adecuada según el tipo solicitado.

Tu reto
Crea estas piezas:

**1. Interfaz INotification**

Debe tener el método: void Send();


**2. Dos implementaciones**

- EmailNotification: imprime Correo enviado.
- SMSNotification: imprime SMS enviado.



**3. Clase NotificationFactory - IMPORTANTE**

Debe tener un método: **public INotification Create(string type)**


**Este método debe devolver:**
- EmailNotification si type es "email".
- SMSNotification si type es "sms".
- Lanzar una ArgumentException si recibe un tipo desconocido.


**4. Prueba en Main**

Usa la fábrica para crear una notificación por correo y otra por SMS, y ejecuta Send() en ambas.

El resultado esperado:
- Correo enviado
- SMS enviado