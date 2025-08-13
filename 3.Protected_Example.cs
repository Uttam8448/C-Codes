using System;

namespace HelloWorld
{
    class Numbers{
        protected int num1,num2;
        public Numbers(){
            num1 = 10;
            num2 = 20;
        }
        public void DisplayNumbers(){
            Console.WriteLine("num1="+this.num1);
            Console.WriteLine("num2=" + this.num2);
        }
    }
    class Sum : Numbers{
        public int total;
        public Sum(){
            total=this.num1+this.num2;
        }
        public void SumDisplay(){
            Console.WriteLine("Sum is :"+ total);
        }
    }

	class Hello {
		static void Main(string[] args) {
			Sum s1 = new Sum();
            s1.DisplayNumbers();
            s1.SumDisplay();
		}
	}
}
