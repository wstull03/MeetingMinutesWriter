using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMeetingMinuteswWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            string topicNotes = "";

            List<string> meetingTypes = new List<string>() { "Marketing Team", "All Team", "Admin Team" };
            List<string> memberTypes = new List<string>() { "(Marketing)", "(All)", "(Administration)" };
            Dictionary<string, string> teamMembers = new Dictionary<string, string>();

            teamMembers.Add("Monica Geller", "(Administration)");
            teamMembers.Add("Rachel Greene", "(Marketing)");
            teamMembers.Add("Chandler Bing", "(Administration)");
            teamMembers.Add("Joey Tribioni", "(Marketing)");
            teamMembers.Add("Pheobe Buffet", "(Administration)");
            teamMembers.Add("Ross Geller", "(Marketing)");


            for (int i = 0; i < meetingTypes.Count; i++)
            {
                //Console.WriteLine(meetingTypes[i]);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Meeting Minutes Management Software");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Create Meeting\n2 - View Team\n3 - Exit");
                Console.WriteLine();
                int.TryParse(Console.ReadLine(), out userChoice);

                switch (userChoice)
                {

                    case 1:

                        Console.WriteLine();
                        Console.WriteLine("Name of team member recording the minutes:");
                        string recordKeeper = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Name of team member leading the meeting:");
                        string meetingLeader = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Date of meeting (MMDDYY:)");
                        string meetingDate = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Meeting Type (1 - Marketing Team, 2 - All Team, 3 - Admin Team):");
                        int meetingTypeNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Meeting Topic:");
                        string meetingTopic = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Meeting Notes:");
                        string meetingNotes = Console.ReadLine();

                        List<string> repeatTopics = new List<string>();
                        List<string> repeatNotes = new List<string>();

                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter notes for another topic?");
                            topicNotes = Console.ReadLine();
                            if (topicNotes == "yes")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Meeting Topic:");
                                string meetingTopicRepeat = Console.ReadLine();
                                repeatTopics.Add(meetingTopicRepeat);
                                Console.WriteLine();
                                Console.WriteLine("Meeting Notes:");
                                string meetingNotesRepeat = Console.ReadLine();
                                repeatNotes.Add(meetingNotesRepeat);
                            }
                            else if (topicNotes == "no")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please enter \"yes\" or \"no\"");
                            }
                        }
                        while (topicNotes != "no");


                        StreamWriter writer = new StreamWriter("Minutes" + meetingDate + ".txt");
                        using (writer)
                        {

                            writer.WriteLine("-----------------------------------");
                            writer.WriteLine();
                            writer.WriteLine("Meeting Minutes Management Software");
                            writer.WriteLine();
                            writer.WriteLine("-----------------------------------");

                            writer.WriteLine("***********************************");
                            writer.WriteLine();
                            writer.WriteLine("Company Name = Central Perk, Incorporated");
                            writer.WriteLine("Company Address = 123 Broadway New York, NY 44789");
                            writer.WriteLine("Meeting Minutes");
                            writer.WriteLine();
                            writer.WriteLine("***********************************");


                            writer.WriteLine();
                            writer.WriteLine("Team member recording minutes is: " + recordKeeper);
                            writer.WriteLine();
                            writer.WriteLine("Team member leading the meeting is: " + meetingLeader);
                            writer.WriteLine();
                            writer.WriteLine("The date of the meeting is: " + meetingDate);
                            writer.WriteLine();
                            writer.WriteLine("The type of meeting is: " + meetingTypes[meetingTypeNumber - 1]);
                            writer.WriteLine();
                            writer.WriteLine("Topic: " + meetingTopic);
                            writer.WriteLine();
                            writer.WriteLine("Notes: " + meetingNotes);
                            writer.WriteLine();

                            for (int i = 0; i < repeatTopics.Count; i++)
                            {
                                writer.WriteLine("Topic: " + repeatTopics[i]);
                                writer.WriteLine();
                                writer.WriteLine("Notes: " + repeatNotes[i]);
                                writer.WriteLine();
                            }

                        }


                        Console.WriteLine();
                        Console.WriteLine("Team member recording minutes is: " + recordKeeper);
                        Console.WriteLine();
                        Console.WriteLine("Team member leading the meeting is: " + meetingLeader);
                        Console.WriteLine();
                        Console.WriteLine("The date of the meeting is: " + meetingDate);
                        Console.WriteLine();
                        Console.WriteLine("The type of meeting is: " + meetingTypes[meetingTypeNumber - 1]);
                        Console.WriteLine();
                        Console.WriteLine("Topic: " + meetingTopic);
                        Console.WriteLine();
                        Console.WriteLine("Notes: " + meetingNotes);
                        Console.WriteLine();

                        for (int i = 0; i < repeatTopics.Count; i++)
                        {
                            Console.WriteLine("Topic: " + repeatTopics[i]);
                            Console.WriteLine();
                            Console.WriteLine("Notes: " + repeatNotes[i]);
                            Console.WriteLine();
                        }
                        break;

                    case 3:

                        Console.WriteLine();
                        Console.WriteLine("Goodbye");
                        Console.WriteLine();
                        break;

                    case 2:

                        Console.WriteLine();
                        Console.WriteLine("Which Team would you like to view (1 - Marketing Team, 2 - All Team, 3 - Admin Team)?");
                        int meetingTeamNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        foreach (KeyValuePair<string, string> teamMember in teamMembers)
                        {
                            if (memberTypes[meetingTeamNumber - 1] == teamMember.Value)
                            {
                                Console.WriteLine(teamMember.Key);
                            }
                            else if (memberTypes[meetingTeamNumber - 1] == "(All)")
                            {
                                Console.WriteLine(teamMember.Key + " " + teamMember.Value);
                            }
                        }
                        break;

                    default:
                       break;
                }
            }

            while (userChoice != 3);
           































































        }
    }
}
