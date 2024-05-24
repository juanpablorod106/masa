class Persona:                                                            
    def __init__(self, nombre, apellido, sexo, cid, edad, direccion,cuenta):            
        self.nombre = nombre
        self.apellido = apellido
        self.sexo = sexo
        self.edad = edad
        self.cid = cid
        self.direccion = direccion
        self.cuenta = cuenta

class Cuentabanco:

    def __init__(self, numero, tipo, saldo, cod_seguridad):
        self.numero = numero
        self.tipo = tipo
        self.saldo = saldo
        self.cod_seguridad = cod_seguridad

    def dep(self,monto = 0):
        self.saldo += monto
        print(f"El saldo se le suma {monto} y ahora el total de su saldo es: {self.saldo}")
   
    def ret(self, monto = 0):    
        if (self.saldo < monto):
           print(f"Ve a trabajar a Sodoma HDP, pobre hdp")
        else:
            self.saldo -= monto
            print(f"El saldo se le resta {monto} y ahora el total de su saldo es: {self.saldo}")

cuenta1 = Cuentabanco(2, "0105032315154040", 0.0, 666)

cuenta1.dep(int(input()))
cuenta1.ret(int(input()))

persona1 = Persona("fkn Juancho","Rodriguez", "gay", 31021385, 60, "Bachaquero", cuenta1)
persona1.cuenta.dep()

