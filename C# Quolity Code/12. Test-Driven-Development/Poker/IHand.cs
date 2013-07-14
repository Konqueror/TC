using System;
using System.Collections.Generic;

namespace Poker
{
    public interface IHand
    {
        List<ICard> Cards { get; }
        void Sort();
        string ToString();
    }
}
