using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentPosInList = 0;
            //int temporaryPosInListVal1;
            //int temporaryPosInListVal2;
            //int temporaryPosInListChangeVal;
            //int positionToChange;
            //bool b_switch = true;
            //int tempValueHolder = 0;
            string file = "input.txt";
            List<int> opcodes = new List<int>();
            List<int> tempList = new List<int>();
            int pos0OfTempList = 0;
            Program P = new Program();

            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                for (int i = 0;  i < values.Length; i++)
                {
                    opcodes.Add(Convert.ToInt32(values[i]));
                }
            }
            int counter = 0;


                for (int i = 1; i < 100; i++)
                {
                    for (int j = 1; j < 100; j++)
                    {
                        tempList.Clear();
                        tempList = new List<int>(opcodes);
                        //foreach (int z in opcodes)
                        //{
                        //    tempList.Add(opcodes[z]);
                        //}

                    //foreach (int zzz in opcodes)
                    //{
                    //    Console.WriteLine(zzz);
                    //}

                    //Console.WriteLine("SPLITTTTINGINLLSKDJFLKSJDLFSKDFJLSDKFJ");
                    //foreach (int zzzz in tempList)
                    //{
                    //    Console.WriteLine(zzzz);
                    //}

                        P = new Program();
                        tempList[1] = i;
                        tempList[2] = j;
                        //Console.WriteLine("Before function call");
                        
                        pos0OfTempList = P.OpCodeCalculation(tempList);
                        //Console.WriteLine("After Function" + pos0OfTempList);
                        if (pos0OfTempList == 19690720)
                        {
                            Console.WriteLine("WINNER Noun Value: " + tempList[1] + " Verb Value: " + tempList[2]);
                            break;
                        }
                    //Console.WriteLine("Running Inner Inner loop");
                    Console.WriteLine("Noun Value: " + tempList[1] + " Verb Value: " + tempList[2]);

                }
                if (pos0OfTempList == 19690720)
                    {
                        break;
                    }
                //Console.WriteLine("Running Inner loop");
                }

          

            //while (opcodes[currentPosInList] != 99)
            //{
            //    if (opcodes[currentPosInList] == 1)
            //    {
            //        temporaryPosInListVal1 = opcodes[currentPosInList + 1];
            //        temporaryPosInListVal2 = opcodes[currentPosInList + 2];
            //        temporaryPosInListChangeVal = opcodes[currentPosInList + 3];
            //        tempValueHolder = opcodes[temporaryPosInListVal1] + opcodes[temporaryPosInListVal2];
            //        opcodes[temporaryPosInListChangeVal] = tempValueHolder;
            //        currentPosInList += 4;
            //    }
            //    if (opcodes[currentPosInList] == 2)
            //    {
            //        temporaryPosInListVal1 = opcodes[currentPosInList + 1];
            //        temporaryPosInListVal2 = opcodes[currentPosInList + 2];
            //        temporaryPosInListChangeVal = opcodes[currentPosInList + 3];
            //        tempValueHolder = opcodes[temporaryPosInListVal1] * opcodes[temporaryPosInListVal2];
            //        opcodes[temporaryPosInListChangeVal] = tempValueHolder;
            //        currentPosInList += 4;
            //    }
            //}


            //foreach (int i in opcodes)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Number of elements in List " + opcodes.Count);
        }
        public int OpCodeCalculation(List<int> opcodes)
        {
            int currentPosInList = 0;
            int temporaryPosInListVal1;
            int temporaryPosInListVal2;
            int temporaryPosInListChangeVal;
            int positionToChange;
            int tempValueHolder = 0;
            int valueToReturn;
            int counter = 0;

            while (opcodes[currentPosInList] != 99)
            {
                if (opcodes[currentPosInList] == 1)
                {
                    temporaryPosInListVal1 = opcodes[currentPosInList + 1];
                    temporaryPosInListVal2 = opcodes[currentPosInList + 2];
                    temporaryPosInListChangeVal = opcodes[currentPosInList + 3];
                    tempValueHolder = opcodes[temporaryPosInListVal1] + opcodes[temporaryPosInListVal2];
                    opcodes[temporaryPosInListChangeVal] = tempValueHolder;
                    currentPosInList += 4;
                }
                if (opcodes[currentPosInList] == 2)
                {
                    temporaryPosInListVal1 = opcodes[currentPosInList + 1];
                    temporaryPosInListVal2 = opcodes[currentPosInList + 2];
                    temporaryPosInListChangeVal = opcodes[currentPosInList + 3];
                    tempValueHolder = opcodes[temporaryPosInListVal1] * opcodes[temporaryPosInListVal2];
                    opcodes[temporaryPosInListChangeVal] = tempValueHolder;
                    currentPosInList += 4;
                }
                counter++;
                if (counter >= opcodes.Count)
                {
                    break;
                }
            }
            if (opcodes[0] != 0)
            {
                Console.WriteLine("Zero Position of List is: " + opcodes[0]);

            }
            valueToReturn = opcodes[0];
            return opcodes[0];
        }
    }

}

