using System;
using System.Collections.Generic;

namespace RPNEvaluator
{
    class RPNEvaluator
    {
        public static int Evaluate(string expression, Dictionary<string,int> dic)
        {
            Stack<int> num_stack = new Stack<int>();
            int i = 0;
            char indv = ' ';
            List<string> spliced = new List<string>(); 
            string to_push;

            while (expression[i] != '\0') //Have to split by whitespace
            {
                to_push = "";
                while (indv != ' ' || indv != '\0')
                {
                    indv = expression[i];
                    to_push += indv;
                    i++;
                }
                spliced.Add(to_push);
                
                


                /*
                if (isInt(indv - '0'))
                {
                    
                }
                indv = expression[i];
                */
            }
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
