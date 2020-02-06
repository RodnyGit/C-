Arquitectura Proxy:
	-El patron proxy da soporte a objetos que controlan la creacion y el acceso a 
	otros objetos. Es un punto intermedio entre el cliente y esos objetos que son activados
	cuando se cumple con determinados requisitos.

Partes:
CLiente: (en nuestro caso es el maim)
	-Es quien de alguna manera quiere acceder al sujeto para consumir
	su informacion
Sujeto:
	-Elemento que contiene la informacion deseada por el cliente
ISujeto:
	-Interface que implementaran tanto el sujeto como el proxy 
	para estandarizar la comunicacion
Proxy:
	-Es la clase intermediaria que se comunica con el cliente para 
	establecer de que forma sera la comunicacion con el sujeto.
Peticion:
	-Cualquier operacion que manifieste el cliente para la cual nesecite
	consumir algun recurso del sujeto.