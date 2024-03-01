//Inicio del Programa ===================================

using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
//1. Introducción a las cadenas de texto ===================================
//  a. Definición de un string ===================================
//  c. Diferencia entre cadenas literales y variables de tipo string. ===================================
Console.WriteLine("1. Introducción a las cadenas de texto\n\n");
Console.WriteLine("");
Console.WriteLine("a. Definición de un string.\nc. Diferencia entre cadenas literales y variables de tipo string.\n");

string evariable1 = Console.ReadLine();

string evariable2 = "Hola mundo!"; //Cadena literal==

string enombre = "Pedro"; //Variable tipo string==

Console.WriteLine(evariable1 + "\n"+ evariable2 +"\n"+ enombre);
Console.ReadKey();

//  b. Representación en memoria ===================================
Console.WriteLine("\nb. Representación en memoria. **********\n");

string enuevostring = evariable2 + enombre;
Console.WriteLine(enuevostring);
Console.ReadKey();

//  d. Concatenación de cadenas. ===================================
Console.WriteLine("\nd. Concatenación de cadenas. **********\n");
//      OPERADORES. ===================================
//          1. Metodo Operador +. ===================================
Console.WriteLine("\n1. Metodo Operador +.\n");
Console.WriteLine( evariable2 +" "+ enombre );
Console.ReadKey();


//          2. Método string.Concat(). ===================================
Console.WriteLine("\n2. Método string.Concat().\n");
Console.WriteLine(string.Concat(enombre, ", ", evariable2));
Console.ReadKey();

//          3. Método string.Join() ===================================
Console.WriteLine("\n3. Método string.Join()\n");
string[] evector = { "Pedro", "Juan","Maria","Rosa","Fernando","Daniela" };
Console.WriteLine(string.Join(" - ", evector));
Console.ReadKey();


//          4. Interpolación de Cadenas ===================================
Console.WriteLine("\n4. Interpolación de Cadenas\n");
int edad = 25;
Console.WriteLine($"Nombre: {enombre} Edad: {edad}");
Console.ReadKey();


//          5. StringBuilder ===================================
Console.WriteLine("\n5. StringBuilder\n");
StringBuilder etexto  = new StringBuilder();
etexto.Append("Bienvenido");
etexto.Append(" ");
etexto.Append (enombre);
etexto.Append(" y " + evariable1);

Console.WriteLine(etexto);
Console.ReadKey();


//=============================================================================================================
//2. Metodos y propiedades. ===================================
Console.WriteLine("\n2. Metodos y propiedades. =============================================\n***** Metodos. *****\n");

//      * Length;
Console.WriteLine("* Length:\n");
int enumnombre = evariable1.Length;
Console.WriteLine("El número de letras que tiene: " + evariable1 + " es: "+ enumnombre );
Console.ReadKey();

//      * ToUpper(): Convertir a mayúsculas
Console.WriteLine("\n* ToUpper():\n");
Console.WriteLine("El nombre el mayúsculas es: " + evariable1.ToUpper());
Console.ReadKey();

//      * ToLower(): Convertir a minúsculas.
Console.WriteLine("\n* ToLower():\n");
Console.WriteLine("El nombre el minúsculas es: " + evariable1.ToLower());
Console.ReadKey();

//      * IndexOf(): Buscar la primera ocurrencia de un caracter o cadena.

//**********************
            string evariable3 = "Hola mundo. Como estás? Hola mundo."; //Definimos una nueva variable String *****
//**********************

Console.WriteLine("\n* IndexOf():\n");
int eindex1 = evariable3.IndexOf("m");
int eindex2 = evariable3.IndexOf ("mundo");
Console.WriteLine("La pocición más cercana donde se puede encontrar la letra \"m\" en la variable es: \"" + eindex1 + "\" Y la pocición del inicio de la palabra \"mundo\" es: \"" + eindex2 + "\"");
Console.ReadKey();
//Devuelve un valor entero, y si no se encuentra lo que se está buscando devuelve un -1****************

//      * LastIndexOf(): Buscar la última ocurrencia de un caracter o cadena.
Console.WriteLine("\n* LastIndexOf():\n");
int elast1 = evariable3.LastIndexOf("o");
int elast2 = evariable3.LastIndexOf("mundo");
Console.WriteLine("La pocición más alejada donde se puede encontrar la letra \"o\" en la variable es: \"" + elast1 + "\" Y la pocición del inicio de la palabra \"mundo\" más alejada en la variable es: \"" + elast2 + "\"");
Console.WriteLine("\""+evariable3.Length+"\"");
Console.ReadKey();

//      * Substring(): Extraer una subcadena.
Console.WriteLine("\n* Substring():\n");
int esub1 = evariable3.IndexOf("C");
int esub2 = evariable3.LastIndexOf("?");
int elongi = esub2 - esub1 + 1; 
//Se hace, ya que los parámetros impuestos abajo, son el inicio y la longitud de la nueva cadena *********
string esubcade1 = evariable3.Substring (esub1, elongi);
string esubcade2 = evariable3.Substring (esub1);
Console.WriteLine($"Vamos a imprimir desde la pocición \"{esub1}\" hasta \"{esub2}\". La impreción es: \"{esubcade1}\"");
Console.WriteLine($"Vamos a imprimir a partir de la la pocición \"{esub1}\". La impreción es: \"{esubcade2}\"");
Console.ReadKey();
// Devuelve el texto que entre en los parámetros y si los parámetros se dan mal, da una excepción ***************************************

//      * Replace(): Reemplazar una subcadena por otra.
Console.WriteLine("\n* Replace()\n");
string erep1 = evariable3.Replace("m", "M");
string erep2 = evariable3.Replace("mundo", "world");
Console.WriteLine("El texto, reemplasando \"m\" por \"M\": " + erep1);
Console.WriteLine("El texto, reemplasando \"mundo\" por \"world\": " +erep2);
Console.ReadKey();
//Devuelve una nueva variable string con los cambios implementados.

//      * Trim(): Eliminar espacios en blanco al inicio y final.
Console.WriteLine("\n* Trim()\n");
string evariable4 = "   Hola a todos mis compañeros   ";
string evariable5 = "###Hola a todos mis catedraticos###";
//Definimos dos nuevas variables para la explicación ====
string etrim1 = evariable4.Trim();
string etrim2 = evariable5.Trim('#');
Console.WriteLine("Imprimir datos sin espacios: \""+ etrim1+"\"");
Console.WriteLine("Imprimir datos sin \"#\": \"" + etrim2+"\"");
Console.ReadKey();

//      * StartsWith(): Indicar si una cadena comienza con otra
Console.WriteLine("\n* StartsWith()\n");
bool estar1 = evariable3.StartsWith("hola");
bool estar2 = evariable3.StartsWith("hola", StringComparison.OrdinalIgnoreCase);
if (estar1)
{
    Console.WriteLine("La variable comenzaba con la palabra \"Hola\"");
}else
{
    Console.WriteLine("La variable NO comenzaba con la palabra \"Hola\"");
}
if (estar2)
{
    Console.WriteLine("La variable comenzaba con la palabra \"Hola\"");
}else
{
    Console.WriteLine("La variable NO comenzaba con la palabra \"Hola\"");
}
Console.ReadKey();

//      * EndsWith(): Indicar si una cadena termina con otra
Console.WriteLine("\n* EndsWith()\n");
bool eend1 = evariable3.EndsWith("Mundo.");
bool eend2 = evariable3.EndsWith("Mundo.", StringComparison.OrdinalIgnoreCase);
if (eend1)
{
    Console.WriteLine("La variable termina con la palabra \"mundo\"");
}
else
{
    Console.WriteLine("La variable NO termina con la palabra \"mundo\"");
}
if (eend2)
{
    Console.WriteLine("La variable termina con la palabra \"mundo\"");
}
else
{
    Console.WriteLine("La variable NO termina con la palabra \"mundo\"");
}
Console.ReadKey();

//=============================================================================================================
Console.WriteLine("\n***** Propiedades. *****\n");

//      * Length;
Console.WriteLine("* Length:\n");
enumnombre = evariable1.Length;
Console.WriteLine("El número de letras que tiene: " + evariable1 + " es: " + enumnombre);
Console.ReadKey();

//      * Chars: Obtiene un array de caracteres que componen la cadena.
Console.WriteLine("* Char:\n");
char eletra = evariable3[5];
Console.WriteLine("La letra elejida es: \"" + eletra + "\"");
Console.ReadKey();

//=============================================================================================================
//3. Operaciones con cadenas. ===================================
//Definimos una nueva variable String *****

//**********************
    string evariable6 = "Hola Mundo. Que Tal?";
    string evariable7 = "Hola mundo. Que tal?";
//**********************

Console.WriteLine("\n3. Operaciones con cadenas. =============================================\n° Comparación de cadenas.\n");

//Manera facil ===
bool ecompa1 = evariable6 == evariable7; //False

//Método string.Equals()
bool ecompa2 = string.Equals(evariable6, evariable7); //False
bool ecompa3 = string.Equals(evariable6, evariable7, StringComparison.OrdinalIgnoreCase); //True

//Método string.Compare()
int ecompa4 = string.Compare(evariable6, evariable7, StringComparison.OrdinalIgnoreCase); //True
Console.WriteLine("Fin del area ° Comparación");
Console.ReadKey();

//      Concatenación de cadenas =================================
Console.WriteLine("\n° Concatenación de cadenas (Anteriormente explicado) ==================================.\n");
Console.ReadKey();

//      Busqueda de patrones =====================================
Console.WriteLine("° Búsqueda de patrones. ================================================\n");
bool ecompa5 = evariable6.Contains("Hola"); //True
bool ecompa6 = evariable6.Contains("hola"); //False

//Metodo Regex.Match
string evariable8 = "El número celular de tu amigo es: 59104667 y se encuentra en al área de contactos de confianza.";
string evariable9 = @"\d+"; //Patrón para buscar dígitos
Match ebusqueda = Regex.Match(evariable8, evariable9);
Console.WriteLine($"El número encontrado es: {ebusqueda.Value}");
Console.ReadKey();

//      Formateo de cadenas =======================================
Console.WriteLine("\n° Formateo de cadenas. ================================================\n");
// Interpolación de Cadenas (Disponible desde C# 6)
Console.WriteLine("* Interpolación de Cadenas\n");

string evari1 = "Mundo";
string evari2 = $"Hola, {evari1}";

Console.WriteLine("Imprimir: "+ evari2);
Console.ReadKey();

//Método String.Format
Console.WriteLine("\n* String.Format\n");
string evari3 = string.Format("Hola, {0}", evari1);
Console.WriteLine("Imprimir: " + evari3);
Console.ReadKey();

//Formato de Tipo Específico
Console.WriteLine("\n* Formato de Tipo Específico\n");
double evari4 = 5910.4667;
string evari5 = evari4.ToString("N2");
Console.WriteLine("Imprimir: " + evari5);
Console.ReadKey();

//Uso de Cadena de Formato Compuesto
Console.WriteLine("\n* Uso de Cadena de Formato Compuesto\n");
int edia = 5;
int emes = 9;
int eaño = 1990;
string efecha = string.Format("La fecha es: {0:D2}/{1:D2}/{2}", edia, emes, eaño);
//D2 transforma en un entero de dos números, incluso si debe colocar un 0 al inicio.
Console.WriteLine(efecha);
Console.ReadKey();










