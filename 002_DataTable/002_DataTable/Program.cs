using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _002_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataTable dt = new DataTable("Test"))
            {
                dt.Columns.Add("Dossage", typeof(int));
                dt.Columns.Add("Drug", typeof(string));
                dt.Columns.Add("Patient", typeof(string));
                dt.Columns.Add("Age", typeof(int));
                dt.Rows.Add(1, "Molly", "John", 12);
                dt.Rows.Add(1, "Porcoset", "Kaga", 24);
                dt.Rows.Add(1, "Molly", "ya", 121);
                dt.Rows.Add(1, "porcoset", "nhoj", 12);

                foreach(DataRow dr in dt.Rows)
                {
                    Console.WriteLine($"Dossage = {dr["Dossage"]}, Drug = {dr["Drug"]} , Patient = {dr["Patient"]}, Age = {dr["Age"]} ");
                }

            }
            Console.ReadLine();
        }
    }
}
