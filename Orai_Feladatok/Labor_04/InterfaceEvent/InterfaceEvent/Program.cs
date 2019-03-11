using System;

namespace InterfaceEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone A = new Phone(1000, "0123456789");
            Phone B = new Phone(1000, "9876543210");

            CallLog log = new CallLog();
            A.RegisterListener(log);
            B.RegisterListener(log);

            A.StartCall(B);
        }
    }
    interface ICallListener
    {
        void IncomingCall(Phone kuldo, string forras_telefonszam);
        void OutgoindCall(Phone kuldo, string cel_telefonszam);
    }
    class Phone
    {
        string number;
        int sum;
        ICallListener callListener;
        public Phone(int sum, string number)
        {
            Sum = sum;
            Number = number;
        }
        public int Sum { get => sum; private set => sum = value; }
        public string Number { get => number; private set => number = value; }

        public void RegisterListener(ICallListener listener)
        {
            callListener = listener;
        }
        private void AcceptCall(Phone source)
        {
            if (callListener != null)
            {
                callListener.IncomingCall(source, source.Number);
            }
        }
        public void StartCall(Phone cel)
        {
            callListener.OutgoindCall(cel, cel.Number);
            if (sum > 100)
            {
                sum -= 100;
                cel.AcceptCall(this);
            }
        }
        public override string ToString()
        {
            return string.Format("Telefonszam:{0}, egyenleg:{1}", number, sum);
        }
    }

    class CallLog : ICallListener
    {
        public void IncomingCall(Phone sender, string source_number)
        {
            Console.WriteLine("Hívás innen: " + sender.ToString());
        }

        public void OutgoindCall(Phone sender, string destination_number)
        {
            Console.WriteLine("Hívom ezt: " + sender.ToString());
        }
    }
}