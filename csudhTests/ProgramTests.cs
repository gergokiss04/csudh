using Microsoft.VisualStudio.TestTools.UnitTesting;
using csudh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DomainTest()
        {
            
            
            Assert.AreEqual("nincs", Program.Domain("ddd.bbb.ccc", 4));

            Assert.AreEqual("ddd", Program.Domain("ddd.bbb.ccc", 3));

            Assert.AreNotEqual("dbd", Program.Domain("ddd.bbb.ccc", 3));
        }
    }
}