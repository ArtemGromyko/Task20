using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task20
{
    class Staff
    {
        private static string NamePattern = @"^([А-Я]{1}[а-яё]{1,23}|[A-Z]{1}[a-z]{1,23})";
        private List<Worker> Workers = new List<Worker>();

        public void AddWorker(Worker w)
        {
            if (w.Age < 18 || w.Age > 65)
                throw new AddWorkerException("unacceptable age", w.Age);
            else if (w.Name.Length > 20 || !Regex.IsMatch(w.Name, NamePattern))
                throw new AddWorkerException("unacceptable name", w.Name);
            else if (w.Position != "Manager" && w.Position != "Developer" && w.Position != "HR-manager")
                throw new AddWorkerException("unacceptable position", w.Position);
            else
                Workers.Add(w);
        }

        public void ShowStaff()
        {
            foreach(var w in Workers)
                Console.WriteLine("Name: " + w.Name + "\nAge: " + w.Age + "\nPosition: " + w.Position + "\n");
        }
    }
}
