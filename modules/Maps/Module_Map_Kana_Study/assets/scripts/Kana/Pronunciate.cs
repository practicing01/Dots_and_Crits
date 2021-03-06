function Module_Map_Kana_Study::Pronunciate(%this,%String_Kana)
{

%Simset_Individual_Chars=new SimSet();

for (%x=0;%x<strlen(%String_Kana);%x+=3)
{

%ScriptObject_Individual_Char=new ScriptObject()
{

Char_Character="";

Char_Type="";

String_Pronunciation="";

};

%ScriptObject_Individual_Char.Char_Character=getSubStr(%String_Kana,%x,3);

%Bool_Found_Hiragana=false;

%Kana_Char=0;

%Bool_Found_Katakana=false;

for (%y=0;%y<%this.Simset_Map_Hiragana.getCount();%y++)
{

%Kana_Char=%this.Simset_Map_Hiragana.getObject(%y);

if (%Kana_Char.Unicode_Character$=%ScriptObject_Individual_Char.Char_Character)
{

%Bool_Found_Hiragana=true;

%ScriptObject_Individual_Char.Char_Type="0";//0=Hiragana

%ScriptObject_Individual_Char.String_Pronunciation=%Kana_Char.Pronunciation;

break;

}

}

if (!%Bool_Found_Hiragana)
{

for (%y=0;%y<%this.Simset_Map_Katakana.getCount();%y++)
{

%Kana_Char=%this.Simset_Map_Katakana.getObject(%y);

if (%Kana_Char.Unicode_Character$=%ScriptObject_Individual_Char.Char_Character)
{

%Bool_Found_Katakana=true;

%ScriptObject_Individual_Char.Char_Type="1";//1=Katakana

%ScriptObject_Individual_Char.String_Pronunciation=%Kana_Char.Pronunciation;

break;

}

}

}

%Simset_Individual_Chars.add(%ScriptObject_Individual_Char);

}

for (%x=0;%x<%Simset_Individual_Chars.getCount();%x++)
{

%ScriptObject_Individual_Char=%Simset_Individual_Chars.getObject(%x);

//Sokuons: Hiragana: っ Katakana: ッ

if (%ScriptObject_Individual_Char.String_Pronunciation$="っ"||%ScriptObject_Individual_Char.String_Pronunciation$="ッ")
{

//echo("found sokuon");

if (%x+1>=%Simset_Individual_Chars.getCount()){break;}//Weird shit where a sokuon would be last.

%ScriptObject_Individual_Char_Next=%Simset_Individual_Chars.getObject(%x+1);

%ScriptObject_Individual_Char.String_Pronunciation=getSubStr(%ScriptObject_Individual_Char_Next.String_Pronunciation,0,1);

}//Choonpu
else if (%ScriptObject_Individual_Char.String_Pronunciation$="ー")
{

//echo("found choonpu");

if (%x-1<0){break;}//Weird shit where a choonpu would be first.

%ScriptObject_Individual_Char_Previous=%Simset_Individual_Chars.getObject(%x-1);

%ScriptObject_Individual_Char.String_Pronunciation=getSubStr(%ScriptObject_Individual_Char_Previous.String_Pronunciation,
strlen(%ScriptObject_Individual_Char_Previous.String_Pronunciation)-1,1);

}//Youons
else if (%ScriptObject_Individual_Char.String_Pronunciation$="ゃ"||%ScriptObject_Individual_Char.String_Pronunciation$="ャ")//ya
{

//echo("found ya");

%ScriptObject_Individual_Char.String_Pronunciation="a";

}
else if (%ScriptObject_Individual_Char.String_Pronunciation$="ゅ"||%ScriptObject_Individual_Char.String_Pronunciation$="ュ")//yu
{

//echo("found yu");

%ScriptObject_Individual_Char.String_Pronunciation="u";

}
else if (%ScriptObject_Individual_Char.String_Pronunciation$="ょ"||%ScriptObject_Individual_Char.String_Pronunciation$="ョ")//yo
{

//echo("found yo");

%ScriptObject_Individual_Char.String_Pronunciation="o";

}

//echo(%ScriptObject_Individual_Char.String_Pronunciation);

}

return %Simset_Individual_Chars;

}
