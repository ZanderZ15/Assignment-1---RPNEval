using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RPNEvaluator
{
    public class RPNEvaluator
    {
        public static int Evaluate(string expression, Dictionary<string,int> dic)
        {
            dic ??= new Dictionary<string, int>(); //in case no dic was passed
            if (string.IsNullOrWhiteSpace(expression)) throw new ArgumentException("Expression cannot be empty.");

            Stack<int> num_stack = new Stack<int>();
           
            string[] split = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] operators = ["+", "-", "*", "/", "%"];
            

            foreach (string el in split) //iterate
            {
                int to_push;
                if (operators.Contains(el)) 
                {
                    int a, b;
                    //Pop top two numbers from stack into a and b
                    if (num_stack.Count < 2) throw new ArgumentException("Invalid RPN: Not enough operands.");
                    
                    b = num_stack.Pop();
                    a = num_stack.Pop();
                    
                    if (b == 0 && (el == "/" || el == "%")) //Check for / or % by 0
                    {
                        throw new DivideByZeroException($"Cannot {el} by zero.");
                    }
                    
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
                else if (dic.TryGetValue(el, out to_push))//should only ever be a var otherwise but check anyways
                {
                    //push the value in the dictionary
                    num_stack.Push(to_push);
                }
                else {throw new ArgumentException("Variable not found.");}
            }
            if (num_stack.Count == 1) {return num_stack.Pop();} 
            
            else {throw new ArgumentException("Invalid RPN: Too many operands left.");}
        }





        public static float Evaluatef(string expression, Dictionary<string,float> dic)
        {
            dic ??= new Dictionary<string, float>(); //in case no dic was passed
            if (string.IsNullOrWhiteSpace(expression)) throw new ArgumentException("Expression cannot be empty.");

            Stack<float> num_stack = new Stack<float>();
           
            string[] split = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] operators = ["+", "-", "*", "/", "%"];
            

            foreach (string el in split) //iterate
            {
                float to_push;
                if (operators.Contains(el)) 
                {
                    float a, b;
                    //Pop top two numbers from stack into a and b
                    if (num_stack.Count < 2) throw new ArgumentException("Invalid RPN: Not enough operands.");
                    
                    b = num_stack.Pop();
                    a = num_stack.Pop();
                    
                    if (b == 0 && (el == "/" || el == "%")) //Check for / or % by 0
                    {
                        throw new DivideByZeroException($"Cannot {el} by zero.");
                    }
                    
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
                else if (float.TryParse(el, out to_push)) //check if its a number; Also writes the number to to_push if number
                {
                    //push to stack
                    num_stack.Push(to_push);
                }
                else if (dic.TryGetValue(el, out to_push))//should only ever be a var otherwise but check anyways
                {
                    //push the value in the dictionary
                    num_stack.Push(to_push);
                }
                else {throw new ArgumentException("Variable not found.");}
            }
            if (num_stack.Count == 1) {return num_stack.Pop();} 
            
            else {throw new ArgumentException("Invalid RPN: Too many operands left.");}
        }




        public static float Evaluatef(string expression, Dictionary<string,int> dic)
        {
            dic ??= new Dictionary<string, int>(); //in case no dic was passed
            if (string.IsNullOrWhiteSpace(expression)) throw new ArgumentException("Expression cannot be empty.");

            Stack<float> num_stack = new Stack<float>();
           
            string[] split = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] operators = ["+", "-", "*", "/", "%"];
            

            foreach (string el in split) //iterate
            {
                float to_push;
                if (operators.Contains(el)) 
                {
                    float a, b;
                    //Pop top two numbers from stack into a and b
                    if (num_stack.Count < 2) throw new ArgumentException("Invalid RPN: Not enough operands.");
                    
                    b = num_stack.Pop();
                    a = num_stack.Pop();
                    
                    if (b == 0 && (el == "/" || el == "%")) //Check for / or % by 0
                    {
                        throw new DivideByZeroException($"Cannot {el} by zero.");
                    }
                    
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
                else if (float.TryParse(el, out to_push)) //check if its a number; Also writes the number to to_push if number
                {
                    //push to stack
                    num_stack.Push(to_push);
                }
                else if (dic.TryGetValue(el, out int integer))//should only ever be a var otherwise but check anyways
                {
                    to_push = integer;
                    //push the value in the dictionary
                    num_stack.Push(to_push);
                }
                else {throw new ArgumentException("Variable not found.");}
            }
            if (num_stack.Count == 1) {return num_stack.Pop();} 
            
            else {throw new ArgumentException("Invalid RPN: Too many operands left.");}
        }
    }
}
