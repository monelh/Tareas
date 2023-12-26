/*
 
 * Ingresar nombre, fecha de nacimiento y fecha actual, calcular la edad del usuario basado en dichos 
 * datos e imprimir los datos de la siguiente manera.
 
 * Ejemplo:
 
 * Entrada de Datos
 * juan soto, 24/06/1991, 23/12/2023
 
 * Salida de Datos
 
 * Nombre: Juan Soto Castro
 * Dia de Nacimiento: 24
 * Mes: Junio
 * Ano: 1991
 * Edad 32 anos
 
 * Nota:
 * Utilizar los metodos de los strings vistos en la clase del dia, Substring, Lenght, ToUpper, Trim o 
 * cualquier otro que considere necesario.

 */

string nombre = "", nacimiento = "", fechaActual = "";
string dia, mes, ano;

do
{
    Console.WriteLine("Ingresa tu nombre:");
    nombre = Console.ReadLine().ToLower();
} while (nombre == "");


string[] nombres = nombre.Split(' ');

int indice = 0;
nombre = "";

foreach (string n in nombres)
{
    nombre += ' ' + nombres[indice].Replace(nombres[indice].ElementAt(0), nombres[indice].ToUpper().ElementAt(0));
    indice++;
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

string edad = (int.Parse(fechaActual.Substring(6,4)) - int.Parse(ano)).ToString();
if (edad == "1")
{
    edad = edad + " ano";
}
else
{
    edad = edad + " anos";
}


if (mes == "01")
{
    mes = "enero";
}
if (mes == "02")
{
    mes = "febrero";
}
if (mes == "03")
{
    mes = "marzo";
}
if (mes == "04")
{
    mes = "abril";
}
if (mes == "05")
{
    mes = "mayo";
}
if (mes == "06")
{
    mes = "junio";
}
if (mes == "07")
{
    mes = "julio";
}
if (mes == "08")
{
    mes = "agosto";
}
if (mes == "09")
{
    mes = "septiembre";
}
if (mes == "10")
{
    mes = "octubre";
}
if (mes == "11")
{
    mes = "noviembre";
}
if (mes == "12")
{
    mes = "diciembre";
}

Console.WriteLine("Nombre: {0}\nDia de Nacimiento: {1}\nMes de nacimiento: {2}\nAno: {3}\nEdad: {4}",nombre,dia,mes,ano,edad);