function Module_Map_Kana_Study::Scene_Initialize(%this)
{

echo("Kana Study initialized.");

%this.Keyboard_Bind();

%this.Gui_Scroll_Arrows_Spawn();

%this.Gui_Move_Arrows_Spawn();

for (%x=0;%x<Scene_Dots_and_Crits.getCount();%x++)
{

%Object=Scene_Dots_and_Crits.getObject(%x);

if (%Object.class$="Class_Portal_Spawn")
{

%this.Simset_Portal_Spawn.add(%Object);

}

}

GlobalActionMap.bindCmd(keyboard,"g",
"Module_Map_Kana_Study.Random_Char_Get();","");

%this.Load_Characters();

%this.Load_Dictionary();

%this.Load_Pronunciations();

%this.Kana_Fields_Generate();

}
