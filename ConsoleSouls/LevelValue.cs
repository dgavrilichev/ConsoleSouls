using System;
using System.Collections.Generic;

namespace ConsoleSouls
{
    internal sealed class LevelValue<T> where T : IComparable
    {
        private T _current;
        internal T Current
        {
            get => _current;
            set => _current = Comparer<T>.Default.Compare(Maximum, value) > 0 ? value : Maximum;
        }

        internal T Maximum { get; set; }

        public LevelValue(T maximum)
        {
            Current = maximum;
            Maximum = maximum;
        }
    }
}
