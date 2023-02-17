using System;
using static.System.Console;

namespace Dictionary 
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			var dic = new Dictionary<int,string>();
			dic[1]= "one";
			dic[2]= "two";
			dic[3]= "tree";
			//dic is {{1,"one"},{2,"two"},{3,"tree"}}

			dic[3]="three"
			//dic is {{1,"one"},{2,"two"},{3,"three"}}

			dic.Remove(3);
			//dic is {{1,"one"},{2,"two"}}

			dic.Clear();
			//dic is empty
		}

	}
}