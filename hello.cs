using System ;

namespace Demo{
	class Hello{
		public static void Main( string[] s ){
			Console.WriteLine("Main functon only!") ;
		}

		public status void Print( string s ){
			Console.WriteLine( s ) ;
		}
		
		public status void Show( string s ){
			Print( s ) ;
		}
		
		public status void Hello(){
			Print("hello!") ;
		}
	}
}
