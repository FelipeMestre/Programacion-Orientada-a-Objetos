# Universidad Católica del Uruguay
## Facultad de Ingeniería y Tecnologías
### Programación II
Código de ejemplo del tema "Creator y OCP"

### Objetivo
Crear una lista de contactos capaz de enviar mensajes por diferentes canales tales como correo electrónico, mensajes SMS y WhatsApp; para el envío de mensajes los canales usan las API provistas.
* https://github.com/fmachadopiriz/WhatsAppApiUCU
* https://github.com/fmachadopiriz/MailSenderApiUCU

### Tarjetas CRC

|Contact	||
|:---|:---|
|Conocer el nombre||
|Conocer el teléfono||
|Conocer el correo electrónico||

Se provee la clase [Contact](https://github.com/ucudal/PII_Phonebook_Start/blob/master/src/Library/Contact.cs)

|Phonebook||
|:---|:---|
|Conocer el dueño|Contact|
|Conocer los contactos en la lista|MessageChannel|
|Agregar contactos a la lista||
|Quitar contactos de la lista||
|Buscar contactos dados sus nombres||
|Enviar un mensaje a contactos dados sus nombres a través de un canal||


Se provee una implementación parcial de la clase [Phonebook](https://github.com/ucudal/PII_Phonebook_Start/blob/master/src/Library/Phonebook.cs) con el constructor y firma del método `Search` -que implementa la responsabilidad de buscar contactos dados sus nombres-; los mensajes a los contactos se envían usando el resultado de ese método `Search`

|Message	||
|:---|:---|
|Conocer el texto del mensaje||
|Conocer la dirección del remitente||
|Conocer la dirección del destinatario||

Se provee la clase [Message](https://github.com/ucudal/PII_Phonebook_Start/blob/master/src/Library/Message.cs)

|<Interface>IMessageChannel||
|:---|:---|
|Enviar un mensaje||
|...||

Se provee una implementación **parcial** de la interfaz [IMessageChannel](https://github.com/ucudal/PII_Phonebook_Start/blob/master/src/Library/IMessageChannel.cs) con el método `Send`. Tengan en cuenta para completar la implementación que para enviar un mensaje por diferentes canales la información necesaria del remitente y del destinatario son diferentes; por ejemplo, para enviar por mail se usa el email y para WhatsApp o SMS se usa el teléfono.

Faltan varias clases cuyas tarjetas o implementaciones no son provistas.
