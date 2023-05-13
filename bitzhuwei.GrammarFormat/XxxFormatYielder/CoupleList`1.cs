using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// stores data in two <see cref="List{T}"/>.
    /// <para><see cref="CoupleList{T}.addList"/> to add and display items.</para>
    /// <para><see cref="CoupleList{T}.orderList"/> to keep items in order so that comparing <see cref="CoupleList{T}.addList"/> is fast.</para>
    /// <para>Only support operation of adding.</para>
    /// </summary>
    public partial class CoupleList<T> : IReadOnlyList<T>
        where T : IComparable<T> {

        /// <summary>
        /// stores data in two <see cref="List{T}"/>.
        /// <para><see cref="CoupleList{T}.addList"/> to add and display items.</para>
        /// <para><see cref="CoupleList{T}.orderList"/> to keep items in order so that comparing <see cref="CoupleList{T}.addList"/> is fast.</para>
        /// <para>Only support operation of adding.</para>
        /// </summary>
        public CoupleList() { }

        /// <summary>
        /// the apearance list.
        /// </summary>
        private readonly List<T> addList = new List<T>();
        /// <summary>
        /// the inner list used to compare <see cref="CoupleList{T}.addList"/> as a collection.
        /// </summary>
        private readonly List<T> orderList = new List<T>();

        /// <summary>
        /// add <paramref name="item"/> if it's new in this list.
        /// </summary>
        /// <param name="item"></param>
        public bool TryInsert(T item) {
            Debug.Assert(item != null);
            bool inserted = this.orderList.TryBinaryInsert(item);
            if (inserted) {
                this.addList.Add(item);
                this.dirty = true;
            }

            return inserted;
        }

        public T this[int index] {
            get { return this.addList[index]; }
        }

        public int Count { get { return this.addList.Count; } }

        public int IndexOf(T item) {
            return this.addList.IndexOf(item);
        }

        ///// <summary>
        ///// get item by <see cref="CoupleList{T}.orderedList"/>
        ///// </summary>
        ///// <param name="index"></param>
        ///// <returns></returns>
        //public T GetOrdered(int index) {
        //    return this.orderedList[index];
        //}

        //public void Print(TextWriter w) {
        //    foreach (var item in this.orderList) {
        //        w.Write(item); w.Write(' ');
        //    }
        //}

        public override string ToString() {
            return $"{this.Count} items";
        }

        //int IComparable<CoupleList<T>>.CompareTo(CoupleList<T> other)
        //{
        //    if (other == null) { return 1; }

        //    int leftCount = this.orderedList.Count;
        //    int rightCount = other.orderedList.Count;
        //    if (leftCount < rightCount) { return -1; }
        //    else if (leftCount > rightCount) { return 1; }
        //    else
        //    {
        //        int result = 0;
        //        for (int i = 0; i < leftCount; i++)
        //        {
        //            var left = this.orderedList[i];
        //            var right = other.orderedList[i];
        //            Debug.Assert(left != null && right != null);
        //            var value = left.CompareTo(right);
        //            if (value != 0)
        //            {
        //                result = value;
        //                break;
        //            }
        //        }

        //        return result;
        //    }
        //}

        public IEnumerator<T> GetEnumerator() {
            return ((IEnumerable<T>)this.addList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable)this.addList).GetEnumerator();
        }

    }
}
