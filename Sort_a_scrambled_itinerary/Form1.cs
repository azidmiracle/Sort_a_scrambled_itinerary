//This is an exercise problem from Google Kickstart.
//I used C# and windows form
//Problem
//Once upon a day, Mary bought a one-way ticket from somewhere to somewhere with some flight transfers.

//For example: SFO->DFW DFW->JFK JFK->MIA MIA->ORD.

//Obviously, transfer flights at a city twice or more doesn't make any sense. So Mary will not do that.

//Unfortunately, after she received the tickets, she messed up the tickets and she forgot the order of the ticket.

//Help Mary rearrange the tickets to make the tickets in correct order.

//Input
//The first line contains the number of test cases T, after which T cases follow.
//For each case, it starts with an integer N. There are N flight tickets follow.
//Each of the next 2 lines contains the source and destination of a flight ticket.

//Output
//For each test case, output one line containing "Case #x: itinerary", where x is the test case number (starting from 1) and itinerary is sorted list of flight tickets which represents the actual itinerary.Each flight segment in the itinerary should be outputted as pair of source-destination airport codes.

//Limits
//1 ≤ T ≤ 100.
//For each case, the input tickets are messed up from an entire itinerary bought by Mary.In other words, it's ensured can be recovered to a valid itinerary.

//Small dataset
//1 ≤ N ≤ 100.
//Large dataset
//1 ≤ N ≤ 104.
//(The segment for second case in sample can be seen as below) MIA-ORD, DFW-JFK, SFO-DFW, JFK-MIA

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sort_a_scrambled_itinerary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            int counter = 1;//initialize the counter for the flight
            string line;//line in the text file to be read
            int numberofcase;//number of test cases
            int from_to;//the arrival location and destination location
            string ALLtoPrintOut="";
            string toPrintOut;

            List<string> DatafromFile = new List<string>();//create a linkedlist for the data from textfile

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\emely\source\repos\GoogleKickStart\Sort_a_scrambled_itinerary\database\C-small-practice.in");

            while ((line = file.ReadLine()) != null)
            {
                DatafromFile.Add(line);//add to linkelist
            }

            string[] result = DatafromFile.ToArray();//put the value into array

            numberofcase = int.Parse(result[0]);//get the first value. This is for the number of test cases, T

            //loop through the lines for T times
            for (int i = 1; i < numberofcase + 1; i++)
            {
                from_to = int.Parse(result[counter])*2 ;//N flight tickets follow. Total places or points (start + destination)

                //create Dictionary
                Dictionary<string, string> Flights = new Dictionary<string, string>();

                for (int x = counter + 1 ;x < counter + from_to; x += 2)
                {
                    Flights.Add(result[x], result[x+1]);//add to dictionary the key (departure point) and value (destination point) pair
                }

                string startpoint = StartPoint(Flights);//call this StartPoint function

                toPrintOut = ("Case #" + i + ":" + PrintOut(Flights, startpoint) + "\n");//call the PrintOut function

                ALLtoPrintOut = ALLtoPrintOut + toPrintOut ;

                counter = counter + from_to + 1;

            }

            labelPrint.Text = ALLtoPrintOut;

        }

        public string StartPoint (Dictionary<string, string> Flights)//get the starting point.
        {          
            string key="";//initialize the starting

            //loop through the key and find it in the value column.
            foreach (KeyValuePair<string, string> ele1 in Flights)
            {
                key = ele1.Key;

                if (Flights.ContainsValue(key))//if the key is found in destination column, then it is not the starting point.
                {
                    continue;
                }

                else//if the key is not found in the destination column, then this is the starting point.
                {
                    break;
                }
                    
            }

            return key;//return the starting point
        }


        public string PrintOut(Dictionary<string, string> Flights,string FirstPoint)// get the sorted pair
        {
            //get the first point

            string Pair = "";

            while (Flights.ContainsKey(FirstPoint) ==true)//loop through the dictionary until the final destination is reached
            {
                Pair= Pair + FirstPoint + "-" + Flights[FirstPoint] + " ";

                FirstPoint = Flights[FirstPoint];
            }

            return Pair;
        }

    }
}
