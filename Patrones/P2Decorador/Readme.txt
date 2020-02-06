Objetivo:
	-Crear una arquitectura que pueda sustituir la herencia multiple 
	en un entorno donde no es factible utilizarla...

Partes:
-Decorable:
	 Clase original que esta siendo decorada 
	a la que se le adicionan o mejora comportamientos

-IDecorador:
	Interfaz que identifica a los objetos que decoran y pueden ser decorados
	
-Operacion:
	Operacion en el componente que puede ser reemplazada

-Decorador:
	Clase que implementa a IDecorador y adiciona el estado o comporamiento nuevo