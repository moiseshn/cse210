using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /*
        ***** PENDING ********
        - Load from file for each goal format and score.
        - Number list from 1 in Record Events
        - Number list in List Goals (iteration inside over an iteratition)
        */
        // try
        // {
        Console.Clear();
        List<Goal> listOfGoals = new List<Goal>();
        int scoreOfGoals = 0;

        bool quitMainMenu = false;
        while (quitMainMenu == false)
        {
            Menu menu = new Menu();
            Console.WriteLine($"\nYou have {scoreOfGoals} points.\n");
            menu.ShowMainMenu();
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice >= 1 && menuChoice <= 6)
            {
                if (menuChoice == 1) // Create New Goal
                {
                    bool quitGoalsMenu = false;
                    while (quitGoalsMenu == false)
                    {
                        menu.ShowGoalsMenu();
                        int goalTypeChoice = int.Parse(Console.ReadLine());

                        if (goalTypeChoice > 0 && goalTypeChoice <= 3)
                        {
                            Console.Write("What is the name of your goal? ");
                            string name = Console.ReadLine();
                            Console.Write($"What is a short description of it? ");
                            string description = Console.ReadLine();
                            Console.Write($"What is a the amount of points associated with this goal? ");
                            int points = int.Parse(Console.ReadLine());

                            if (goalTypeChoice == 1) // Create SimpleGoal
                            {
                                listOfGoals.Add(new SimpleGoal(name, description, points));
                                quitGoalsMenu = true;
                            }
                            else if (goalTypeChoice == 2) // Create EternalGoal
                            {
                                listOfGoals.Add(new EternalGoal(name, description, points));
                                quitGoalsMenu = true;
                            }
                            else if (goalTypeChoice == 3) // Create ChecklistGoal
                            {
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                int totalrequired = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times? ");
                                int bonus = int.Parse(Console.ReadLine());

                                if (bonus >= 0)
                                {
                                    listOfGoals.Add(new ChecklistGoal(name, description, points, bonus, totalrequired));
                                    quitGoalsMenu = true;
                                }
                                else
                                {
                                    Console.WriteLine("Not a positive number.");
                                    quitGoalsMenu = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not a valid goal type.");
                                quitGoalsMenu = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNot a valid goal type option.");
                            quitGoalsMenu = true;
                        }
                    }
                }
                else if (menuChoice == 2) // List Goals
                {
                    if (listOfGoals.Count == 0)
                    {
                        Console.WriteLine("\nYou have no goals yet.");
                        quitMainMenu = false;
                    }
                    else
                    {
                        Console.WriteLine("\nThe goals are:");
                        foreach (var goal in listOfGoals)
                        {
                            string isGoalCompleted = goal.IsCompleted() ? "[X]" : "[ ]";
                            if (goal is ChecklistGoal checklistGoal)
                            {
                                Console.WriteLine($"- {isGoalCompleted} {goal.GetGoalName()} ({goal.GetGoalDescription()}) -- Currently completed: {checklistGoal.GetTotalTasksDone()}/{checklistGoal.GetTotalTasksRequired()}");
                                quitMainMenu = false;
                            }
                            else
                            {
                                // ADDING NUMBER LIST but duplicates iteration *************
                                // for (int i = 0; i < listOfGoals.Count; i++)
                                // {
                                //     Console.WriteLine($"{i}. {isGoalCompleted} {listOfGoals[i].GetGoalName()} ({listOfGoals[i].GetGoalDescription()})");
                                // }
                                Console.WriteLine($"- {isGoalCompleted} {goal.GetGoalName()} ({goal.GetGoalDescription()})");
                                quitMainMenu = false;
                            }
                        }
                    }
                }
                else if (menuChoice == 3) // Save Goals
                {
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        writer.WriteLine(scoreOfGoals);
                        foreach (var goal in listOfGoals)
                        {
                            writer.WriteLine($"{goal.GetType().Name}:{goal.GetSavingFormat()}");
                        }
                    }
                }
                else if (menuChoice == 4) // Load Goals
                {
                    listOfGoals.Clear();
                    scoreOfGoals = 0;
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();

                    using (StreamReader reader = new StreamReader(filename))
                    {
                        // int score = 0;
                        // int score = int.Parse(File.ReadLines(filename).First());
                        int score = int.Parse(reader.ReadLine());
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] chuncks = line.Split(":");
                            string type = chuncks[0];
                            // string goal = chuncks[1];

                            if (type == nameof(SimpleGoal))
                            {
                                string[] parts = line.Split(",");
                                string name = parts[0];
                                string description = parts[1];
                                int points = int.Parse(parts[2]);
                                bool isComplete = bool.Parse(parts[3]);

                                listOfGoals.Add(new SimpleGoal(name, description, points, isComplete));
                            }
                            else if (type == nameof(EternalGoal))
                            {
                                string[] parts = line.Split(",");
                                string name = parts[0];
                                string description = parts[1];
                                int points = int.Parse(parts[2]);

                                listOfGoals.Add(new EternalGoal(name, description, points));
                            }
                            else if (type == nameof(ChecklistGoal))
                            {
                                string[] parts = line.Split(",");
                                string name = parts[0];
                                string description = parts[1];
                                int points = int.Parse(parts[2]);
                                int bonus = int.Parse(parts[3]);
                                int totalTasksRequired = int.Parse(parts[4]);
                                int totalTasksDone = int.Parse(parts[5]);

                                listOfGoals.Add(new ChecklistGoal(name, description, points, bonus, totalTasksRequired, totalTasksDone));
                            }

                        }
                        scoreOfGoals = score;
                    }
                    quitMainMenu = false;
                }
                else if (menuChoice == 5) // Record Events
                {
                    if (listOfGoals.Count == 0)
                    {
                        Console.WriteLine("\nYou haven't recorded events yet.");
                        quitMainMenu = false;
                    }
                    else
                    {
                        Console.WriteLine("\nYour goals are:");
                        // ************************** number list starts from zero
                        for (int i = 0; i < listOfGoals.Count; i++)
                        {
                            Console.WriteLine($"{i}. {listOfGoals[i].GetGoalName()}");
                        }

                        Console.Write("\nWhich goal did you accomplish? ");
                        int userTaskAchieved = int.Parse(Console.ReadLine());

                        while (userTaskAchieved < 0 || userTaskAchieved > listOfGoals.Count)
                        {
                            Console.WriteLine("\nNot a valid task to complete option.");
                            quitMainMenu = false;
                        }

                        listOfGoals[userTaskAchieved].RegisterGoalEvent();
                        int pointsEarned = listOfGoals[userTaskAchieved].GetGoalPoints();
                        scoreOfGoals += pointsEarned;

                        if (listOfGoals[userTaskAchieved] is ChecklistGoal checklist)
                        {
                            if (checklist.GetTotalTasksDone() >= checklist.GetTotalTasksRequired())
                            {
                                int bonusEarned = listOfGoals[userTaskAchieved].GetGoalBonus();
                                scoreOfGoals += bonusEarned;
                            }
                        }

                        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points.");
                        Console.WriteLine($"You have {scoreOfGoals} total points.");
                    }
                }
                else // Quit
                {
                    Console.Clear();
                    Console.WriteLine("\nBye....\n");
                    quitMainMenu = true;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nPlease select a valid option from menu.");
                quitMainMenu = false;
            }
        }

    }
}
/*
https://video.byui.edu/media/t/1_i8i158nf

Your program must do the following:

1. Provide for simple goals that can be marked complete and the 
    user gains some value. For example, if you run a marathon 
    you get 1000 points.
2. Provide for eternal goals that are never complete, but each 
    time the user records them, they gain some value. For example, 
    every time you read your scriptures you get 100 points.
3. Provide for a checklist goal that must be accomplished a 
    certain number of times to be complete. Each time the user 
    records this goal they gain some value, but when they achieve 
    the desired amount, they get an extra bonus. For example, if 
    you set a goal to attend the temple 10 times, you might get 
    50 points each time you go, and then a bonus of 500 points 
    on the 10th time.
4. Display the user's score.
5. Allow the user to create new goals of any type.
6. Allow the user to record an event (meaning they have 
    accomplished a goal and should receive points).
7. Show a list of the goals. This list should show indicate 
    whether the goal has been completed or not (for example [ ] 
    compared to [X]), and for checklist goals it should show 
    how many times the goal has been completed (for example 
    Completed 2/5 times).
8. Allow the user's goals and their current score to be saved 
    and loaded.

Design Requirements
In addition your program must:

1. Use inheritance by having a separate class for each kind of 
    activity with a base class to contain any shared attributes 
    or behaviors.
2. Use polymorphism by having derived classes override base 
    class methods where appropriate.
3. Follow the principles of encapsulation and abstraction by 
    having private member variables and putting related items 
    in the same class.

Showing Creativity and Exceeding Requirements
Here are some ideas you might consider:

1. Add your own ideas for gamification. This could include 
    leveling up, earning certain bonuses, or other "fun" aspects 
    to the quest.
2. Add additional kinds of goals, such as the ability to make 
    progress towards a large goal (such as getting value for 
    working towards running a marathon), or "negative goals" 
    where they lose points for bad habits.
3. There are lots of ways to show creativity in this assignment. 
    Pick anything that sounds fun to you!

Report on what you have done to exceed requirements by adding 
a description of it in a comment in the Program.cs file.
*/