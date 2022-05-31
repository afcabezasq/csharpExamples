using CalculatorSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CalculatorTest;

[TestClass]
public class CalculatorTests
{
    
    [TestMethod]
    public void ShouldAdd()
    {
        double result = Calculator.Add(5,6);
        Console.WriteLine(result);
        Assert.AreEqual(result,11);
    }

    [TestMethod]
    public void ShouldMultiply()
    {
        double result = Calculator.Multiply(3,5);
        Console.WriteLine(result);
        Assert.AreEqual(result,15);
    }

    [TestMethod]
    public void ShouldSubtract()
    {
        double result = Calculator.Substract(5,6);
        Console.WriteLine(result);
        Assert.AreEqual(result,-1);
    }

    
    [TestMethod]
    public void ShouldDivide()
    {
        double result = Calculator.Divide(4,2);
        Console.WriteLine(result);
        Assert.AreEqual(result,2);
    }
}