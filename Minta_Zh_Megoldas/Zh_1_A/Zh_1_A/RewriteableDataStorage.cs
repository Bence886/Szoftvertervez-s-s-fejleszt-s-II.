using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_1_A
{
    class RewriteableDataStorage : DigitalDataStorage, IRewriteable
    {
        bool closed = false;
        public RewriteableDataStorage(int size) : base(size)
        {
        }
        DateTime lastWriteDate;

        public DateTime LastWriteDate { get => lastWriteDate; set => lastWriteDate = value; }

        public void Rewrite(string data)
        {
            int i = DataArray.Length-1;
            while (i > 0 && DataArray[i] == null)
            {
                i--;
            }
            DataArray[i] = data;
        }

        public override void Write(string data)
        {
            if (!closed)
            {
                int i = 0;
                while (i < DataArray.Length && DataArray[i] != null)
                {
                    i++;
                }
                if (i < DataArray.Length)
                {
                    DataArray[i] = data;
                }
                else
                {
                    throw new NoStorageSpace(this, this.DataArray.Length);
                }
            }
        }

        void Close()
        {
            if (FreeSpace() == DataArray.Length)
            {
                throw new EmptyStorageException(DataArray.Length);
            }
            else
            {
                closed = true;
                OnStorageFull();
            }
        }

        public override string ToString()
        {
            return $"{DataArray.Length}";
        }
    }


}
