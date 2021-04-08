using System;

namespace ANormalDayInDrakonarg
{
    class Program
    {
        static void Main(string[] args)
        {

// The adventure begins

            Console.WriteLine("What is your name, adventurer?");
            string name = Console.ReadLine();
            Console.WriteLine($"\nWelcome to Drakonarg {name}, a little country in Orthenmark, one continent of Dolmortwartz.");
            Console.WriteLine("You are a member of the Sweet Lotus Adventurer Guild and your commander ordered you");
            Console.WriteLine("to investigate the missing deliveries from a salt mine during the last few days.");
            Console.WriteLine("Around you are small hills to the left and right and a little mountain.");
            Console.WriteLine("You are standing in front of a small wooden door that leads into the mine.");
            Console.WriteLine("Do you want to open the door?");
            Console.Write("Type YES or No: ");
            string choiceFirstDoor = Console.ReadLine();
            string choiceFirstDoorUpper = choiceFirstDoor.ToUpper();

    // Enter the mine desicion
    
            if (choiceFirstDoorUpper == "NO")
            {
        // game over
                Console.WriteLine("\nYou head back to the barracks and report, you cannot do this task.");
                Console.WriteLine("Your Captain is not amused and throws you out of the adventurer guild.");
                Console.WriteLine("\"Fine, if you don´t want to solve this case, someone else will do it.\"");
                Console.WriteLine("THE END");
            }
            else if (choiceFirstDoorUpper == "YES")
            {
            // how to open the door
                Console.WriteLine("\nYou reach for the door knob. You hesitate for one second, but grab and turn it. It is locked.");
                Console.WriteLine("Do you break the door down, look for a key or try to pick the lock?");
                Console.Write("Type BREAK, LOOK or PICK: ");
                string optionsFirstDoor = Console.ReadLine();
                string optionsFirstDoorUpper = optionsFirstDoor.ToUpper();
            // options for entrance
                switch (optionsFirstDoorUpper)
                {
                    case "BREAK":
                        Console.WriteLine("\nYou pull back your foot and give the door a powerful kick with your heavy boot.");
                        Console.WriteLine("The door breaks in half, splinters of wood are flying in all directions.");
                        Console.WriteLine("One half crushes inside the mine, the other swings on the hinges inside.");
                        break;

                    case "LOOK":
                        Console.WriteLine("\nYou look around and notice a rusty hook on the wall.");
                        Console.WriteLine("On it hangs a ring with several keys. You grab it and try one after the other.");
                        Console.WriteLine("The fifth one fits and you open the door.");
                        break;

                    case "PICK":
                        Console.WriteLine("\nYou draw a lockpick from your pockets and stick it inside the keyhole.");
                        Console.WriteLine("The lock is very simple and old. You have no trouble unlocking it.");
                        break;
                }
            // Decision torch at entrance
                Console.WriteLine("\nYou step inside the mine. It is dark, but near the entrance you can see a torch sitting tight in a ring at the wall.");
                Console.WriteLine("Do you want to light the torch and take it with you?");
                Console.Write("Type YES or NO: ");
                string entranceTorch = Console.ReadLine();
                string entranceTorchUpper = entranceTorch.ToUpper();
                
            // "Are you sure" loop
                int counter = 0;
                while (entranceTorchUpper != "YES")
                {
                    Console.WriteLine("\nAre you sure, you want to venture blindly into the mine?");
                    Console.WriteLine("Type YES if you want to take the torch with you or NO if you want to ignore the warning.");
                    entranceTorch = Console.ReadLine();
                    entranceTorchUpper = entranceTorch.ToUpper();
                    counter++;

                    if (entranceTorchUpper == "YES")
                    {
                        break;
                    }
                    else if (entranceTorchUpper == "NO")
                    {
                        if (counter == 2)
                        {
                            break;
                        }
                        continue;
                    }
                }

            // Output decision Torch
                if (entranceTorchUpper == "NO")
                {
                // Game over
                    Console.WriteLine("\nWithout the torch, you walk into the darkness, completly unable to see anything.");
                    Console.WriteLine("While you carefully move forward, suddenly a stone under your foot starts sliding forwards.");
                    Console.WriteLine("Too late! You realize you are sliding into a hole in the ground and are falling through the air for several seconds.");
                    Console.WriteLine("Your body hits the ground and you are dead.");
                    Console.WriteLine("THE END");
                }
                else if (entranceTorchUpper == "YES")
                {
            // Continue with Torch
                    Console.WriteLine("\nYou pull the torch out of its position and ignite it with your flintstone.");
                    Console.WriteLine("You walk deeper into the cave. A few metres further you notice a hole in the ground and loose rocks lying around it.");
                    Console.WriteLine("How do you want to proceed?");
                    Console.Write("Type CAREFUL or BOLD: ");
                    string approachHole = Console.ReadLine();
                    string approachHoleUpper = approachHole.ToUpper();
            // Output approachHole
                    if (approachHoleUpper == "BOLD")
                    {
                // Game over
                        Console.WriteLine("\nYou step towards the hole and try to look down. The moment you step on the loose rocks, they start to slide towards the hole.");
                        Console.WriteLine("You try to grasp something, but too late. The rocks take you with them into a deep pit.");
                        Console.WriteLine("THE END");
                    }
                    else if (approachHoleUpper == "CAREFUL")
                    {
                // Continue past the hole
                        Console.WriteLine("\nYou carefully step closer to the hole. You kick the loose stones with your feet.");
                        Console.WriteLine("The rocks you touch start to slide down a small slope in front of the hole and fall down.");
                        Console.WriteLine("A few moments later you hear a quiet echo from smashing stones.");
                        Console.WriteLine("That hole goes pretty deep, good choice checking for safety first.");
                        Console.WriteLine("You step around the hole and continue your search.");
                // Light at the end of passage
                        Console.WriteLine("\nFurther down a long passage you spot a weak light at the end of it.");
                        Console.WriteLine("Do you want to get closer and investigate it?");
                        Console.Write("Type YES or NO: ");
                        string investigateLight = Console.ReadLine();
                        string investigateLightUpper = investigateLight.ToUpper();
                // Output decision investigateLight
                        if (investigateLightUpper == "NO")
                        {
                    // Report back incomplete investigation
                            Console.WriteLine("\nYou walk back to the exit and leave the mine in order to report to your commander.");
                            Console.WriteLine("Do you want to tell him that you didn't finish your investigation?");
                            Console.Write("Type TRUTH or LIE: ");
                            string truthOrLie = Console.ReadLine();
                            string truthOrLieUpper = truthOrLie.ToUpper();

                            if (truthOrLieUpper == "TRUTH")
                            {
                        // truth => END
                                Console.WriteLine("\nYour commander is not happy about your investigation report,");
                                Console.WriteLine("but he respects your honesty and gives you a small cut of your payment.");
                                Console.WriteLine("The rest will go to a guild member, that will finish your investigation.");
                                Console.WriteLine("THE END");
                            }
                            else if (truthOrLieUpper == "LIE")
                            {
                        // lie => END
                                Console.WriteLine("\nYou tell him, that you have slain a monster, that killed all of the miners");
                                Console.WriteLine("and guards. He looks at you in disbelief and asks about proof of your claims.");
                                Console.WriteLine("He caught you off guard and you hesitate. After a few moments you state,");
                                Console.WriteLine("\"I did not have enough time, because the mine started to collapse.\"");
                                Console.WriteLine("The commander orders one of your guild members to investigate the mine to back up your story.");
                                Console.WriteLine("After a few hours he returns and reports, that the mine was flooded and everyone inside drowned.");
                                Console.WriteLine("Your commander gets angry about your lie and gives your payment to your guild member.");
                                Console.WriteLine("You are ordered to clean all boots of the guild for this day.");
                                Console.WriteLine("THE END");
                            }
                        }
                // investigate light
                        else if (investigateLightUpper == "YES")
                        {
                            Console.WriteLine("\nAs you walk closer towards the exit, you notice that the light is moving over the walls.");
                            Console.WriteLine("You step outside the passage into a large, wide mine shaft.");
                            Console.WriteLine("It is filled with water and light shimmers through a hole in the ceiling far above you.");
                            Console.WriteLine("The salt crystals at the wall are glowing weakly from the reflection.");
                            Console.WriteLine("You take a moment to notice everything around you.");
                            Console.WriteLine("As you look at the body of water in front of your feet you realize the motionless, floating bodies.");
                            Console.WriteLine("They are humans, wearing miner clothes and guard uniforms.");
                            Console.WriteLine("Do you want to get closer to the bodies to investigate them further?");
                            Console.Write("Type YES or NO: ");
                            string investigateBodies = Console.ReadLine();
                            string investigateBodiesUpper = investigateBodies.ToUpper();
                    
                    // not investigate the bodies => END
                            if (investigateBodiesUpper == "NO")
                            {
                                Console.WriteLine("\nYou had enough of the overwhelming smell of rotting corpses and turn around to exit the mine.");
                                Console.WriteLine("You report to your commander what you have found and he gives you the promised payment.");
                                Console.WriteLine("THE END");
                            }
                    // investigate the bodies or report back
                            else if (investigateBodiesUpper == "YES")
                            {
                                Console.WriteLine("\nYou step further into the shaft, as the water gets deeper. In the center it reaches up to");
                                Console.WriteLine("your hips. As you get to one of the bodies, it reached your chest. You pull the body of a miner");
                                Console.WriteLine("closer towards you and turn him around. His lips are purple and his skin is pale.");
                                Console.WriteLine("He propably died a few days ago.");
                                Console.WriteLine("Do you want to travel back and report to your commander or do you want investigate more bodies?");
                                Console.Write("Type REPORT or INVESTIGATE: ");
                                string reportOrInvestigate = Console.ReadLine();
                                string reportOrInvestigateUpper = reportOrInvestigate.ToUpper();
                        // investigate further: Game Over
                                if (reportOrInvestigateUpper == "INVESTIGATE")
                                {
                                    Console.WriteLine("\nYou let the body go and step towards other bodies.");
                                    Console.WriteLine("You are only a few steps away from the next body, as your next step ends in deep water.");
                                    Console.WriteLine("You try to pull back, but your boot is too heavy and pulls you forward.");
                                    Console.WriteLine("Your gear pulls you underwater and your attempts to get to the surface are in vain.");
                                    Console.WriteLine("THE END");
                                }
                        // report back: extra reward
                                else if (reportOrInvestigateUpper == "REPORT")
                                {
                                    Console.WriteLine("\nYou head back and report every detail you noticed to your commander.");
                                    Console.WriteLine("He is satisfied with your report and grants you a hefty bonus.");
                                    Console.WriteLine("THE END");
                                }
                            }
                        }
                    }
                }
            }
        // output with wrong input
        else
            {
                Console.WriteLine("Unknown command: please restart the game!!!");
            }
        }
    }
}