using NUnit.Framework;

namespace TestProject
{
	[TestFixture]
	public class WelcomerTest
	{
		[Test]
		public void Should_Say_Hello_World()
		{
			Assert.AreEqual("Hello Word", Welcomer.SayHello());
		}
	}
}
