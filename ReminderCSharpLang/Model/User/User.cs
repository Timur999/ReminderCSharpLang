using ReminderCSharpLang.Model.XMLDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.User
{
    public class User
    {
        //public Car Car { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string HomeCountry { get; set; }

        public string GetAgeGroup()
        {
            if (this.Age < 13)
                return "Children";
            if (this.Age < 20)
                return "Teenagers";
            return "Adults";
        }

        public void WhereUser()
        {

            var names = new List<string>()
{
    "Zoe Doe",
    "John Doe",
    "Jane Doe",
    "Jenna Doe",
    "Joe Doe"
};
            //query syntax
            //var shName = from name in names where name.Length <= 8 orderby name.Length select name;
            //names.Add("Zoe Doe");

            //method syntax
            //var shorts = shortNames(names).Where(n => n.StartsWith("Z"));
            //foreach (var name in shorts)
            //    Console.WriteLine(name);

            // names.Sort();
        }

        public void OrderByUser()
        {
            //var soertedNames = names.OrderBy(n => n);
            //foreach (var name in names)
            //    Console.WriteLine(name);
        }

        public void SkipUser()
        {
            var names = new List<string>()
{
    "Zoe Doe",
    "John Doe",
    "Jane Doe",
    "Jenna Doe",
    "Joe Doe"
};
            //            var middleNames = names.Take(2).Skip(1).ToList();
            //            foreach (var name in middleNames)
            //                Console.WriteLine(name);


            Currency.GetCurrencyRateToPage();
        }

        public void SelectUser()
        {
            List<User> listOfUsers = new List<User>()
            {
                new User() { Name = "John Doe", Age = 42 },
                new User() { Name = "Jane Doe", Age = 34 },
                new User() { Name = "Joe Doe", Age = 8 },
                new User() { Name = "Another Doe", Age = 15 },
            };

            //            List<string> namesy = listOfUsers.Select(user => user.Name).ToList();

            //            List<User> usersy = listOfUsers.Select(user => new User() { Name = user.Name }).ToList();
            var usersy = listOfUsers.Select(user => new { user.Name, user.Age });

            foreach (var us in usersy)
            {
                Console.WriteLine(us.Name + " " + us.Age);
            }
        }


        public void GroupBy()
        {
            var users = new List<User>()
        {
        new User { Name = "John Doe", Age = 42, HomeCountry = "USA" },
        new User { Name = "Jane Doe", Age = 38, HomeCountry = "USA" },
        new User { Name = "Joe Doe", Age = 19, HomeCountry = "Germany" },
        new User { Name = "Jenna Doe", Age = 19, HomeCountry = "Germany" },
        new User { Name = "James Doe", Age = 8, HomeCountry = "USA" },
        };

            List<IGrouping<string, User>> keyValuePairs = users.GroupBy(user => user.HomeCountry).ToList();
            var usersGroupedByCountry = users.GroupBy(user => user.HomeCountry);
            foreach (var group in usersGroupedByCountry)
            {
                Console.WriteLine("Users from " + group.Key + ":");
                foreach (var user in group)
                    Console.WriteLine("* " + user.Name);
            }

            var usersGroupedByAgeGroup = users.GroupBy(user => user.GetAgeGroup());
            foreach (var group in usersGroupedByAgeGroup)
            {
                Console.WriteLine(group.Key + ":");
                foreach (var user in group)
                    Console.WriteLine("* " + user.Name + " [" + user.Age + " years]");
            }
        }

        //LINQ
        public IEnumerable<string> shortNames(List<string> names)
        {
            // Get the names which are 8 characters or less, using LINQ
            var shortNames = names.Where(name => name.Length <= 8);
            // Order it by length
            shortNames = shortNames.OrderBy(name => name.Length);
            // Add a name to the original list
            names.Add("Zoe Doe");

            // Iterate over it - the query has not actually been executed yet!
            // It will be as soon as we hit the foreach loop though!
            //foreach (var name in shortNames)
            //    Console.WriteLine(name);

            return shortNames;
        }
    }
}
