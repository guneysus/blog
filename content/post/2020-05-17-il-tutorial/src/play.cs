using System;

namespace Play
{
    public class Program
    {
        public static void Main () {
            // Console.WriteLine(10);
			// var arr = new string[2];
			// arr[0] = "ahmed";
			// arr[1] = "şeref";
			
		
			// for(var i=0; i<5; i++) {}
			// Console.WriteLine("ş");
			var type = typeof(string);
			var m= type.GetMethod("ToString");
        }
    }
}