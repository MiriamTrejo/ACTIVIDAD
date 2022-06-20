// See https://aka.ms/new-console-template for more information

namespace Arreglo_numerico
{
    class Program
    {
        static void Main(string[] args)
        {

            List<float> arreglo = new List<float>();

            int opcion;
            do
            {
               
                Console.WriteLine("COMO PUEDO AYUDARTE");
                Console.WriteLine("1.-Ingresar los Numeros:");
                Console.WriteLine("2.-Mostrar los Numeros:");
                Console.WriteLine("3.-Ordenar los Numeros:");
                Console.WriteLine("4.-Guardar los Numeros:");
                Console.WriteLine("5.-Salir: ");
                Console.WriteLine(" ");
                
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("");
               

                switch (opcion)
                {

                    case 1: //Aquí la función es poder ingresar los numeros deseados 
                        arreglo.Clear();
                        Console.Write("¿Cuantos Numeros deseas ingresar?: ");
                        int sub = int.Parse(Console.ReadLine());


                        double[] numeros = new double[sub];
                        for (int i = 0; i < sub; i++)
                        {
                            Console.Write("( " + (i + 1)+ " )");
                            arreglo.Add(float.Parse(Console.ReadLine()));
                        }
                        break;


                    case 2://Aquí se va a guardar los números que agregamos en nuestro primer case.
                        Console.Write("Los valores del arreglo son \n");
                        for (int i = 0; i < arreglo.Count; i++)
                        {
                            Console.WriteLine("[" + arreglo[i] + "] ");
                        }

                        break;
                    case 3:  // Aquí nos va poder ordenar los numeros escogiendo la opción ya sea 1 que es ordenar del número mayor al 
                            //menor y la ota opción hace que los números se acomoden de menor a mayor.
                        Console.WriteLine("1.-Mayor a Menor: ");
                        Console.WriteLine("2.-Menor a Mayor: ");

                        int orden = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (orden == 1)
                        {
                            for (int i = arreglo.Count; i >= 0; i--)
                            {
                                for (int j = 0; j < i - 1; j++)
                                {
                                    if (arreglo[j] < arreglo[j + 1])
                                    {
                                        float aux = arreglo[j];
                                        arreglo[j] = arreglo[j + 1];
                                        arreglo[j + 1] = aux;

                                    }
                                }
                            }
                        }
                        else if (orden == 2)
                        {
                            for (int i = arreglo.Count; i >= 0; i--)
                            {
                                for (int j = 0; j < i - 1; j++)
                                {
                                    if (arreglo[j] > arreglo[j + 1])
                                    {
                                        float aux = arreglo[j];
                                        arreglo[j] = arreglo[j + 1];
                                        arreglo[j + 1] = aux;

                                    }
                                }
                            }
                        }

                        for (int i = 0; i < arreglo.Count; i++)
                        {
                            Console.WriteLine(arreglo[i]);
                        }
                        break;

                    case 4:  //Esta función hace que se pueda guardar los números que pusimos en nuestro primer caso que declaramos
                        Stream Archivo2 = new FileStream("Archivo.txt", FileMode.OpenOrCreate);
                        StreamWriter Escribir = new StreamWriter(Archivo2);

                        for (int i = 0; i < arreglo.Count; i++)
                        {
                            Escribir.WriteLine(arreglo[i]);
                        }

                        Escribir.Close();
                        Archivo2.Close();
                        break;
                    case 5:  // Este nos sirve para poder salir de la consola
                        Console.WriteLine("Salir");
                        break;

                }

            } while (opcion!= 5);

            
        }
    }
}