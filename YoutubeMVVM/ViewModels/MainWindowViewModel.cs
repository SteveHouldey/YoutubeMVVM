/**
 * Main Window View Model - Created by Steven Houldey
 * 
 * This file was created by Steven Houldey for a youtube video.
 * Full Code is aviliable on Github - see the link below:
 * 
 * No Liabilty will be taken for any mishap to your computer / infrastructure by using this program.....
 * 
 * If you find this useful, please give me a thumbs up and leave a comment....
 * 
 * 
 * Licensed under MIT. - Free to use ;)
 * 
 */


using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using YoutubeMVVM.Functions;
using YoutubeMVVM.Models;

namespace YoutubeMVVM.ViewModels
{
   public class MainWindowViewModel : INotifyPropertyChanged
    {

        /// <summary>
        /// Create the ICommand AddUserToList
        /// </summary>
        public ICommand AddUserToList { get; set; }

        public ICommand ExitProgram { get; set; }

        /// <summary>
        /// Private string for the persons name to be used within the View
        /// </summary>
        private string _personName = string.Empty;

        /// <summary>
        /// Name of the person to add to the list 
        /// </summary>
        public string PersonName 
        {
            get { return _personName; }
            set 
            {
                _personName = value;
                OnPropertyChanged(nameof(PersonName));
            }
        }

        /// <summary>
        /// Create a local private list collection of the model PersonModel."
        /// </summary>
        private ObservableCollection<PersonModel> _persons;


        /// <summary>
        /// Event to be called when values change.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Public collection of the PersonModel that can be accessed within the view
        /// </summary>
        public ObservableCollection<PersonModel> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                OnPropertyChanged(nameof(Persons));
            }
        }

        /// <summary>
        /// Method to call to update values
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

       
        /// <summary>
        /// Main Entry point of the view model
        /// </summary>
        public MainWindowViewModel()
        {
            _persons = new ObservableCollection<PersonModel>();
            AddUserToList = new RelayCommand(AddNewPersonToListCommand, CanAddNewPersonToListExecute);
            ExitProgram = new RelayCommand(ExitTheProgramCommand, CanExitProgramCommand);
            
        }

       

        /// <summary>
        /// Command that will add the FistName to the list when called from a button on the view form.
        /// </summary>
        /// <param name="parameter"></param>
        public void AddNewPersonToListCommand(object parameter)
        {

            _persons.Add(new PersonModel
            {
                Name = _personName
            });

            PersonName = string.Empty; // Empty Out the Text Box                  

            
        }


        /// <summary>
        /// Check to carry out to see if the command can be called.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanAddNewPersonToListExecute(object parameter)
            => !string.IsNullOrEmpty(PersonName);

        /// <summary>
        /// Exit the Program Command
        /// </summary>
        /// <param name="parameter"></param>
        public void ExitTheProgramCommand(object parameter)
        {
            App.Current.Shutdown();
        }

        private bool CanExitProgramCommand(object parameter)
        {
            return true;
        }

       
    }
}
