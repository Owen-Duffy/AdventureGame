using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Game
    {
        public static void gameTitle()
        {
            Player player1 = new Player();
            //string playerName;
            Console.WriteLine("Welcome to Luginica.");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadLine();
            Console.WriteLine("What is your name, adventurer?");
            string playerName = Console.ReadLine();
            //man(playerName);
            player1.name = playerName;
            Console.WriteLine($"Welcome, {playerName}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You wake up in a forest with a headache and some pain in your left arm. \nYou have no idea where you are or how you got there.\nIn fact, you can't remember any of your memories at all.\nYou're not even sure of who you are.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Assess condition");
            Console.WriteLine("3. Yell for help");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "look around":
                    {
                        Console.WriteLine("Looking around you can see trees several hundred feet tall as far as you can see asides from the small clearing you woke up in.");
                        Console.WriteLine("At the base of a tree to your right, you see a muddy apple lying in the dirt.");
                        Console.WriteLine("The sun is shining brightly, directly over your head. It must be noon wherever this is.");
                        Console.WriteLine("You stretch, slowly rising to your feet. The air around you feels warm and relaxing.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "2":
                case "assess":
                case "assess condition":
                    {
                        Console.WriteLine("Your mouth is dry and you feel slightly dizzy. You are both hungry and thirsty.");
                        Console.WriteLine("Checking your arm you notice strange bruises along your bicep and forearm. \nYou can't remember how they got there.");
                        Console.WriteLine("Checking your pockets you find a small emblem with a picture of a sun on it. \nYou also find a small pouch with some snacks.");
                        Console.WriteLine("While you don't feel amazing, you don't have any serious injuries or other problems,");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        second();
                        break;

                    }

                case "3":
                case "yell":
                case "yell for help":
                    {
                        Console.WriteLine("You yell loudly and desperately. \nYour voice is hoarse and your throat is sore.");
                        Console.WriteLine("You feel more exhausted than you did before. \nYour eyes are heavy and slowly shut against your will.");
                        Console.WriteLine("You drift off to sleep.");
                        Console.WriteLine("'Hey! You alright there, buddy?'");
                        Console.WriteLine("You hear a voice that jolts you from your sleep. \nYour eyes shoot open like a distressed animal.");
                        Console.WriteLine("You see man wearing medieval looking clothes. \nHe looks somewhat dishelved, but has kind looking eyes.");
                        Console.WriteLine("'Sorry, I didn't mean to startle you there! You good, man? \nI think I heard you screaming.' He says");
                        Console.WriteLine("'All good, man. And yeah, that was me' You respond, still cautious of the stranger.");
                        Console.WriteLine("'So why were you yelling? You don't seem particulalry hurt or anything' He asks, curious");
                        Console.WriteLine("'I just woke up here. I have no idea how I got here or where I am. \nDo you think you could take me back to town' You ask, honestly.");
                        Console.WriteLine("'You're in Luginica, buddy. Well, more specefically, you're in Sprit Forest which is just west of a small town'");
                        Console.WriteLine("'I don't mind taking you to that small town, but I'm actually on my way to the capital right now if you want to come with me' He offers.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        man();
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Please only type one of the choices. Press Enter to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }

        public static void second()
        {
            string choice;
            Console.WriteLine("Wandering around the forest, you notice some things. \nYou notice that there's a clearing that can take you deeper into the forest.\nThere's also an exit to the forest with a road that has a sign.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Go deeper into the forest.\n2. Leave the forest and check the road.");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (choice)
            {
                case "1":
                case "forest":
                    {
                        Console.WriteLine("You wander deeper and deeper into the forest.\nYou keep searching, trying to find a clue that might help your situation. \nAfter a while it doesn't even look like you're making any progress, like you're walking in circles.\nAfter you notice the same tree with the same distinctive markings, you realize something.\nThis forest must be magical and you must be stuck in some sort of loop.\nYou keep wondering around trying to find a way to break out, but to no avail.\nAfter what feels like an unimaginably long stretch of time, you feel your body start to give out.\nYou're starving and exhausted.\nYou eventually have to come to terms with that you're stuck here with no way out.");
                        Console.WriteLine("Press Enter to continue");

                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "road":

                    {
                        Console.WriteLine("You leave the forest and find yourself on a dirt road. \nThere's a wooden sign conveniently right there.\nThe sign reads:\nEAST --> Yellowseed Town\nCapital <-- WEST");
                        Console.WriteLine("Press Enter to continue"); ;
                        Console.ReadLine();
                        road();
                        break;

                    }


                default:
                    {
                        Console.WriteLine("Please only type one of the choices. Press Enter to try again.");
                        Console.ReadLine();
                        man();
                        break;
                    }
            }
        }

        public static void road()
        {
            string choice;
            Console.WriteLine("Looking at the sign again you ponder what to do.\nIt says:\nEAST --> Yellowseed Town\nCapital <-- WEST ");
            Console.WriteLine("Which way will you go?\n1.East to the town\n2.West to the capital");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (choice)
            {
                case "1":
                case "east":
                case "town":
                    {
                        Console.WriteLine("You begin walking east towards the town called Yellowseed.\nAfter a few hours you see it over the horizon.\nYou begin to approach it and eventually enter the town.");
                        Console.WriteLine("Press Enter to continue");

                        Console.ReadLine();
                        town();
                        break;
                    }
                case "2":
                case "west":
                case "capital":

                    {
                        Console.WriteLine("You begin walking west towards the capital of whatever place this is.\nAfter a few hours you see the massive walls over the horizon.\nAfter a little while longer you finally walk up to the gates and approach the guard.\nHe searches you for weapons, you allow him, and he lets you enter no problems.");
                        Console.WriteLine("Press Enter to continue"); ;
                        Console.ReadLine();
                        capital();
                        break;

                    }


                default:
                    {
                        Console.WriteLine("Please only type one of the choices. Press Enter to try again.");
                        Console.ReadLine();
                        man();
                        break;
                    }
            }

        }

        public static void third()
        {
            int hunger = 5;
            int snacksEaten;

            Console.WriteLine("You start walking west down the road. You see a sign that says you are headed towards the capital.");
            Console.WriteLine("You feel incredibly hungry. You feel as if you don't eat something soon, you won't make it to the capital");
            Console.WriteLine("Searching your pockets you find some snacks in a small pouch.");
            Console.WriteLine("How many do you eat?");
            Console.Write("Snacks eaten: ");
            int.TryParse(Console.ReadLine(), out snacksEaten);
            hunger = hunger - snacksEaten;
            while (hunger > 1)
            {
                Console.WriteLine("You still feel much too hungry, you won't be able to make it to the capital like this.");
                Console.WriteLine("How many more snacks do you eat?");
                Console.WriteLine("Snacks eaten: ");
                int.TryParse(Console.ReadLine(), out snacksEaten);
                hunger = hunger - snacksEaten;
            }

            Console.WriteLine("Feeling satisfied for now, you continue walking towards the capital.");
            Console.WriteLine("Finally, you see it over the horizon. You're close now");
            Console.WriteLine("As you approach the capital's gates, a guard stop you.");
            Console.WriteLine("'Halt!', he says. 'I have to search you for weapons.'");
            Console.WriteLine("Seeing as though you have no choice but to comply you allow him.");
            Console.WriteLine("'You're free to enter. Welcome to the capital.', he says.");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            capital();

        }
        

        public static void man()
        {
            string choice;

            Console.WriteLine("The man is asking you what you want to do.");
            Console.WriteLine("What do you tell him?");
            Console.WriteLine("1. 'Please take me to the town.'");
            Console.WriteLine("2. 'I'll come with you to the capital.'");

            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (choice)
            {
                case "1":
                case "town":
                    {
                        Console.WriteLine("'Please take me to the town near here'");
                        Console.WriteLine("'The man looks slightly dissapointed, but responds 'Can do, buddy.'");
                        Console.WriteLine("He leads you outside the forest and onto a dirt road");
                        Console.WriteLine("He points in one direction of the road. 'That way's east. It'll lead you straight to Yellowseed'");
                        Console.WriteLine("'Nice folk over there, they'll treat you nicely.' He tells you.");
                        Console.WriteLine("'Thanks for all your help, man' You tell him, gratefully.");
                        Console.WriteLine("You start walking towards the town.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        town();
                        break;
                    }
                case "2":
                case "capital":

                    {
                        Console.WriteLine("'Please let me come with you to the capital. I might get some answers to how I ended up here over there.' You ask him.");
                        Console.WriteLine("'Gladly! My trip's been pretty lonely so far, you know.' He responds, excitedly.");
                        Console.WriteLine("'By the way, the name's Gilbert' He tells you.");
                        Console.WriteLine("'Nice to meet you, Gilbert. You tell him. ");
                        Console.WriteLine("The two of you continue walking, and after several hours. You arrive");
                        Console.WriteLine("The guards there question you and Gilbert, but let you through, seeing that you have no weapons.");
                        Console.WriteLine("After you are inside, Gilbert says to you:");
                        Console.WriteLine("'Well, friend. It was nice to meet you. Glad I could help you out of the bind.'");
                        Console.WriteLine("'I'll see you around, I have some business to take care of here.'");
                        Console.WriteLine("'Take care, Gilbert.' You tell him.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        capital();
                        break;

                    }


                default:
                    {
                        Console.WriteLine("Please only type one of the choices. Press Enter to try again.");
                        Console.ReadLine();
                        man();
                        break;
                    }
            }

        }

        public static void town()
        {
            Random rnd = new Random();
            string[] townOptions = {"As soon as you enter the town, a child, maybe 10 years old runs past you, and bumps into you. You later realize your wallet is gone.",
                "As you enter the town, a guard stares you down, but says nothing.",
                    "As you enter the town, you trip over a stone and fall flat on your face, embarrassing yourself."};
            int randomNumber = rnd.Next(0, 3);
            string townText = townOptions[randomNumber];

            string townChoice;

            Console.WriteLine(townText);
            Console.WriteLine("Do continue into town, anyways; Yes or No?");
            Console.WriteLine("Choice: ");
            townChoice = Console.ReadLine().ToLower();

            if (townChoice == "yes" || townChoice == "y")
            {
                Console.WriteLine("As you continue into town, you can see one of the guards whispering to another man, while they both keep glancing at you.");
                Console.WriteLine("The guard approaches you with his weapon out, and says 'You! Come with me now'");
                Console.WriteLine("Since you have no chance of beating him or running away, you comply.");
                Console.WriteLine("You suddenly feel an intense pain in the back of your head, as the guard strikes you with the butt of his spear.");
                Console.WriteLine("You fall unconscious...");
                Console.WriteLine("You wake up in a prison cell, framed for a crime you didn't commit, with no hope of escape.");
                Console.WriteLine("Press Enter to continue.");
                gameOver();

            }
            else if (townChoice == "no" || townChoice == "n")
            {
                third();
            }
            else
            {
                Console.WriteLine("Please only type one of the choices. Press Enter to try again.");
                Console.ReadLine();
                town();
            }
        }


        public static void capital()
        {
            string choice;

            Console.WriteLine("You enter the capital streets. Looking around you can see bustling streets packed with guards, merchant stalls and customers.");
            Console.WriteLine("You feel as if the answer to returning home lies somewhere in this city.");
            Console.WriteLine("What will you do?");
            Console.WriteLine("1. Approach a stall.");
            Console.WriteLine("2. Talk to a guard.");

            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (choice)
            {
                case "1":
                case "stall":
                    {
                        Console.WriteLine("You approach a stall that doesn't look too busy.");
                        Console.WriteLine("'Hey there, buddy.' You say to the merchant.");
                        Console.WriteLine("'What can I do you for?', the merchant asks.");
                        Console.WriteLine("You pull out an emblem with a picture of a sun on it from your pocket that you had noticed earlier.\n'Do you know what this is?', you ask.");
                        Console.WriteLine("The merchant's eyes widen. 'Why that's a royal emblem.' He exclaims. \nHow the heck did you get your hands on that?");
                        Console.WriteLine("'I woke up in a forest missing my memories' I have no idea how I got this.");
                        Console.WriteLine("'Wait a minute...could it be...' The merchant ponders for a minute. \n'One of the princes went missing a few weeks ago, you say you don't remember who you are, and you have THAT in your pocket'");
                        Console.WriteLine("'You need to go see the king.' He says to you. 'You just might be his missing son.'");
                        Console.WriteLine("'Me, a prince?' you ponder. It's true you lost all your memories even your name you have no idea. \nWhile it's certainly possible you could be his son, the idea still seems rediculous.");
                        Console.WriteLine("'Fine, then.', you say. 'Where can I talk to the king?' \n You figure that even if you're not the missing prince, he would still have some answers that could be useful. \n'The king lives in that massive building in the center of the city' He points in the direction of the building he just mentioned. \n You can certainly see it. It's a massive building just like he said. You flag down a guard, and explain him the situation you're in. \nHe recognizes the importance of the situation and escorts you to the king's quarters.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        king();
                        break;
                    }
                case "2":
                case "guard":

                    {
                        Console.WriteLine("You approach one of the guards inside that don't look too busy. Determined to get more answers.");
                        Console.WriteLine("You pull out your emblem. 'Do you know what this is', you ask.");
                        Console.WriteLine("The guard's eyes widen immediately, shocked at what he's looking at. 'Oh my God.', he says. \n 'A royal emblem'");
                        Console.WriteLine("'A royal what?', you ask, confused. 'I have no idea what this thing is or how I got it.', you explain. \n'I just woke up in the forest eariler today. You see, I've actually completely lost my memories.'");
                        Console.WriteLine("The guard looks as if he's putting two and two together in his head. \n'You REALLY should go talk to the king.', he says. 'I'll escort you.'");
                        Console.WriteLine("Talking to the king would be a pretty quick way to find out more about your situation, you think. \nThis guard's reaction still doesn't make sense to you, however. \n 'Why do you want me to see the king so badly', you ask him. \n'His highness's son, the prince, went missing a few weeks ago. \nI've never seen the prince myself, so I don't know what he looks like, but I think you're him, you just lost your memories!'");
                        Console.WriteLine("You're finding his response a little hard to belive. \nSomething about being a prince just seems so unlikely to you. Nevertheless, you go along with the guard's idea. \n'Lead the way', you tell him.");
                        Console.WriteLine("He starts escorting you towards a giant building in the center of the city.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        king();
                        break;

                    }


                default:
                    {
                        Console.WriteLine("Please only type one of the choices. Press Enter to try again.");
                        Console.ReadLine();
                        capital();
                        break;
                    }
            }


        }

        public static void king()
        {
            Console.WriteLine("The guard escorts you to the king's chambers and you both enter.");
            Console.WriteLine("The king takes one look at you, his eyes widen like saucers, and he gets out of chair immediately. \nThere's not even a need for you to pull out your emblem. 'Oh my son, how I've missed you. I'd feared something terrible had happened.'");
            Console.WriteLine("He walks up to you and wraps you in a hug. Immediately years of memories start rushing back into you. \n There is no doubt in your mind anymore, he is your father and you are home.");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            youWin();
        }




        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("Unfortunately, you failed to uncover the mystery of your situation. \nYou have no chance of returning home.\nGAME OVER");
            Console.WriteLine("Better luck next time.\nPress Enter to try again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.WriteLine("Congratulations you've won!\nYou successfully uncovered the mystery behind your situation and made it home.\nYour loving family are thrilled to see you alive.");
            Console.WriteLine("Press Enter to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}


    

