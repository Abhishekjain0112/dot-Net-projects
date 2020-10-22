using System;
using System.Collections.Generic;

namespace AddNewMember
{
    public class Club          //Do not change the class name
    {

        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };

        public static void Main(string[] args)        //Do not change the method signature
        {
            Console.WriteLine("Group Name:");
            string grp = Console.ReadLine();
            int num=0;

            foreach (var keyValue in groupInfo) {
                if (keyValue.Value.Equals(grp)) {
                    num = keyValue.Key;
                }
            }
            Console.WriteLine("Member Name:");
            string name = Console.ReadLine();

            foreach (var keyvalue in memberInfo) {
                if (keyvalue.Key== num) {
                    keyvalue.Value.Add(name);
                }
            
            }

            foreach (var keyvalue in memberInfo)
            {
                if (keyvalue.Key == num)
                {
                    foreach (string ss in keyvalue.Value) {
                        Console.WriteLine(ss);
                    }
                }

            }







        }
    }
}
