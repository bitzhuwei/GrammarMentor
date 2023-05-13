using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using Microsoft.Win32.SafeHandles;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// Correspond to the Vn node Repeat in the grammar(Regex).
    /// </summary>
    public class Repeat {
        /// <summary>
        /// the 'omissive' sign.
        /// </summary>
        public const int infinite = -1;
        public const string infiniteString = "infinite";
        public const string omissiveString = "omissive";


        public readonly ERepeat repeatType;
        /// <summary>
        /// at least 0.
        /// </summary>
        public readonly int min;
        /// <summary>
        /// -1 means infinite.
        /// </summary>
        public readonly int max;

        /// <summary>
        /// not <see cref="ERepeat.Interval"/>
        /// </summary>
        /// <param name="repeatType"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public Repeat(ERepeat repeatType) {
            this.repeatType = repeatType;
            switch (repeatType) {
            case ERepeat.One:
            this.min = 1;
            this.max = 1;
            break;
            case ERepeat.ZeroOne:
            this.min = 0;
            this.max = 1;
            break;
            case ERepeat.OneMore:
            this.min = 1;
            this.max = infinite;
            break;
            case ERepeat.ZeroMore:
            this.min = 0;
            this.max = infinite;
            break;
            case ERepeat.Interval:
            throw new ArgumentException($"{ERepeat.Interval} is not accepted here.", $"{nameof(repeatType)}");
            //break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }

        /// <summary>
        /// <see cref="ERepeat.Interval"/>
        /// </summary>
        /// <param name="repeatType"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public Repeat(int min, int max = infinite) {
            this.repeatType = ERepeat.Interval;
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// returns {min, max}
        /// </summary>
        /// <returns></returns>
        public string ToBound() {
            var upper = max == infinite ? "¡Þ" : max.ToString();
            return $"{{{min}, {upper}}}";
        }

        public override string ToString() {
            var result = string.Empty;
            if (this.repeatType == ERepeat.Interval) {
                var upper = max == infinite ? "¡Þ" : max.ToString();
                result = $"{{{min}, {upper}}}";
            }
            else {
                result = this.repeatType.ToString();
            }

            return result;
        }
    }

    public enum ERepeat {
        /// <summary>
        /// {1, 1}
        /// <para>1 time</para>
        /// </summary>
        One,
        /// <summary>
        /// ? {0, 1}
        /// <para>0 or 1 time.</para>
        /// </summary>
        ZeroOne,
        /// <summary>
        /// + {1, ¡Þ}
        /// <para>1 or more times.</para>
        /// </summary>
        OneMore,
        /// <summary>
        /// * {0, ¡Þ}
        /// <para>0 or more times.</para>
        /// </summary>
        ZeroMore,
        /// <summary>
        /// {min, max}
        /// </summary>
        Interval,
    }
}
