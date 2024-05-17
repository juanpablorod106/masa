import math
class Punto:

    def __init__(self,x,y):
        self.x = x
        self.y = y

    def mover_derecha(self,n):
        self.x += n

    def mover_izquierda(self,n):
        self.x -= n

    def mover_arriba(self,n):
        self.y += n

    def mover_abajo(self,n):
        self.y -= n

samsung_galaxy_s3 = Punto(0,0)
samsung_galaxy_s4 = Punto(3,3)
def distancia(x1,x2,y1,y2):
    return math.sqrt( math.pow (x2 - x1,2) + pow (y2 - y1,2) )

resultado = distancia (samsung_galaxy_s3.x,samsung_galaxy_s4.x,samsung_galaxy_s3.y,samsung_galaxy_s4.y)
print (resultado)


