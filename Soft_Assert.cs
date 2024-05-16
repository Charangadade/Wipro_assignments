using NUnit.Framework;
using System.Collections.Generic;


public class SoftAssert
{
    private List<string> _errors = new List<string>();


   public void AreEqual(object expected, object actual, string message = "")
    {
        try
        {
            ClassicAssert.AreEqual(expected, actual, message);
        }
        catch (AssertionException ex)
        {
            _errors.Add(ex.Message);
        }
    }


   public void IsTrue(bool condition, string message = "")
    {
        try
        {
            ClassicAssert.IsTrue(condition, message);
        }
        catch (AssertionException ex)
        {
            _errors.Add(ex.Message);
        }
    }


   public void IsFalse(bool condition, string message = "")
    {
        try
        {
            ClassicAssert.IsFalse(condition, message);
        }
        catch (AssertionException ex)
        {
            _errors.Add(ex.Message);
        }
    }


   public void AssertAll()
    {
        if (_errors.Count > 0)
        {
            throw new AssertionException(string.Join("\n", _errors));
        }
    }
}
