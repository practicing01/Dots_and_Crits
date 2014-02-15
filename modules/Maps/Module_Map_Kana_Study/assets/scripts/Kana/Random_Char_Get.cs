function Module_Map_Kana_Study::Random_Char_Get(%this)
{

%ScriptObject_Char=%this.Simset_Dictionary.getObject(getRandom(0,%this.Simset_Dictionary.getCount()-1));

//echo("kana or kanji" SPC %ScriptObject_Char.String_Kanji_Or_Kana);

echo("Kana:" SPC %ScriptObject_Char.String_Kana);

echo("Definition:" SPC %ScriptObject_Char.String_Definition);

%Kana_Temp=0;

if (%ScriptObject_Char.String_Kana!$="")
{

%Kana_Temp=%ScriptObject_Char.String_Kana;

}
else
{

%Kana_Temp=%ScriptObject_Char.String_Kanji_Or_Kana;

}

echo("kana strlen" SPC strlen(%Kana_Temp));

%this.Pronunciate(%Kana_Temp);

}
