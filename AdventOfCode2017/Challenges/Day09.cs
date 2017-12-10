﻿using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2017.Interfaces;

namespace AdventOfCode2017.Challenges
{
    public class Day09 : IChallengeDay
    {
        public string Part01(string input)
        {
            int numberOfGroups = 0;
            int scoreOfLevel = 0;
            int totalScore = 0;
            bool garbage = false;
            bool ignoreNextChar = false;
            foreach (char c in input) {
                if (ignoreNextChar) { ignoreNextChar = false; continue; }
                if (c == '!') { ignoreNextChar = true;continue; }
                if (garbage && c != '>') { continue; }
                if (garbage && c == '>') { garbage = false; continue; }
                if (c == '<') { garbage = true; continue; }
                if (c == '{') {scoreOfLevel++;}
                if (c == '}') { numberOfGroups++; totalScore += scoreOfLevel; scoreOfLevel--; }
            }
            return totalScore.ToString();
           
        }

        public string Part02(string input)
        {
            throw new NotImplementedException();
        }

        // escaped the " with "", so the Verbatim literal would not break (so slightly modified input)
        public string input = @"{{{{{{<o,!!!!!!!!iuo!!!>}{{{o{{a<u}>},{<!>,<,"">}},{},{{{<},e<i!!!>!!!{'u,!>!!!>}!!!>a>},<u>},{{{<>},{<!!""<e!>,<<!>,<!!!!uu!>,<ee,,!,!}!>},<!>>}},<!!,!>},<'<,!!e!{!>},<'a!!i<!!!>a>},{<'!>ao!i{a!!'!!!!'!!!>},<e!>,<>,<o!!{>}}},{{<{u!>,<!!!<<{!!!>!!a>,{<!!<!!!>a>}},{<>}},{{<<!>,<,!e!>},<!>},<i!<!!!!!>>},{},{<""{ou!!!>u!!u!>""e{!!!!!!{!!}!!}""}!!e>,{<!>},<u!i!!!>'!!'!!oi{!!!>!!!>o!>},<'""<i>}}},{{{{{{<e!>},<<o!u>}},{}}},{{<!!u{i!>,<!o!>},<eo!u!!!>,a!!!!!>u>,<!>,<o""!>},<{!!!>},<ua'{u{a>}}}}},{{{},{<!>,<o!!>},{{<'i!>o!uu>},{<!!ia!>,<>}}},{{{{},{{},{<""!!o{!e!>},<!!!>!>},<ou>}},{<>,<e!!!>,o!>,<!>,<!!<!>,'""'!>},<>}}},{{{{<!!!!i!!""ei!>},<,,{{{oeu"">}},{{<'}}!i,>},<o,ou'!ai!>,<a""""u>},{{{<!>},<!!!>!>,<>,<,""o!!'!!!>!>},<e!""<!'"">},<!>},<!!!>!>''i!!{i!!!>i!!!>,<!>},u'o!!'>}}},{{}}},{{{},<!!!!!a{""<''!!!>"">}},{{{},{<!!{,!>,<!>,<!<!}o{ee{!!!>>}},{{{{<!',i!!!>},<>}},{{{<!>},<""!>'!!!!!!!>i>},<{!><!!!>!>!i!!!>!!,'>},<!!<>}},{<!!!>""!!u!>,<{'i!eu>}}}},{{{{{<!',>}}},{<<!>},<a>,{<,o}uu!>!!!>eiuuoi,{!>{>,<""{{<,i<!!!>''!>,<ai<>}}},{{<!!{}o!!,!!a}<!!!!<a!>},<'>,{<e{u{u''>,{}}},{{{<!!}e!!!><!>},<u!>},<!>!>u!>,<!!!<e>}},{<,{a!!!!}!!{!{ei!,!!<!>},<,o!!o!!i!!>,{{<!>,i}{'!>,<!><a'{i!>,<<>},{}}},{}}},{{{},{{<u>},<'i'!>},<o}!!!>eo}!>,<ui!>,<>}}},{{<!!ai!!''""ea""o!>},<!>,<}o}!!<{!!ie>,{<'e{u!u>,<'!""u!!<!>,<!!{o!!!>o}}>}},{<>}}},{{{}},{{{<o!>a!!ou!!,!>,e'e!>},<{!""}!!!>>}},<!!!!i!!!>},<!!!>,,!>!>},<>},{<i>,{}}}},{{{{},<e!!i{oau!>,<,,i!!!!!>},<>},{<ieeeu<>,<!><""ooa'>},{}}},{{{<ii>},{{<!!>,{<ao,""{!!!>,<{!!!>},<!!o,!>,<e{>}},{<!>,<{a!>a!!'>}}},{{<""!>},<,,a<e'!>,<,ii>}}}},{{{{}},{{},{{<""e!>,<ao!!!!!!}i!<aau!!{>,{<!>},<}>,{<e!!""<u>}}},{{<>}}},{{{<,i!>o!!!>i>}},{{},{<o!>},<u'}i""}o'!>,<>}},{{{<!>}{e}o!>,<e}>,{<{!!,a!!,uiaui!'u<>}},{<!>},<<}!!'}}a!>},<!>},<!>,<}e!!!!!>u'i>,{}}}}}},{{{{{}},{{},{{<!{!>!!<'<,'}!>},<<u>},<a!>!u!!""!o{!!auae<!!!>,<,!!!>!>,<>}}},{{{{{{<"""",i!u{oa!>},<,}aoou!{<>},<{a!!!>,<u!!a!!!>!>i!>,<!!!""!>>}}},{<!>oi!>!>},<o!>,<o!>,<a}>}}},{{{{<o>}}},{{{<},{a!!!>o!>},<""<!!!!!>{!!!>},<!>},<e!!{>}},{<a!!!>}!!!>!>!!!>}'!!!>eu!>},<!!a>}}}},{{{},{<!>,<{!!ii,!!!>'!<""!>},<!!!>!!a>}},{{<!>,<!!!>!!!>u>},{<i>}},{{{{{{<!!e!>a!!ai!>},<a<!u>},<<!,!!,!!iou!!!>},<!}>}},{{<}a!!!>!>!!!!!!i""'!!io""<e!>,<!>,<!>>}},{<{""i>}}}}},{{<o,i""!'""<!!!!}iu!>,<'""!!!>},<!!!>!{u>,{<!!<e!>i!>,<,>}},{{}},{{}}},{{{},{<!!!!o!>},<!!!>i{!!!>a}{!!{{}i}u!!!>}i>}}}}},{{{{<!>!>,<{e'!!!""!!!>'!!!>!!i>},{}},{{{}},{{{<u<!!<!>},<}ou,',!!!>>,<<!>},<!!!!!>},<!!}>},<>},{}}}},{{{}},{<,!!ue>,<!>},<}>},{{<a!!"">,{{{<e!!!!!!!!!!!>!>""o}{!o}!!""'!!!>!>,<<<>}},<o'!!!>}u{!!e!>},<>}},<>}},{{{{},{<>,<!{!>},<!!u!!!>}!>ei,a""{e!!""!,<}>}}},{{<!>},<{!>},<!!!>>}}},{{{<{<}}{,>,<!<'<!!!>,<iu!!o!>,<'!i{>},{<,}!""""!!!>!<!!o!e{}'!!!>,<!!o>},{{{{{<!!!>!,o},!!}>},<}!a}!>!!!'u!!!!!>!>},<!!!!!<!>},<!>,<!!!>,<}!""!!!!a!!>},{<''!>!!o!>i!>},<>}},{<i!>,<e'}{e!!!>!!!>,""{}}!i!!""!'!a!>,<>,<i!!!{'!!o}e<,!>},<""{!!!,,i!<o!!!>>}},{},{<e>,<}o}>}}}}},{{{{{}},{{<'!!!!e!>},<{>},{<o}!>},<""!o!{"">}},{{{},<{!!>},{},{{<a<!!!>!!!<""!!i}'!!!>""!!!u<""!>,<""!!!>!!{i<>,{<""{!!!!!>a!!!>i""i>}}}}},{{<!eoi!>,<i}!!!!!>!!!>i!!!>!>,<>,{<u!!!!!>,>}},{<u!>},<>},{{<!!i,!>i,u!!a!o,}!>,<o!>,<u}>}}},{{{{<!{{!!e>}},<}!>!>,<u!!'u!!!>!!""""i!!!><e,!!!>{<>},{<a""i!!<""ai!i!e!>},<}}""<>,<u{!!!>>}},{{{<{}o'a'!>!!<!>,<,}>,{{<u!>,!!!!!>i{""!>}!>u!>>},<,<>}},<>},{<""!>>,{<!!!>!!!>!!}!>,<!!!!i!>!!!>>}},{<""<a}u!>},<!!!>i}<!>},<>,{}}}},{{{{<<!!!>'uo,!>!!'}e!}u!>e,u{"">},{}},{<""!!!>},<!!!!e<e!u>},{<!!!>>,{<!!""i!>},<!!u!!!!!!}!>,<'!>},<!>!{<i{!!!>},<!!!>o>}}},{{{<!>,<eua,}!!!>!>,""a""!>>},{{<>}},{{<!a!!!>!>u!!o!>a,,!>,<!!!!!o<eia!!!!{!>},<>,{}}}},{<}!!""}!>},<!{!!!!'!>},<!!'!!>,{}},{{{{<!!!>!!,!!,!!!>!>},<""<!>},<!!!>!!!!!!>,{{}}}}}}},{{<""!o!!!><!u''!!!!e!>},<<!>,<>,<!!!>!!!>},<e!!!>!}a!{e!iu!>,<!!"""">},{<!!'!>},<,!>!!!>!!!>!!!>},<''uo<>},{<>}}},{{{}},{{},{{{{{<uoa!>,<<'!>>}},{{<!!!>},<!e<!!!>{!'}!>ae,>},<uu<!>>}},{<!>!>},<>,<!!!>""o<i>}},{<a!>}i!>,<{!<""!!'}e!e}!a,!>>,{<i>}},{<>,<i,!>,<oe!!!!!!!>""i!!>}},{<!>},<ao>}}},{{},{{{{<u!>,<!>!!}}},>}},{{<i,!!!><i{!>{e!!!io{!!,a!!'!!>},{}},{}},{{{<!!<!>},<a<a>,{}},{{},<}}!>,<,!'>},{{<<!>,<!!!'!e<!!!>""!!!>""!>,<!!{!>},<!'!!!>!>,<!e!!{i>}}},{{<""!!!>!>},<{!!!>!!<>}}},{{},{{}},{{<!!!!!!a!!!>}>,{<!!o'!>},<o!!!>!>,<'oe'>}},{<'!!!>,<!!}>,<!>,<!!'!>},<!u!!{!!a!!o!!!>,<{,!!!>!!!>>},{{<<'!,""!i!u!>,<""!>},<}!>a!!,u!!!!!>""'u>},{<<!a!u!!!!u!>!>,<u'i!!!>!{!!!>!!u}!>},<u>}}}}},{{{<!!'!!!>!>,<!>,<!>""'!!!>!""}a!>},<!o!u!!!!!>o>,{<iea'}i!!!!""!!!>!!!!u!""e"">}}},{{{<i!ui!!!>{!!!><!!!>oe!>,<>},<!!i!!!>!'u{<!>,<ioau>},{<!!}!>a{!e!!!!!!!!o""!!!>>,{{{<,o'!>!!{""o!!e!,oi!'!!!>},<,e>}},{<""!!!>""<i,!!{!>,<!!<{>}}}},{{<!!!>}}!>},<o!,,!!!>,<>,<>},{{<!>},<!!!!{o!!<{o!{>,{<'e}""uo!e>}},{{<!!!!o}ae!!!>,<{e<a!>},<{!oa>}},{}},{{{{},{<<!!!>}!!a!>{!>},<!>},<,!!<,!!<i!!!!e'!!<!>},<>}}}}}}}}},{{{{{{{<!e!i{!>,<i!,ai!!!!!>'>,{<!!e<e<!u!>,<!a,<u!,{<e>}},{}},{{<!!e!,!i!>},<!!!>!!!>,<o{{{!>,<}a{'o!!!>,<>,{{},<!!!>a>}},{{{{{}}}},{<!!!>}'!!!>},<{a}!!aa!!u{!!""!!!iu>,{{<a!>!!!!!!!>!!!><!!e!>!>,<ea!>,<!>!>""""!!!>ae>},<,<!>},<!!u!!!>,aa>}},{<o""'o!!u!!!!!>!>},<>,<!a!!!!!!""!!!!!>,<""'""e{!!!>!!!>!>,<>}}},{{{{<""!>},<!!a!,e!!e!'{""!>},<>}},{{{<!!ou>}},{{{<!>},<!!<}{!""!!!>,<u!,ao<{'!!>},{<},>}},{<u!!,!{!>},<i}o!!!>},<!>,<u!i<""'!>,<{"",>}},{{}}}},{{},{<!!!>}""!!!>!!!!!>!>'''<,!!!!!>!!!>!>,<a>}},{{<u!>!>u!!!""!>!!""!>,<!!ei{!!{uo>,{<e!>,<!!!>!!!>!>},<!!!!!!!!!>!!!!<!!!>o>}}}},{{{<!>},<e!!!>!{ei!>},<{{i""u!!u>},<<>}}},{{{{<!>i!>},<!!!>,!!!!!!<>},{{{<!!!>!>,<!!},!!!,<e!>},<i!!!!!>!!'!>},<!>},<{,>}},{<aea!!!>i}>,<!>},<!!!>},<<,e""iu""{{!!a{!!!>o,!>,<o!!>}}}},{<"""",!>},<!{!>a""<""{!>!!e!!!!!>i>},{<{<e!}!>,<,u}!>,!>!!iua!>,<!!,{e>}},{{<!!!>},<e!><',!!iu!!!>!>!!!>,<'!>,<>,<!!u<>},{{<{!!!>!><!}{>,<""!>},<>},{<!!i!>i!>},<a}!}iei!>},<u}i""{!>,<>},{{{<ue!!!a!>,<<{!!{{!!!>!!!>!!!!!>},<!>,<>}},{<o!>,<{o!>},<!!,'!>},<{!!!!,>,{}},{{<!>>},{<!>},<>,<}e,!!!>""!ee!!!>},<"",a!>},<!>!'{e!!o>},{<eu,!!!>!!!>!>,<!!!>>}}}},{{<ei'!>>},<!><!>},<!>!!!>{o!!!!!>},<!>},<!!<<{!!e!uii>}},{{{},{<<!>!!!!!>'ai!>a{!!!>>}},{{<!!e<"">},{<""e>}},{{{{}}},<u!'!!!o}i!>}""<!>,<!>},<i,>}}}},{{{{<a}!>,<,!a{>},{<!',!>!>},<!!'{!>ae!!,"">}},{<o!>!'!!!>a,,eo>,<!>},<!!o>}},{},{{{{},{{<,!!!>!><>}}},{<<{!!!>{{'e{!!o""{oe!>,<{,!e>,{}},{}},{{{}}}},{{{{<!!!!{e!!'!,>},<,!>},<'uo>},<'!!oouo!>!!!>!""a{!u<!>,<>},{{<!u!!!><{{,e'}!!u!>},<i!!io>},<"">},{{},{{{<}ai!!o""u!!!>a!>},<""!!!>!>},<{!!!>>},<!>},<!'!>!>,<!!!><!>,<',{!<>}}}}},{{{{},<""}""{!>},<}<!>e!>},<!!'>},{{}},{<!!!!!>eu!!""!<o!>o{}<,>}},{{<a{!!!>!""u""i!!!>,<!>,<e{!<<a}!!!>'>,{{{<'oei!!!>},<!!!>},<!!!>,<!!!>>}}}},{{{{<!>'u!'u},!>,<o!>'!!!>{i}u!>>}},{<""o}>}},{{<!!'!>,<e!!!>!!'}!!!>!>,<!!!>eu>},<oa>}}},{{},{<!>,<>},{}},{{},{{{},{<'!>,<!!!!{!>a>}},{{<ea<!<''!>},<ie'!>,<{aa},!!o>},<>}},{<!>,<!>,<!>!o!>!!!>u!>u!!,!!o>}}},{{{{<}'<!>,<i!!!>ei!a""!!!><{}!>,<!<!!e<}>,{<>}},{}},{{{}},{{<<>,{<!>,<>}}},{<""!!!>""ea}!>!>!!'!>},<<{!u!'>,<u>}}},{{{{{<a!o""!>},<>}}},{<""u!!!>}!!!>!>!>i'!>{i<oe!!,!i>},{<e!>aae!!!!<a}!>},<{>}},{{},{{{<,>},{<'!>},<<<!>!!'!!!>aoai!""!!'!>u!>},<>}}},{<'o}!>,<!>},<o,>,{{{<""{'!}!!<!!o!!,}!>},<}}ui}!!!!!>!!!>>}}}}},{{{{{{},{<u!>},<!!!>""{u""i>,{<eie!ea'!!{!>},<!!a>}},{<!>},<e>,<!>,<i'i!!!>{!!!>a!""!!!>o}!>,<o{}>}},{{},<!!o""'e{o!>},<!!'o!!!>!>a!>},<!!!!!!!!},>},{<""a}!!""!<}>,{<>}}},{{<i!!!>}<!>,<!,!!!>u!!!!a'o""'!!>},<iee!>,<!>,<!>!""o!<ei!<<uua{>}},{{<{>}}},{{{<aou!>>},{}}}},{{{{{<>},<>},<!!!>>},{<{o!>e,!>},<<oaa!!!>!!!>!!!>e>,{<e!>!>},<oo!!!>!>},<'!,!!!!!>}!>!!!>,<!!!>i!a>}},{{<!!!!e!>!!>},{}}},{{<a,}!!!>,<'!>},<!>,<!,i!>},<,""!!!!>,<!}""<!>,<i'!!''!!!!!!!>!>!'{!!!!!!!>!!!>,<,e>},{<!!!>},<!>,!><u!><>,<,!>},<!o""!>,<u!!!!e>},{{<!>},<{!!!!!>e!>,<>},{{{<!>,<!!!>,<!!'!!}e!>}aoi!!!>'a!!!>a!!"">},<!>o>}}}},{{{{<""!>},<}o!>u!>,<i!>,<<e!!!>>,{<o{{i!>},<e""{'o!>,<>,<!>,<!!{!a""!i!!!!!>!>},<'<!!!!!>!!!>!!!}!!!}!!}!>>}}}},{{}}}}},{{{<e!!<!!!>,<'!e!>,<au!>i{<!!>,<!>,o!>!>!!ea!!{<a!!!>,<!>},<>},{<,,{e!""!!!"""">}},{{{}},{<}a!>!!!>a!!!>!><}!o!>},<!>},<,i!!<,'<>,<!!>}},{{{{},{<'a!a{e!!!>u>,<{<!!!>!!!>i,!>},<!!!>iu""!!!>,<!>,<>}},{{}},{}},{{{{<!!!i>,<,!u""!!!>!!""!>!>!>},<{}>}},{{<!!!>!!!>{>},<!{,{!!!>,<u!!!>{!>,<!!a!>},<!!!>!'<o>}},{{{{{},<{!!!>i!>,<u!!i}u<>},{{{<i!!!>}!o!!!<}!>,<>}},{{<{'!>!!u'o!>},<!u,!>!""""ui>}},{{{<u<!!""'<,""<!o!!!>'>},<{!i!>o!>,<'<i!>,<>}}},{<!e!><!!!{i{'o!!!>!}u!>},<!!!>!!!>}!!!>},<{>,{}}}},{{{<!!!>!!o{!!o!>>,<i!!{!!i,!>,<i!}!>},<a!!'!e!!}i!,!!!>'!!!e>},{{<!><a'i!}!>,<!>e!>}!>},<i'>,{}}},{{<,u!'!!""'u""{!>,<}i""!""!!e!a!!u{>}}},{{{{<{!!!>!>,<<{!!o!!!>!,!>,<!!,!>!!'e{>}},<<{}!!!>},<!!!>>},{{<!!!>e""!!'!><!!o!<}',>}},{<>,<'!>,<!!""!<ui'a!>},<!>,<!>>}},{{},{{{<!>,<!>,<!>},<!'!!!>!!>}},{<ui!!!>,<<!!!>>}},{}},{{{{<>},<o!!!>a!!,!ioe'!!!><}!>},<>},{<e!>},<!>,<i}e>,<!!!!!>u,u}!!!>!>},<!!!!eau}o'!e>}},{{<'a""!u>,{}}},{{{<!!<!>},<<!!!!""!>,<{!!!!!>!>,<uo>}},{{},{<!!{u!!{{>}}},{{},{{{{<}<u!u!!!""!!e!>o!!!<!!}a""{<!!!!!u,o!!>}},<a}!!'!!!!{i""{>},{<!>,<>}}}}},{{{{},<!}>}}},{{<<!!!!i{e!>""e!!!>!!',a!>},<!>}>},{<o""ia}!>,<u!>,!!!>!>,<!>!oa!>i>}}},{{{{{<!<}{!!!!!>}e>,{}}},{<e'i>,{}},{{<o!>,<!!<u!!!>}u!!!>io'!!>}}},{<ui!>},<!a!,'!!!>},<>,{<'!!!!!!!>!!<!!e>}}},{{<!!!!!!e!>a<>,<{!!}a!!!!!>!{'!!<!!""{""!!!>,<i!>},<>},{<{}}}{!!!>oai}!!!>iu!'!>},<o!'u>,<""!!""}>},{{},<!>},<a!>},<'!><<!!!>},<{u!!!>,<a""!{>}}},{{{<!!u}o""e!!>,<}!>},<""!>,<oueu!>u,e!>},<u!!>},{{},{{<>},<!!!>!!}!i>},{<a!!!>,!!'o,a'!!!>>,<!!{"">}}}}},{{{{<i!!!!o!>,<}{i!>},<uo!!!>i!>},<o!>>}}},{<!>,<!!!>a!!!>!!!a!!!>!!!>!!!>}!>},<}"">,<!!o{u!<!i>},{}}}}}},{{{{<!!!>!!!!ee<!!a!>!!!>!>>},{{<{""'!!'},!!}oa<!>o>},{{<!!!>!!!>,<!>,<>}}}},{{<i!!!!!>o!>oo!>!!uo,u>},<e!>},<!!!>!!!>""!!!>!!!>!!!>},<!},oi!!}{ao,ii>}},{{{<!>!>},<!{!>!!!>ea!}{!!{i!>!!!>o>,{<!o!>,<o>}}},{<!>,<!!""!!!>{!>!>,<>,{{{<!!!>ae!>},<o!>},<!a>},<o!>},<<""!}!!!u!>!>},<!!!>'!!!!!>},<>},{}}},{{},{{<!>,<<!>},<o!>,<!>,<}<'}oaa,!!!>,<!>,<>},<ei'!!!>!>!!!>,<!!ue,,>}}},{},{{{}},{{<i!>},<u!!!>!""},!>,<',!>},<}!>},<>},{{{},<>},{<!>!o!>,<!>},<o!>!!u!!!,!>,<a!{!>},<}'>,{{<<u>},{}}},{{{{}},{{<ee>}}},{{},{{},<>}}}},{<!>},<{e!!!>},<u}<!!!!e!>},<ae!!!>!!,,u!'<!>},<>,{<!>}u'!>,<{e!>'<!!!}a<<>}}},{{}}}},{{{<!!!!!!i!!!>,<!!!>!>,<""<e!!'>},{{{}},<!!!!!>,!!!>!>,<u>}},{{{},{<<>,<o!!!>!>i""e!'}!e}>}},{{{<ue!!!>}u!!!>,!>!!}>},{<!!u{}!!uo!!!!a>}},{{},{{<!>,<!!!>ii,'!!<!>,<!i!!!!!o,,,!!,!i<>}}}},{{{{<!!!'e!>ea!!!>,<!><a!!e{>}},{{{{<{!!!>ou!!',!>},<""!>},<}!!!>>}},{}},{{{{},{{<!!!!""'<>},{}}},{{<!!i{e!'!>},<!>},<e',!>,<>},{}}},{<i!!}u>,<!!<,i!!"",ue!>i>},{{{<ao""!>e<>},{{<,!>,<a!!o'<e{ieo!>>},{<u{!!!>!o{<aa!!!>!!'!>,<"">}}}}},{{},{<!!e}>}}},{<!!o!!!>}o!ae!!!>iiu!>>}},{{{<i!!!!,}iai!>},<,{!>},<a!>!!e>},<uu'!!!>!!!>{!!!>iu'}!>!!!>e!!!>!a>},{{<!,!>},<,{!!<ae!>},<ao<<!>},<eoa!>,>}}}},{{{<ie}o!!!>},<!>>,{{<""e!>e<!''u!!!!u!!{>}}},{{<ue!'!,,{ui!>,<i>},{<{!>,<!>,<!!e<'!!!>},<'<!!'i!!!!!>>}}},{{{<!!!,!!!>""!!i<u!""e''>},{{},{<!>},<a>}}},{{{},<!!!!!>,<!!oo!!!>},<!!u!!!!!>!a"">},{{<i{!>,<!>},<oi!!!>},<!!a!>,<!!!>e,o!!!>!!!""i>},{<!!!>iue""'ue'>}}},{}},{{{{<!!,e,!>},<}!!!!a!>},<}!>,<}!>},<e>,{<i!!!!!>!>,<!!"">}}}},{{<a!!!>,<!a!!ea!!a!u!>},<u!>,<i!!e>,{<o!!!!!u!!!!e!>e<""ue!>,<!!a!>,<{'<<>}},{{{<e<{!!!>!!!!{,}i<o""a!!o!>,<{>},{<oe""!!!>""!!i!!!>iiau>}},{},{{},{<o<!{!!!!!>!>},<}ii{u""!!<!!,>}}}}},{{{},{<!!}u!>,<o!o}u!>a!>},<""<!>},<>}},{<e>,<!!u"">},{{},{<!>},<a{ia<""""u""<!!}!!!>},<!!!>!'!>},<>,{<!e{,i<!oe!>ie!!a{<>,{{{{}}}}}}}}}},{{{{<}!a}!!{!!!>o!!!o!<u!<!>},<,>},{{<!>},<}!>!>}!<>},<!>},<""!!{!u!!!>!!!!}!!!!'!>u>},{{<!,!!!>o!>ua!}""!!a'i>},{<u>,{<a!!{!>}ia""!>,<!!!>!!}!>""!>e!>,<!!{>}}}},{{<aeaia{!!!{!!!>{!>}>,<o<!>},<a!!!>!!ie>},{<!>},<!{}!!!>}!eo'{<>,{{}}},{{{<!>},<e!!'e!!'!}o""!!>}},{<oi!!!>!>}ao!!"""">,<!!eoa>}}},{{<o<{!!!>,<a'>},{{<!!!!',!!!!ouia>},{<ouu!>,<a!a!>!!!!o,i!a'!!!!!>!!!>},<'>}},{{}}},{{{{{<!!,>}}},{<uu""<{!>,<!>,<<!>},<{euo>,<!>}!>},<!!a}!!{!,'{a<!>},<!!!>},<!!!>,<}e>},{{}}},{{{},<!!!!e!,!>},<o!e>},{{<},,!!!>u!>!!!>!>,<!!>}}}}},{{{{<!>,<!!!!'u<""ii!>},<'!!!>'a!!!!"">}},{{<i{i!>},<a!!!>!!!>iei!>!!!!{!>>,<'ioie'euee'!!!>>},<o,au}aa,o{>}},{<'}""!>},<>}},{{<""""!>!>,<a'!>},<!>,<o'>,<!!!>i!a!>,<!>,<}!!,!>},<!>,<i'!!!>!>},<uo!>},<!>>}},{{{<uo!>!!e!!!>,<{a>},<""!!!>},<'e""!}u!{!>},<!>},<{>},{<{!<o'!<!>},<{,}!}!>,<!!!!a"",!>}}{>,<,oo>}}}},{{}},{{{{{{}},<<ouou}o!!!>!!!!oe!!""!u,!!{>}},{{<!!!!!!'!!!>a!>,<,>},{<!!!!>}}},{{{{{{{},<!!!>'oo""""aa{!!{<ue>},{{},<<!!""!>eo!!<!!!>!>!>},<!>},<},!>,<!!a{!!!>!>,<!!!>>}},{{{},<{''!>uo!!!!o',>},{{<e{!>,<!<}a!>'!a!!!!,o!!!>!{>}}},{{{<<e""o'{}e!e}""e""ai}}o<>},{<u<!!}<}!!!{!>},<}<!>eo!,!>>,<a!!e""!>},<!!{e!!!>}!>,{!!i}!!!>!>},<>}},{{<o""'!>,<}!>},<,!!!eu!!!!!>i!{<}>},{<ie}{,i!!!!!iua!,!>!!,!!!>!>,<>}},{{<!!!>!>,<,ieiu!!!!ia!!!!!>oo!>,<ie>,<oe'o!,!'!!{""!>,<!,>},{<}<!>!>},<i}>}}},{{{<{!>!!!>!>>},{{<e!!a!>},<,!i>},<!!,u!>},<!>,<{!!!>},<!!'ii!>,<}!>,<!!!>""""!!""!>},<!!a>},{{{<!>},<eo!"",e}<ua}ui!!!>{>,{}},{<!>},<ouu!>},<{iu,a!e!!>}},{{{<i!!{}!!!u!!!!!!!>e{u>}},{{}}}}},{{<<,,u!>,<a<>},{{{{}}},{{{}}},{}},{{<!!!!!!,""!>},<oi!!!>,<>,<oe!!!!!><}>}}},{{{<'!!!>!!!>>},<!"""">}}}},{{{<a!>u>}},{<!{i'!>},<!!>},{{},{{},{{},{<!>ai!>,<>,{{<!!!>o!>ee""<"">},<eaa!>!!{!!!>,<!!!>},<""iau}<}!>!!!>,<,o>}}}}}},{{},{{{<!>""!!i!!<,''!!!>}!>!!},!>},<!>}!>,<!!!>}>}},{<!!!>,<{!>i,e!!!>!>,<!!!'oeo!!!}"">}},{{},{}}}},{{{},{{{<ii!>""{!>,<ui!,!!""!!o>}},<!ouaou!>""!!,!u!!!>,<>},{{<""o<'!!!!!!!!!>!!!>!!,!!!>!!u!!!>!!!>!!"",!!!>>},{<{,e!!}a""ii!!""'{,ea>}}},{{<}!>},<,!a!{{',"",!u""!>},<e>},{{}}},{{{},<}>},{<!!!>ia!o!o,""o!!!>{ai!'!!!>!!!>>,<!o,!!!>>},{{{{},{{<},iai<u>,{<!!!!!>},<a!!!>},<i>}}}},{{},<!>},<!!{'>}},{{{}},{{{{{<<<u!>}!!u!>},<!>uuai!"">}},{<}{<!>,<u!>},<'!{>}},{<u!!i<!!,""}}!!!ii!>,<,!!!>!!'>}},{}},{}},{{},{<,i!uui!!'!>!>i>}}}},{{{<!o""{""!>e!>},<!!}!>},<}!>,<""!!,!!!>,>},{<!'!!!!{o!!!!>,<!>,<{u!!!>!!!>,<,{!>,<!!!>,<!>!!<!<<!o}""i{>},{}}}},{{{<,o!>{>},{}},{},{<!>,<!ia}!!'!!!>}>,{<!>,<!>},<{!>,<!>i!!!!>}}},{{<,,!>,<!!}<o!>,<ii!!ao!{!>},<!>},<!>},<>,{<""a!!<!'>}},{<i!!!!!!'i!>,<!>},<e}!<u>,<!>},<""oa!!!ia!>},<u>}}},{},{{{<e<!!u'e!!!>{aa"",a!!!>!!!,a!}>,{<<u!>},<e!!uu'<}!>,<!>,<o{!!!!!>!oo'>}}},{},{{},{{},{}}}},{{<a""{!!!>!>ao!u!!!!!>!>,<'!!!>""}}!>},<o>,<ia!>,<!>},<!!!!!!au!>,<""<o!>},<!oi!!!!!>!!"">}}}}},{{{{{{<e>,<!!""!>aa!!!>},<!!!!!!a!!!ao!!o!>,<,!>},<!!!>{>},{}}}},{{{{<!i!>,<i!!},,!!!>i}!>!'!{""!u>,<!>!>,{!>,<i!uia!>!!!>!>!a>},{<{""!}!!oi!a!!!>u>,{<,>}}},{{{<ae'e!!,i!!}!>},<o!!!!!>,<!!!!'!>,<i,,o>},{<!!!>,<!!!>},<u!><,!!!>o>}},{}}},{{{<!<""uu!>,<}>,{<o!!!'!>,<io'!>>,<,e>}},{<!!!a>,<!!""!!e!!{!>,<aiu>}},{{},{{}},{{{{<e!>},<a!>},<,e,!!!!!>!!!!!,!>u}""<!u!>,<e>}},{{{{<!>},<,!!{!>},<!!!{!>},<!!!>{!>},<!!<,!!!>!!<!!<!!!>>},<!!'o!>!!!>ii!>,<!i!!<!>},<>},{},{<o>}},{<!>!!!>{!,e>,<!>,<!!'a}'!>,<!>,<!!!>},<{""{>}}},{{{{<!}!!a'>}},{{{},<""'!!ea!>},<!>{!>,<!>},<e}!>,<!!!>},<,{!>,<>},{<!>,<!>},<i{,>}},{{},{<!>,<!!'ou!!!!u!!!><!!e,!!!>!>},<!!>}}},{{},<eai!!!>>}},{{<!o{<o>,{}},{<!!!>""""!>},<<{,!>,<!!!>""ee!!!>u>,{<!!!!!{''!>},<!><'!u>}},{{<i""o!o!>,<a!!!!!>,}{o,!>},<<""!!!e!>},<>},{{<!!}!!i!!,!>},<'uai!>,<!!<u,!>},<!}!>,<>}}}},{{{{{<>},<!>ee>},{{<!!!>!!!>}!!!>""!o!!!>e!!!>!u'!>},<!!!!}o,e{>}}},{{},{<}{!!!>{!!!!!>!!!>}!!uu}!{!!!!!!{a!,!!}!>,<>}}},{{<a""}uae!>},<>},{<}>,<i''!>,<i!'!!!>'uu!o<}""!!!!!>!!!',>}}}},{{},{{{<oo!!!>i!u!!o"",ua'!!!>u""'!>>}},{{},{<!""!>},!>!!!>,<!!!>,<!>,<!!i!>},<u!!},!}!!!!!>>,<<,!!!>},<!!'!!!i}!!!!!!<i{}i!!!>},<!>},<>},{{<'!>'i!>,<""{!>e!>},<>},<""<!!!>},<i!u!!i!!a!eu}i!>,!!a<{!!!!!}!!!!"">}}},{{{{{<!!!!!>>},<!!""o!>},<""!>,<u>}},{{<!!i!>i""i{}o!!!>!!!>,<!,a!!!>},<!!!>!!!>,<!!!>!>},<!!{>},{}},{<!!i!>},<{o<!>i}a!>!'!<io<""{>,{<aii!!!>!!{{>}}}}}},{{{{{<oa!!""!>,<ai!<!!!!!!e!!{e>}},{{<a}!!!>'!>},<'i}o!,<>},{{<!!!>""!e',{"",e""ei<}{<>},{<!{i,o'!>},<ii!!!>!>>}}}},{{<e!!i,!!!!!!!>},<a<>},{{{<<!!!>},<'!!u!!!!!>ae<>}}}},{{{<{!>},<e!>'>}}}},{<!>,<>,<oo!>},<oiu!>u,!><'!!!>!!ou{>}},{{{},{<!>'ua!i!""!!!>e>,{}}}}},{{{{<>,{<!}!>},<},oo!>},<!!e}{<<!>u!}<!>,<>,<e>}},{{<,!>,<""{>},<!o}!a!!!>!>,<!>},<!!e!!!>!!ui<!!!>o!!!>!>},<!!>},{{<<''!!!!''<iu!ea!>!>!!!a!,>}}},{{},<!!!'!>,<,!>,<}>},{{{{<u!!}i!!i"">},{<{!>!!<!<i!!!>ai}a!!!>'!>u<u<}o>}},{{},<!""!!<,!>!!!>a!!<!>,<{}'>},{<!>!o!!ei!!!>!>},<!!!""o!><o>}},{}}},{{{}},{<u"",a}!!o,}!>!""!>},<,<>,<!!!!ui,{""!>,!>,<>}},{{{{<o!>},<i{!!"",!!!>!!!>>},{{{<!>},<,!!}a!>o!>,<a}uee>},{}}}},{{<{!!!>!!!>""e!>!,!}!!>},{{<,!!ia}!!!>!!!>i!!o!!!>aa!>,<!>},<!!!!i>},<!!o!!!>>},{{<{!!ea!>,<u{!!<!""{!>!!!>!{>}}}},{{<aio!>""!!,<>},{<i!!!!!>""u!!}!ii!!!>'i!!e!!!>!!a!io!>>}},{{{{}},{<""!>},<""o!!!>i}!!i!>{i{!>!,!!!""{!>},<>}}}}},{{<a,e!!a{!!!oe!,o!!!!a!!>,{}}}},{{{{<'!!'{!!{i!>>}},{<a>},{{<e,i!!oe,'>}}}},{{{{<e!>!""o,!!!>!>,<!>,<!>},<u!a'{i!>,<!>{>},{<!!}!""!!!>!>,<!>},<<<!!!!!!!>}""e'!>,<!>},<!!!>>}},{},{{},{<!!}o!!!!!>""}""o!>},<u!oaa!!u!>,<!>},<,>}}},{{<""!!!>!>!!!>,i!{u'"">},{},{<i!>,<""{!!}!{u{o!!!!}au>,{<""!>},<}u!>!>,<i>}}},{{<!,!>},<,>,{<,{!!!""a!oe!!u!!,ai!>>}},{{},<""!>,<ai<{,!>},<>},{}}},{{{<!>},<<!!!><,!!u>},{{{{},{}}}},{<!!'!>!><!>o!!,!!!><!!a>}},{{<u<!!}!!i""o!>},<!i}>},{}},{{{<e!!!>,!}<,>},{<i'!>},<}<!>,<{'!u}!>!!<a!!>}}}}},{{{{},{<{!!!>},<!'{!!'{{,,!>>,<!>,<<!!!>o>},{{{},{}}}}},{{{{{<'!>""i}ao'!>,<!!'o!>},<u'}!>!><i>},{<!!'o!<!!!>,<!>,<!!!>!!eau!ie{!><<>}},{{<,e!!u}',a!>,<eueo,}!>},<<!}>}}},{{<'uo!>,<<auue!u{>,{<}>}},{{{<a>}},{{<>}},{<i'{!!!>,!>,!uie!>},<!!<'>,{<>}}},{}}},{{<!>},<!>,<!!,!!""e{!>},<oa!!}u,'<,o'a>,<!>,<!{{!o}!u!>i,'!>},<e!}>},{{},{<o!!>}},{<!!!!!>!>},<{ii!>!>{{>,<!e!>!!'!!!>,<!>,<i>}},{{{<!>u!>,<!i'!!!>o}!>},<!!{!>!>},<iae{ai!>},<>},{<!!ao>,{}}},{{{}},{{{<aeu!>},<!>,<,!>},<'!>u!ou!!""iiu""!!""{>}}},{{},<""uiau!!!>ii!!!>},<<!<!>,<'i'>}},{}}},{{<e,!!a>,<!>},<ei!!!>},<a<o>},{{<""""a'!!{a{a,,}<!>,<!!ie>},{{<""'!!!!!>!>,<""!!!>,o',!!!'>,<!!""!>""!!i!!!>o'!>,<u>},{{},<u!'!!o!o'!,'>},{{{}},{{<"">},{{<!!!>,<i""{!'{!o,eoio,i!u!>,<!!>}}}}}},{<!!""e!!!o""a!>}!>""u!i{!!oai<!!!>,>,{<,!>,<eu,,o!>},<<o!!!,!!,io!!!""!>,<a!>},<>}}}},{{{{{<!>},<<o!!!>},<<u!!,u""!>},<!!,}!>,<!,>}}},{{<o""}!uu!!!>'""""u,{<>,<,u<e!!!>,<!!}!<i!!!>!!!><!!!!!!o!!!>!!}>},<!!""!>,<<""!>},<}!>,<<{o!!e'}>}},{{{{{},{}},{{<!!ou{!!!!,!>!!!>!>!!}!>{o!!!>},<o!>e!!!>>}}}},{{<i!!""'"">},{},{{<e!!a!!oiu!!!>!>!!}!!!>!'!!!!{i!!u>},<{'>}},{{<'!>>},{{<""}i!>},<}""!>,!{<!<>},{}},{{{<!>!!o>}},<!!<u!>},<e{a!>eo!!!!!>,<!a<!}ee>}}},{{<'u,<o!!i}}e}o!o"">,{<>}},{{{{}},{{{{<!!!>!>},<'}!!ai!!ou!>,<'!>!>i>}},<'o!<<>}},{{},{{<!!,!!!!!>>}}}},{<i>},{{{<!!!>>,{{<!>},<''!!!>},<!!},"",!!{!!,i!!!>a,!>,<!>},<<"">}}}},{}}}}}},{{{{},{{<eu!!}o!,o!>},<{!o!""{{i}""a<>},<""!!>},{{{}},<<u!!!!!>!>},<!}!!ei'{>}}},{{{{{<aue!!!>!<uai{>},{{{},{<""oo'ee{>,{<o!}!>,<!!!>oo{!!!ae}>}}},{},{<!!,!>}!!!>!>},<i!!a'>}},{{}}},{{{{<}!!!!!!<!>},<!!>}},{<!ea}""""ii<u!{""}""{!>!!!>},<>}},{{<""a!!ii{!>>}}},{{{<!!!!}>,<i""}!!!>,<!>,<""i!""!!uo!!!>>},{<o<!>,<""'e!!!>!'!<!oe>}}},{{<""!>},<!!!>o}<<""'!!!!'!!!>'o!>>},{<!!!>},<!!ooa!!!>!>eiea!>!>,<!!i!o>}}},{{<i<,>}},{{<u!>},<,!>},<u!!!>},<}a>,{{<!>},<u!>},<!i!>,<au!,'>},{<!e!>},<!!!>},<>,<{u!!ouo,ui'!!!>!'>}}},{<,!!!>""""o,e>},{<!!e!>'!!!>,!!<!!ioe!!e<<{!>},<,"">,{<!ui!,!!!>!!a!>!>,<""uu>}}},{{{<'a{!!!o{!o>,<}!>,!>},<""u""!eu!!!>>},{{{<>}}}},{{{<!!""<>}}},{{{{<},,!>},<!>!!!>!>a!>!!!>,<u!!!u!!i>}},{<!>},<""!>},<>}},{{{<'o!!!>!!!>!!!!!>!!{!>,<!>!!!>!>,<e""!>,<i}!><>,{{<}e!!!>'u!>{!!!>'!>,<!>},<>}}},{<'!!e!>au<!>,<{!>,<}<}!>u,o"">,{{<!>!>,<!!!!!!!>,<}!!u!>},<!!!>,<!>},<'""""'{!!}!>},<>}}}},{<'!!!!!>{i!oa""!>},<,!!!>>},{{{},<!>,<>}}},{{{}}},{{{{<>}}},{{{},<uu!}u,{!!},!u!!!!!>{ao>},{{<a>},{<u!>""""'u""iio'u!!'!>,<<>}},{{},{}}}}}}},{{{{{<}""ei"",,u!!!>},<o!!e!}u!!!>u>}},{}},{{{<!!{i{!{,e!!!'a}>}}}},{{{{<oo!au'!!{>,<i!!!>'!!!>e{i<}<>},{<!!!!,e>}},{{<i,,!!!>},<!,!{o""{u!>},<o,!!>},{{{<<!!!>,!!ui<{!!!>,<>}},{{<>}},{<a,e!!!!!>""i!>,<{>,<>}}}},{<!>!>,<!>},<}!"">,{}},{<""!>},<o!>a""!!!>},<!>},<},!""!}e}!{,!>,<<>,{}}},{{<!>},<!>""o!>,<uu!!}!,<!!!o'a>,{<!!!!{!!""{}!!<{'a!'!!!>},<i{!>},<a}!u<>}}}},{{{{{{<!!""<,!e!>u!!!>!>},<<!!a!!'a>,{<!>,<!>},<'!>},<!>""a!!!>,}!>,<!!o,""'>}},{<!!!>a<uao!>},<""!!!,!!}!!}""!>},<>}},<i!>,<!!!>ou!""o'!>,<i!!'!!}'>},{}},{{<<!{!!u,!!!!""!>},<!>,<oe'e}!'o!,u!!>}},{<}!!}>}},{{{<aoi!!>},{<e!>,<""!>},<a!>'u>}},{{<a,!!!>a'!>},<o!>,<e>,{}}},{<<""!>,<ou!!!>!!!>a!o!!!>!!}a>,{<!!!><'!!!u!>},<i'!{!>},<>}}},{{{<{!>,<e!'a!!'u!!,ieu!ee!>},<!>,<!>,<>,{<!""o>}},{{},{<ea!!!!,'!}o,!!!><ia}!>!!!>!!!!!>u>}},{}}}},{{{{{<!!!>'""!>,<!!!>,<"">},<!!e{!!''!{,""""a!>,<i>},{},{{<iiu!}!!!>{}!!!!!!'e'!!''>},{<!>!>},<!i>}}},{<'"">,{}},{{<e!,!o!!!>'i}!'!>,<{e'}}e!>,<u>}}},{{{<}{},!>oa'aia!!!>!>},<!!!>a>},<!!!>!!!!!>!>,<!!!>'!>!>>},{<'o!!!>o!{!>},<!!!>,<!>,<>},{{{}}}},{{{<!>,<aoo<'!!!>u}!>},<!>,<!!!>!>o<io,>},<>},{{<!u},e!!o'},<!>,<!!!>!>i!!a!e!>,<!!!>>},{<ue!'>}},{<}}o!!!>!!!!!!!>!!!>>,<<!!u<!e}""ei""o,!>,<'o!!!>!<<u>}},{{{<!>,<i<!>},<u!!!>!!!>!!!>},<,!>,<i!}!>,<!>},<>},{}},{},{<o}'>}}},{{{{{<!!!!!!,'}i<>},<!""!>,<!!'ui!!!>'u!>},<!!>},{},{<i!!!>i!o>,<!!>}},{}},{{{},{{{{<!{}!!!!!>>},{<i!>},<!>,<!!!>!>,<""o>,{<o<ei''!!!>},<u!<!>},<!}e,<oaa>}}},{}}}}},{{<<''}!>,a""!!!>!>},<ia,!!!>,<u>,{<!>,<>}},{{{<<!!!>},<iaaae>}},{{<>},{{<{a>},<,!!e!o{!!e>}}},{{<>},<!!e''!!{'o!!,,'{}i,i!>},<>}},{{<!>o!>},<!!!>>,{<}e'a'""!>,<!e!>},<!!!<!!oa!>},<!>},<!!!e>}},{{<}!>},<i!e'!>,<!!au>,<!>,o!>,<!>},<!>,<!!!>!>},<!>,<""a!!!>,<a}>},{<{<o>}}}}},{{},{{<!!!>'}a{!i,""!>',eao!!}<>},{{},<}<{""!>,<!!!>,<!!,<iuaeu"",ee>},{{<ui!!!}>},<!!!>>}}},{{{{{<>,{<,}eu<""!}{u""i!>!!oao>}},<,,<o!>},<}!!!>!>,<}a!>""!>},<!!>},{{<,a!a!!""!!u!!!!<i>},{<!>!>'!>,<!>!!""!>,<!!""!{!!!>}>}},{<!<!>,<!!!!uo'!!!>}!<!!!!!!}!>!!u!!!><!>},<<>}},{{{{<{ai!!!>!>!!euie!>,<!!u!!i,u!!!>,<"">},<!>{'!><!!!>!u,!!!!!o!{ie!u}>},{<,!!'{'i>,{<!!o<!!!!!>ooa!oo<<oi'>}},{}}},{{{{}},{<u}}<""e<o{"">,{}}},{<},!!ea!!!!!>},<!>},<,!""e}!>},<>}},{{{{{<'}!>,<,}!>},<ea{,!<o>,{<""!>,<,!!{ei<'o>}},{<<!oiu!!o!>},<!o<'!!""{>}}},{{<!>},<}a>}},{<!!u>}},{{<e}!!u!!}!>oa"">},<{!i!i>},{{{<!!!>!>!!!!!!iu!!!>!>,<a!!,,!ai"">}}}}},{{{{{<!>,<e>},{}}},{},{{}}},{{{<u{{{!!!>,,!><!>,<!>,<a>}},{{},{{}}},{}},{{{{<!>i!>,<u!!{<u<!>u!!!>""ooe{!>},<>},{<!!!u{!>},<!!o}i,{u!!!>!>},<,ea>}}},{<""!!!i>,<!!}!!!>},<!!a!>},<!>},<'}ue!>},<>}}}}}}";
    }
}
