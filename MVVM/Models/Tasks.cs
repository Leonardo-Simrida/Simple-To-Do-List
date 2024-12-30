using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Simple_To_Do_List.MVVM.Models;
public class Tasks
{
	private ObservableCollection<string> lists;

	public ObservableCollection<string> Lists
	{
		get { return lists; }
		set { lists = value; }
	}

}
