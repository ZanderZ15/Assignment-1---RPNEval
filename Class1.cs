using System;
using System.Collections.Generic;

namespace StringSplitter
{
    class StringSplitter
    {
        public static List<string> split_string(string expression)
        {
             int i = 0;
            char indv = ' ';
            List<string> spliced = new List<string>(); 
            string to_add;

            while (expression[i] != '\0') //Split by whitespace
            {
                to_add = "";
                while (indv != ' ' || indv != '\0') //While not at a space character add it to our string
                {
                    indv = expression[i];
                    to_add += indv;
                    i++;
                }
                spliced.Add(to_add); //Add string to end of array
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
