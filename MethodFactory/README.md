# Práctica: fábrica de documentos

Vamos a cambiar de contexto para que practiques el patrón sin copiar el ejemplo de notificaciones.
**Situación: **Una aplicación puede crear documentos PDF o Word. Cada documento tiene un método Open() que muestra un mensaje.

Tu reto en C#
**1. Crea la interfaz IDocument**

- Debe declarar: *void Open();*


**2. Crea dos implementaciones**
- PdfDocument: Open() muestra Abriendo documento PDF.
- WordDocument: Open() muestra Abriendo documento Word.


**3. Crea una fábrica abstracta**

Llamada DocumentFactory, con este método:
*public abstract IDocument Create();*


**4. Crea dos fábricas concretas**
- PdfDocumentFactory, que devuelve new PdfDocument().
- WordDocumentFactory, que devuelve new WordDocument().

**5. Prueba el patrón en Main**

Crea una fábrica PDF, utiliza Create() para obtener el documento y llama a Open(). Después, repite el proceso con Word.

*Resultado esperado:*
Abriendo documento PDF
Abriendo documento Word