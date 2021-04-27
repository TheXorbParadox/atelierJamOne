#include <iostream>

int main()
{
	while (true)
	{
		char op;
		float num1, num2;

		std::cout << "Enter an operator (+, -, *, /): " << std::endl;
		std::cin >> op;

		// What am I doing with my life.
		// C++ is poggers ngl. You should try it. 
		// It feels really good to write in this.
		// There still are....quite a few problems but it kinda works.

		switch (op)
		{
		case '+': // Addition?

			std::cout << "Enter two numbers" << std::endl;
			std::cin >> num1 >> num2;

			std::cout << num1 << "+" << num2 << " = " << num1 + num2 << std::endl;
			break;

		case '-': // Subtraction?

			std::cout << "Enter two numbers" << std::endl;
			std::cin >> num1 >> num2;

			std::cout << num1 << "-" << num2 << " = " << num1 - num2 << std::endl;
			break;

		case '*': // You gotta be kidding me

			std::cout << "Enter two numbers" << std::endl;
			std::cin >> num1 >> num2;

			std::cout << num1 << "*" << num2 << " = " << num1 * num2 << std::endl;
			break;

		case '/': // I know you know this one

			std::cout << "Enter two numbers" << std::endl;
			std::cin >> num1 >> num2;

			std::cout << num1 << "/" << num2 << " = " << num1 / num2 << std::endl;
			break;

		default: // Now this is interesting. It just checks if the operand is not listed, then do this thing.

			std::cout << "The operator is not correct!" << std::endl;
			break;
		}

		char j;

		std::cout << "If you want to quit, press 'e' " << std::endl;
		std::cin >> j;

		if (j == 'e')
		{
			return 0;
		}
	}
}