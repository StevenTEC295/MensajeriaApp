# MensajeriaApp
### Descripción
Esta es una aplicación desarrollada en C# y Windows Forms para la interactividad con la interfaz. La aplicación fue realizada como solución al problema planteado en la tarea de Algoritmos Y Estructuras de Datos 1. La cual busca que el estudiante desarrolle una aplicación de mensajería instantánea similar a Whatsapp. Mediante sockets y números de puerto. 
### Solución
Se desarrollaron 2 clases importantes que simulen un Servidor (listener) de la aplicación encargado de recibir la información entrante y aceptar solicitudes de otros sockets.
La segunda clase es la Cliente que se encarga de iniciar la conexión y enviar los mensajes nuevos al servidor del puerto escogido.

Por medio de la interfaz mostramos los mensajes en un TextBox, y por texto indicamos el puerto listener y destino.

### Cómo ejecutar?

Puede clonar este repositorio y dar click en el archivo .exe de la aplicación. Este inmediatamente ejecutará el programa

También puede solo descargar este archivo
![image](https://github.com/user-attachments/assets/ec112ea8-8db8-4d41-86e2-747a4ee75ba0)

Otra forma es abriendo la terminal en la carpeta del proyecto. y ejecutar el comando "dotnet run". debe tener instalado .Net para hacerlo de esta manera
![image](https://github.com/user-attachments/assets/38c7316d-f0ff-406a-96b7-228fc3fa5640)

También podría abrir la terminal en la carpeta donde se encuentre el .exe, y escribir NombreArchivo.exe en la terminal y este se ejecutará
![image](https://github.com/user-attachments/assets/93e43801-1012-4207-a2e5-e4075d614fa2)

(Cabe destacar que esta versión solo está optimizada para una conexión por instancia), debe ejecutar el programa 2 veces mínimo para realizar una conexión entre 2 instancias.

### Cómo usar el programa
#### -Ejecutar al menos 2 instancias del programa
![image](https://github.com/user-attachments/assets/779304b4-1f81-4ec0-8015-a15c921c81ae)

#### -Escribir el puerto listener y pulsar Iniciar
![image](https://github.com/user-attachments/assets/576a4185-38b6-4605-b747-8ecd004f88d2)

#### -Escribir el mensaje deseado, luego el puerto de destino y pulsar Enviar
![image](https://github.com/user-attachments/assets/980e758b-f979-490f-a07d-70c884f3c785)

#### -En este punto ya puede enviar los mensajes que guste
![image](https://github.com/user-attachments/assets/dc3eb115-d6fc-43c3-b502-de96c5c9bf6e)



