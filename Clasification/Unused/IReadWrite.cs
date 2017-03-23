namespace Clasification
{
    internal interface IReadWrite
    {
        string Read(string type);

        void Write(string data, string type);
    }
}