using System;

public class Logger
{
    private static Logger instance;
    private Logger() { }
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First log message.");
        logger2.Log("Second log message.");

        if (logger1 == logger2)
        {
            Console.WriteLine("Same instance: True");
        }
        else
        {
            Console.WriteLine("Same instance: False");
        }
    }
}
