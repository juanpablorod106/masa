#include <stdio.h>
#include <stdlib.h>
#include <math.h>
int main(){

float lb,la,c1,c2,c3,fa,fb,f1,f2,f3,i;
float hdrtam;

float RDTN, RDTAM2, RDTAM4;

printf ("Ingresa tu limite superior, (a): \n");
scanf ("%f",&la);

printf ("Ingresa tu limite inferior, (b): \n");
scanf ("%f",&lb);

//HRDTAM4
hdrtam = ((lb - la) / 4);
printf("\n HDRTAM4 = %f \n",hdrtam);

c1 = la + hdrtam;
c2 = la + hdrtam + hdrtam;
c3 = la + hdrtam + hdrtam + hdrtam;

printf ("-------------------------------");
printf ("\n Limite superior: %f \n",la);
printf ("\n Intervalo 1: %f \n",c1);
printf ("\n Intervalo 2: %f \n",c2);
printf ("\n Intervalo 3: %f \n",c3);
printf ("\n Limite infeior: %f \n",lb);
printf ("------------------------------- \n \n");

printf ("---------------------------------------------");
printf ("\n \n Funcion de limite inferior, (a): \n \n");
fa =pow(la,3) - (2*pow(la,2)) + la - 0.5;
printf("%f",fa);

printf ("\n \n Funcion de intervalo 1, (i1): \n \n");
f1 =pow(c1,3) - (2*pow(c1,2)) + c1 - 0.5;
printf("%f \n",f1);

printf ("\n \n Funcion de intervalo 2, (i2): \n \n");
f2 =pow(c2,3) - (2*pow(c2,2)) + c2 - 0.5;
printf("%f \n",f2);

printf ("\n \n Funcion de intervalo 3, (i3): \n \n");
f3 =pow(c3,3) - (2*pow(c3,2)) + c3 - 0.5;
printf("%f \n",f3);

printf ("\n \n Funcion de limite superior, (b): \n \n");
fb =pow(lb,3) - (2*pow(lb,2)) + lb - 0.5;
printf("%f \n",fb);

printf ("----------------------------------------------\n");

return 0;
}

