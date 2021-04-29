using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Buildar.Model
{
    public class User : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        public event PropertyChangedEventHandler PropertyChanged;

        public int UserId { get; set; }

        [Required]
        [StringLength(50)] //makslengde 50
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(50)] //makslengde 50
        public string Firstname
        {
            get => firstName;
            set
            {
                if (Equals(firstName, value)) return;
                firstName = value;

                OnPropertyChanged(nameof(Firstname));
                OnPropertyChanged(nameof(FullName));
            }
        }

        [Required]
        [StringLength(50)] //makslengde 50
        public string Lastname
        {
            get => lastName;
            set
            {
                if (Equals(lastName, value)) return;
                lastName = value;

                OnPropertyChanged(nameof(Lastname));
                OnPropertyChanged(nameof(FullName));
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string FullName => $"{Firstname} {Lastname}";

        // Foreign key to build. One user can have several builds.
        public ICollection<Build> Builds { get; set; }

        public override string ToString()
        {
            return $"{FullName}, {DateOfBirth.ToShortDateString()}";
        }
        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
