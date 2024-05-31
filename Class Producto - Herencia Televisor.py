tasa = 37.5

class Producto:
    
    def __init__(self,nombre,marca,precio):

        self.nombre = nombre
        self.marca = marca
        self.precio = precio

    def mostrar_info(self):
        print(f"{self.nombre} {self.marca} {self.precio}")
    def calcular_dolar(self,tasa):
        print(f"El precio es igual a: {self.precio * tasa}")
        self.mostrar_info()

class Televisor(Producto):

    def __init__(self, nombre, marca, precio, pantalla, tipo_pantalla):
        super().__init__(nombre, marca, precio)
        self.nombre = self.nombre
        self.marca = self.marca
        self.precio = self.precio
        self.pantalla = pantalla
        self.tipo_pantalla = tipo_pantalla

    def mostrar_info(self):
        print(f"El televisor {self.nombre} de marca {self.marca} cuesta {self.precio} y cuenta con una pantalla de {self.pantalla} de tipo {self.tipo_pantalla} ")
   
    #super().mostrar info()

    def calcular_dolar(self,tasa):
        return tasa * self.precio


prod2 = Televisor("Smart TV","Samsung",1500,"100 Pounds", "QLED")
precio = prod2.calcular_dolar(tasa)

prod2.mostrar_info()
print ("El precio del aparato es igual a:",(precio),"Bs.D")
