/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



    public class Program
    {
     public int add(int a,int b)
    {
        int c;
        return c = a + b;
        
    }


        static void Main(string[] args)
        {
         Program prog = new Program();
        var res=prog.add(3,2);

        var jsonObject = new { result = res,
            prog = prog.add(3, 7)
        };

        var json=JsonConvert.SerializeObject(jsonObject);
        File.WriteAllText("new.json",json);
        }
    }

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



public class Program
{
    public int add(int a, int b)
    {
        int c;
        return c = a + b;

    }


    static void Main(string[] args)
    {
        Program prog = new Program();
        var res = prog.add(3, 2);


        string json = File.ReadAllText("new.json");
        var jsonObject = JsonConvert.DeserializeObject(json);

        Console.WriteLine(jsonObject);
      
    }
}