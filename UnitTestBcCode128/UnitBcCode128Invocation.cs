using BcCode128;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBcCode128
{
    [TestClass]
    public class UnitBcCode128Invocation
    {
        [TestMethod]
        public void TestMethod1()
        {
            var barcodTemplate = "S/N:941001-0114-0001";
            var expect = ">:S/N:>5941001>6-0114->50001";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var barcodTemplate = "000074061730000003900000001580000000125000795-02";
            var expect = ">;00007406173000000390000000158000000012500079>65-02";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod3()
        {
            var barcodTemplate = "00007406173000000390000000158000000017100703OUT";
            var expect = ">;00007406173000000390000000158000000017100703>6OUT";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod4()
        {
            var barcodTemplate = "0000740617300000039000000015800000001UPG-X-009";
            var expect = ">;000074061730000003900000001580000000>61UPG-X-009";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var barcodTemplate = "0000740617300000039000000015800000001TD3KX";
            var expect = ">;000074061730000003900000001580000000>61TD3KX";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod6()
        {
            var barcodTemplate = "000074061730000003900000001580000000115-9917-02";
            var expect = ">;00007406173000000390000000158000000011>65-9917-02";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod7()
        {
            var barcodTemplate = "0000740617300000039000000015800000001622-28670";
            var expect = ">;0000740617300000039000000015800000001622>6-2>58670";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var barcodTemplate = "0000740617300000039000000015800000001135S00130";
            var expect = ">;0000740617300000039000000015800000001135>6S0>50130";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod9()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KING-B913U";
            var expect = ">;000074061730000003900000001580000000>61KING-B913U";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KIN1280";
            var expect = ">;000074061730000003900000001580000000>61KIN>51280";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KING-B4308";
            var expect = ">;000074061730000003900000001580000000>61KING-B>54308";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod12()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KSG-O2/128";
            var expect = ">;000074061730000003900000001580000000>61KSG-O2/128";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var barcodTemplate = "00007406173000000390000000158000000010344655 A024148";
            var expect = ">;00007406173000000390000000158000000010344655>6 A>5024148";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod14()
        {
            var barcodTemplate = "0000740617300000039000000015800000001A029369";
            var expect = ">;000074061730000003900000001580000000>61A>5029369";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod15()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KST-E-09305";
            var expect = ">;000074061730000003900000001580000000>61KST-E-0>59305";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod16()
        {
            var barcodTemplate = "0000740617300000039000000015800000001N18201";
            var expect = ">;000074061730000003900000001580000000>61N1>58201";

            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod17()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KIN-KGEN/14+";
            var expect = ">;000074061730000003900000001580000000>61KIN-KGEN/14+";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod18()
        {
            var barcodTemplate = "0000740617300000039000000015800000001KIN-KGEN/14+";
            var expect = ">;000074061730000003900000001580000000>61KIN-KGEN/14+";
            var actual = BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate);
            Assert.AreEqual(expect, actual);
        }
    }
}