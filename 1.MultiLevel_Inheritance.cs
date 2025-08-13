using System;

namespace HelloWorld
{
    class First{
        public void Hello(){
            Console.WriteLine("Hello From First");
        }
    }
    class Second : First{
        public void Welcome(){
            Console.WriteLine("Welcome from Second");
        }
    }
    class Third : Second{
        public void Hi(){
            Console.WriteLine("Hi from third");
        }
    }
	class Hello {
		static void Main(string[] args) {
			Third t = new Third();
            t.Hello();
            t.Welcome();
            t.Hi();
		}
	}
}
