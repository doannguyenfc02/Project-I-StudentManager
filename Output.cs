using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_I
{
    public class Output
    {
        private string fullname;
        private string mssv;
        private string note;


        public string Fullname { get => fullname; set => fullname = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Note { get => note; set => note = value; }
        public Output(string fullname, string mssv, string note)
        {
            this.Fullname = fullname;
            this.Mssv = mssv;
            this.Note = note;
        }
        public Output(DataRow rows) 
        {
            this.Fullname = rows[0].ToString();
            this.Mssv = rows[1].ToString();
            this.Note = rows[2].ToString();

        }
    }
}
