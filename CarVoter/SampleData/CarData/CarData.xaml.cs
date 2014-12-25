﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.CarData
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class CarData { }
#else

	public class CarData : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public CarData()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/CarVoter;component/SampleData/CarData/CarData.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Description = string.Empty;

		public string Description
		{
			get
			{
				return this._Description;
			}

			set
			{
				if (this._Description != value)
				{
					this._Description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		private System.Windows.Media.ImageSource _Image = null;

		public System.Windows.Media.ImageSource Image
		{
			get
			{
				return this._Image;
			}

			set
			{
				if (this._Image != value)
				{
					this._Image = value;
					this.OnPropertyChanged("Image");
				}
			}
		}

		private double _KiloWatts = 0;

		public double KiloWatts
		{
			get
			{
				return this._KiloWatts;
			}

			set
			{
				if (this._KiloWatts != value)
				{
					this._KiloWatts = value;
					this.OnPropertyChanged("KiloWatts");
				}
			}
		}

		private double _NumDownVotes = 0;

		public double NumDownVotes
		{
			get
			{
				return this._NumDownVotes;
			}

			set
			{
				if (this._NumDownVotes != value)
				{
					this._NumDownVotes = value;
					this.OnPropertyChanged("NumDownVotes");
				}
			}
		}

		private double _NumUpVotes = 0;

		public double NumUpVotes
		{
			get
			{
				return this._NumUpVotes;
			}

			set
			{
				if (this._NumUpVotes != value)
				{
					this._NumUpVotes = value;
					this.OnPropertyChanged("NumUpVotes");
				}
			}
		}

		private string _Title = string.Empty;

		public string Title
		{
			get
			{
				return this._Title;
			}

			set
			{
				if (this._Title != value)
				{
					this._Title = value;
					this.OnPropertyChanged("Title");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}
#endif
}