using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    class ToDoModel :INotifyPropertyChanged
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set 
			{
				if (_id == value)
					return;
				_id = value;
				OnPropertyChanged("ID");
			}
		}

		private string  _email;

		public string  Email
		{
			get { return _email; }
			set
			{
				if (_email == value)
					return;
				_email = value;
				OnPropertyChanged("Email");
			}
		}
		private string _pass;

		public string Pass
		{
			get { return _pass; }
			set
			{
				if (_pass == value)
					return;
				_pass = value;
				OnPropertyChanged("Pass");
			}
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				if (_name == value)
					return;
				_name = value;
				OnPropertyChanged("Name");
			}
		}
		private string _surname;

		public string Surname
		{
			get { return _surname; }
			set
			{
				if (_surname == value)
					return;
				_surname = value;
				OnPropertyChanged("Surname");
			}
		}
		private string _bd;

		public string BD
		{
			get { return _bd; }
			set
			{
				if (_bd == value)
					return;
				_bd = value;
				OnPropertyChanged("BD");
			}
		}
		private string _country;

		public string Country
		{
			get { return _country; }
			set
			{
				if (_country == value)
					return;
				_country = value;
				OnPropertyChanged("Country");
			}
		}
		private string _sex;

		public string Sex
		{
			get { return _sex; }
			set
			{
				if (_sex == value)
					return;
				_sex = value;
				OnPropertyChanged("Sex");
			}
		}

        private string _qualific;

        public string Qualific
		{
            get { return  _qualific; }
            set 
			{
				if (_qualific == value)
					return;
				_qualific = value;
				OnPropertyChanged("Qualific");

			}
        }
		private string _personal_record;

		public string Personl_record
		{
			get { return _personal_record; }
			set
			{
				if (_personal_record == value)
					return;
				_personal_record = value;
				OnPropertyChanged("Personl_record");

			}
		}
		

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string name="")
		{

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

	}
}
