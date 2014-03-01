function Module_Map_Kana_Study::Scene_Unload(%this)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Ass_Unload();

%this.Simset_Portal_Spawn.delete();

%this.Camera_Move_Schedule.delete();

%this.Player_Move_Schedule.delete();

Window_Dots_and_Crits.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

echo("Deleting dictionary.");

%this.Simset_Dictionary.deleteObjects();

%this.Simset_Dictionary.delete();

echo("Deleting hiragana characters.");

%this.Simset_Map_Hiragana.deleteObjects();

%this.Simset_Map_Hiragana.delete();

echo("Deleting katakana characters.");

%this.Simset_Map_Katakana.deleteObjects();

%this.Simset_Map_Katakana.delete();

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

if (isObject(%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots))
{

%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.deleteObjects();

%this.ScriptObject_Kana_Fields.SimSet_Kana_Slots.delete();

}

if (isObject(%this.ScriptObject_Kana_Fields))
{

%this.ScriptObject_Kana_Fields.delete();

}

}
