using System;
using NUnit.Framework;

namespace Authority.Test.Unit
{
    [TestFixture]
    public class AuthorityConfigurationTests
    {
        [Test]
        public void Ctor_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => new AuthorityConfiguration());
        }

        [Test]
        public void Default_ReturnsConfigInstance()
        {
            var instance = AuthorityConfiguration.Default();

            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void ConfiguredApplication_ReturnsCommandLineApp()
        {
            var instance = AuthorityConfiguration.Default().ConfiguredApplication();

            Assert.That(instance, Is.TypeOf<CommandLineApplication>());
        }
    }
}
