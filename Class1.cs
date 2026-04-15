using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RPNEvaluator
{
    class RPNEvaluator
    {
        public static int Evaluate(string expression, Dictionary<string,int> dic)
        {
            Stack<int> num_stack = new Stack<int>();
           
            string[] split = expression.Split(' ');
            string[] operators = ["+", "-", "*", "/", "%"];

            foreach (string el in split)
            {
                if (operators.Contains(el)) //check if its an op
                {
                    //do the operation
                }
                if () //check if its a number
                {
                    //push to stack
                }
                if () //check if its a var
                {
                    //lookup the var in dictionary
                }
            }


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
