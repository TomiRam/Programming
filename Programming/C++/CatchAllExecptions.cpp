#include <iostream>
#include <stdexcept>
#include <vector>

using namespace std;

int main(){
	class IsEmptyException : exception { };
	class NotEnoughException : exception { };

	void throwWhenNullOrEmpty(vector<int> list)
	{
		if (list.size()==0)
		{
			throw.IsEmptyException();
		}
		if (list.size()<10)
		{
			throw.NotEnoughException();
		}
		try{
			throwWhenNullOrEmpty({1,2,3});

		}
		catch(...){
			cout<< "Error happened";
		}
	}
	
	return 0;
}