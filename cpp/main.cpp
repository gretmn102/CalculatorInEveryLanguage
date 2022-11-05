#include <iostream>

using namespace std;

int main() {
    
    double firstnum;
    double secondnum;
    string operation;
    
    std::cout << "Input your first number" << endl;
    
    
    std::cin >> firstnum;
    
    std::cout << "Input your second number" << endl;

    std::cin >> secondnum;

    std::cout << "Input your desired operation" << endl;

    std::cin >> operation;
    
    std::cout << "\n";
    
    if (operation == "+")
    {
      std::cout << firstnum + secondnum;
    }
    if (operation == "-")
    {
      std::cout << firstnum - secondnum;
    }
    if (operation == "*")
    {
      std::cout << firstnum * secondnum;
    }
    if (operation == "/")
    {
      std::cout << firstnum / secondnum;
    }
    
    return 0;
}
