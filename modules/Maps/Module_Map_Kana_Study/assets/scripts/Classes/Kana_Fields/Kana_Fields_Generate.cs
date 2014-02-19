function Module_Map_Kana_Study::Kana_Fields_Generate(%this)
{

//Make scriptobject to hold the definition imagefont and other variables.

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition))
{

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars))
{

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots))
{

%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars))
{

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields))
{

%this.ScriptObject_Kana_Fields.delete();

}

%this.ScriptObject_Kana_Fields=new ScriptObject()
{

SimSet_ImageFont_Definition=0;

SimSet_ImageFont_Pronunciation_Chars=0;

SimSet_Kana_Slots=0;

SimSet_Kana_Chars=0;

};

if (isObject(%this.Simset_Objects))
{

%this.Simset_Objects.deleteObjects();

%this.Simset_Objects.delete();

}

%this.Simset_Objects=new SimSet();

%this.Object_Count=0;

/**********************************************************/

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition=new SimSet();

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars=new SimSet();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots=new SimSet();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars=new SimSet();

%Int_Char_Size="4 4";

%Vector_2D_Last_Position="0 0";

/**********************************************************/

//Create definition ImageFont.

%ScriptObject_Char=%this.Random_Char_Get();

%Int_Definition_String_Length=strlen(%ScriptObject_Char.String_Definition);

//for (%x=0;%x<%Int_Definition_String_Length/($Camera_Size.X/2);%x++)
for (%x=0;%x<%Int_Definition_String_Length/($Camera_Size.X/%Int_Char_Size.X);%x++)
{

%ImageFont_Definition=new ImageFont();

%ImageFont_Definition.Image="Dots_and_Crits:Font";

%ImageFont_Definition.Position="0" SPC (($Camera_Size.Y/2)-(%Int_Char_Size.Y/2))-((%x*%Int_Char_Size.Y)*2);

%Vector_2D_Last_Position=%ImageFont_Definition.Position;

%ImageFont_Definition.FontSize=%Int_Char_Size;

%ImageFont_Definition.TextAlignment="Center";

//%ImageFont_Definition.Text=getSubStr(%ScriptObject_Char.String_Definition,%x*($Camera_Size.X/2),($Camera_Size.X/2));
%ImageFont_Definition.Text=getSubStr(%ScriptObject_Char.String_Definition,%x*($Camera_Size.X/%Int_Char_Size.X),($Camera_Size.X/%Int_Char_Size.X));

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Definition.add(%ImageFont_Definition);

Scene_Dots_and_Crits.add(%ImageFont_Definition);

}

/**********************************************************/

//Create pronunciation segments and Kana characters.

%String_Kana=0;

%ScriptObject_Individual_Char=0;

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
/*
%ImageFont_Char.Position=((%Int_Previous_String_Length*%Int_Char_Size.X*%Int_Char_Size.X) + ((strlen(%ScriptObject_Individual_Char.String_Pronunciation)/2)*%Int_Char_Size.X*%Int_Char_Size.X))-%Int_Pronunciation_String_Length_Half*%Int_Char_Size.X*%Int_Char_Size.X
*/
%ImageFont_Char.Position=((%Int_Previous_String_Length*(%Int_Char_Size.X*1.1)) + ((strlen(%ScriptObject_Individual_Char.String_Pronunciation)/2)*(%Int_Char_Size.X*1.1)))-%Int_Pronunciation_String_Length_Half*(%Int_Char_Size.X*1.1)
SPC %ImageFont_Definition.Position.Y-%Int_Char_Size.Y*2;

%Int_Previous_String_Length+=strlen(%ScriptObject_Individual_Char.String_Pronunciation);

%ImageFont_Char.FontSize=%Int_Char_Size;

%ImageFont_Char.TextAlignment="Center";

%ImageFont_Char.Text=%ScriptObject_Individual_Char.String_Pronunciation;

Scene_Dots_and_Crits.add(%ImageFont_Char);

%this.ScriptObject_Kana_Fields.SimSet_ImageFont_Pronunciation_Chars.add(%ImageFont_Char);

/*********************************************************************************************************/

//Create Kana slot for this pronunciation segment.

%Shape_Vector_Kana_Slot=new ShapeVector()
{

Size=%Int_Char_Size.X/2 SPC %Int_Char_Size.Y/2;
class="Class_Vector_Shape_Kana_Slot";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Char_Character=%ScriptObject_Individual_Char.Char_Character;

Char_Mounted_Character="";

};

%this.Simset_Objects.add(%Shape_Vector_Kana_Slot);

%Shape_Vector_Kana_Slot.setPolyCustom(4,"-1 1 1 1 1 -1 -1 -1");

%Shape_Vector_Kana_Slot.setLineColor("0.50 0.50 0.50 1");

%Shape_Vector_Kana_Slot.setFillColor("0.25 0.25 0.25 1");

%Shape_Vector_Kana_Slot.setFillMode(true);

%Shape_Vector_Kana_Slot.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Shape_Vector_Kana_Slot.createPolygonBoxCollisionShape(%Int_Char_Size);

%Shape_Vector_Kana_Slot.Position=%ImageFont_Char.Position;

%Shape_Vector_Kana_Slot.Position.Y-=%Int_Char_Size.Y*2;

Scene_Dots_and_Crits.add(%Shape_Vector_Kana_Slot);

%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.add(%Shape_Vector_Kana_Slot);

/*********************************************************************************************************/

//Kana sprite.

/*******************************************************/

//Find Kana.

%Bool_Found_Hiragana=false;

%Kana_Char=0;

%Bool_Found_Katakana=false;

for (%y=0;%y<%this.Simset_Map_Hiragana.getCount();%y++)
{

%Kana_Char=%this.Simset_Map_Hiragana.getObject(%y);

if (%Kana_Char.Unicode_Character$=%ScriptObject_Individual_Char.Char_Character)
{

%Bool_Found_Hiragana=true;

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

break;

}

}

}

/*******************************************************/

%Sprite_Kana_Char=new Sprite()
{

Position=getRandom(-(($Camera_Size.X/2)-%Int_Char_Size.X),($Camera_Size.X/2)-%Int_Char_Size.X)
SPC getRandom(0-%Int_Char_Size.Y,-(($Camera_Size.Y/2)-%Int_Char_Size.Y));
Size=%Int_Char_Size;
Image=%Kana_Char.Image_Asset;
Frame=%Kana_Char.Frame;

FixedAngle=true;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count+1;

class="Class_Sprite_Kana_Char";

Char_Character=%ScriptObject_Individual_Char.Char_Character;

};

%this.Object_Count+=2;

%this.Simset_Objects.add(%Sprite_Kana_Char);

%Collision_Shape_Index=%Sprite_Kana_Char.createPolygonBoxCollisionShape(%Int_Char_Size);

Scene_Dots_and_Crits.add(%Sprite_Kana_Char);

%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.add(%Sprite_Kana_Char);

/*********************************************************************************************************/

}

%SimSet_Pronunciation.deleteObjects();

%SimSet_Pronunciation.delete();

}
