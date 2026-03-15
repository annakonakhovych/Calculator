namespace Computer_Science_Calculator;

public class Queue
{
    private const int Capacity = 50;
    private string[] _array = new string[Capacity];
    private int _pointer;

    public void Enqueue(string value)
    {
        if (_pointer == Capacity)
        {
            throw new Exception("Queue is full");
        }

        _array[_pointer] = value;
        _pointer++;
    }

    public string Dequeue()
    {
        if (_pointer == 0)
        {
            return null;
        }

        string value = _array[0]; //показуємо елемент який ми забрали(ну а далі вже пересуввємо усе)
        
        for (int i = 0; i < _pointer - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _pointer--;
        return value;
    }
}