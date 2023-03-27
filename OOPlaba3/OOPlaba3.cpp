#include <iostream>
#include <string>

using namespace std;

template <typename T>
class A {
public:
	T a;
	string str;
	A(T val): a(val), str(to_string(val)) {}
	A() : a(0), str(to_string(0)) {}
};

template <typename T>
ostream& operator<<(ostream& out, const A<T>& elem) {
	return out << elem.str;
}

template <typename T>
class Massiv {
private:
	T* arr; // при создании фактически T* arr = new T[размер]
	int capacity;
	int currentsize;

	void increase_capacity() {
		T* new_arr = new T[capacity * 2];

		for (int i = 0; i < currentsize; i++) {
			new_arr[i] = arr[i];
		}

		delete arr;
		capacity *= 2;
		arr = new_arr;
	}

	void reduce_capacity() {
		capacity = currentsize;
		T* new_arr = new T[capacity];

		for (int i = 0; i < currentsize; i++) {
			new_arr[i] = arr[i];
			delete arr;
			arr = new_arr;
		}
	}

	void increase_capacity(int expander) { // юзлесс
		T* new_arr = new T[capacity + expander];

		for (int i = 0; i < currentsize; i++) {
			new_arr[i] = arr[i];
		}

		delete arr;
		capacity += expander;
		arr = new_arr;
	}

public:
	Massiv() :capacity(1), currentsize(0), arr(new T[capacity]) {}
	Massiv(int capacity1) : capacity(capacity1), currentsize(0), arr(new T[capacity1]) {}
	~Massiv() {
		delete arr;
	}

	int get_currentsize() {
		return currentsize;
	}

	void push_back(T val) {
		if (currentsize == capacity) increase_capacity();
		arr[currentsize] = val;
		currentsize++;
	}

	void pop_back() {
		currentsize--;
		if (currentsize == (capacity / 2)) reduce_capacity();
	}

	int search(T val) { 
		for (int i = 0; i < currentsize; i++) {
			if (arr[i] == val) {
				return i;
			}
		}
		return -1;
	}

	void remove(int index) {
		for (int i = index; i <= currentsize; ++i) {
			arr[i] = arr[i + 1];
		}
		--currentsize;
		if (currentsize == (capacity / 2)) reduce_capacity();
	}

	void push(int index, T val)
	{
		if (currentsize >= capacity) increase_capacity();

		if (index == capacity) push_back(val);
		else {
			for (int i = currentsize - 1; i >= index; i--) {
				arr[i + 1] = arr[i];
			}

			arr[index] = val;
			++currentsize;
		}

	}

	void set(int index, T val) {
		if (index <= currentsize && index >= 0)
			arr[index] = val;
	}

	T get(int index) const { 
		if (index <= currentsize && index >= 0)
			return arr[index];
	}
};

// int* x = new int[10];

int main() {
	setlocale(LC_ALL, "rus");
	Massiv<A<int>*> arr;
	for (int i = 0; i < 1000; ++i) {
		arr.push_back(new A<int>(rand() % 100));
	}
	for (int i = 0; i < 100; ++i) {
		switch (rand() % 8)
		{
		case 0:
			arr.push_back(new A<int>(rand() % 100)); // засунуть в конец
			break;
		case 1:
			if (arr.get_currentsize()) {
				arr.remove(rand() % 1000);} // удалить со сдвигом
			break;
		case 2:
			if (arr.get_currentsize()) {
				arr.pop_back();}  // удалить с конца
			break;
		case 3:
			arr.get(rand() % 1000);  //возвращает адрес значения
			break;
		case 5:
			arr.set(rand() % 1000, new A<int>(rand() % 100)); // поменять значение по индексу
			break;
		case 6:
			arr.search((new A<int>(rand() % 100))); //возвращает индекс
			break;
		case 7:
			arr.push(rand() % 1000, new A<int>(rand() % 100)); // засунуть со сдвигом элемент по индексу
			break;
		}
	}
	for (int i = 1; i < arr.get_currentsize(); ++i) {
		cout << *arr.get(i); //arr.get(i) возвращает адрес - разыменовываем
		cout << "  ";
		if ((i + 1) % 10 == 0) cout << endl;
	}
}
