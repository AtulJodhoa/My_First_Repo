namespace MyPolynomial
{
    class TestMyPolynomial
    {
        static void Main()
        {
            //double[] arr = { -2, -2, 3, 0, -4 };
            //MyPolynomial equation1 = new MyPolynomial(arr);
            //Console.WriteLine("The degree of this polynomial is: " + equation1.GetDegree());
            //Console.WriteLine(equation1.ToString());
            //Console.WriteLine("Evaluating the expression with x = 2");
            //Console.WriteLine(equation1.Evaluate(2));

            ////Note that program does not work if trailing 0s are added
            ////But why would you add trailing zeros :0 when you can use a smaller array with less elements
            ////e.g. double[] arr2 = { 6, -2, 0,0 };
            //double[] arr2 = { 6, -2, 1, 8 };
            //MyPolynomial equation2 = new MyPolynomial(arr2);
            //Console.WriteLine("The degree of this polynomial is: " + equation2.GetDegree());
            //Console.WriteLine(equation2.ToString());
            //Console.WriteLine("Evaluating the expression with x = -2");
            //Console.WriteLine(equation2.Evaluate(-2));

            ////Addition
            //Console.WriteLine("\n(" + equation1.ToString() + ") + (" + equation2.ToString() + ") :");
            //MyPolynomial resultAddEqn = equation1.Addition(equation2);
            //Console.WriteLine("The degree of this polynomial is: " + resultAddEqn.GetDegree());
            //Console.WriteLine(resultAddEqn.ToString());
            ////Multiply
            //MyPolynomial resultMultiplyEqn = equation1.Multiply(equation2);
            //Console.WriteLine("\n(" + equation1.ToString() + ") (" + equation2.ToString() + ") :");
            //Console.WriteLine("The degree of this polynomial is: " + resultMultiplyEqn.GetDegree());
            //Console.WriteLine(resultMultiplyEqn.ToString());
            //Console.ReadKey();

            double[] poly1 = { 4, 0, 3, 2 };
            double[] poly2 = { 1, 2, 7, 0, 5 };

            MyPolynomial equation1 = new MyPolynomial(poly1);
            Console.WriteLine("The degree of this polynomial is: " + equation1.GetDegree());
            Console.WriteLine(equation1.ToString());
            Console.WriteLine("Evaluating the expression with x = 5");
            Console.WriteLine(equation1.Evaluate(5));

            MyPolynomial equation2 = new MyPolynomial(poly2);
            Console.WriteLine("The degree of this polynomial is: " + equation2.GetDegree());
            Console.WriteLine(equation2.ToString());
            Console.WriteLine("Evaluating the expression with x = 5");
            Console.WriteLine(equation2.Evaluate(5));

            //Addition
            Console.WriteLine("\n(" + equation1.ToString() + ") + (" + equation2.ToString() + ") :");
            MyPolynomial resultAddEqn = equation1.Addition(equation2);
            Console.WriteLine("The degree of this polynomial is: " + resultAddEqn.GetDegree());
            Console.WriteLine(resultAddEqn.ToString());
            //Multiply
            MyPolynomial resultMultiplyEqn = equation1.Multiply(equation2);
            Console.WriteLine("\n(" + equation1.ToString() + ") (" + equation2.ToString() + ") :");
            Console.WriteLine("The degree of this polynomial is: " + resultMultiplyEqn.GetDegree());
            Console.WriteLine(resultMultiplyEqn.ToString());
            Console.ReadKey();

            //Questions in pdf
            //It is important to keep the degree of the eqn as an instance variable of the class
            //to encapsulate it. This helps with abstraction of the code as the test driver MyPolynomialClass
            //should only be provided with an interface to interact with the variable.
            //No direct access also means secure code as the value of _n cannot be changed outside of the encapsulated class

            //Since C/C++ have more focus on memory usage than C#, memory efficiency can play a big role
            //in keeping the instance variable or dynamically calculating it during runtime.
        }
    }
}
