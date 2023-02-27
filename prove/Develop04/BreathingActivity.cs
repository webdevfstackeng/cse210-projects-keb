using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()  
    {
        
    }


    public void RunActivity()
    {

        Console.Write("Breath in ...");
        PauseCountdownTimer(5);
        Console.Write("Now breath out ...");
        PauseCountdownTimer(5);

        while (GetDuration() > 0)
        {
            PauseCountdownTimer(5);
            Console.Write("Breath in ...");
            PauseCountdownTimer(5);
            Console.Write("Now breath out ...");
            PauseCountdownTimer(5);
        }


    }
}

 