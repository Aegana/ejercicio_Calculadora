using System;  //son directivas que permiten utilizar funcionalidades que vienen dadas por defecto en nuestro programa, por ej: la clase console

namespace CALCULADORA //espacio de nombres definidas como nuestro proyecto
{

    class Program //clase principal de nuestro proyecto, llamada Program 
    {
        static void Main(string[] args) /*esto es un comentario */ /*es el método principal que viene dado por defecto para ejecutar nuestro código*/
        {
            //utilizando atributos de la clase console:
            Console.BackgroundColor = ConsoleColor.White; //fondo del texto
            Console.ForegroundColor = ConsoleColor.Black; //color del texto

            //declarar variables
            int num1 = 0, num2 = 0, resultado = 0;
            char opcion = '0'; string valorElegido = "";
            int n = 1;
            //throw new ArgumentException("Se ha dividido entre 0");
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("***********************BIENVENIDO A LA CALCULADORA***********************" + "\n"
                   + "¿Desea realizar alguna operación? <S/N> \n"); // "\n indica un salto de línea"
                    valorElegido = Console.ReadLine();
                    if (valorElegido.ToUpper() == "S")
                    {
                        //interactuar con el usuario
                        Console.WriteLine("Elija una operación: + - / * ");
                        opcion = Convert.ToChar(Console.ReadLine());
                        Peticion(opcion, num1, num2, resultado);
                        n++;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (valorElegido.ToUpper() == "N")
                    {
                        Console.WriteLine("Pulse cualquier tecla para salir de la aplicación");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida.");
                        //propiedad para borrar en pantalla
                        Console.Clear();
                        n++;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en la aplicación.");
                Console.WriteLine("Error:"+ex);
                throw;
            }



           
            
        }
        //se declara la función Petición para pedir los numeros al usuario
        public static void Peticion(char opcion, int num1, int num2, int resultado)
        {
            switch (opcion)
            {
                case '+':
                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case '-':
                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case '*':
                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;
                case '/':

                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado de la división es: " + resultado);
                    break;
                default:
                    Console.WriteLine("La opción elegida no es válida.");
                    break;
            }
        }

    }
}