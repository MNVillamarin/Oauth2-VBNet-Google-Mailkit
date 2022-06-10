***Tutorial OAuth Gmail***

> **[Registrar la aplicación en Google Devs:]{.underline}**
>
> Ir a
> [[https://console.cloud.google.com/]{.underline}](https://console.cloud.google.com/)
>
> Crear un proyecto Nuevo:
>
> ![](./imagesTutorial/media/image2.png){width="5.094242125984252in"
> height="2.76713801399825in"}
>
> ![](./imagesTutorial/media/image1.png){width="4.458825459317585in"
> height="3.6387204724409448in"}
>
> Con el proyecto ya creado, en el menú izquierdo nos dirigimos a: **API
> y Servicios -\> Credenciales.**
>
> ![](./imagesTutorial/media/image13.png){width="3.9345199037620295in"
> height="3.8053947944007in"}
>
> Seleccionamos el proyecto creado:
>
> ![](./imagesTutorial/media/image4.png){width="5.946673228346457in"
> height="3.643839676290464in"}
>
> Vamos a Pantalla de consentimiento y configuramos el UserType como
> **Externos** y le damos a CREAR.
>
> ![](./imagesTutorial/media/image18.png){width="6.003964348206474in"
> height="4.089050743657043in"}
>
> En las siguientes pantallas se rellenan los campos necesarios:
>
> ![](./imagesTutorial/media/image17.png){width="5.253964348206474in"
> height="4.792961504811898in"}
>
> ![](./imagesTutorial/media/image9.png){width="5.378964348206474in"
> height="4.884518810148731in"}
>
> Le damos a GUARDAR Y CONTINUAR, nos envía a una pantalla de permisos,
> le damos nuevamente GUARDAR Y CONTINUAR sin modificar nada.
>
> ![](./imagesTutorial/media/image12.png){width="4.270611329833771in"
> height="4.711554024496938in"}
>
> En la siguiente pantalla agregaremos los usuarios de prueba (el / los
> usuarios que conectaran con Gmail) ya que el estado de la aplicación
> será de "Prueba" todavia:
>
> ![](./imagesTutorial/media/image11.png){width="6.530757874015748in"
> height="2.474047462817148in"}
>
> Le damos GUARDAR Y CONTINUAR luego de agregar los usuarios, nos
> enviara a un resumen de lo configurado:
>
> ![](./imagesTutorial/media/image5.png){width="5.947424540682415in"
> height="5.044542869641295in"}
>
> Bien, ahora crearemos las credenciales, para ello vamos a: Crear
> credenciales -\> ID cliente de OAuth
>
> ![](./imagesTutorial/media/image14.png){width="6.2529800962379705in"
> height="3.100363079615048in"}
>
> Elegimos el tipo de aplicación y le damos crear:
>
> ![](./imagesTutorial/media/image8.png){width="6.016868985126859in"
> height="3.586656824146982in"}
>
> Se generarán las claves, las copiamos y guardamos para luego
> utilizarlas en el codigo:
>
> ![](./imagesTutorial/media/image15.png){width="5.9613134295713035in"
> height="3.6531725721784776in"}
>
> Bien, a esta altura deberíamos tener 3 datos que utilizaremos
> próximamente:

-   **El / Los usuarios autorizados que conectaran desde nuestra app con
    > Gmail.**

-   **El KEY ID de cliente.**

-   **El KEY Secreto de cliente.**

> **[Cargar estos codigos en el codigo de la aplicación:]{.underline}**
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
> ![](./imagesTutorial/media/image7.png){width="7.480314960629921in"
> height="4.527777777777778in"}
>
> Al ejecutar la aplicación, seremos enviados a la web de Gmail para
> loguearnos con la cuenta autorizada y permitir el acceso a la misma
> desde nuestra aplicación:
>
> ![](./imagesTutorial/media/image3.png){width="3.373669072615923in"
> height="3.7964785651793527in"}
>
> Luego de loguearnos nos avisara que la APP esta en prueba:
>
> ![](./imagesTutorial/media/image6.png){width="3.3772287839020123in"
> height="3.840325896762905in"}
>
> Le damos continuar y nos pedira permisos sobre la casilla para poder
> enviar, recibir, etc:
>
> ![](./imagesTutorial/media/image10.png){width="2.581515748031496in"
> height="4.032081146106736in"}
>
> Luego de continuar, nos avisara que la aplicación recibe el Token
> correctamente:
>
> ![](./imagesTutorial/media/image16.png){width="4.458825459317585in"
> height="0.6192814960629921in"}
>
> Ya podemos cerrar el navegador, nuestra APP se encuentra conectada con
> Gmail.
