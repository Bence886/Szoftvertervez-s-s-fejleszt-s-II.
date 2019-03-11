using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_1_A
{
    delegate void StorageFull(DigitalDataStorage s);
    class DigitalDataStorage : IComparable
    {
        public event StorageFull StorageFullEvent;
        public string[] DataArray { get; private set; }
        public DigitalDataStorage(int size)
        {
            DataArray = new string[size];
        }

        public void OnStorageFull()
        {
            StorageFullEvent(this);
        }

        public virtual void Write(string data)
        {
            int i = 0;
            while (i < DataArray.Length && DataArray[i] != null)
            {
                i++;
            }
            if (i < DataArray.Length)
            {
                if (i == DataArray.Length - 1)
                {
                    DataArray[i] = data;
                    OnStorageFull();
                }
                else
                {
                    DataArray[i] = data;
                }
            }
            else
            {
                throw new NoStorageSpace(this, this.DataArray.Length);
            }
        }

        public int FreeSpace()
        {
            int num = 0;
            for (int i = 0; i < DataArray.Length; i++)
            {
                if (DataArray[i] == null)
                {
                    num++;
                }
            }
            return num;
        }

        public int CompareTo(object obj)
        {
            if (obj is DigitalDataStorage)
            {
                if (FreeSpace() > (obj as DigitalDataStorage).FreeSpace())
                {
                    return 1;
                }
                else if (FreeSpace() == (obj as DigitalDataStorage).FreeSpace())
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
                // return FreeSpace() - (obj as DigitalDataStorage).FreeSpace();
            }
            throw new ArgumentException(obj.GetType() + " is not a " + this.GetType());
        }

        public override string ToString()
        {
            return $"{DataArray.Length}";
        }
    }

    class NoStorageSpace : ApplicationException
    {
        DigitalDataStorage dds;
        int max;

        public NoStorageSpace(DigitalDataStorage dds, int max)
        {
            this.dds = dds;
            this.max = max;
        }
    }
}
