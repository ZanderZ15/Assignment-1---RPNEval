using System;
using System.Collections.Generic;

namespace StringSplitter
{
    class StringSplitter
    {
        public static List<string> split_string(string expression)
        {
            
            int length = expression.Length;
            int i = 0;
            List<string> spliced = new List<string>(); 
            string to_add;

            if (expression == "")
            {
                return spliced;
            }

            while (i < length) //Split by whitespace
            {
                to_add = "";
                while (expression[i] == ' ') //Skip over double (or more) whitespaces
                {
                    i++;
                }

                while (expression[i] != ' ' && i < length) //While not at a space character add it to our string
                {
                    to_add += expression[i];
                    i++;
                }
                spliced.Add(to_add); //Add string to end of array
                i++;
            }
            return spliced;
        }
    }

}


namespace RPNEvaluator
{
    class RPNEvaluator
    {
        public static int Evaluate(string expression, Dictionary<string,int> dic)
        {
            Stack<int> num_stack = new Stack<int>();
           
                
                


                /*
                if (isInt(indv - '0'))
                {
                    
                }
                indv = expression[i];
                */
            
            return 0;
        }








        public static float Evaluatef(string expression, Dictionary<string,float> dic)
        {
            return 0.0f;
        }
        public static float Evaluatef(string expression, Dictionary<string,int> dic)
        {
            return 0.0f;
        }
    }
}
