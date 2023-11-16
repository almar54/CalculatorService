using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Sum(double num1, double num2);
        [OperationContract]
        double Sub(double num1, double num2);
        [OperationContract]
        double Mul(double num1, double num2);
        [OperationContract]
        double Div(double num1, double num2);
    }
}
