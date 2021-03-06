using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App5.ViewModels
{
    public class AboutViewModel: BaseViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }



        public AboutViewModel()
        {
            Title = "About";

            Persons = new ObservableCollection<Person>();

            // Persons.Add("Ngo Thanh Tung");


            OpenWebCommand = new Command(() =>
            {

                Persons.Add(Person.Random());

            });
        }



        public ICommand OpenWebCommand { get; }

       public class Person
        {
            public string PersonName { get; set; }

            public int Age { get; set; }

            public static Person Random()
            {
                return new Person() { PersonName = Guid.NewGuid().ToString(), Age = 32 };
            }
        }

    }
}