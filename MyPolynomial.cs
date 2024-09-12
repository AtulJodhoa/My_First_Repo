using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPolynomial
{
    internal class MyPolynomial
    {
        private double[] _coeffs;
        private int _n;
        public MyPolynomial(double[] coeffs)
        {
            //Pointt the reference to the passed array
            _coeffs = new double[coeffs.Length];
            Array.Copy(coeffs, _coeffs, coeffs.Length);
            //Get the degree of the polynomial
            //eg. 4 elements in the array correspond to x^3. n = 3
            _n = coeffs.Length-1;
        }

        public int GetDegree()
        {
            return _n;
        }

        //Overriding the ToString function from the superclass
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            double temp;
            //iterate coeffcients of x^ _n to x^1
            for (int i = _n; i >= 1; i--)
            {
                //Omit any expression that has 0 as coefficient
                if (_coeffs[i] != 0)
                {
                    //Get the current coefficient
                    temp = _coeffs[i];
                    //If i equals largest indeterminate power do...
                    //We want to preserve the sign of the largest power 
                    //As code does not fall through the append operation statements
                    if (i == _n)
                    {
                        result.Append($"{temp}X^{i}");
                    }
                    if (i > 1 && i < _n)
                    {
                        //Add the absolute value to the string.
                        //Using abs value to ensure that the coefficient is always positive
                        //Append the correct sign afterwards
                        result.Append($"{Math.Abs(temp)}X^{i}");
                    }                   
                    if(i == 1 && i != _n)
                    {
                        result.Append(Math.Abs(temp) + "X ");
                    }
                    //Append + if the next coefficient is positive
                    if (_coeffs[i-1] >= 0)
                    {
                        result.Append(" + ");
                    }
                    //Append - if the next coefficient is negative
                    if (_coeffs[i-1] < 0)
                    {
                        result.Append(" - ");
                    }                   
                }
            }
            //Append the last element
            result.Append(" " + Math.Abs(_coeffs[0]));
            return result.ToString();
        }
        public double Evaluate(double x)
        {
            double result = 0; 
            //Add all expressions until last coefficient
            for (int i = _n; i >= 1; i--)
            {
                //This expression does not add the element with x^0 so we add it after the loop
                result = result + (_coeffs[i] * Math.Pow(x,i));
            }
            result = result + _coeffs[0];   
            return result;
        }

        public MyPolynomial Addition(MyPolynomial anotherPoly)
        {
            int eqn1Degree = this.GetDegree();
            int eqn2Degree = anotherPoly.GetDegree();
            int maxDegree = 0;
            //Get the degree of the new polynomial
            if (eqn1Degree > eqn2Degree)
            {
                maxDegree = eqn1Degree;
            }
            else maxDegree = eqn2Degree;
            //Declare the new polynomial
            double[] Resultcoeffs = new double[maxDegree + 1];
            for (int i = maxDegree; i >= 0; i--)
            {
                double thiscoeff =0;
                double anothercoeff = 0;
                //Only grab the coefficients of the variables in eqn 1
                if (i <= eqn1Degree)
                {
                    thiscoeff = _coeffs[i];
                }
                if (i <= eqn2Degree)
                {
                    anothercoeff = anotherPoly._coeffs[i];
                }
                Resultcoeffs[i] = thiscoeff + anothercoeff;
            }
            return new MyPolynomial(Resultcoeffs);
        }

        public MyPolynomial Multiply(MyPolynomial another)
        {
            int eqn1Degree = this.GetDegree();
            int eqn2Degree = another.GetDegree();
            int maxDegree = eqn1Degree + eqn2Degree;
            double[] resultCoeffs = new double[maxDegree + 1];

            //Start by multiplying 1 coefficient of eqn1 with all other coefficients of eqn2
            for (int i = 0; i <= eqn1Degree; i++)
            {
                //Multiply by each coeff for eqn2
                for (int j = 0; j <= eqn2Degree; j++)
                {
                    resultCoeffs[i + j] += _coeffs[i] * another._coeffs[j];
                }
            }
            
            return new MyPolynomial(resultCoeffs);
        }

    }
}
