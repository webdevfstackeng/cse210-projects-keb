using System;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _description; 
    private int _duration;
    private int _activationCount;
    private int _totalTime;

    public Activity()
    {
        //_activityName = activityName;
        //  _description = description;
        //  _duration = duration;
        //  _activationCount = activationCount;
        //  _totalTime = totalTime;
    }

    public void DisplayStartMessage()
    {
        
        //Console.WriteLine($"{_description}");
        Console.WriteLine("Get ready ...");
        //Thread.Sleep(1000);
        PauseWithSpinner();
        Console.WriteLine();
        Console.Write("How long in seconds, would you like for your session? "); 
        _duration = int.Parse(Console.ReadLine());
         Console.WriteLine();   
        
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        PauseWithSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
        PauseWithSpinner();
    }

    
    public void PauseWithSpinner()
    {
        List<string> animation = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string str = animation[i];
            Console.Write(str);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= animation.Count)
            {
                i = 0;
            }
        }
    }
    
    public void PauseCountdownTimer(int _activationTimer)
    {
        int countdown = _activationTimer; // Set the countdown time in seconds
       

        while (countdown > 0)
        {
            Console.Write(countdown);
            
            countdown--;
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
        _duration -= _activationTimer;
        Console.WriteLine("\n");
    }

    public int GetDuration()

    {
        return _duration;
    }

}







