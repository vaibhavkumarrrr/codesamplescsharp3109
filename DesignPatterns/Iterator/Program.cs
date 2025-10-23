﻿// EN: Iterator Design Pattern
//
// Intent: Lets you traverse elements of a collection without exposing its
// underlying representation (list, stack, tree, etc.).
using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp.training.congruent.apps.patterns
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // EN: Returns the key of the current element
        public abstract int Key();
		
        // EN: Returns the current element
        public abstract object Current();
		
        // EN: Move forward to next element
        public abstract bool MoveNext();
		
        // EN: Rewinds the Iterator to the first element
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        // EN: Returns an Iterator or another IteratorAggregate for the
        // implementing object.
        public abstract IEnumerator GetEnumerator();
    }

    // EN: Concrete Iterators implement various traversal algorithms. These
    // classes store the current traversal position at all times.
    class AlphabeticalOrderIterator : Iterator
    {
        private readonly WordsCollection _collection;
		
        // EN: Stores the current traversal position. An iterator may have a lot
        // of other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;
		
        private readonly bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }
		
        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }
		
        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
		
        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }

    // EN: Concrete Collections provide one or several methods for retrieving
    // fresh iterator instances, compatible with the collection class.
    class WordsCollection : IteratorAggregate
    {
        readonly List<string> _collection = [];
		
        bool _direction = false;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
		
        public List<string> GetItems()
        {
            return _collection;
        }
		
        public void AddItem(string item)
        {
            this._collection.Add(item);
        }
		
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }

    class Program
    {
        static void Main(string[] _)
        {
            // EN: The client code may or may not know about the Concrete
            // Iterator or Collection classes, depending on the level of
            // indirection you want to keep in your program.
         
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
