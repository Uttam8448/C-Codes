using System;

namespace HelloWorld
{
    class TataGroup{
        public void Workss(){
            Console.WriteLine("Hello From TataGroup!!");
        }
    }
    class TCS : TataGroup{
        public void Works(){
            Console.WriteLine("Welcome from TCS. TCS works in IT services");
        }
    }
    class TataMotors : TataGroup{
        public void Work(){
            Console.WriteLine("Welcome to TataMotors.");
        }
    }
	class Hello {
		static void Main(string[] args) {
			TataMotors t1 = new TataMotors();
            t1.Workss();
            t1.Work();
            TCS t2 = new TCS();
            t2.Workss();
            t2.Works();
		}
	}
}
