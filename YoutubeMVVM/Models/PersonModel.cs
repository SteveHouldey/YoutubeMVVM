/**
 * Person Model - Created by Steven Houldey
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
using System.ComponentModel;

namespace YoutubeMVVM.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        private string _name = string.Empty;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
