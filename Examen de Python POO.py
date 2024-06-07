# Juan Rodrìguez - 31.021.385
                                            # Parte 1 del examen - Creaciòn de clases y Objetos
class Persona:
    def __init__(self,nombre,edad):
        self.nombre = nombre
        self.edad = edad
    
    def imp(self):
        return (self.nombre, self.edad)

p1 =Persona("Juanchorois",18)

#print (p1.imp())

                                            # Herencia estudiante - Imprime el nombre de la universidad

class Estudiante(Persona):
    def __init__(self, nombre, edad,universidad):
        super().__init__(nombre, edad)
        self.universidad = universidad

    def uni(self):
        return (self.universidad)
    
u1 = Estudiante("Juanchorois",18,"harvard")

#print(u1.uni())

                                             # Parte 2 del examen - Herencia y Sobreescritura
class Profesor(Persona):
    def __init__(self, nombre, edad,asignatura):
        super().__init__(nombre, edad)
        self.asignatura = asignatura

    def imp(self):
        return (self.nombre, self.edad,self.asignatura)

Prof= Profesor ("Dayan Matos","40","Compiladores")

#print(Prof.imp())

                                               # Parte 3 del examen - Composiciòn

class Curso:
    def __init__(self,nombre):
        self.nombre = nombre

#Lista de estudiantes del programa

    lista = ["Walter White"]

#Metodo de agregar estudiantes
    
    def agg(self):
        return self.lista.append("Saul Goodman")
    
#Metodo de imprimir todos los estudiantes del curso
    
    def imp_n(self):
        return (self.lista)

c1 = Curso("Calculo IV")

 #Impresiòn del programa con excentricidades

"""print (c1.nombre)
print(c1.imp_n())
print("Agreguen al resto de estudiantes y reimpriman la lista chavales")
c1.agg()
print (c1.nombre)
print(c1.imp_n())"""