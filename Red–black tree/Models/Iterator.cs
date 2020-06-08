using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RedBlackTreeAlgorithms
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Возвращает ключ текущего элемента
        public abstract int Key();

        // Возвращает текущий элемент.
        public abstract object Current();

        // Переходит к следующему элементу.
        public abstract bool MoveNext();

        // Перематывает Итератор к первому элементу.
        public abstract void Reset();
    }

    public abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }


    class InOrderIterator<T> : Iterator
    {
        private RedBlackTree<T> _tree;
        private RedBlackTreeNode<T> _current;

        // Хранит текущее положение обхода. У итератора может быть множество
        // других полей для хранения состояния итерации, особенно когда он
        // должен работать с определённым типом коллекции.
        private int _position = -1;

        public InOrderIterator(RedBlackTree<T> tree)
        {
            this._tree = tree;
        }

        public override object Current()
        {
            return this._current;
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            if (_current == _tree.RightMost)
            {
                return false;
            }
            if (_current == null)
            {
                _current = _tree.LeftMost;
                return true;
            }
            if (_current.Right != null)
            {
                _current = (RedBlackTreeNode<T>)_current.Right;
                while (_current.Left != null)
                    _current = (RedBlackTreeNode<T>)_current.Left;
                return true;
            }
            while (_current.Parent != null)
            {
                if (_current.Parent.Left == _current)
                {
                    _current = (RedBlackTreeNode<T>)_current.Parent;
                    return true;
                }
                _current = (RedBlackTreeNode<T>)_current.Parent;
            }
            return true;
        }

        public override void Reset()
        {
            this._position = -1;
        }
    }


}
