using System.Collections.Generic;
using System.IO;
using BcCode128;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var zplcodeList = new List<string>();
 
     
            var barcodTemplate = "0000740617300000039000000015800000001622-28670";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001135S00130";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KING-B913U";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KIN1280";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KING-B4308";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KSG-O2/128";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "00007406173000000390000000158000000010344655 A024148";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001A029369";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KST-E-09305";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001N18201";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KIN-KGEN/14+";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001KIN-KGM100X64SC2/128";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "000074061730000003900000001580000000107091682-R";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "000074061730000003900000001580000000142000656-02-R";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            barcodTemplate = "0000740617300000039000000015800000001GDN7X";
            zplcodeList.Add(BarcodeConverter128.StringToBarcodeZplFormat(barcodTemplate));

            string result = null;

            var i = 0;
            var height = 110;
            foreach (var zpl in zplcodeList)
            {
                result = result + "^FT49," + height + "^BCN,61,N,N,Y^FD" + zpl + "^FS" + "\r\n";

                height = height + 150;
                i++;
            }


            const string top = "^XA" + "\r\n" +
                               "^LS10" + "\r\n" +
                               "^PR3,6,6^FS" + "\r\n" +
                               "^JWH^FS" + "\r\n" +
                               "^JZY" + "\r\n" +
                               "^JJ0,0^FS" + "\r\n" +
                               "^MNY^FS" + "\r\n";

            const string down = "^PQ1,0,0,Y" + "\r\n" +
                                "^XZ" + "\r\n" +
                                "^XA" + "\r\n" +
                                "^IDSTRNWARE" + "\r\n" +
                                "^XZ";

            var zplstr = "";

            zplstr = top + result + down;


            using (var sw = new StreamWriter("label.zpl"))
            {
                sw.Write(zplstr);
            }
        }
    }
}