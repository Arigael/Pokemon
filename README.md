# Pokemon

# Por Felipe Rubio y Miguel Toro

Class Player:
Para la clase player solo consideramos que se le pudiera obtener y setear una cola de critters, puesto que a la hora del combate iba ser necesario modificar la cola para agregar o quitar critters de ella segun estos fuesen muriendo en el combate. Decidimos agregarle un nombre al jugar para poder identificarlo mejor.

Class Critter:
En esta clase se encuentra los atributos de los critters (Nombre, Ataque defensa y velocidad base, hp, un enum para definir la afinidad y una lista que son las skills que posee el critter) todos estos atributos son definidos en el constructor de la case.


Class Skill:
En la super clase skill definimos el nombre, el poder de atk del skill, el numero de movmientos que es el numero de veces el cual puede ser usara un skill y la afinidad. Consideramos no hacer el constructor en esta clase puesto que cada tipo de skill (ataque y soporte) puesto que cada tipo requeria cumplir una condicion diferente para poder ser considerada de un tipo u otro.
 
 
Class AtkSkill:
Esta clase hereda de la clase skill y es ella misma quien define el constructor. Alli estan definidos los metodos que se encargan del lanzamiento de los hechizos.

Class SuppSkill:
Esta clase hereda de la clase skill y es ella misma quien define el constructor. Alli estan definidos los metodos que se encargan del lanzamiento de los hechizos.

Class Control:
Esta clase es la que se encarga de manejar y controlar el combate. Definir los jugadores presentes en el combate y controlar los turnos de este.
