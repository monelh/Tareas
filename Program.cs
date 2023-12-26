/*
 
 * Ingresar nombre, fecha de nacimiento y fecha actual, calcular la edad del usuario basado en dichos 
 * datos e imprimir los datos de la siguiente manera.
 
 * Ejemplo:
 
 * Entrada de Datos
 * juan soto, 24/06/1991, 23/12/2023
 
 * Salida de Datos
 
 * Nombre: Juan Soto
 * Dia de Nacimiento: 24
 * Mes: Junio
 * Ano: 1991
 * Edad 32 anos
 
 * Nota:
 * Utilizar los metodos de los strings vistos en la clase del dia, Substring, Lenght, ToUpper, Trim o 
 * cualquier otro que considere necesario.

 */

//Creación de variables
string nombre = "", nacimiento = "", fechaActual = "";
string dia, mes, ano;

do
{
    Console.WriteLine("Ingresa tu nombre:");
    nombre = Console.ReadLine().ToLower();
} while (nombre == "");

//Creando el arreglo de nombres
string[] nombres = nombre.Split(' ');

//Juan Antonio Soto Castro
 /*
  [0] = Juan
  [1] = Antonio
  [2] = Soto
  [3] = Castro
  */

nombre = "";

for (int indice = 0; indice < nombres.Length; indice++)
{
    nombre += ' ' + nombres[indice].Replace(nombres[indice].ElementAt(0), nombres[indice].ToUpper().ElementAt(0));
}

do
{
    Console.WriteLine("Fecha de nacimiento: (DD/MM/AAAA)");
    nacimiento = Console.ReadLine();
} while (nacimiento == "");

do
{
    Console.WriteLine("Fecha actual: (DD/MM/AAAA)");
    fechaActual = Console.ReadLine();
} while (fechaActual == "");

dia = nacimiento.Substring(0, 2);
mes = nacimiento.Substring(3, 2);
ano = nacimiento.Substring(6, 4);

string edad = "";

if(int.Parse(fechaActual.Substring(3, 2)) > int.Parse(mes))
{
    edad = (int.Parse(fechaActual.Substring(6, 4)) - int.Parse(ano)).ToString();
} else if(int.Parse(mes) == int.Parse(ano))
{
    if(int.Parse(fechaActual.Substring(0,2)) >= int.Parse(dia))
    {
        edad = (int.Parse(fechaActual.Substring(6, 4)) - int.Parse(ano)).ToString();
    } else
    {
        edad = (int.Parse(fechaActual.Substring(6, 4)) - int.Parse(ano) - 1).ToString();
    }
} else
{
    edad = (int.Parse(fechaActual.Substring(6, 4)) - int.Parse(ano) - 1).ToString();
}

if (edad == "1")
{
    edad = edad + " año";
}
else
{
    edad = edad + " años";
}


switch (mes)
{
    case "01":
        mes = "Enero";
        break;
    case "02":
        mes = "Febrero";
        break;
    case "03":
        mes = "Marzo";
        break;
    case "04":
        mes = "Abril";
        break;
    case "05":
        mes = "Mayo";
        break;
    case "06":
        mes = "Junio";
        break;
    case "07":
        mes = "Julio";
        break;
    case "08":
        mes = "Agosto";
        break;
    case "09":
        mes = "Septiembre";
        break;
    case "10":
        mes = "Octubre";
        break;
    case "11":
        mes = "Noviembre";
        break;
    case "12":
        mes = "Diciembre";
        break;
}

Console.WriteLine("Nombre: {0}\nDia de Nacimiento: {1}\nMes de nacimiento: {2}\nAno: {3}\nEdad: {4}",nombre,dia,mes,ano,edad);