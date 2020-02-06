Objetivos:
	-Desacoplar la implementacion de la abstraccion.
	-Se utiliza cuando surge una nueva version de la implementacion 
	pero la anterior aun se debe seguir utilizando.
	-Protege de cambio al cliente ya que su codigo no cambia 
	pues trabaja con la abstraccion y no con la implementacion en concreto
	-El cliente debe indicar con que version desea trabajar.

Componentes:
	-IBridge:
	Interfaz que contiene Las caracteristicas minimamente comunes 
	que deben tener las implementaciones con respecto a la abstraccion
	
	-Implementaciones:
	Son las versiones 1ue contienen el codigo relevante para el cliente, 
	accedidas mediante la abstraccion.
	
	-Abstraccion:
	Es la clase que interactua con el cliente sustituyendo alguna de las implementaciones.