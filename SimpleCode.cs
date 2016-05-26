using System; /* include the System namespace */
namespace SampleApplication // namespace declaration. A namespace is a collection of classes 
{



   #region Class definition
   class Rectangle // Class Example
   {
      // member variables
      public double length; // default access specifier for a class type is internal. Default access for the members is private
      public  double width;
	  
	  public Rectangle() // constructor is a special member function of a class that is executed whenever we create new objects of that class
      { // A default constructor does not have any parameter
         Console.WriteLine("Object is being created");
      }
	  
	  ~Rectangle() //destructor is a special member function of a class that is executed whenever an object of its class goes out of scope
      { // it can neither return a value nor can it take any parameters.
         Console.WriteLine("Object is being deleted");
      } // Destructor can be very useful for releasing memory resources before exiting the program. Destructors cannot be inherited or overloaded.
	  
	  public Rectangle(double len)  //Parameterized constructor
      {
         length = len;
      }
	  
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
	   
	  public static void showMessage(String msg){ // static functions exist even before the object is created.
		 Console.WriteLine("message: ", msg);
	  }
   }
   
      // Derived class  : A class can be derived from more than one class or interface
   class Shape: Rectangle , PaintCost
   {
	  private double cost;
      //public Tabletop(double l, double w) : base(l, w)  // The derived class inherits the base class member variables and member methods.
      //{ }
	   
      public double getArea()
      { 
         return (width * length); 
      }

      public double GetCost() // Function Overloading : The definition of the function must differ from each other by the types and/or the number of arguments in the argument list. You cannot overload function declarations that differ only by return type.
      {
         double cost;
         cost = GetArea() * 70;
         return cost;
      }
	  
	  public int getCost(int area) // face multiple inheritance example
      {
         return area * 70;
      }
	  
	   public void Display()
      {
         base.Display();
         Console.WriteLine("Cost: {0}", GetCost());
      }
   }
   
    // Base class PaintCost  // C# does not support multiple inheritance. However, you can use interfaces to implement multiple inheritance. 
   public interface PaintCost 
   {
      int getCost(int area);

   }
   
   class ExecuteRectangle 
   {
	   
      static void Main(string[] args)  // static -- only one instance of the member exists for a class
      {
		  
		  int? num1 = null;  // Syntax for declaring a nullable type
		  double num3 = num1 ?? 5.34;   // 5.34
		  Console.WriteLine(num3);
		  
		  bool result=1<=2 ? true : false; // if 1<=2 return true
		  Console.WriteLine(result);
		  
		  //int* iptr; // Pointer 
		  
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
		  string fullname = "Ying" + "Wang";
		  
		  //by using string constructor
		  char[] letters = { 'H', 'e', 'l', 'l','o' };
		  string greetings = new string(letters); // Hello
		  Console.WriteLine(greetings);
		  
		  //methods returning string
		  string[] sarray = { "Hello", "From", "Tutorials", "Point" };
		  string message = String.Join(" ", sarray); // Hello From Tutorials Point
		  Console.WriteLine(message);
		  
		  //formatting method to convert a value
		  DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
		  string chat = String.Format("Message sent at {0:t} on {0:D}", waiting); // Message sent at 5:58 PM on Wednesday, October 10, 2012
		  Console.WriteLine(chat);
		  		  
		  
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
		 Shape t = new Shape(4.5, 7.5);
         t.Display();
		 sha.Acceptdetails();
		 Console.WriteLine("Total area: {0}",  sha.getArea()); // 4.5*3.5
		 Console.WriteLine("Total paint cost: ${0}" , sha.getCost(area));
		 
		  /* output example */
         Console.ReadKey(); /* for VS.NET Users. This makes the program wait for a key press */
		 
		 Books Book1;   /* Declare Book1 of type Book */
		 Books Book2;   /* Declare Book2 of type Book */

		 /* book 1 specification */
		 Book1.title = "C Programming";
		 Book1.author = "Nuha Ali"; 
		 Book1.subject = "C Programming Tutorial";
		 Book1.book_id = 6495407;
		 
		 Console.ReadLine();
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

// Important complex data structure: 
// Polymorphism : http://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
// Operator Overloading : http://www.tutorialspoint.com/csharp/csharp_operator_overloading.htm