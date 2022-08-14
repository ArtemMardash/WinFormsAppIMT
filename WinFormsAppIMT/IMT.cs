using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppIMT
{
    internal class IMT
    {
        int age;
        int weight;
        int height;
        string name;
        string gender;
        string result;

        public IMT(string name, int height, int weight, string gender, int age)
        {
            this.age = age;
            this.weight = weight;
            this.gender = gender;
            this.height = height;
            this.name = name;
        }
        public string DoRecomendations()
        {
            double imt = weight / ((Math.Pow(height, 2) / 10000));
            if(age >= 18)
            {
                if (gender == "М")
                {
                    if (imt < 18)
                    {
                        result  = "Истощение";
                    }
                    else if(imt > 18 && imt < 24)
                    {
                        Console.WriteLine("Идеальный вес");
                    }
                    else if (imt > 24 && imt < 29)
                    {
                        result = "Немного лишнего веса";
                    }
                    else if (imt > 29)
                    {
                        result = "Ожирение";
                    }
                    return result;
                }
                else
                {
                    if(imt < 20)
                    {
                       result = "истощение";
                    }
                    else if(imt > 20 && imt < 26)
                    {
                        result = "Идеальный вес";
                    }
                    else if(imt > 26 && imt < 31)
                    {
                        result = "немного лишнего веса";
                    }
                    else if(imt > 31)
                    {
                        result = "Ожирение";
                    }
                    return result;
                }
            }
            else
            {
                return "IMT = " + imt + "this is work only for adults people";
            }
        }



    }
}
