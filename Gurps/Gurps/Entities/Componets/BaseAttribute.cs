using System;

namespace Gurps.Entities
{
	public class BaseAttribute
	{
		private string _name;
		private int _value;


		public string Name {
			get{ return _name; }
			set {
				if (_name == null) {
					_name = value;
				}
			}
		}

		public int Value {
			get { return _value; }
			set {
				_value = value;
				if (_value < 1) {
					_value = 1;
				}
			}
		}

		public int Modifier {
			get;
			set;
		}

		public int Price {get;set;}


		public BaseAttribute(string name,int value,int price)
		{
			this.Name = name;
			this.Value = value;
			this.Price = price;
			this.Modifier = 0;
		}
	}
}

