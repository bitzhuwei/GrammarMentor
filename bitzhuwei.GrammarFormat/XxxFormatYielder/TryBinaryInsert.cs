﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic {
    static partial class Algorithm {
        // 尝试插入新元素。如果存在相同的元素，就不插入，并返回false。否则返回true。
        /// <summary>
        /// try to add <paramref name="item"/> if it's new to the <paramref name="list"/>.
        /// <para>returns true if inserted, otherwise false.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool TryBinaryInsert<T>(this IList<T> list, T item)
            where T : IComparable<T> {
            bool inserted = false;

            if (list == null || item == null) { return inserted; }

            int left = 0, right = list.Count - 1;
            if (right < 0) {
                list.Add(item);
                inserted = true;
            }
            else {
                while (left < right) {
                    int mid = (left + right) / 2;
                    T current = list[mid];
                    int result = item.CompareTo(current);
                    if (result < 0) { right = mid; }
                    else if (result == 0) { left = mid; right = mid; }
                    else { left = mid + 1; }
                }
                {
                    T current = list[left];
                    int result = item.CompareTo(current);
                    if (result < 0) {
                        list.Insert(left, item);
                        inserted = true;
                    }
                    else if (result > 0) {
                        list.Insert(left + 1, item);
                        inserted = true;
                    }
                }
            }

            return inserted;
        }

        /// <summary>
        /// <para>returns true if contains, otherwise false.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool BinaryContains<T>(this IList<T> list, T item)
            where T : IComparable<T> {
            bool contains = true;

            if (list == null || item == null) { return contains; }

            int left = 0, right = list.Count - 1;
            if (right < 0) {
                contains = false;
            }
            else {
                while (left < right) {
                    int mid = (left + right) / 2;
                    T current = list[mid];
                    int result = item.CompareTo(current);
                    if (result < 0) { right = mid; }
                    else if (result == 0) { left = mid; right = mid; }
                    else { left = mid + 1; }
                }
                {
                    T current = list[left];
                    int result = item.CompareTo(current);
                    if (result < 0) {
                        list.Insert(left, item);
                        contains = false;
                    }
                    else if (result > 0) {
                        list.Insert(left + 1, item);
                        contains = false;
                    }
                }
            }

            return contains;
        }

        /// <summary>
        /// <para>returns true if contains, otherwise false.</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int BinaryIndexOf<T>(this IList<T> list, T item)
            where T : IComparable<T> {
            int index = -1;

            if (list == null || item == null) { return index; }

            int left = 0, right = list.Count - 1;
            if (right < 0) {
            }
            else {
                while (left < right) {
                    int mid = (left + right) / 2;
                    T current = list[mid];
                    int result = item.CompareTo(current);
                    if (result < 0) { right = mid; }
                    else if (result == 0) { left = mid; right = mid; }
                    else { left = mid + 1; }
                }
                {
                    T current = list[left];
                    int result = item.CompareTo(current);
                    if (result < 0) {
                        list.Insert(left, item);
                    }
                    else if (result > 0) {
                        list.Insert(left + 1, item);
                    }
                    else {
                        index = left;
                    }
                }
            }

            return index;
        }

    }
}
