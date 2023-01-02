using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_I
{
    public class List_output
    {
        private static List_output instance;
        public static List_output Instance
        {
            get
            {
                if (instance == null)
                    instance = new List_output();
                return instance;
            }
            set => instance = value;
        }


        List<Output> list_outputs;
        public List<Output> List_outputs { get => list_outputs; set => list_outputs = value; }



        List_output()
        {
            list_outputs = new List<Output>();
            //list_outputs.Add(new Output("ADMIN","20200445", "quanly"));

        }
    }
}
