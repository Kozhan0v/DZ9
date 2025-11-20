using System;

namespace Tumakov.Interfaces
{
    internal interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
