using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace csudh
{
    public class Program
    {
       static List<IPaddress> listam = new List<IPaddress>(); 
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("csudh.txt");
            
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                listam.Add(new IPaddress(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3.Feladat:A lista tartalma:");
            foreach (var item in listam)
            {
                Console.WriteLine(item.domainname+" "+item.ipaddress);
            }
            Console.WriteLine();
            Console.WriteLine("A lista címtartalma: "+listam.Count());
            Console.WriteLine();


            string megoldas = Domain("ddd.bbb.ccc", 3);
            Console.WriteLine(megoldas);
            Console.WriteLine();
            foreach (var item in listam)
            {
                Console.WriteLine("5.Feladat:Az első domain felépítése:");
                    string[] words = item.domainname.Split('.');
                    string firstWord = "";
                    string secondWord = "";
                    string thirdWord = "";
                    string fourthWord = "";
                    string fifthhWord = "";

                    if (words.Length >= 3)
                    {
                        firstWord = words[0];
                        secondWord = words[1];
                        thirdWord = words[2];
                        fourthWord = "nincs";

                        if (words.Length >= 4)
                        {
                            fourthWord = words[3];

                        }
                        fifthhWord = "nincs";

                    }

                    Console.WriteLine("1.szint:" + firstWord + "\n" + "2.szint:" + secondWord + "\n" + "3.szint:" + thirdWord + "\n" + "4.szint:" + fourthWord + "\n" + "5.szint:" + fifthhWord);
                    Console.WriteLine();

                break;
            }


            StreamWriter sw = new StreamWriter("table.html");
            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<table>");

           
            sw.WriteLine("<tr>");
            sw.WriteLine("<td>Ssz</td>");
            sw.WriteLine("<td>Host domainneve</td>");
            sw.WriteLine("<td>Host IP címe</td>");
            sw.WriteLine("<td>1.szint</td>");
            sw.WriteLine("<td>2.szint</td>");
            sw.WriteLine("<td>3.szint</td>");
            sw.WriteLine("<td>4.szint</td>");
            sw.WriteLine("<td>5.szint</td>");
            sw.WriteLine("</tr>");
            int counter = 0;
            foreach (var item in listam)
            {
                counter++;
                

                string[] words = item.domainname.Split('.');
                string firstWord = "";
                string secondWord = "";
                string thirdWord = "";
                string fourthWord = "";
                string fifthhWord = "";

                if (words.Length >= 3)
                {
                    firstWord = words[0];
                    secondWord = words[1];
                    thirdWord = words[2];
                    fourthWord = "nincs";

                    if (words.Length >= 4)
                    {
                        fourthWord = words[3];

                    }
                    fifthhWord = "nincs";

                }
                sw.WriteLine("<tr>");
                sw.WriteLine("<td>"+counter+"</td>");
                sw.WriteLine("<td>"+item.domainname+"</td>");
                sw.WriteLine("<td>"+item.ipaddress+"</td>");
                sw.WriteLine("<td>"+firstWord+"</td>");
                sw.WriteLine("<td>"+secondWord+"</td>");
                sw.WriteLine("<td>"+thirdWord+"</td>");
                sw.WriteLine("<td>"+fourthWord+"</td>");
                sw.WriteLine("<td>"+fifthhWord+"</td>");
                sw.WriteLine("</tr>");

            }

            sw.WriteLine("</table>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();




            Console.ReadKey();

        }

        public static string Domain(string domain, int index)
        {
            string[] parts = domain.Split('.');
            if (index < 1 || index > parts.Length)
            {
                return "nincs";
            }

            return parts[parts.Length - index];
        }
    }
}
