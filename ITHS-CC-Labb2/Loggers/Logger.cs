﻿namespace ITHS_CC_Labb2;

public class Logger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }
}