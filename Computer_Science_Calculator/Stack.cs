namespace Computer_Science_Calculator;

public class Stack
{
    private const int Capacity = 50;
    private string[] _array = new string[Capacity];
    private int _pointer; //автоматисно рівний нулю при створенні, вказує на комірку в масиві

    public void Push(string value)
    {
        if (_pointer == Capacity)
        {
            throw new Exception("Stack overflowed");
        }

        _array[_pointer] = value;
        _pointer++;
    }

    public string Pull()
    {
        if (_pointer == 0)
        {
            return null; //ічого не виведе типу порожній рядок
        }

        _pointer--;
        return _array[_pointer];
    }

    public string Peek()
    {
        if (_pointer == 0)
        {
            return null;
        }

        return _array[_pointer - 1];
    }
}