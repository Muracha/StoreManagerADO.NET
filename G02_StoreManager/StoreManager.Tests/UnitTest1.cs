using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StoreManager.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int x = 5;
			int y = 10;
			int actualResult = x + y;
			int expectedResult = 15; 
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
