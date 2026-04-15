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
            

            foreach (string el in split) //iterate
            {
                int to_push;
                if (operators.Contains(el)) 
                {
                    //Pop top two numbers from stack into a and b
                    int a = num_stack.Pop();
                    int b = num_stack.Pop();

                    to_push = el switch //Do the operation
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => a / b,
                        "%" => a % b,
                        _ => throw new InvalidOperationException()
                    }; 
                    //Push result to stack
                    num_stack.Push(to_push);
                }
                else if (int.TryParse(el, out to_push)) //check if its a number; Also writes the number to to_push if number
                {
                    //push to stack
                    num_stack.Push(to_push);
                }
                else if () //check if its a var
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
