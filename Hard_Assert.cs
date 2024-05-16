using NUnit.Framework;


public static class HardAssertUtils
{
    public static void AreEqual(object expected, object actual, string message = "")
    {
        ClassicAssert.AreEqual(expected, actual, message);
    }


   public static void IsTrue(bool condition, string message = "")
    {
        ClassicAssert.IsTrue(condition, message);
    }


   public static void IsFalse(bool condition, string message = "")
    {
        ClassicAssert.IsFalse(condition, message);
    }
}
