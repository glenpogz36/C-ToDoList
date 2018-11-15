using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Models
{  
   public class Program 
   {
         public class Item
        {
            private string _description;
            private static List<Item> _instances = new List<Item> {};

            public Item (string description)
            {
            _description = description;
            _instances.Add(this);
            }

            public string GetDescription()
            {
            return _description;
            }

            public void SetDescription(string newDescription)
            {
                _description = newDescription;
            }

            public static List<Item> GetAll()
            {
            return _instances;
            }

            public static void ClearAll()
            {
                _instances.Clear();
            }
        }


        public static void Main(string[] args) 
        {
             
          Console.WriteLine ("Welcome to the To Do List");
           List<string> newList = new List<string>();
           
          Console.WriteLine("Would you like to Add, View or Exit? (Add/View/Exit)");
          string option = Console.ReadLine();   
           while(!string.IsNullOrEmpty(option))
          {
               while(option =="Add")
          {
          Console.WriteLine ("Please enter the desciption of your item to add.");
          string description = Console.ReadLine();
          
          
          Item newItem = new Item(description);
          string thing = newItem.GetDescription();
          newList.Add(thing);
          

          Console.WriteLine("Add, View or Exit? (Add/View/Exit)");
          option = Console.ReadLine(); 
          }

          while(option=="View")
          {
           Console.WriteLine("Here are the items in your list."); 
          foreach(object item in newList)
          {
           Console.WriteLine(item);

          }
         Console.WriteLine("Add, View or Exit? (Add/View/Exit)");
          option = Console.ReadLine(); 
          
          }

          if(option=="Exit")
          {
               return;
          }
         
         }
         
     }
              
}        
}
