using System; /* include the System namespace */
namespace SampleApplication /* namespace declaration. A namespace is a collection of classes */
{


#region Class definition
   class Rectangle // Class Example
   {
      // member variables
      double length;
      double width;
      public void Acceptdetails()
      {
         length = 4.5;    
         width = 3.5;
      }
      
      public double GetArea()
      {
         return length * width; 
      }
      
      public void Display()
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }
   
   class ExecuteRectangle 
   {
      static void Main(string[] args) 
      {
		  
		  int? num1 = null;  // Syntax for declaring a nullable type
		  double num3 = num1 ?? 5.34;   // 5.34
		  
		  1<=2 ? True : False; // if 1<=2 return true
		  
		  int* iptr; // Pointer 
		  
		  object obj;
		  obj = 100; // When a value type is converted to object type, it is called boxing
		  
		  const double d = 5673.74;  // Constants are defined using the const keyword
		  int i;
		  // cast double to int.
		  i = (int)d;
		  
		  // Array
		  int[] balance = new int[10];
		  balance[0] = 4500;
		  
		  int [] marks = new int[]  { 99,  98, 92, 97, 95};
		  
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); 
		 
		  /* output example */
         Console.WriteLine("Hello World");
         Console.ReadKey(); /* for VS.NET Users. This makes the program wait for a key press */
      }
   }
#endregion
}