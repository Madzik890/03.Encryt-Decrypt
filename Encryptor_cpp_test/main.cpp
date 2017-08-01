#include <Caesar.hpp>
#include <iostream>
#include <cstdlib>
#include <sys/timeb.h>

int getMilliCount() {
	timeb tb;
	ftime(&tb);
	int nCount = tb.millitm + (tb.time & 0xfffff) * 1000;
	return nCount;
}

int getMilliSpan(int nTimeStart) {
	int nSpan = getMilliCount() - nTimeStart;
	if (nSpan < 0)
		nSpan += 0x100000 * 1000;
	return nSpan;
}

int main()
{

	Encryptor::Caesar * caesar = new Encryptor::Caesar(38);
	std::string text = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
	int start = getMilliCount();
	std::string cry_text = caesar->Encrypt(text);
	int milliSecondsElapsed = getMilliSpan(start);

	std::cout <<cry_text<<" crypt time: " << milliSecondsElapsed <<" ms"<< std::endl;


	delete caesar;
	std::system("pause");
	return 0;
}