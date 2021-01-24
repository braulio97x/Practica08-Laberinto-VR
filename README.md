# Practica08-Laberinto-VR
||**VICERRECTORADO DOCENTE**|**Código:** GUIA-PRL-001|
| :- | :-: | :- |
||CONSEJO ACADÉMICO|**Aprobación:** 2016/04/06|
|**Formato:** Guía de Práctica de Laboratorio / Talleres / Centros de Simulación|

![](infoJuego.002.jpeg)


|<p></p><p>**PRÁCTICA DE LABORATORIO**</p>|
| - |
|**CARRERA**: COMPUTACION|**ASIGNATURA**: HIPERMEDIAL|
|**NRO. PRÁCTICA**:|8|**TÍTULO PRÁCTICA**: Desarrollo de una aplicación de realidad virtual usando la herramienta Unity y desplegada en un dispositivo móvil Android.|
|<p></p><p>**OBJETIVO**</p><p></p><p>- Experimenta con aplicaciones de realidad virtual.</p><p>- Experimenta con aplicaciones de realidad aumentada.</p><p>- Distingue la diferencia entre tecnologías de realidad virtual y realidad aumentada.</p>|
|<p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p>**INSTRUCCIONES**</p>|<p>Este proyecto es una oportunidad para que combine y practique todo lo que aprendió en el capítulo de Realidad Virtual. Creará una experiencia de realidad virtual totalmente interactiva en forma de laberinto.</p><p></p><p>Esto le brinda la oportunidad de aplicar lo que ha aprendido con las secuencias de comandos para brindar una experiencia audiovisual completa.</p><p></p><p>***Crear la GVR Camera Rig***</p><p></p><p>Durante este paso, crearemos la cámara VR incluyendo el GvrEditorEmulator en la escena y configurando la cámara.</p><p></p><p>1. Agregue el objeto prefab GvrEditorEmulator a la escena.</p><p>2. Convierta el objeto Main Camera en un elemento hijo del objeto GvrEditorEmulator.</p><p>3. Restablece el componente Transformar del objeto Main Camera</p><p>4. Mueva el objeto GvrEditorEmulator a una ubicación conveniente para el desarrollo, por ejemplo, Posición: 0, 3, 35 y Rotación: 0, 180, 0.</p><p>5. Ingrese al modo de juego y use Alt + Mouse y Ctrl + Mouse para rotar e inclinar el ángulo de visión de la cámara.</p><p></p><p>- **Desarrollo**</p><p>Se agregan los componentes según lo especificado. Esta cámara se ubica al inicio de todos los Waypoints.</p><p>![](infoJuego.004.png)</p><p></p><p>**Ubicación:** </p><p>![](infoJuego.005.png)</p><p></p><p>**Resultado**</p><p>![](infoJuego.006.png)</p><p></p><p>***Preparando la escena para la interacción***</p><p></p><p>Durante este paso, prepararemos la escena para la interacción configurando el puntero, el emisor de rayos y el sistema de eventos, y luego probaremos el sistema de punto de referencia incluido (waypoint).</p><p></p><p>1. Agregue el objeto prefab GvrReticlePointer a la escena como elemento secundario del objeto del Main Camera.</p><p>2. Aumente el valor de Distancia máxima de retícula para el GvrReticlePointer del</p><p>valor predeterminado de 10 a 20.</p>|






3. Agregue el script GvrPointerPhysicsRaycaster como componente en el objeto Main Camera.

![](infoJuego.009.png)

3. Agregue el objeto prefab GvrEventSystem a la escena.

![](infoJuego.010.png)

3. Ingrese al modo de juego y navegue por la escena haciendo clic en los puntos de referencia.

![](infoJuego.011.png)


# ***Hacer que los objetos del juego sean interactivos***

Durante este paso haremos que la Moneda, la Llave y la Puerta sean interactivas añadiéndoles componentes de disparadores y eventos.

Se cumplieron cada uno de los requerimientos de este punto. Como pruebas se envían capturas de pantalla correspondientes.

`                    `**Coin                                           Key                                          Door**

![](infoJuego.012.png)![](infoJuego.013.png)![](infoJuego.014.png)





# ***Hacer la interfaz de usuario interactiva***

Durante este paso, haremos que el objeto SignPost sea interactivo al agregarle componentes de disparadores y eventos. El proceso es casi idéntico al que hicimos con la moneda, la llave y la puerta en el paso anterior, pero no necesitamos un colisionador para interactuar con los objetos del juego de la interfaz de usuario. En su lugar, debemos verificar que el objeto del juego Canvas tenga un componente Graphic Raycaster, y debido a que estamos usando GVR, reemplazaremos el Graphic Raycaster de Unity con el GvrPointerGraphicRaycaster de Google VR.

Se completó la interfaz correspondiente, para esto se cumplieron los requerimientos especificados en el informe. Se agregan las capturas según los puntos que necesitan evidencia.

![](infoJuego.015.png)





**Programando el comportamiento de la moneda (coin)**

Durante este paso, programaremos el comportamiento de la moneda para que, cuando se haga clic en una moneda (coin), se reproduzca un sonido, muestre un efecto de "poof" y desaparezca.

La moneda se programó según lo especificado, añadiendo una animación de rotación y la animación de desaparición, igualmente el sonido.

![](infoJuego.017.png)




















![](infoJuego.018.png)


















# ***Programando el comportamiento de la llave (key)***

Durante este paso, programaremos el comportamiento de la llave (key) para que, cuando se haga clic en la llave, reproduzca un sonido, muestre un efecto de "poof" y desaparezca.

La llave se programó según lo especificado, añadiendo una animación de flotación y la animación de desaparición, igualmente el sonido.

![](infoJuego.019.png)![](infoJuego.020.png)



# ***Programando el comportamiento de la puerta (door)***

Durante este paso, programaremos el comportamiento de la puerta (door) para que cuando se haga clic en la llave (key), la Puerta se desbloquee y cuando se haga clic en la Puerta, se escuche un sonido y comience a girar a una posición de apertura.

Las puertas se programaron según lo especificado, añadiendo una animación de apertura y los controladores correspondientes, la cual se desbloquea al obtener la llave.

![](infoJuego.022.png)

![](infoJuego.023.png)

![](infoJuego.024.png)



![](infoJuego.025.png)

![](infoJuego.026.png)	























# ***Programando el comportamiento del SignPost***

Durante este paso, programaremos el comportamiento de SignPost para que cuando se haga clic en SignPost se reinicie el juego.

El mensaje de victoria se programa según lo especificado, agregando la funcionalidad de reset para la escena, este se encuentra dentro del templo y no se puede acceder a él hasta haber encontrado la llave y abrir la puerta.

![](infoJuego.027.png)![](infoJuego.028.png)


# ***Crear la funcionalidad del juego***

Durante este paso, armaremos todo y convertiremos nuestro proyecto en un juego real. Laberinto

Se agregaron las paredes y esquinas en todo el espacio disponible, según el laberinto creado, dentro de este se encuentra la llave y las monedas. La puerta no se abre hasta encontrar la llave, por lo tanto, no se puede encontrar el mensaje de victoria para reiniciar. Se agregan varios Waypoints para poder navegar en todo el mapa.

![](infoJuego.029.png)








||
| - |
|**ACTIVIDADES POR DESARROLLAR**|
|1.	Crear un repositorio en GitHub con el nombre “Practica08 – Laberinto VR”|
|<p>2. Realizar un commit y push por cada requerimiento de los puntos antes descritos.</p><p>&emsp;a. Ignorar las carpetas Temp y Library</p><p>&emsp;b. Agregar el archivo apk comprimido en .zip</p><p>c. **La evidencia del correcto funcionamiento de la aplicación**</p><p>d. **El informe debe incluir conclusiones apropiadas.**</p><p>- Se logró implementar escenarios de realidad virtual con Unity, y que estas sean cargadas en dispositivos móviles Android. </p><p>- El desarrollo de aplicaciones o juegos virtuales permitió diferenciar a la realidad virtual de la realidad aumentada.</p><p></p><p>e. **En el informe se debe incluir la información de GitHub (usuario y URL del repositorio de la práctica)**</p><p>**Usuario:** braulio97x</p><p>**URL: [**https://github.com/braulio97x/Practica08-Laberinto-VR.git](https://github.com/braulio97x/Practica08-Laberinto-VR.git)**</p><p></p><p>f. **En el informe se debe incluir la firma digital de los estudiantes.**</p><p>![](infoJuego.030.png)</p>|
|3.	Luego, se debe crear el archivo README del repositorio de GitHub.|
|<p>4. Generar informe de los resultados en el formato de prácticas. Debe incluir:</p><p>&emsp;a. El desarrollo de cada uno de los requerimientos antes descritos.</p><p>&emsp;b. La evidencia del correcto diseño de la escena</p>|

||
| - |
|5.	En el archivo README del repositorio debe constar la misma información del informe de resultados de la práctica que se indica en el punto anterior.|
|<p>**RESULTADO(S) OBTENIDO(S)**:</p><p>- Desarrolla e integra módulos interactivos virtuales.</p>|
|<p>**CONCLUSIONES**:</p><p>- Los estudiantes podrán implementar escenarios de realidad virtual usando la herramienta Unity.</p>|
|**RECOMENDACIONES**:|





***Docente*:** Dr. Gabriel León Paredes, PhD.

***Firma*: ![](infoJuego.031.png)**
