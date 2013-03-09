using System;
using Mobile;


namespace IO
{
    class GSMCallHistoryTest
    {
        public static void Test()
        {
            //Create an instance of the GSM class.
           
            GSM TestGSM = new GSM("iPhone4s", "Apple", 1800, "RichPerson", "ApppleBattery", 15, 8, BatteryTypes.NiCd, 15, 2500);
            //Add few calls.
            TestGSM.AddCall(DateTime.Now, DateTime.Now, "088891450", 200);
            TestGSM.AddCall(DateTime.Now, DateTime.Now, "088891451", 123);
            TestGSM.AddCall(DateTime.Now, DateTime.Now, "088891452", 432);
            TestGSM.AddCall(DateTime.Now, DateTime.Now, "088891453", 523);
            
            //Display the information about the calls.
            Console.WriteLine(TestGSM.CallHisotryToString());
            
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine(TestGSM.CalculateCallPrice((decimal)0.37));
            
            //Remove the longest call from the history and calculate the total price again.
            TestGSM.DeleteCall("088891453");
            Console.WriteLine(TestGSM.CalculateCallPrice((decimal)0.37));
            
            //Finally clear the call history and print it.
            TestGSM.ClearHistory();
            Console.WriteLine(TestGSM.CallHisotryToString());


        }
    }
}
