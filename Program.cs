using System;

namespace ConsoleApp
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: Define a public class that stores a string value
    /// Restrictions: None
    /// </summary>
    public class MyClass
    {
        private string myString;

        /// <summary>
        /// Purpose: Property to set the value of the private field `myString`
        /// Restrictions: None
        /// </summary>
        public string MyString
        {
            set
            {
                myString = value;
            }
        }

        /// <summary>
        /// Purpose: Method to retrieve the value of the private field `myString`
        /// Restrictions: None
        /// Return Value: The value of `myString`
        /// </summary>
        public virtual string GetString()
        {
            return myString;
        }
    }

    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: Define a derived class of MyClass that returns a modified string value
    /// Restrictions: None
    /// </summary>
    public class MyDerivedClass : MyClass
    {
        /// <summary>
        /// Purpose: Override the `GetString` method to return a modified string value
        /// Restrictions: None
        /// Return Value: The value of `myString` with additional text
        /// </summary>
        public override string GetString()
        {
            return base.GetString() + " (output from the derived class)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Purpose: Instantiate an object of the `MyDerivedClass` class and output the modified string value
            /// Restrictions: None
            /// </summary>
            MyDerivedClass myObj = new MyDerivedClass();
            myObj.MyString = "I love the Earth";
            Console.WriteLine(myObj.GetString());
        }
    }
}
