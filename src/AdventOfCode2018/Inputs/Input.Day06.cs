using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Inputs
{
    public static partial class Input
    {
        public static IList<string> Day06Parse(string input) => input.SplitLines().ToList();

        public const string Day06 =
@"252, 125
128, 333
89, 324
141, 171
266, 338
117, 175
160, 236
234, 202
165, 192
204, 232
83, 192
229, 178
333, 57
70, 243
108, 350
161, 63
213, 277
87, 299
163, 68
135, 312
290, 87
73, 246
283, 146
80, 357
66, 312
159, 214
221, 158
175, 54
298, 342
348, 162
249, 90
189, 322
311, 181
194, 244
53, 295
80, 301
262, 332
268, 180
139, 287
115, 53
163, 146
220, 268
79, 85
95, 112
349, 296
179, 274
113, 132
158, 264
316, 175
268, 215";
    }
}