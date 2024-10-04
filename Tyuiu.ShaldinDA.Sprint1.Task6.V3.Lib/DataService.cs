using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShaldinDA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string WorkWithText(string value)
        {
            string[] words = value.Split(' ');
            string res = "";
            foreach (string word in words) 
            {
                int lenth = word.Length;
                res += word[lenth - 1];
            }

                
            return res;


        

        }
    }
}
