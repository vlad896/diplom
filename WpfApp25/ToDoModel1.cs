using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    class ToDoModel1 : INotifyPropertyChanged
	{
        private int _Id_event;

        public int Id_event
		{
            get { return _Id_event; }
			set
			{
				if (_Id_event == value)
					return;
				_Id_event = value;
				OnPropertyChanged("ID_event");

			}
		}
		private int _Id;

		public int Id
		{
			get { return _Id; }
			set
			{
				if (_Id == value)
					return;
				_Id = value;
				OnPropertyChanged("Id");

			}
		}


		private string _dist;

		public string Dista
		{
			get { return _dist; }
			set
			{
				if (_dist == value)
					return;
				_dist = value;
				OnPropertyChanged("Dista");

			}
		}

		private string _var;

		public string Var
		{
			get { return _var; }
			set
			{
				if (_var == value)
					return;
				_var = value;
				OnPropertyChanged("Var");

			}
		}
		private string _sum;

        

        public string Sum
		{
			get { return _sum; }
			set
			{
				if (_sum == value)
					return;
				_sum = value;
				OnPropertyChanged("Sum");

			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string name = "")
		{

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

	}
}
