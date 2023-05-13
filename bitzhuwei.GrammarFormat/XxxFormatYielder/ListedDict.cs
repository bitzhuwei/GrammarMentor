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
    /// <typeparamref name="TKey"/> -> list of <typeparamref name="TValue"/>.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public partial class ListedDict<TKey, TValue> : IEnumerable<KeyValuePair<TKey, CoupleList<TValue>>>
        where TValue : IComparable<TValue> {

        /// <summary>
        /// <typeparamref name="TKey"/> -> list of <typeparamref name="TValue"/>.
        /// </summary>
        public ListedDict() { }

        private readonly Dictionary<TKey, CoupleList<TValue>> m_Dict = new Dictionary<TKey, CoupleList<TValue>>();

        public bool TryInsert(TKey key, IReadOnlyList<TValue> values) {
            if (!this.m_Dict.TryGetValue(key, out var list)) {
                list = new CoupleList<TValue>();
                this.m_Dict.Add(key, list);
            }

            bool inserted = false;
            foreach (var value in values) {
                if (list.TryInsert(value)) { inserted = true; }
            }

            return inserted;
        }

        public bool TryInsert(TKey key, TValue value) {
            if (!this.m_Dict.TryGetValue(key, out var list)) {
                list = new CoupleList<TValue>();
                this.m_Dict.Add(key, list);
            }
            var inserted = list.TryInsert(value);

            return inserted;
        }

        /// <summary>
        /// get value for specified <paramref name="key"/>.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public CoupleList<TValue> this[TKey key] {
            get { return this.m_Dict[key]; }
        }

        public int Count { get { return this.m_Dict.Count; } }

        public bool TryGetValue(TKey key, out CoupleList<TValue> list) {
            return this.m_Dict.TryGetValue(key, out list);
        }

        public bool ContainsKey(TKey key) {
            return this.m_Dict.ContainsKey(key);
        }

        public IEnumerator<KeyValuePair<TKey, CoupleList<TValue>>> GetEnumerator() {
            return (this.m_Dict as IEnumerable<KeyValuePair<TKey, CoupleList<TValue>>>).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.m_Dict.GetEnumerator();
        }

        /// <summary>
        /// get traditional <see cref="KeyValuePair{TKey, TValue}"/>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KeyValuePair<TKey, TValue>> GetPairs() {
            foreach (var pair in this.m_Dict) {
                var key = pair.Key; var list = pair.Value;
                foreach (var value in list) {
                    yield return new KeyValuePair<TKey, TValue>(key, value);
                }
            }
        }
    }
}
