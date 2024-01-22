using System;
public class Job
    {
        public string _jobtitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        
        // A special method, called a constructor        
        public Job()
        {

        }
    
          // A method that displays the Job details
        public void DisplayJobDetails()
        {
         Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear}");   
        }
    }

