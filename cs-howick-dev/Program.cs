// See https://aka.ms/new-console-template for more information
namespace CSHowickDev
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Now, We are playing Mad Libs");

            Console.WriteLine("Before we start, Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {

                Console.WriteLine("Enter a Adjective, could be a cuss or anything");
                string adjective = Console.ReadLine();

                Console.WriteLine("Enter a verb(past tense)");
                string verbPastTense = Console.ReadLine();

                Console.WriteLine("Enter a verb ending in'ING'");
                string verbING = Console.ReadLine();

                Console.WriteLine("Enter a funny noun: ");
                string noun = Console.ReadLine();

                Console.WriteLine("Now, for the fun part,");
                Console.WriteLine("Enter the name of the guy who is in front of you: ");
                string guy = Console.ReadLine();


                Console.WriteLine("The Crazy Day in the Zoo Story");
                Console.WriteLine("Once upon a" + adjective + " day, " +
                    "I went to the " + adjective + " zoo with my " + adjective + "  friend. " +
                    "We were so excited to see all the " + adjective + "  animals! As soon as " +
                    "we entered the zoo, we heard a" + adjective + "  noise coming from the monkey exhibit. " +
                    "We ran over to see what was happening and found that the   " + guy + "   had " +
                    "  " + verbPastTense + "  all of the bananas!\r\n\r\nAfter we watched the  " + guy + "   for a" +
                    " while, we decided to visit the  " + adjective + "   lions. But when we got to their exhibit, " +
                    "we saw that the lions were " + verbING + "  around and playing with a big " +
                    " " + noun + " . It was the funniest thing we had ever seen!\r\n\r\nNext, we headed to the " +
                    " " + adjective + "   aquarium to see the  " + adjective + "   fish. We were amazed by the  " + adjective + "   " +
                    "colors and patterns on their scales. But then, out of nowhere, a  " + adjective + "   octopus" +
                    " shot out from its hiding spot and   " + verbPastTense + "  us! We laughed so hard " +
                    "we couldn't catch our breath.\r\n\r\nFinally, we decided to take a break and have " +
                    "some  " + adjective + "   snacks. We sat on a  " + adjective + "   bench and ate  " + adjective + "  " +
                    " sandwiches while watching the  " + adjective + "   peacocks strut their stuff. It was such a" +
                    "  " + adjective + "   day at the zoo, and we can't wait to come back again!\r\n\r\nThe end.");
                Console.WriteLine("Guess what animal is your friend? :");
                string yourFriend = Console.ReadLine().ToLower();

                if (yourFriend == "monkey")
                {
                    Console.WriteLine("dont do your friend like that, but you are right.");
                }
                else
                {
                    Console.WriteLine("try again next time, buddy");
                }

            }
            else
            {
                Console.WriteLine("Sorry, grow up a few more years, kid.");
            }


        }
        }
    }