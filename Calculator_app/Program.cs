using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_app
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Welcome to Calculator.");
            string input = "";
            StringCalculator calculator= new StringCalculator();
            double answer = 0.0;
            while (true)
            {
                Console.Write("Calculate: ");
                input = Console.ReadLine();
                if(input.CompareTo("e") >= 0)
                {
                    Console.WriteLine("Bye Bye...");
                    break;
                }
                else
                {
                    answer = calculator.calculate(input);
                    Console.Write(" Result: " + answer + "\n------------------------\n");
                }
                

            }
        }
    }
    public class StringCalculator
    {

        public StringCalculator()
        {
        }

        public double calculate(string expression)
        {
            /**
            * EXPECTED EXPRESSION FORM: 12*2+12/2-2*3.5
            **/
            double final_answer = 0.0;

            if (isValid(expression))
            {
                //expression cleanup
                string clean_expression = expression.Replace(" ", "");

                clean_expression = clean_expression.Replace(".", ",");  //convert into correct comma
                clean_expression = clean_expression.Replace("-", "+-"); //convert into addition terms
                string[] expression_terms = clean_expression.Split('+');//split into terms

                //calculate terms  
                foreach (string term in expression_terms)
                {
                    double term_answer = 0;

                    if (term.Contains("*"))
                    {
                        //multiplication
                        string[] multiplicationNums = term.Split('*');
                        term_answer = 1.0;
                        foreach (string num in multiplicationNums)
                        {
                            term_answer *= double.Parse(num);
                        }
                    }
                    else if (term.Contains("/"))
                    {
                        //division
                        string[] divisionNums = term.Split('/');
                        term_answer = double.Parse(divisionNums[0]);

                        for (int i = 1; i < divisionNums.Length; i++)
                        {
                            term_answer /= double.Parse(divisionNums[i]);
                        }
                    }
                    else
                    {//when there's no * and /
                        term_answer = double.Parse(term);
                    }

                    final_answer += term_answer;
                }
;
            }

            return final_answer;

        }

        private bool isValid(String expression)
        {

            return true;
        }
    }
}
