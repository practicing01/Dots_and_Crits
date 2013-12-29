function Module_Map_Bath_Salts::Scene_Initialize(%this)
{

echo("Bath Salts initialized.");

exec("./Scene_Initialize/Initialize_Floor/Initialize_Floor.cs");

%this.Gui_Scroll_Arrows_Spawn();

%this.Gui_Move_Arrows_Spawn();

%this.Initialize_Floor();

for (%x=0;%x<Scene_Dots_and_Crits.getCount();%x++)
{

%Object=Scene_Dots_and_Crits.getObject(%x);

if (%Object.class$="Class_Portal_Spawn")
{

%this.Simset_Portal_Spawn.add(%Object);

}

}

}
