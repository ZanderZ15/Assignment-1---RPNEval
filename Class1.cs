using System;
using System.Collections.Generic;

namespace RPNEvaluator
{
    class RPNEvaluator
    {
        public static int Evaluate(string expression, Dictionary<string,int> dic)
        {
            Stack<int> num_stack = new Stack<int>();
           
            string[] words = expression.Split(' ');

                


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
