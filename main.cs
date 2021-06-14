/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
C#, VB, Perl, Swift, Prolog, Javascript, Pascal, HTML, CSS, JS
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Rec
{
  static void Main ()
  {
    Console.WriteLine (" =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.Write (" |");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write ("                 +TABUADA+                     ");
    Console.ResetColor ();
    Console.Write ("|\n");
    Console.WriteLine (" =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine ("");

    Console.WriteLine (" Digite o numero da tabuada que deseja calcular ");
    Console.WriteLine (" Enter the number of the tablet you want to calculate ");

    string numero = "1";
    while (numero != "<>")
      {
	Console.Write (" ultilize");
	Console.ForegroundColor = ConsoleColor.Green;
	Console.Write (" <> ");
	Console.ResetColor ();
	Console.Write ("para parar o programa !!\n");
	Console.Write (" ultilise");
	Console.ForegroundColor = ConsoleColor.Green;
	Console.Write (" <> ");
	Console.ResetColor ();
	Console.Write ("to stop the program !!\n");
	Console.Write (" digite um numero:");
	Console.Write ("/Enter the number: ");
	string tabuada = Console.ReadLine ();
	
	if (tabuada != "<>")
	  {
	    int tab = Convert.ToInt32 (tabuada);
	      Console.WriteLine ("\n    -=-=-=-=-=-=-=-=");
	    for (int i = 01; i <= 10; i++)
	      {
		int result = tab * i;
		  Console.Write ("      |" + tab + " x " + i + " = ");
		  Console.ForegroundColor = ConsoleColor.Green;
		  Console.Write (result);
		  Console.ResetColor ();
		  Console.Write ("|\n");
	      }
	    Console.WriteLine ("    -=-=-=-=-=-=-=-=\n");
	  }
	numero = tabuada;
      }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine ("\n obrigado por utilizar o programa !!");
    Console.WriteLine ("\n thank you for using the program !!");
    Console.ResetColor();
  }
}


