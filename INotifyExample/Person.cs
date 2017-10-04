using System;
using System.ComponentModel;

namespace INotifyExample
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string fullName;

        public string FirstName {
            get { return firstName; }
            set {
                if(firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged("firstName");
                }
            }
        }

        public string LastName {
            get { return lastName; }
            set {
                if(lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("lastName");
                }
            }
        }

        public string FullName {
            get { return fullName = firstName + " " + lastName; }
            set {
                if(fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged("fullName");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void  OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}