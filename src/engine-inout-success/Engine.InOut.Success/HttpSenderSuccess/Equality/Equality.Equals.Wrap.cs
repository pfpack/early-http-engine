#nullable enable

namespace PrimeFuncPack
{
    partial struct HttpSenderSuccess<TContent>
    {
        public override bool Equals(object? obj)
            =>
            obj is HttpSenderSuccess<TContent> other && Equals(other);
    }
}