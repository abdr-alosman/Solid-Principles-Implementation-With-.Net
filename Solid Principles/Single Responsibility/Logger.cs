﻿

namespace Solid_Principles.Single_Responsibility
{
    
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
   
    public class Logger : ILogger
    {
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        public void Info(string info)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }
        public void Debug(string info)
        {
            // here we need to write the Code for Debug information into the ErrorLog text file
        }
        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
        }
    }
    // As you can see in the above class file, we are defining all the logging activities i.e. info, debug and error. 
}
