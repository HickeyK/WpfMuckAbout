using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Model.Annotations;

namespace Model
{
    public class Family : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _Name;
        private ObservableCollection<Member> _FamilyMembers;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged();
                OnPropertyChanged("FamilySummary");
            }
        }

        public ObservableCollection<Member> FamilyMembers
        {
            get
            {
                return _FamilyMembers;
            }
            set
            {
                _FamilyMembers = value;
                OnPropertyChanged();
                OnPropertyChanged("FamilySummary");
            }
        }

        public string FamilySummary
        {
            get { return string.Format("{0} family with {1} members.",Name, FamilyMembers.Count); }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
