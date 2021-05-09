using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp25
{
    class ToDoModel2: INotifyPropertyChanged
    {
		private int _id_u;

		public int Id_u
		{
			get { return _id_u; }
			set
			{
				if (_id_u == value)
					return;
				_id_u = value;
				OnPropertyChanged("Id_u");

			}
		}


		private string _u_date;

		public string U_date
		{
			get { return _u_date; }
			set
			{
				if (_u_date == value)
					return;
				_u_date = value;
				OnPropertyChanged("U_date");

			}
		}

		private string _operation;

		public string Operation
		{
			get { return _operation; }
			set
			{
				if (_operation == value)
					return;
				_operation = value;
				OnPropertyChanged("Operation");

			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string name = "")
		{

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
