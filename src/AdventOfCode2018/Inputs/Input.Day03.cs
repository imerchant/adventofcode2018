using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Inputs
{
    public static partial class Input
    {
        public static IList<string> Day03Parse(string input) => input.SplitLines().ToList();

        public const string Day03 =
@"#1 @ 167,777: 23x12
#2 @ 253,106: 10x25
#3 @ 104,622: 11x25
#4 @ 267,61: 14x16
#5 @ 829,831: 19x10
#6 @ 886,374: 22x12
#7 @ 129,812: 18x17
#8 @ 972,677: 14x17
#9 @ 123,249: 12x14
#10 @ 669,330: 11x21
#11 @ 657,629: 29x28
#12 @ 961,341: 14x16
#13 @ 921,321: 10x27
#14 @ 418,646: 13x10
#15 @ 94,106: 24x22
#16 @ 570,515: 23x18
#17 @ 476,666: 29x23
#18 @ 28,430: 7x4
#19 @ 943,766: 10x19
#20 @ 120,528: 25x22
#21 @ 801,611: 4x6
#22 @ 455,766: 20x20
#23 @ 12,560: 29x29
#24 @ 694,858: 29x28
#25 @ 506,830: 27x26
#26 @ 245,815: 12x11
#27 @ 130,169: 11x21
#28 @ 318,536: 12x11
#29 @ 552,292: 20x29
#30 @ 18,428: 27x28
#31 @ 863,195: 29x28
#32 @ 119,798: 17x19
#33 @ 199,295: 23x10
#34 @ 28,60: 21x23
#35 @ 549,211: 25x20
#36 @ 821,745: 11x24
#37 @ 594,155: 24x28
#38 @ 220,172: 22x28
#39 @ 299,334: 28x17
#40 @ 365,660: 28x27
#41 @ 863,948: 18x18
#42 @ 685,115: 15x24
#43 @ 168,837: 21x19
#44 @ 835,76: 27x29
#45 @ 564,649: 26x16
#46 @ 668,398: 19x18
#47 @ 784,349: 29x10
#48 @ 409,316: 24x18
#49 @ 216,297: 16x20
#50 @ 627,54: 29x19
#51 @ 8,263: 24x15
#52 @ 516,697: 16x13
#53 @ 714,569: 26x25
#54 @ 212,159: 28x26
#55 @ 804,224: 15x28
#56 @ 106,557: 29x24
#57 @ 717,605: 23x14
#58 @ 556,76: 24x11
#59 @ 582,123: 15x11
#60 @ 7,670: 10x14
#61 @ 590,343: 25x18
#62 @ 816,115: 18x11
#63 @ 110,892: 12x27
#64 @ 226,411: 23x24
#65 @ 71,805: 14x19
#66 @ 285,52: 19x17
#67 @ 515,814: 22x18
#68 @ 254,342: 10x13
#69 @ 42,385: 23x13
#70 @ 285,708: 13x24
#71 @ 464,703: 17x24
#72 @ 833,54: 19x26
#73 @ 534,272: 29x19
#74 @ 362,264: 28x18
#75 @ 239,420: 14x25
#76 @ 255,420: 28x20
#77 @ 881,401: 23x23
#78 @ 685,482: 14x24
#79 @ 756,156: 22x15
#80 @ 39,211: 26x21
#81 @ 20,476: 14x10
#82 @ 352,42: 13x24
#83 @ 329,228: 26x25
#84 @ 930,625: 18x14
#85 @ 113,433: 20x29
#86 @ 894,390: 15x25
#87 @ 123,618: 23x14
#88 @ 543,253: 15x24
#89 @ 424,723: 10x20
#90 @ 445,373: 10x14
#91 @ 662,825: 22x23
#92 @ 284,196: 18x13
#93 @ 335,567: 26x12
#94 @ 294,150: 21x18
#95 @ 742,232: 29x29
#96 @ 391,841: 16x19
#97 @ 580,188: 5x3
#98 @ 52,333: 12x19
#99 @ 947,440: 21x25
#100 @ 812,612: 23x27
#101 @ 144,626: 15x16
#102 @ 784,683: 27x23
#103 @ 861,263: 27x29
#104 @ 845,892: 23x29
#105 @ 472,672: 18x16
#106 @ 937,130: 11x15
#107 @ 281,161: 15x14
#108 @ 522,748: 11x29
#109 @ 838,969: 25x19
#110 @ 271,381: 15x12
#111 @ 585,150: 27x11
#112 @ 335,369: 22x13
#113 @ 540,719: 24x15
#114 @ 651,198: 28x17
#115 @ 425,55: 29x22
#116 @ 815,702: 17x26
#117 @ 560,494: 10x15
#118 @ 609,82: 16x23
#119 @ 46,385: 24x26
#120 @ 128,922: 13x13
#121 @ 258,333: 25x18
#122 @ 612,805: 19x22
#123 @ 441,262: 14x10
#124 @ 984,470: 11x10
#125 @ 415,610: 16x25
#126 @ 772,562: 25x16
#127 @ 830,22: 29x15
#128 @ 81,863: 16x12
#129 @ 883,550: 23x29
#130 @ 93,691: 18x19
#131 @ 134,63: 25x17
#132 @ 155,579: 14x23
#133 @ 2,674: 14x27
#134 @ 490,495: 12x19
#135 @ 804,160: 12x14
#136 @ 386,84: 22x17
#137 @ 497,387: 22x19
#138 @ 463,932: 18x29
#139 @ 488,732: 29x18
#140 @ 577,936: 19x10
#141 @ 78,429: 29x13
#142 @ 268,937: 19x12
#143 @ 682,855: 13x27
#144 @ 153,773: 16x28
#145 @ 887,435: 16x16
#146 @ 300,235: 25x29
#147 @ 381,648: 25x22
#148 @ 339,17: 29x18
#149 @ 210,433: 27x16
#150 @ 396,728: 22x21
#151 @ 359,635: 27x14
#152 @ 342,478: 21x17
#153 @ 909,484: 11x21
#154 @ 150,428: 16x15
#155 @ 134,565: 20x11
#156 @ 319,276: 29x14
#157 @ 905,588: 11x25
#158 @ 487,48: 3x4
#159 @ 64,219: 15x25
#160 @ 131,34: 12x18
#161 @ 477,477: 15x14
#162 @ 568,204: 28x26
#163 @ 559,769: 14x12
#164 @ 883,918: 15x20
#165 @ 730,844: 13x15
#166 @ 193,293: 7x8
#167 @ 149,777: 22x19
#168 @ 138,192: 17x18
#169 @ 285,343: 11x20
#170 @ 564,662: 23x27
#171 @ 368,853: 25x14
#172 @ 434,358: 27x27
#173 @ 54,624: 21x21
#174 @ 936,233: 27x19
#175 @ 912,672: 12x11
#176 @ 577,727: 15x25
#177 @ 831,630: 10x14
#178 @ 954,594: 29x18
#179 @ 664,10: 22x17
#180 @ 552,940: 11x16
#181 @ 642,338: 12x13
#182 @ 817,822: 19x16
#183 @ 800,611: 20x27
#184 @ 56,653: 20x20
#185 @ 892,578: 21x15
#186 @ 317,160: 10x25
#187 @ 549,927: 26x20
#188 @ 102,955: 28x15
#189 @ 864,102: 21x22
#190 @ 881,551: 11x24
#191 @ 30,204: 11x21
#192 @ 101,357: 26x24
#193 @ 161,823: 25x24
#194 @ 323,795: 19x11
#195 @ 907,608: 13x23
#196 @ 359,644: 10x24
#197 @ 74,116: 27x13
#198 @ 448,766: 14x19
#199 @ 400,76: 15x21
#200 @ 423,615: 28x29
#201 @ 662,64: 24x16
#202 @ 441,828: 25x27
#203 @ 171,579: 17x17
#204 @ 709,935: 24x12
#205 @ 868,350: 14x12
#206 @ 795,938: 20x17
#207 @ 191,285: 12x22
#208 @ 122,473: 18x19
#209 @ 704,786: 15x29
#210 @ 389,89: 26x15
#211 @ 772,9: 16x13
#212 @ 64,423: 20x10
#213 @ 107,542: 10x19
#214 @ 787,596: 29x22
#215 @ 210,300: 15x16
#216 @ 115,788: 28x24
#217 @ 25,902: 13x10
#218 @ 325,432: 21x20
#219 @ 901,748: 17x10
#220 @ 875,395: 25x14
#221 @ 17,719: 13x13
#222 @ 553,238: 28x13
#223 @ 19,475: 10x11
#224 @ 223,778: 26x19
#225 @ 187,515: 17x24
#226 @ 762,549: 18x20
#227 @ 2,381: 20x15
#228 @ 362,410: 18x10
#229 @ 597,736: 15x17
#230 @ 253,298: 22x18
#231 @ 772,686: 15x24
#232 @ 799,261: 26x25
#233 @ 58,918: 24x12
#234 @ 592,233: 15x22
#235 @ 110,605: 19x23
#236 @ 251,7: 13x22
#237 @ 803,821: 16x17
#238 @ 498,485: 22x13
#239 @ 261,363: 24x21
#240 @ 825,60: 13x27
#241 @ 738,363: 20x22
#242 @ 312,250: 28x26
#243 @ 876,111: 21x16
#244 @ 745,877: 29x19
#245 @ 228,115: 24x21
#246 @ 772,707: 17x19
#247 @ 875,269: 28x14
#248 @ 774,47: 24x19
#249 @ 274,296: 22x15
#250 @ 135,460: 10x12
#251 @ 81,801: 10x28
#252 @ 467,900: 27x23
#253 @ 270,251: 27x26
#254 @ 447,76: 25x11
#255 @ 567,917: 21x20
#256 @ 385,852: 20x22
#257 @ 623,165: 12x27
#258 @ 579,909: 18x29
#259 @ 462,97: 17x15
#260 @ 198,272: 29x24
#261 @ 249,160: 24x15
#262 @ 137,473: 11x26
#263 @ 630,879: 26x26
#264 @ 561,378: 21x23
#265 @ 155,55: 29x28
#266 @ 948,737: 29x26
#267 @ 273,147: 24x27
#268 @ 580,127: 11x27
#269 @ 610,387: 19x10
#270 @ 96,709: 19x25
#271 @ 852,5: 25x10
#272 @ 516,744: 23x13
#273 @ 195,82: 15x11
#274 @ 581,392: 17x15
#275 @ 900,263: 10x19
#276 @ 626,722: 29x29
#277 @ 321,540: 11x20
#278 @ 454,690: 23x10
#279 @ 143,753: 25x11
#280 @ 245,348: 23x19
#281 @ 286,868: 20x21
#282 @ 654,807: 13x21
#283 @ 1,601: 29x25
#284 @ 379,715: 20x23
#285 @ 60,451: 17x15
#286 @ 114,623: 22x29
#287 @ 85,886: 21x27
#288 @ 952,295: 24x12
#289 @ 723,661: 14x28
#290 @ 338,712: 17x20
#291 @ 100,431: 17x22
#292 @ 281,193: 20x10
#293 @ 518,398: 20x27
#294 @ 639,922: 24x20
#295 @ 630,372: 27x10
#296 @ 776,389: 19x23
#297 @ 134,575: 13x14
#298 @ 112,514: 26x10
#299 @ 565,745: 28x18
#300 @ 494,536: 17x10
#301 @ 282,12: 12x3
#302 @ 190,892: 23x28
#303 @ 618,389: 6x5
#304 @ 53,859: 18x18
#305 @ 517,769: 24x25
#306 @ 125,172: 25x16
#307 @ 75,267: 20x12
#308 @ 116,58: 15x27
#309 @ 370,409: 23x23
#310 @ 788,519: 14x26
#311 @ 243,11: 27x28
#312 @ 152,158: 19x18
#313 @ 823,797: 19x3
#314 @ 915,688: 28x24
#315 @ 4,166: 26x25
#316 @ 571,685: 23x24
#317 @ 297,437: 26x17
#318 @ 831,121: 16x10
#319 @ 466,273: 27x28
#320 @ 455,159: 14x29
#321 @ 341,855: 29x23
#322 @ 828,691: 23x28
#323 @ 373,273: 15x25
#324 @ 53,230: 10x11
#325 @ 302,446: 28x15
#326 @ 397,483: 16x12
#327 @ 211,651: 26x20
#328 @ 654,83: 28x19
#329 @ 373,486: 14x14
#330 @ 983,238: 14x26
#331 @ 586,498: 14x15
#332 @ 565,620: 15x20
#333 @ 875,848: 22x21
#334 @ 686,746: 23x17
#335 @ 130,893: 10x20
#336 @ 895,428: 14x14
#337 @ 590,359: 13x19
#338 @ 134,514: 21x11
#339 @ 99,438: 14x25
#340 @ 401,901: 4x10
#341 @ 665,203: 22x22
#342 @ 430,394: 17x16
#343 @ 382,646: 27x25
#344 @ 540,719: 21x18
#345 @ 697,71: 12x11
#346 @ 257,126: 13x18
#347 @ 327,489: 16x23
#348 @ 411,130: 28x24
#349 @ 429,255: 28x20
#350 @ 583,496: 15x15
#351 @ 596,114: 18x16
#352 @ 743,229: 20x20
#353 @ 28,348: 28x26
#354 @ 813,75: 16x15
#355 @ 108,635: 22x12
#356 @ 594,338: 16x21
#357 @ 20,268: 29x13
#358 @ 837,66: 17x19
#359 @ 266,176: 19x17
#360 @ 382,893: 7x5
#361 @ 760,807: 25x29
#362 @ 138,405: 21x24
#363 @ 673,93: 26x19
#364 @ 193,117: 19x26
#365 @ 698,749: 17x13
#366 @ 141,242: 19x21
#367 @ 530,719: 19x14
#368 @ 612,675: 25x23
#369 @ 970,755: 12x28
#370 @ 135,459: 18x27
#371 @ 251,163: 18x3
#372 @ 417,760: 27x23
#373 @ 150,460: 28x22
#374 @ 220,765: 21x14
#375 @ 164,109: 22x13
#376 @ 55,534: 10x22
#377 @ 879,134: 29x25
#378 @ 620,713: 10x10
#379 @ 389,382: 15x12
#380 @ 417,197: 18x22
#381 @ 308,854: 27x19
#382 @ 244,122: 27x27
#383 @ 532,3: 16x19
#384 @ 239,49: 14x19
#385 @ 813,974: 17x21
#386 @ 847,113: 20x18
#387 @ 946,430: 20x24
#388 @ 375,82: 11x21
#389 @ 381,353: 14x22
#390 @ 274,131: 8x19
#391 @ 382,98: 26x14
#392 @ 210,812: 19x10
#393 @ 45,660: 18x25
#394 @ 184,155: 18x17
#395 @ 305,396: 16x29
#396 @ 258,581: 22x15
#397 @ 522,67: 27x25
#398 @ 751,117: 12x17
#399 @ 523,936: 24x14
#400 @ 488,885: 12x24
#401 @ 790,796: 19x10
#402 @ 950,614: 25x29
#403 @ 651,78: 21x21
#404 @ 473,404: 25x12
#405 @ 134,544: 23x13
#406 @ 195,320: 17x26
#407 @ 33,262: 13x14
#408 @ 827,515: 11x19
#409 @ 962,545: 14x17
#410 @ 29,881: 23x19
#411 @ 524,842: 14x12
#412 @ 234,823: 13x14
#413 @ 29,571: 22x29
#414 @ 415,401: 19x21
#415 @ 333,695: 24x25
#416 @ 651,369: 19x19
#417 @ 627,229: 17x26
#418 @ 615,843: 23x14
#419 @ 690,811: 28x22
#420 @ 172,263: 28x12
#421 @ 248,483: 11x17
#422 @ 699,877: 28x24
#423 @ 561,329: 17x26
#424 @ 373,48: 29x17
#425 @ 103,888: 25x12
#426 @ 564,844: 20x14
#427 @ 928,702: 10x12
#428 @ 817,191: 21x29
#429 @ 280,5: 18x15
#430 @ 134,522: 16x23
#431 @ 7,165: 22x26
#432 @ 259,164: 17x23
#433 @ 946,775: 13x20
#434 @ 62,629: 25x17
#435 @ 828,333: 22x19
#436 @ 65,472: 22x19
#437 @ 899,397: 6x10
#438 @ 465,686: 16x18
#439 @ 22,173: 21x14
#440 @ 726,6: 23x29
#441 @ 212,362: 19x26
#442 @ 40,634: 10x27
#443 @ 902,127: 23x11
#444 @ 172,623: 24x13
#445 @ 140,383: 25x20
#446 @ 462,761: 20x14
#447 @ 117,586: 13x24
#448 @ 640,152: 19x19
#449 @ 787,711: 19x17
#450 @ 145,936: 24x13
#451 @ 506,918: 24x28
#452 @ 370,289: 25x20
#453 @ 17,512: 25x28
#454 @ 336,491: 13x25
#455 @ 575,409: 14x29
#456 @ 152,800: 12x29
#457 @ 584,508: 24x11
#458 @ 237,426: 20x11
#459 @ 235,427: 16x19
#460 @ 164,364: 11x22
#461 @ 698,41: 29x17
#462 @ 269,472: 25x11
#463 @ 14,416: 21x19
#464 @ 579,816: 16x23
#465 @ 328,778: 28x22
#466 @ 794,42: 20x10
#467 @ 397,853: 10x17
#468 @ 340,789: 19x28
#469 @ 33,343: 25x13
#470 @ 703,224: 11x10
#471 @ 958,563: 28x21
#472 @ 289,183: 25x17
#473 @ 949,741: 18x26
#474 @ 643,57: 21x29
#475 @ 508,609: 17x10
#476 @ 389,527: 27x13
#477 @ 746,131: 27x25
#478 @ 483,478: 18x15
#479 @ 839,562: 15x25
#480 @ 410,233: 28x26
#481 @ 293,194: 19x14
#482 @ 665,397: 16x16
#483 @ 258,163: 16x10
#484 @ 919,58: 12x10
#485 @ 324,105: 15x17
#486 @ 361,851: 25x27
#487 @ 130,279: 14x19
#488 @ 474,391: 12x22
#489 @ 95,945: 19x22
#490 @ 108,308: 10x24
#491 @ 484,677: 27x10
#492 @ 887,406: 26x20
#493 @ 470,113: 11x22
#494 @ 674,505: 18x11
#495 @ 820,697: 22x22
#496 @ 323,980: 26x17
#497 @ 930,263: 26x13
#498 @ 276,869: 14x20
#499 @ 327,796: 27x23
#500 @ 249,139: 27x27
#501 @ 733,883: 26x12
#502 @ 473,670: 27x28
#503 @ 814,236: 17x20
#504 @ 340,144: 22x10
#505 @ 38,848: 24x29
#506 @ 380,430: 11x23
#507 @ 212,901: 14x18
#508 @ 680,7: 25x14
#509 @ 315,367: 26x11
#510 @ 860,7: 25x24
#511 @ 912,191: 20x15
#512 @ 651,319: 15x26
#513 @ 267,461: 17x23
#514 @ 615,68: 26x18
#515 @ 127,237: 21x21
#516 @ 599,695: 14x11
#517 @ 314,520: 10x29
#518 @ 253,164: 19x11
#519 @ 487,968: 17x24
#520 @ 486,37: 18x19
#521 @ 642,791: 25x15
#522 @ 959,636: 27x24
#523 @ 153,641: 26x15
#524 @ 393,276: 11x17
#525 @ 233,416: 16x14
#526 @ 663,391: 12x20
#527 @ 411,726: 28x23
#528 @ 957,725: 16x15
#529 @ 306,395: 23x25
#530 @ 642,954: 10x14
#531 @ 186,900: 12x21
#532 @ 897,262: 16x13
#533 @ 422,329: 27x19
#534 @ 868,23: 19x14
#535 @ 220,163: 16x27
#536 @ 23,416: 26x22
#537 @ 306,498: 18x29
#538 @ 723,600: 26x11
#539 @ 368,135: 29x28
#540 @ 579,74: 16x25
#541 @ 118,471: 19x22
#542 @ 893,677: 22x25
#543 @ 415,150: 16x11
#544 @ 764,113: 26x22
#545 @ 584,520: 14x19
#546 @ 644,677: 11x25
#547 @ 924,313: 22x21
#548 @ 865,95: 27x21
#549 @ 821,297: 12x19
#550 @ 301,885: 24x10
#551 @ 975,504: 10x18
#552 @ 599,633: 15x27
#553 @ 813,306: 17x15
#554 @ 379,479: 16x26
#555 @ 252,544: 11x16
#556 @ 183,832: 13x16
#557 @ 439,131: 26x12
#558 @ 118,891: 16x16
#559 @ 649,819: 21x29
#560 @ 611,408: 25x27
#561 @ 652,115: 6x5
#562 @ 876,911: 19x19
#563 @ 85,266: 24x18
#564 @ 130,242: 24x10
#565 @ 362,957: 29x16
#566 @ 680,168: 5x5
#567 @ 447,107: 20x12
#568 @ 955,542: 20x25
#569 @ 95,749: 23x25
#570 @ 117,51: 19x29
#571 @ 287,805: 16x28
#572 @ 30,163: 22x13
#573 @ 218,355: 18x13
#574 @ 243,440: 18x16
#575 @ 775,53: 23x22
#576 @ 883,632: 22x25
#577 @ 819,203: 12x14
#578 @ 847,919: 10x4
#579 @ 920,637: 29x17
#580 @ 133,516: 16x21
#581 @ 116,909: 24x17
#582 @ 47,829: 29x24
#583 @ 195,180: 27x22
#584 @ 883,608: 24x17
#585 @ 350,873: 11x14
#586 @ 848,611: 19x21
#587 @ 50,718: 11x23
#588 @ 52,336: 24x14
#589 @ 792,180: 27x17
#590 @ 312,423: 25x21
#591 @ 982,134: 11x23
#592 @ 718,654: 28x21
#593 @ 510,669: 26x18
#594 @ 690,194: 18x29
#595 @ 169,111: 13x12
#596 @ 359,849: 10x15
#597 @ 200,305: 26x26
#598 @ 353,680: 23x13
#599 @ 256,324: 11x29
#600 @ 453,290: 22x14
#601 @ 364,948: 16x14
#602 @ 326,107: 10x3
#603 @ 854,967: 19x18
#604 @ 413,774: 29x16
#605 @ 308,36: 23x13
#606 @ 423,624: 16x21
#607 @ 697,211: 18x14
#608 @ 193,263: 25x11
#609 @ 849,905: 22x13
#610 @ 344,477: 11x18
#611 @ 631,168: 14x22
#612 @ 508,855: 17x16
#613 @ 571,608: 13x14
#614 @ 104,665: 10x24
#615 @ 762,555: 23x29
#616 @ 945,701: 13x21
#617 @ 258,427: 17x17
#618 @ 675,402: 19x21
#619 @ 874,926: 14x17
#620 @ 0,417: 28x18
#621 @ 260,168: 21x10
#622 @ 291,304: 19x24
#623 @ 566,863: 11x23
#624 @ 746,134: 22x26
#625 @ 214,930: 13x24
#626 @ 541,478: 10x15
#627 @ 50,718: 12x22
#628 @ 299,867: 25x15
#629 @ 818,493: 27x26
#630 @ 731,242: 26x29
#631 @ 213,512: 29x13
#632 @ 336,262: 25x15
#633 @ 669,635: 27x26
#634 @ 258,124: 17x27
#635 @ 834,662: 29x27
#636 @ 838,589: 27x23
#637 @ 870,11: 17x25
#638 @ 440,466: 28x25
#639 @ 404,81: 10x27
#640 @ 59,602: 27x13
#641 @ 982,133: 15x22
#642 @ 53,532: 11x28
#643 @ 846,35: 11x22
#644 @ 364,393: 21x22
#645 @ 920,688: 23x14
#646 @ 538,744: 16x27
#647 @ 239,616: 21x23
#648 @ 554,287: 15x20
#649 @ 241,473: 19x16
#650 @ 830,151: 25x21
#651 @ 382,445: 15x19
#652 @ 598,747: 11x21
#653 @ 574,669: 27x24
#654 @ 433,775: 16x16
#655 @ 162,758: 11x25
#656 @ 25,889: 19x13
#657 @ 249,440: 20x25
#658 @ 42,62: 23x18
#659 @ 65,610: 18x15
#660 @ 116,270: 24x15
#661 @ 497,732: 12x27
#662 @ 207,681: 13x25
#663 @ 679,132: 13x29
#664 @ 121,749: 25x23
#665 @ 135,560: 24x26
#666 @ 716,478: 21x17
#667 @ 815,635: 17x19
#668 @ 415,800: 10x10
#669 @ 866,14: 18x19
#670 @ 350,180: 21x23
#671 @ 579,225: 22x12
#672 @ 665,445: 27x16
#673 @ 4,126: 10x24
#674 @ 111,323: 3x4
#675 @ 786,535: 21x13
#676 @ 303,245: 4x11
#677 @ 123,50: 16x21
#678 @ 682,885: 29x29
#679 @ 894,100: 24x22
#680 @ 518,87: 19x24
#681 @ 701,172: 27x15
#682 @ 764,838: 19x20
#683 @ 569,162: 22x15
#684 @ 8,151: 25x28
#685 @ 79,509: 15x25
#686 @ 350,372: 28x11
#687 @ 874,143: 29x12
#688 @ 470,945: 23x22
#689 @ 120,639: 19x10
#690 @ 47,908: 20x13
#691 @ 945,445: 25x13
#692 @ 777,793: 20x13
#693 @ 650,941: 22x18
#694 @ 188,690: 29x23
#695 @ 808,720: 23x27
#696 @ 243,859: 13x25
#697 @ 737,964: 17x26
#698 @ 649,112: 19x15
#699 @ 542,313: 26x21
#700 @ 537,798: 26x28
#701 @ 935,305: 24x15
#702 @ 700,406: 7x10
#703 @ 222,342: 14x19
#704 @ 786,741: 20x22
#705 @ 500,24: 12x20
#706 @ 526,922: 17x15
#707 @ 5,293: 20x26
#708 @ 668,910: 15x28
#709 @ 568,839: 10x13
#710 @ 708,613: 19x16
#711 @ 171,855: 20x26
#712 @ 753,555: 26x10
#713 @ 183,916: 27x20
#714 @ 719,938: 11x15
#715 @ 582,481: 12x23
#716 @ 946,567: 21x24
#717 @ 285,195: 18x29
#718 @ 388,337: 18x19
#719 @ 773,3: 13x11
#720 @ 740,865: 21x18
#721 @ 709,221: 27x18
#722 @ 45,232: 12x17
#723 @ 816,673: 15x27
#724 @ 911,229: 23x20
#725 @ 270,821: 17x20
#726 @ 430,379: 18x16
#727 @ 565,413: 15x24
#728 @ 880,346: 29x26
#729 @ 870,104: 14x20
#730 @ 588,937: 15x13
#731 @ 601,248: 27x17
#732 @ 839,282: 24x26
#733 @ 24,625: 26x14
#734 @ 421,180: 28x29
#735 @ 846,222: 17x21
#736 @ 436,985: 23x15
#737 @ 479,874: 24x11
#738 @ 275,74: 12x12
#739 @ 687,136: 22x11
#740 @ 534,727: 22x11
#741 @ 552,513: 19x17
#742 @ 726,972: 17x26
#743 @ 845,683: 27x28
#744 @ 328,236: 25x20
#745 @ 428,70: 27x25
#746 @ 188,157: 3x3
#747 @ 652,61: 25x24
#748 @ 599,923: 10x20
#749 @ 643,891: 10x28
#750 @ 49,719: 24x24
#751 @ 244,310: 29x13
#752 @ 222,375: 16x29
#753 @ 3,624: 24x10
#754 @ 181,248: 17x21
#755 @ 302,108: 16x18
#756 @ 315,546: 20x10
#757 @ 756,250: 23x18
#758 @ 107,947: 16x28
#759 @ 376,294: 20x10
#760 @ 930,132: 29x23
#761 @ 465,357: 17x19
#762 @ 587,908: 18x12
#763 @ 286,334: 29x14
#764 @ 567,756: 21x21
#765 @ 457,395: 24x10
#766 @ 455,71: 17x14
#767 @ 878,886: 13x27
#768 @ 665,331: 16x16
#769 @ 187,309: 27x29
#770 @ 893,372: 24x13
#771 @ 324,170: 27x21
#772 @ 351,182: 10x18
#773 @ 861,611: 14x26
#774 @ 848,29: 24x10
#775 @ 867,366: 16x16
#776 @ 182,145: 24x17
#777 @ 593,574: 27x10
#778 @ 842,919: 26x17
#779 @ 883,385: 17x25
#780 @ 832,62: 12x20
#781 @ 694,77: 17x16
#782 @ 811,406: 27x29
#783 @ 487,928: 19x10
#784 @ 278,411: 16x15
#785 @ 524,268: 24x12
#786 @ 770,602: 10x19
#787 @ 870,833: 20x24
#788 @ 55,79: 10x18
#789 @ 140,568: 17x10
#790 @ 970,240: 21x25
#791 @ 721,827: 26x29
#792 @ 512,794: 14x26
#793 @ 590,576: 15x13
#794 @ 143,541: 17x18
#795 @ 73,538: 10x20
#796 @ 80,449: 26x10
#797 @ 268,303: 12x10
#798 @ 887,782: 16x28
#799 @ 328,224: 27x23
#800 @ 602,808: 24x10
#801 @ 337,549: 26x22
#802 @ 533,473: 25x25
#803 @ 776,559: 21x10
#804 @ 334,186: 17x17
#805 @ 598,491: 16x18
#806 @ 122,452: 10x13
#807 @ 32,569: 25x14
#808 @ 778,842: 17x13
#809 @ 759,576: 19x17
#810 @ 217,283: 29x18
#811 @ 342,721: 24x19
#812 @ 255,791: 22x18
#813 @ 975,578: 13x13
#814 @ 20,420: 18x19
#815 @ 709,60: 27x22
#816 @ 671,437: 22x27
#817 @ 256,373: 19x21
#818 @ 516,680: 28x29
#819 @ 210,791: 27x26
#820 @ 262,306: 28x17
#821 @ 833,636: 25x26
#822 @ 342,134: 25x19
#823 @ 400,844: 12x15
#824 @ 610,154: 17x26
#825 @ 535,906: 27x29
#826 @ 397,899: 12x26
#827 @ 799,131: 19x15
#828 @ 22,580: 29x28
#829 @ 718,12: 17x29
#830 @ 536,846: 15x11
#831 @ 114,638: 5x4
#832 @ 647,63: 12x15
#833 @ 244,620: 11x18
#834 @ 289,861: 11x19
#835 @ 858,349: 21x28
#836 @ 384,853: 20x14
#837 @ 912,494: 28x26
#838 @ 70,460: 21x29
#839 @ 947,544: 18x17
#840 @ 274,801: 18x13
#841 @ 791,327: 26x26
#842 @ 486,879: 11x18
#843 @ 187,187: 15x16
#844 @ 247,287: 29x17
#845 @ 670,190: 19x14
#846 @ 555,746: 18x28
#847 @ 875,651: 18x29
#848 @ 745,257: 14x17
#849 @ 736,811: 22x29
#850 @ 255,783: 20x17
#851 @ 860,432: 27x29
#852 @ 799,581: 8x15
#853 @ 772,939: 10x23
#854 @ 477,935: 11x12
#855 @ 755,547: 24x18
#856 @ 587,155: 23x25
#857 @ 148,377: 11x17
#858 @ 897,139: 15x24
#859 @ 974,401: 16x15
#860 @ 486,492: 11x20
#861 @ 90,666: 29x19
#862 @ 252,644: 19x28
#863 @ 506,937: 15x10
#864 @ 400,864: 16x18
#865 @ 374,761: 22x15
#866 @ 157,762: 29x25
#867 @ 113,15: 28x25
#868 @ 919,853: 18x25
#869 @ 468,353: 27x21
#870 @ 923,246: 28x23
#871 @ 832,226: 3x11
#872 @ 747,247: 25x10
#873 @ 111,575: 27x17
#874 @ 902,186: 19x14
#875 @ 895,418: 16x12
#876 @ 782,697: 12x21
#877 @ 750,293: 25x21
#878 @ 841,903: 14x11
#879 @ 951,458: 21x26
#880 @ 380,880: 13x29
#881 @ 845,659: 11x25
#882 @ 806,136: 23x25
#883 @ 221,949: 28x19
#884 @ 289,251: 18x17
#885 @ 268,351: 23x19
#886 @ 212,894: 12x10
#887 @ 187,137: 25x26
#888 @ 30,388: 27x13
#889 @ 470,209: 19x27
#890 @ 914,591: 12x29
#891 @ 133,495: 13x29
#892 @ 25,923: 25x27
#893 @ 927,698: 25x27
#894 @ 838,628: 10x19
#895 @ 306,677: 20x10
#896 @ 435,179: 12x15
#897 @ 9,245: 21x19
#898 @ 795,609: 15x11
#899 @ 704,117: 14x20
#900 @ 89,663: 21x11
#901 @ 139,488: 22x15
#902 @ 960,568: 18x16
#903 @ 287,317: 12x23
#904 @ 252,54: 19x18
#905 @ 798,115: 14x11
#906 @ 860,16: 28x13
#907 @ 52,870: 28x12
#908 @ 650,942: 13x12
#909 @ 475,41: 20x27
#910 @ 29,245: 14x14
#911 @ 81,472: 15x21
#912 @ 573,182: 25x15
#913 @ 164,560: 15x29
#914 @ 562,512: 10x10
#915 @ 820,767: 15x18
#916 @ 149,760: 23x16
#917 @ 632,378: 24x12
#918 @ 319,197: 26x20
#919 @ 541,11: 24x21
#920 @ 521,588: 29x27
#921 @ 777,737: 20x15
#922 @ 631,51: 20x11
#923 @ 479,230: 20x14
#924 @ 270,127: 16x27
#925 @ 561,211: 17x20
#926 @ 287,118: 21x16
#927 @ 771,302: 24x16
#928 @ 973,683: 22x10
#929 @ 669,322: 17x11
#930 @ 495,38: 14x22
#931 @ 263,467: 16x19
#932 @ 760,706: 14x11
#933 @ 624,915: 27x25
#934 @ 443,973: 15x13
#935 @ 779,299: 21x12
#936 @ 196,194: 13x17
#937 @ 418,788: 26x23
#938 @ 937,178: 26x11
#939 @ 156,625: 29x10
#940 @ 289,372: 27x18
#941 @ 305,795: 18x13
#942 @ 387,261: 12x23
#943 @ 561,233: 12x28
#944 @ 559,499: 23x18
#945 @ 573,935: 13x18
#946 @ 827,23: 25x20
#947 @ 568,951: 14x29
#948 @ 173,382: 13x14
#949 @ 71,523: 13x29
#950 @ 362,445: 27x16
#951 @ 542,752: 17x12
#952 @ 133,366: 25x26
#953 @ 355,401: 10x19
#954 @ 874,395: 24x20
#955 @ 354,764: 16x27
#956 @ 63,263: 23x12
#957 @ 515,736: 24x13
#958 @ 559,844: 10x26
#959 @ 17,715: 29x14
#960 @ 681,548: 12x21
#961 @ 751,809: 20x14
#962 @ 81,686: 24x16
#963 @ 781,202: 22x11
#964 @ 833,838: 21x26
#965 @ 878,119: 29x24
#966 @ 269,667: 21x10
#967 @ 955,599: 29x10
#968 @ 821,779: 18x15
#969 @ 569,112: 17x19
#970 @ 897,29: 17x11
#971 @ 295,10: 22x27
#972 @ 824,212: 29x25
#973 @ 239,334: 11x18
#974 @ 440,566: 25x11
#975 @ 783,957: 14x12
#976 @ 715,536: 20x26
#977 @ 860,435: 22x10
#978 @ 203,525: 21x19
#979 @ 927,244: 15x18
#980 @ 63,730: 11x29
#981 @ 190,160: 27x17
#982 @ 315,528: 15x14
#983 @ 852,962: 15x18
#984 @ 132,611: 16x12
#985 @ 481,775: 22x15
#986 @ 7,504: 20x17
#987 @ 85,909: 13x26
#988 @ 688,804: 29x27
#989 @ 275,438: 24x29
#990 @ 586,641: 15x12
#991 @ 577,803: 22x26
#992 @ 685,548: 20x27
#993 @ 346,708: 13x14
#994 @ 439,367: 12x10
#995 @ 849,117: 5x3
#996 @ 45,207: 18x27
#997 @ 291,476: 20x24
#998 @ 937,449: 11x14
#999 @ 272,809: 25x15
#1000 @ 939,600: 25x25
#1001 @ 207,513: 20x13
#1002 @ 958,460: 29x10
#1003 @ 418,174: 25x24
#1004 @ 733,890: 24x28
#1005 @ 148,460: 21x17
#1006 @ 711,605: 29x11
#1007 @ 634,800: 15x28
#1008 @ 79,181: 22x11
#1009 @ 417,223: 11x12
#1010 @ 890,129: 14x21
#1011 @ 245,660: 11x27
#1012 @ 389,630: 24x25
#1013 @ 62,174: 20x10
#1014 @ 346,63: 17x13
#1015 @ 490,975: 14x24
#1016 @ 248,347: 14x20
#1017 @ 97,908: 13x14
#1018 @ 939,242: 17x19
#1019 @ 840,634: 15x18
#1020 @ 885,736: 25x15
#1021 @ 105,971: 28x24
#1022 @ 770,402: 24x11
#1023 @ 918,397: 20x19
#1024 @ 333,191: 10x19
#1025 @ 964,731: 23x19
#1026 @ 365,772: 20x15
#1027 @ 609,434: 12x20
#1028 @ 424,182: 13x24
#1029 @ 925,585: 25x29
#1030 @ 884,173: 21x26
#1031 @ 921,590: 10x23
#1032 @ 217,304: 18x27
#1033 @ 467,683: 7x5
#1034 @ 873,362: 21x22
#1035 @ 73,660: 25x16
#1036 @ 952,594: 11x24
#1037 @ 783,84: 10x13
#1038 @ 349,211: 16x19
#1039 @ 472,925: 23x27
#1040 @ 469,225: 23x13
#1041 @ 972,512: 22x11
#1042 @ 6,489: 15x18
#1043 @ 35,410: 25x12
#1044 @ 582,496: 15x25
#1045 @ 797,579: 14x27
#1046 @ 377,151: 21x18
#1047 @ 82,477: 18x11
#1048 @ 933,405: 25x16
#1049 @ 8,298: 13x7
#1050 @ 717,576: 13x18
#1051 @ 185,78: 18x28
#1052 @ 654,401: 25x11
#1053 @ 174,586: 22x25
#1054 @ 534,746: 14x18
#1055 @ 745,151: 13x18
#1056 @ 809,597: 11x18
#1057 @ 268,892: 20x25
#1058 @ 119,571: 27x18
#1059 @ 349,872: 27x15
#1060 @ 880,560: 27x22
#1061 @ 892,359: 23x12
#1062 @ 535,708: 18x18
#1063 @ 483,723: 26x19
#1064 @ 250,563: 10x13
#1065 @ 901,30: 13x29
#1066 @ 526,268: 21x21
#1067 @ 794,581: 13x19
#1068 @ 439,770: 13x19
#1069 @ 786,335: 16x12
#1070 @ 856,117: 22x26
#1071 @ 414,634: 23x21
#1072 @ 256,643: 18x12
#1073 @ 718,692: 26x15
#1074 @ 500,311: 22x17
#1075 @ 126,344: 26x27
#1076 @ 451,458: 29x21
#1077 @ 160,455: 23x16
#1078 @ 895,946: 22x23
#1079 @ 414,154: 12x28
#1080 @ 514,319: 29x28
#1081 @ 844,916: 17x12
#1082 @ 353,877: 18x29
#1083 @ 360,193: 18x29
#1084 @ 719,531: 15x10
#1085 @ 26,163: 17x18
#1086 @ 276,395: 27x24
#1087 @ 96,956: 15x21
#1088 @ 454,927: 21x12
#1089 @ 932,638: 14x15
#1090 @ 701,536: 21x13
#1091 @ 425,750: 23x17
#1092 @ 781,224: 17x17
#1093 @ 503,32: 20x18
#1094 @ 243,630: 18x19
#1095 @ 924,828: 22x24
#1096 @ 96,739: 20x23
#1097 @ 274,111: 18x16
#1098 @ 419,568: 27x29
#1099 @ 885,51: 18x24
#1100 @ 788,347: 24x26
#1101 @ 527,57: 28x17
#1102 @ 82,674: 14x25
#1103 @ 683,522: 28x16
#1104 @ 771,589: 10x17
#1105 @ 318,426: 27x11
#1106 @ 43,273: 22x21
#1107 @ 884,5: 12x27
#1108 @ 555,495: 21x21
#1109 @ 40,852: 18x12
#1110 @ 360,883: 10x17
#1111 @ 474,305: 28x20
#1112 @ 533,783: 23x27
#1113 @ 260,349: 21x28
#1114 @ 130,547: 13x16
#1115 @ 717,823: 18x24
#1116 @ 452,726: 17x13
#1117 @ 4,103: 12x29
#1118 @ 12,595: 23x11
#1119 @ 306,969: 22x18
#1120 @ 669,61: 24x10
#1121 @ 264,920: 13x18
#1122 @ 218,658: 17x13
#1123 @ 823,221: 27x20
#1124 @ 495,544: 12x10
#1125 @ 127,912: 15x24
#1126 @ 18,71: 28x18
#1127 @ 615,825: 22x21
#1128 @ 520,305: 18x27
#1129 @ 134,389: 29x10
#1130 @ 954,536: 10x15
#1131 @ 828,340: 16x16
#1132 @ 961,583: 25x25
#1133 @ 248,573: 24x19
#1134 @ 363,429: 22x19
#1135 @ 392,373: 22x25
#1136 @ 158,947: 28x11
#1137 @ 869,436: 18x12
#1138 @ 545,47: 11x15
#1139 @ 12,536: 21x16
#1140 @ 344,907: 16x25
#1141 @ 782,84: 20x27
#1142 @ 255,872: 17x12
#1143 @ 230,635: 14x20
#1144 @ 871,588: 13x26
#1145 @ 701,44: 6x7
#1146 @ 296,199: 16x25
#1147 @ 800,984: 17x15
#1148 @ 259,534: 29x11
#1149 @ 464,364: 29x28
#1150 @ 706,669: 21x10
#1151 @ 820,783: 27x21
#1152 @ 666,428: 28x24
#1153 @ 458,226: 16x16
#1154 @ 931,650: 11x15
#1155 @ 444,779: 19x27
#1156 @ 389,445: 20x16
#1157 @ 600,933: 25x15
#1158 @ 837,643: 28x20
#1159 @ 752,592: 11x23
#1160 @ 326,797: 10x4
#1161 @ 553,725: 27x15
#1162 @ 821,77: 19x27
#1163 @ 108,964: 26x19
#1164 @ 792,130: 13x27
#1165 @ 362,405: 12x19
#1166 @ 393,60: 15x12
#1167 @ 476,126: 17x21
#1168 @ 39,653: 20x28
#1169 @ 530,753: 16x18
#1170 @ 704,650: 29x24
#1171 @ 829,420: 27x21
#1172 @ 801,117: 5x5
#1173 @ 56,443: 22x13
#1174 @ 567,71: 16x10
#1175 @ 690,172: 24x23
#1176 @ 718,484: 12x11
#1177 @ 962,184: 27x12
#1178 @ 340,183: 14x17
#1179 @ 293,176: 25x23
#1180 @ 77,847: 17x17
#1181 @ 697,401: 14x19
#1182 @ 956,588: 28x13
#1183 @ 147,198: 11x14
#1184 @ 451,142: 24x23
#1185 @ 823,81: 22x10
#1186 @ 875,258: 26x25
#1187 @ 931,867: 23x11
#1188 @ 675,163: 15x23
#1189 @ 828,569: 18x18
#1190 @ 253,565: 3x5
#1191 @ 743,301: 11x26
#1192 @ 895,763: 14x23
#1193 @ 355,909: 16x27
#1194 @ 605,163: 17x11
#1195 @ 140,800: 19x27
#1196 @ 345,411: 20x11
#1197 @ 474,869: 15x20
#1198 @ 632,689: 18x11
#1199 @ 321,792: 23x14
#1200 @ 293,482: 17x11
#1201 @ 233,437: 22x16
#1202 @ 475,373: 13x25
#1203 @ 862,626: 26x21
#1204 @ 285,791: 18x28
#1205 @ 163,163: 28x11
#1206 @ 687,196: 12x28
#1207 @ 953,336: 14x14
#1208 @ 502,655: 18x15
#1209 @ 279,876: 29x23
#1210 @ 971,455: 29x19
#1211 @ 387,481: 19x20
#1212 @ 562,337: 29x20
#1213 @ 431,767: 11x12
#1214 @ 878,32: 12x29
#1215 @ 784,222: 17x24
#1216 @ 395,641: 22x22
#1217 @ 905,361: 16x17
#1218 @ 744,124: 16x29
#1219 @ 171,831: 26x21
#1220 @ 425,264: 27x21
#1221 @ 268,165: 16x28
#1222 @ 603,334: 22x15
#1223 @ 666,831: 18x25
#1224 @ 435,845: 20x13
#1225 @ 55,796: 23x21
#1226 @ 536,184: 22x29
#1227 @ 350,208: 21x25
#1228 @ 783,944: 25x20
#1229 @ 917,12: 17x18
#1230 @ 227,670: 24x17
#1231 @ 658,137: 23x26
#1232 @ 878,941: 29x25
#1233 @ 263,161: 25x21
#1234 @ 641,947: 19x23
#1235 @ 858,908: 19x24
#1236 @ 123,901: 14x25
#1237 @ 270,370: 11x26
#1238 @ 555,885: 14x27
#1239 @ 72,849: 21x15
#1240 @ 834,661: 17x21
#1241 @ 465,672: 14x21
#1242 @ 165,50: 11x23
#1243 @ 113,124: 14x18
#1244 @ 541,852: 28x12
#1245 @ 411,215: 23x18
#1246 @ 495,870: 26x23
#1247 @ 399,529: 9x8
#1248 @ 665,392: 13x17
#1249 @ 316,423: 28x12
#1250 @ 463,465: 12x14
#1251 @ 452,187: 21x11
#1252 @ 871,932: 14x12
#1253 @ 76,518: 18x28
#1254 @ 571,871: 24x20
#1255 @ 9,385: 5x6
#1256 @ 595,929: 17x15
#1257 @ 791,281: 10x23
#1258 @ 84,890: 22x20
#1259 @ 929,407: 12x13
#1260 @ 671,434: 14x7
#1261 @ 56,241: 26x13
#1262 @ 728,842: 16x13
#1263 @ 916,40: 29x26
#1264 @ 59,232: 15x29
#1265 @ 119,900: 12x16
#1266 @ 599,170: 28x19
#1267 @ 630,327: 28x20
#1268 @ 736,354: 28x29
#1269 @ 672,711: 15x24
#1270 @ 269,48: 17x11
#1271 @ 738,687: 17x19
#1272 @ 921,807: 17x27
#1273 @ 957,417: 27x28
#1274 @ 750,97: 28x20
#1275 @ 32,908: 12x23
#1276 @ 56,248: 25x29
#1277 @ 905,678: 26x15
#1278 @ 47,430: 21x18
#1279 @ 570,498: 25x20
#1280 @ 25,903: 29x29
#1281 @ 932,444: 28x27
#1282 @ 820,81: 10x18
#1283 @ 106,581: 12x13
#1284 @ 97,126: 20x14
#1285 @ 784,200: 12x17
#1286 @ 569,62: 17x14
#1287 @ 800,19: 17x26
#1288 @ 208,900: 20x25
#1289 @ 272,167: 27x20
#1290 @ 771,958: 18x17
#1291 @ 908,9: 14x27
#1292 @ 675,714: 5x12
#1293 @ 885,368: 18x13
#1294 @ 207,290: 16x23
#1295 @ 237,328: 14x21
#1296 @ 960,405: 23x11
#1297 @ 78,825: 10x14
#1298 @ 449,911: 25x19
#1299 @ 964,723: 22x21
#1300 @ 274,811: 29x15
#1301 @ 270,709: 23x27
#1302 @ 927,405: 18x10
#1303 @ 483,929: 15x15
#1304 @ 775,937: 15x17
#1305 @ 707,44: 10x19
#1306 @ 285,667: 17x12
#1307 @ 796,565: 11x19
#1308 @ 572,171: 26x22
#1309 @ 576,350: 21x12
#1310 @ 129,455: 22x23
#1311 @ 688,851: 17x28
#1312 @ 483,371: 19x10
#1313 @ 595,156: 20x17
#1314 @ 637,371: 29x18
#1315 @ 406,630: 23x15
#1316 @ 493,779: 12x18
#1317 @ 213,270: 21x29
#1318 @ 840,427: 25x17
#1319 @ 94,903: 16x28
#1320 @ 816,174: 14x25
#1321 @ 932,601: 11x20
#1322 @ 590,155: 19x29
#1323 @ 399,454: 18x15
#1324 @ 317,23: 29x15
#1325 @ 306,668: 17x19
#1326 @ 292,392: 22x26
#1327 @ 127,459: 22x19";
    }
}