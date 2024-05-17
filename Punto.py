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
print (samsung_galaxy_s3.x)
samsung_galaxy_s3.mover_arriba(10)
print (samsung_galaxy_s3.y)
