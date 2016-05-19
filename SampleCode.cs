using System; /* include the System namespace */
namespace SampleApplication // namespace declaration. A namespace is a collection of classes 
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
		  
		  // String -- More string methods : http://www.tutorialspoint.com/csharp/csharp_strings.htm
		  string fullname = fname + lname;
		  
		  //by using string constructor
		  char[] letters = { 'H', 'e', 'l', 'l','o' };
		  string greetings = new string(letters); // Hello
		  
		  //methods returning string
		  string[] sarray = { "Hello", "From", "Tutorials", "Point" };
		  string message = String.Join(" ", sarray); // Hello From Tutorials Point
		  
		  //formatting method to convert a value
		  DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
		  string chat = String.Format("Message sent at {0:t} on {0:D}", waiting); // Message sent at 5:58 PM on Wednesday, October 10, 2012
		  
		  
		  
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); 
		 
		  /* output example */
         Console.WriteLine("Hello World");
         Console.ReadKey(); /* for VS.NET Users. This makes the program wait for a key press */
		 
		 Books Book1;   /* Declare Book1 of type Book */
		 Books Book2;   /* Declare Book2 of type Book */

		 /* book 1 specification */
		 Book1.title = "C Programming";
		 Book1.author = "Nuha Ali"; 
		 Book1.subject = "C Programming Tutorial";
		 Book1.book_id = 6495407;
      }
   }

   // Structure http://www.tutorialspoint.com/csharp/csharp_struct.htm
   struct Books
   {
	   public string title;
	   public string author;
	   public string subject;
	   public int book_id;
	   };  
	   
	// Enums   
	enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat }; // By default, the value of the first enumeration symbol is 0.
   #endregion
}