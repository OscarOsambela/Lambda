using System;
using System.Collections.Generic;

//expresiones lambda
//para ejecutar tarea o tareas que no necesitan ser declaradas
//simplificar codigo
//se utilizan delegados sencillos
//se utilizan en expresiones Linq

class MainClass {
  public static void Main (string[] args) {
		OperacionesMatematicas oper = new OperacionesMatematicas(Cuadrado);//metodo sin expresion lambda se llama al metodo (que es Cuadrado)
    OperacionesMatematicas oper2 = new OperacionesMatematicas(num => num * num);//metodo con expresion lambda solo en el parametro
 		OperacionesMatematicasSuma operSuma = new OperacionesMatematicasSuma(Suma);//metodo sin expresion lambda se llama al metodo (que es Suma)
 		OperacionesMatematicasSuma operSuma2 = new OperacionesMatematicasSuma((num1, num2) => num1 + num2);//metodo con expresion lambda solo en el parametro

		Console.WriteLine(oper(4));
    Console.WriteLine(oper2(9)); 
    Console.WriteLine(operSuma(2,5));
    Console.WriteLine(operSuma2(20,53));

    //Lista de valores numericos con expresion lambda
    List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13};
    List<int> numeroPares = numeros.FindAll(i => i % 2 == 0);
    List<int> numeroImpares = numeros.FindAll(i => i % 2-1 == 0);

    Console.WriteLine("De la lista muéstrame los números pares");
    foreach(int num in numeroPares) Console.WriteLine(num);
    Console.WriteLine("De la lista muéstrame los números impares");
    //tambien el foreach con operacion lambda
    numeroImpares.ForEach(numero2 => Console.WriteLine(numero2));
  }


//delegado
public delegate int OperacionesMatematicas(int numero);	
public delegate int OperacionesMatematicasSuma(int numero1, int numero2);	


//metodo sin expresion lambda
public static int Cuadrado(int num){
	return num * num;
}

//metodo
public static int Suma(int num1, int num2){
  return num1 + num2;
	}
}