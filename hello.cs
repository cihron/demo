using System ;

namespace Demo{
	class Hello{
		public static void Main( string[] s ){
			Console.WriteLine("Main functon only!") ;
		}

		public static void Print( string s ){
			Console.WriteLine( s ) ;
		}
		
		public static void Show( string s ){
			Print( s ) ;
		}
		
		public static void Say_hello(){
			Print("hello!") ;
		}
	}
}
