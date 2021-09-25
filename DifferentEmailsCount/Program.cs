using System;

namespace DifferentEmailsCount
{
    class Program
    {

        static string[] emails = 
        { 
            "test.email+alex@leetcode.com",
            "test.e.mail+bob.cathy@leetcode.com",
            "testemail+david@lee.tcode.com" ,
            "test.email.a+alex@leetcode.com",
            "testema.il+david@lee.tcode.com",
            "a@leetcode.com",
            "b@leetcode.com",
            "c@leetcode.com"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! These is a test to found valid different emails from a list that are actually receiving an email.");
            Console.WriteLine("Press any <KEY> to continue...");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Loading email list to use in this exercise...");

            PrintingEmails(emails);

            if (emails.Length <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("No emails were found to execute process.");
            }
            else 
            {
                RemoveIgnoreCharacterFromLocalName(emails);
                
                Console.WriteLine();
                Console.WriteLine("Email list after removing ignore characters (',', '+'):");
                PrintingEmails(emails);

                int uniqueEmails = TotalDifferentValidEmails(emails);

                Console.WriteLine();
                Console.WriteLine($"Total unique emails: {uniqueEmails}.");
            }


            Console.WriteLine();
            Console.WriteLine("Press any <KEY> to continue...");
            Console.ReadLine();
        }

        private static void PrintingEmails(string[] emailArray)
        {
            for (int i = 0; i < emailArray.Length; i++)
            {
                Console.WriteLine(emailArray[i]);
            }
        }

        private static void RemoveIgnoreCharacterFromLocalName(string[] emailArray)
        {
            for (int i = 0; i < emailArray.Length; i++)
            {
                if (emailArray[i].Length > 100) continue;

                string[] tempEmailArray = emailArray[i].Split('@');
                tempEmailArray[0] = tempEmailArray[0].Replace(".", "");
                if (tempEmailArray[0].IndexOf('+') >= 0) tempEmailArray[0] = tempEmailArray[0].Remove(tempEmailArray[0].IndexOf('+'));

                emailArray[i] = tempEmailArray[0] + "@" + tempEmailArray[1];
            }
        }

        private static int TotalDifferentValidEmails(string[] emailArray)
        {
            int diffEmails = 0;
            string tempEmail = string.Empty;

            for (int i = 0; i < emailArray.Length; i++)
            {
                for (int j = i + 1; j < emailArray.Length; j++)
                {
                    if (!String.IsNullOrEmpty(tempEmail))
                    {
                        if (emailArray[i] != emailArray[j] && emailArray[j] != tempEmail)
                        {
                            diffEmails += 1;
                            tempEmail = emailArray[j];
                        }
                    }
                    else if (emailArray[i] != emailArray[j])
                    {
                        diffEmails += 1;
                        tempEmail = emailArray[j];
                    }

                }
                if (diffEmails > 0) return diffEmails;
            }

            return diffEmails;
        }
    }
}
