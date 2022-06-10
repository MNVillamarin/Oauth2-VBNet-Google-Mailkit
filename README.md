***Tutorial OAuth Gmail***

> **Registrar la aplicación en Google Devs:**
>
> Ir a
> [https://console.cloud.google.com/](https://console.cloud.google.com/)
>
> Crear un proyecto Nuevo:
>
> ![](./imagesTutorial/media/image2.png)
>
> ![](./imagesTutorial/media/image1.png)
>
> Con el proyecto ya creado, en el menú izquierdo nos dirigimos a: **API
> y Servicios -\> Credenciales.**
>
> ![](./imagesTutorial/media/image13.png)
>
> Seleccionamos el proyecto creado:
>
> ![](./imagesTutorial/media/image4.png)
>
> Vamos a Pantalla de consentimiento y configuramos el UserType como
> **Externos** y le damos a CREAR.
>
> ![](./imagesTutorial/media/image18.png)
> 
> En las siguientes pantallas se rellenan los campos necesarios:
>
> ![](./imagesTutorial/media/image17.png)
>
> ![](./imagesTutorial/media/image9.png)
>
> Le damos a GUARDAR Y CONTINUAR, nos envía a una pantalla de permisos,
> le damos nuevamente GUARDAR Y CONTINUAR sin modificar nada.
>
> ![](./imagesTutorial/media/image12.png)
>
> En la siguiente pantalla agregaremos los usuarios de prueba (el / los
> usuarios que conectaran con Gmail) ya que el estado de la aplicación
> será de "Prueba" todavia:
>
> ![](./imagesTutorial/media/image11.png)
>
> Le damos GUARDAR Y CONTINUAR luego de agregar los usuarios, nos
> enviara a un resumen de lo configurado:
>
> ![](./imagesTutorial/media/image5.png)
>
> Bien, ahora crearemos las credenciales, para ello vamos a: Crear
> credenciales -\> ID cliente de OAuth
>
> ![](./imagesTutorial/media/image14.png)
>
> Elegimos el tipo de aplicación y le damos crear:
>
> ![](./imagesTutorial/media/image8.png)
>
> Se generarán las claves, las copiamos y guardamos para luego
> utilizarlas en el codigo:
>
> ![](./imagesTutorial/media/image15.png)
>
> Bien, a esta altura deberíamos tener 3 datos que utilizaremos
> próximamente:

-   **El / Los usuarios autorizados que conectaran desde nuestra app con
    > Gmail.**

-   **El KEY ID de cliente.**

-   **El KEY Secreto de cliente.**

> **[Cargar estos codigos en el codigo de la aplicación:]**
>
> En la Clase Mail.vb\
> \
> Debemos cargar la cuenta de Gmail autorizada en el campo "
> GmailAccount "
>
> La KEY ID de cliente en el campo " ClientId "
>
> y El KEY Secreto de cliente en el campo "ClientSecret"
>
> ![](./imagesTutorial/media/image7.png)
>
> Al ejecutar la aplicación, seremos enviados a la web de Gmail para
> loguearnos con la cuenta autorizada y permitir el acceso a la misma
> desde nuestra aplicación:
>
> ![](./imagesTutorial/media/image3.png)
>
> Luego de loguearnos nos avisara que la APP esta en prueba:
>
> ![](./imagesTutorial/media/image6.png)
>
> Le damos continuar y nos pedira permisos sobre la casilla para poder
> enviar, recibir, etc:
>
> ![](./imagesTutorial/media/image10.png)
>
> Luego de continuar, nos avisara que la aplicación recibe el Token
> correctamente:
>
> ![](./imagesTutorial/media/image16.png)
>
> Ya podemos cerrar el navegador, nuestra APP se encuentra conectada con
> Gmail.
