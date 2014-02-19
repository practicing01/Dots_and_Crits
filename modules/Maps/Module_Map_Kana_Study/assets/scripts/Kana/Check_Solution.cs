function Module_Map_Kana_Study::Check_Solution(%this)
{

%Bool_All_Correct=true;

%Bool_Finished=true;

for (%x=0;%x<%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.getCount();%x++)
{

%ShapeVector_Kana_Slot=%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.getObject(%x);

if (%ShapeVector_Kana_Slot.Char_Mounted_Character$=""){%Bool_Finished=false;}

if (%ShapeVector_Kana_Slot.Char_Mounted_Character!$=%ShapeVector_Kana_Slot.Char_Character&&%ShapeVector_Kana_Slot.Char_Mounted_Character!$="")
{

%Bool_All_Correct=false;

break;

}

}

if (!%Bool_All_Correct)
{

for (%x=0;%x<%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.getCount();%x++)
{

%ShapeVector_Kana_Slot=%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.getObject(%x);

%ShapeVector_Kana_Slot.Char_Mounted_Character="";

%ShapeVector_Kana_Slot.setFillColor("0.25 0.25 0.25 1");

}

for (%x=0;%x<%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.getCount();%x++)
{

%Sprite_Kana_Char=%this.ScriptObject_Kana_Fields.SimSet_Kana_Chars.getObject(%x);

%Sprite_Kana_Char.BodyType="dynamic";

%Sprite_Kana_Char.Position=getRandom(-50-%Sprite_Kana_Char.Size.X,50-%Sprite_Kana_Char.Size.X)
SPC getRandom(0,-($Camera_Size.Y/2));

}

}
else if (%Bool_Finished)
{

//next char

}

}
