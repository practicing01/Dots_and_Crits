function Module_Map_Kana_Study::Kana_Fields_Generate(%this)
{

//Make scriptobject to hold the definition imagefont and other variables.

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition))
{

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition.deleteObject();

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition.delete();

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

SimSet_ImageFont_Definition=0;

SimSet_ImageFont_Pronunciation_Chars=0;

SimSet_Kana_Chars=0;

};

/**********************************************************/

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition=new SimSet();

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars=new SimSet();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars=new SimSet();

%Int_Char_Size="2 2";

%Vector_2D_Last_Position="0 0";

/**********************************************************/

%ScriptObject_Char=%this.Random_Char_Get();

%Int_Definition_String_Length=strlen(%ScriptObject_Char.String_Definition);

for (%x=0;%x<%Int_Definition_String_Length/($Camera_Size.X/2);%x++)
{

%ImageFont_Definition=new ImageFont();

%ImageFont_Definition.Image="Dots_and_Crits:Font";

%ImageFont_Definition.Position="0" SPC (($Camera_Size.Y/2)-(%Int_Char_Size.Y/2))-((%x*%Int_Char_Size.Y)*%Int_Char_Size.Y);

%Vector_2D_Last_Position=%ImageFont_Definition.Position;

%ImageFont_Definition.FontSize=%Int_Char_Size;

%ImageFont_Definition.TextAlignment="Center";

%ImageFont_Definition.Text=getSubStr(%ScriptObject_Char.String_Definition,%x*($Camera_Size.X/2),($Camera_Size.X/2));

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition.add(%ImageFont_Definition);

Scene_Dots_and_Crits.add(%ImageFont_Definition);

}

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

%Int_Pronunciation_String_Length_Half=0;

for (%x=0;%x<%SimSet_Pronunciation.getCount();%x++)
{

%ScriptObject_Individual_Char=%SimSet_Pronunciation.getObject(%x);

%Int_Pronunciation_String_Length_Half+=strlen(%ScriptObject_Individual_Char.String_Pronunciation);

}

%Int_Pronunciation_String_Length_Half=%Int_Pronunciation_String_Length_Half/2;

%Int_Previous_String_Length=0;

for (%x=0;%x<%SimSet_Pronunciation.getCount();%x++)
{

%ScriptObject_Individual_Char=%SimSet_Pronunciation.getObject(%x);

%ImageFont_Char=new ImageFont();

%ImageFont_Char.Image="Dots_and_Crits:Font";

%ImageFont_Char.Position=((%Int_Previous_String_Length*%Int_Char_Size.X*%Int_Char_Size.X) + ((strlen(%ScriptObject_Individual_Char.String_Pronunciation)/2)*%Int_Char_Size.X*%Int_Char_Size.X))-%Int_Pronunciation_String_Length_Half*%Int_Char_Size.X*%Int_Char_Size.X
SPC %ImageFont_Definition.Position.Y-%Int_Char_Size.Y*%Int_Char_Size.Y;

%Int_Previous_String_Length+=strlen(%ScriptObject_Individual_Char.String_Pronunciation);

%ImageFont_Char.FontSize=%Int_Char_Size;

%ImageFont_Char.TextAlignment="Center";

%ImageFont_Char.Text=%ScriptObject_Individual_Char.String_Pronunciation;

Scene_Dots_and_Crits.add(%ImageFont_Char);

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.add(%ImageFont_Char);

}

%SimSet_Pronunciation.deleteObjects();

%SimSet_Pronunciation.delete();

}
