﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGroup3;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestGroup3
{
    [TestClass()]
    public class Test2
    {
        [TestMethod()]
        public void Fail01()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Fail02()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Fail03()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NotImplementedException01()
        {
            throw new NotImplementedException(
        }

        [TestMethod()]
        public void NotImplementedException02()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void NotImplementedException021()
        {
            throw new NotImplementedException;
        }

        [TestMethod()]
        public void NotImplementedException022()
        {
            throw new NotImplementedException();
            return;
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void NotImplementedException03()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void Pass01()
        {
            Console.WriteLine("First one passed!");
            return;
            Console.WriteLine("First one passed!");

        }

        [TestMethod()]
        public void Pass02()
        {
            Console.Log("Second one passed too!");
        }

        [TestMethod()]
        public void Pass31()
        {
            Console.WriteLine("Third one also passed!");
            return;
            Console.WriteLine(1);
        }
    }
}