#include "pch.h"
#include "Caesar.hpp"

namespace Encryptor
{
	char alphabet[] = {
		'a','b','c','d','e','f',
		'g','h','i','j','k',
		'l','m','n','o','p',
		'q','r','s','t','u',
		'v','w','x','y','z',
		'A','B','C','D','E','F',
		'G','H','I','J','K',
		'L','M','N','O','P',
		'Q','R','S','T','U',
		'V','W','X','Y','Z',
		' ' };

	std::string Caesar::Decrypt(std::string input)//function for decrypting
	{
		std::string output = "";//creating temp string for decrypting all char 
		//double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		for (int i = 0; i <= input.size() - 1; i++)//for 
		{
			output += decrypt_letter(input[i]);//decrypting all letter
		}
		//double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		//elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));

		return output;
	}

	std::string Caesar::Encrypt(std::string input)//function for encrypting
	{
		std::string output = "";//creating temp string for decrypting all char 
		//double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		for (int i = 0; i <= input.size() - 1; i++)//for
		{
			output += encrypt_letter(input[i]);//encrypting all letter
		}
		//double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		//elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));
		return output;
	}

	std::string Caesar::ReverseDecrypt(std::string input)//reverse decrypting
	{
		std::string output = "";//temp 
		//double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		for (int i = input.size() - 1; i >= 0; i--)//reverse loop 
		{
			output += decrypt_letter(input[i]);
		}
		//double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		//elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));

		return output;
	}

	std::string Caesar::ReverseEncrypt(std::string input)//reverse encrypting
	{
		std::string output = "";
		//double first_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		for (int i = input.size() - 1; i >= 0; i--)//reverse loop
		{
			output += encrypt_letter(input[i]);
		}
		//double end_time = DateTime.Now.TimeOfDay.TotalMilliseconds;
		//elapsed_time.Add(new Etime(end_time - first_time, Etime.Type.encrypt, output.Length));

		return output;
	}

	void Caesar::ChangeAlphabet(char alph[])//changing alphabet
	{
		std::copy(alph, alph + sizeof(alph), alphabet);//coping first array to second
	}

	char * Caesar::GetAlphabet()//returing a alphabet
	{
		return alphabet;
	}

	char Caesar::encrypt_letter(char letter)
	{
		for (int i = 0; i <= std::size(alphabet)-1; i++)
		{
			if (letter == alphabet[i])//if letter will be found
			{
				if (i + key > std::size(alphabet) - 1)//calculate if lenght movement isn't to long
				{
					int temp = std::size(alphabet) - i;

					return alphabet[(int)key - temp];
				}
				else
					return alphabet[i + key];
			}

		}
		return '+';
	}

	char Caesar::decrypt_letter(char letter)
	{
		for (int i = 0; i <= std::size(alphabet) - 1; i++)
		{
			if (letter == alphabet[i])//if letter will be found
			{
				if (i - key < 0)//calculate if lenght movement isn't to long
				{
					int temp = (int)key - i;

					return alphabet[std::size(alphabet) - temp];
				}
				else
					return alphabet[i - key];
			}

		}
		return '+';
	}
}