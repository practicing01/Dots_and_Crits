function Module_Map_Kana_Study::Kana_Fields_Generate(%this)
{

//Make scriptobject to hold the definition imagefont and other variables.

if (isObject(%this.ScriptObject_Kana_Fields.ImageFont_Definition))
{

%this.ScriptObject_Kana_Fields.ImageFont_Definition.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars))
{

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars))
{

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.delete();

}

%this.ScriptObject_Kana_Fields=new ScriptObject()
{

ImageFont_Definition=0;

SimSet_ImageFont_Pronunciation_Chars=0;

SimSet_Kana_Chars=0;

};

/**********************************************************/

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars=new SimSet();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars=new SimSet();

/**********************************************************/

%ScriptObject_Char=%this.Random_Char_Get();

%this.ScriptObject_Kana_Fields.ImageFont_Definition=new ImageFont();

%this.ScriptObject_Kana_Fields.ImageFont_Definition.Image="Dots_and_Crits:Font";

%this.ScriptObject_Kana_Fields.ImageFont_Definition.Position="0" SPC ($Camera_Size.Y/2)-1.5;

%this.ScriptObject_Kana_Fields.ImageFont_Definition.FontSize="2 2";

%this.ScriptObject_Kana_Fields.ImageFont_Definition.TextAlignment="Center";

%this.ScriptObject_Kana_Fields.ImageFont_Definition.Text=%ScriptObject_Char.String_Definition;

echo(%ScriptObject_Char.String_Definition);

Scene_Dots_and_Crits.add(%this.ScriptObject_Kana_Fields.ImageFont_Definition);

/**********************************************************/

%String_Kana=0;

if (%ScriptObject_Char.String_Kana!$="")
{

%String_Kana=%ScriptObject_Char.String_Kana;

}
else
{

%String_Kana=%ScriptObject_Char.String_Kanji_Or_Kana;

}

%SimSet_Pronunciation=%this.Pronunciate(%String_Kana);

for (%x=0;%x<%SimSet_Pronunciation.getCount();%x++)
{

%ScriptObject_Individual_Char=%SimSet_Pronunciation.getObject(%x);

%ImageFont_Char=new ImageFont();

%ImageFont_Char.Image="Dots_and_Crits:Font";

%ImageFont_Char.Position=((-(%SimSet_Pronunciation.getCount()/2))+(4*%x)) SPC ($Camera_Size.Y/2)-4;

%ImageFont_Char.FontSize="2 2";

%ImageFont_Char.TextAlignment="Center";

%ImageFont_Char.Text=%ScriptObject_Individual_Char.String_Pronunciation;

echo(%ScriptObject_Individual_Char.String_Pronunciation);

Scene_Dots_and_Crits.add(%ImageFont_Char);

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.add(%ImageFont_Char);

}

%SimSet_Pronunciation.deleteObjects();

%SimSet_Pronunciation.delete();

}
