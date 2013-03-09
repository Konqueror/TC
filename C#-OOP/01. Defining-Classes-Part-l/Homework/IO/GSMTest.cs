using System;
using Mobile;
using System.Collections.Generic;

namespace IO
{
    class GSMTest
    {
        public static void Test()
        {
            //Create an array of few instances of the GSM class.
            List<GSM> GSMList = new List<GSM>();
            GSMList.Add(new GSM("iPhone4s", "Apple", 1800, "RichPerson", "ApppleBattery", 15, 8, BatteryTypes.NiCd, 15, 2500));
            GSMList.Add(new GSM("3310", "Nokia", 200, "PoorPerson", "NokiaBattery", 3, 2, BatteryTypes.NiCd, 4, 200));
            //Display the information about the GSMs in the array
            Console.WriteLine(GSMList[0].ToString());
            Console.WriteLine("=============");
            Console.WriteLine(GSMList[1].ToString());
            //Display the information about the static property IPhone4S.
            GSM.IPhone4s = true;
            foreach (var mobile in GSMList)
            {
                GSM.IPhone4s = true;
                Console.WriteLine("{0} : is iPhone4s: {1}\n", mobile, GSM.IPhone4s);
            }
        }
    }
}
