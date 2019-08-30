# Composición y Delegación

Esta librería implementa un patrón conocido como Pipes and Filters. Esta arquitectura de software consta de dividir tareas complejas en tareas más pequeñas y sencillas que pueden ser ejecutas en serie o paralelo: https://docs.microsoft.com/en-us/azure/architecture/patterns/pipes-and-filters .
En este caso, utilizaremos el patrón de Pipes and Filters aplicado a imagenes y modificaciones aplicadas a ellas (filtros).

Uno de los filtros implementados aqui es un filtro de convolución. Los filtros de convolución son una familia de filtros
sencillos que calculan el color de un pixel en base al color de los pixels vecinos (https://en.wikipedia.org/wiki/Kernel_(image_processing)).
Por ejemplo, un filtro de convolución es el suavizado, que permite hacer una imagen más
borrosa, simplemente tomando como el color de cada pixel el promedio del color de los pixels
vecinos. De esta forma, cada uno de los pixels se parece más a sus vecinos, y la imagen se
vuelve más borrosa.
Para aplicar un filtro de convolución, se puede utilizar una matriz de 3x3, donde en cada
elemento de la matriz es un coeficiente por el cual se debe multiplicar al color del vecino, un
divisor y un complemento.
Por ejemplo, para un posible filtro de suavizado, se puede utilizar una matriz (m) como:

![alt text](https://github.com/fedemartino/CompAndDel/blob/master/matrix.png)

Un divisor de 9 y un complemento de 0.
```c#
rojo_nuevo[x, y] =
(
    (
        r[x - 1, y - 1] * m[0, 0] + r[x, y - 1] * m[0, 1] + r[x + 1, y – 1] * m[0, 2] +
        r[x - 1, y] * m[1, 0] + r[x, y] * m[1, 1] + r[x + 1, y] * m[1, 2] +
        r[x - 1, y + 1] * m[2, 0] + r[x, y + 1] * m[2, 1] + r[x + 1, y + 1] * m[2, 2]
    ) / divisor
) + complemento
```

Donde ``` r[x,y] ``` corresponde al componente rojo del pixel (x,y) de la imagen original y ```m[i,j]``` al
valor de la matriz en la posición (i,j), donde ```0 <= i``` , ```j <= 2``` . Es decir, el coeficiente del centro
es el peso del pixel que se está filtrando, y el resto el peso de todos los pixels que lo rodean.
En el caso del suavizado, sería:
```c#
rojo_nuevo[x, y] =
(
    (
        r[x-1,y-1] * 1 + r[x,y-1] * 1 + r[x+1,y-1] * 1 +
        r[x-1,y] * 1 + r[x,y] * 1 + r[x+1,y] * 1 +
        r[x-1,y+1] * 1 + r[x,y+1] * 1 + r[x+1,y+1] * 1
) / 9) + 0
```
Lo que equivale a hacer un promedio del valor del componente rojo para cada uno de los
pixels.

El resultado final sería así:
![original](https://upload.wikimedia.org/wikipedia/commons/5/50/Vd-Orig.png) => ![Blur](https://upload.wikimedia.org/wikipedia/commons/0/04/Vd-Blur2.png)

Para poder utlizar esta libreria, se debe primer cargar una imagen en un IPicture:
```c#
PictureProvider p = new PictureProvider();
IPicture pic = p.GetPicture("PathToImage.jpg");
```
Luego, se deberan generar una serie de Pipes & Filters para transformar la imagen. Finalmente, se deberá guardar una copia de la imagen mediante el siguiente código:

```c#
PictureProvider p = new PictureProvider();
IPicture pic = p.SavePicture("PathToNewImage.jpg");
```
