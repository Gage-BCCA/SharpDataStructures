using System.Runtime.InteropServices.JavaScript;

namespace SharpDataStructures.Structures;


public class DynamicArray
{
    /*
     *   Array that dynamically grows and shrinks
     */
    
    private int _count;
    private int _capacity;
    private int[] _array;

    public int Count => _count;
    public int Length => _capacity;

    public DynamicArray()
    {
        this._count = 0;
        this._capacity = 0;
        this._array = [this._capacity];
    }

    public void Append(int value)
    {
        if (_count == _capacity)
        {
            ResizeArray();
        }

        _array[_count] = value;
        _count += 1;
    }

    public int Get(int index)
    {
        return _array[index];
    }

    public void Delete(int index)
    {
        DeleteAtIndexAndShiftLeft(index);
        _count -= 1;
        if (_count < _capacity / 2)
        {
            DownsizeArray();
        }
    }

    private void ResizeArray()
    {
        UpsizeCapacity();
        int[] newArray = new int[_capacity];
        for (int x = 0; x < _count; x++)
        {
            newArray[x] = _array[x];
        }
        _array = newArray;
    }

    private void DownsizeArray()
    {
        DownsizeCapacity();
        int[] newArray = new int[_capacity];
        for (int x = 0; x < _count; x++)
        {
            newArray[x] = _array[x];
        }
        
        _array = newArray;
    }

    private void UpsizeCapacity()
    {
        if (_capacity == 0)
        {
            _capacity += 1;
        }
        else
        {
            _capacity = _capacity * 2;
        }
        
    }

    private void DownsizeCapacity()
    {
        _capacity = _capacity / 2;
    }

    private void DeleteAtIndexAndShiftLeft(int index)
    {
        int[] buffer = new int[_capacity];
        
        int i = 0;
        int j = 0;
        while (i < _capacity)
        {
            if (i != index)
            {
                buffer[j] = _array[i];
                j++;
            }

            i++;
        }

        _array = buffer;
    }
    


}