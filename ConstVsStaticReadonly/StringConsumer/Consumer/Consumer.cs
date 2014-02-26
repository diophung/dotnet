using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringProducer;

namespace StringConsumer
{
    public class Consumer
    {
	    public static void Main(string[] args)
	    {
			string constStr = Producer.ConstString;
			string staticStr = Producer.StaticReadonlyStringValue;


			Console.WriteLine(constStr);
			Console.WriteLine(staticStr);
		    Console.ReadLine();
	    }
    }
}
