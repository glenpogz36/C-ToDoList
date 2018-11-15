using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Models
{
   public class Program 
   {
        public static void Main(string[] args) 
        {
            List<string> ToDoInput = new List<string>();

            Console.WriteLine ("Welcome to the To Do List");
            Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");

            string answer = Console.ReadLine();
            if(answer == "Add")
           {    
                addItems();
           }
           else if (answer =="View" && ToDoInput.Count != 0)
           {
                viewItems();
           } 
           else if (answer =="View" && ToDoInput.Count == 0)
           {
                Console.WriteLine("Your To Do List is empty at the moment.");
           }         

            public static void addItems()
        {  
                Console.WriteLine ("Please enter the desciption of your item to add.");
                string description = Console.ReadLine();
            
            while (!string.IsNullOrEmpty(description))
            {
                ToDoInput.Add(description);
                Console.WriteLine("Would you like to Add or View? (Add/View)");
                answer = Console.ReadLine();

                if(answer == "View")
                {
                viewItems();
                }
                else if(answer =="Add")
                {
                 addItems();
                }
                
            }
         }

        public static string viewItems()
         {
                 Console.WriteLine("Here are your items.");
                 foreach (string item in ToDoInput)
                {
                Console.WriteLine(item);
                }
         }
         
       
                
      
         

        }
           
}