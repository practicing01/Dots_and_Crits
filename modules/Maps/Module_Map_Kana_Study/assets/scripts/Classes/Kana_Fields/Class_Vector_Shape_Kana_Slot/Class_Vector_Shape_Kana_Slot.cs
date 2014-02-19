function Class_Vector_Shape_Kana_Slot::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Sprite_Kana_Char"&&%this.Char_Mounted_Character$="")
{

%Module_ID_Grab=ModuleDatabase.findModule(Module_Card_Grab,"1");

%String_Module_ID_Loaded_Modules=ModuleDatabase.findModules(true);

for (%x=0;%x<getWordCount(%String_Module_ID_Loaded_Modules);%x++)
{

%Module_ID_Loaded_Module=getWord(%String_Module_ID_Loaded_Modules,%x);

if (%Module_ID_Loaded_Module==%Module_ID_Grab)
{

for (%y=0;%y<Module_Card_Grab.Simset_Player_Information.getCount();%y++)
{

%Player_Object=Module_Card_Grab.Simset_Player_Information.getObject(%y);

if (%Player_Object.Sprite_Grab==%Colliding_Object)
{

%Player_Object.Sprite_Grab.dismount();

%Player_Object.Sprite_Grab.Angle=0;

for (%z=0;%z<%Player_Object.Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%z++)
{

%Mounted_Object=%Player_Object.Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%z);

if (%Mounted_Object==%Player_Object.Sprite_Grab)
{

%Player_Object.Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.remove(%Mounted_Object);

break;

}

}

%Player_Object.Sprite_Grab=0;

break;

}

}

break;

}

}

%this.Char_Mounted_Character=%Colliding_Object.Char_Character;

%Colliding_Object.BodyType="static";

%Colliding_Object.Position=%this.Position;

//Bugged.  Maybe because of mounting dynamic to static or sprite to vectorshape.
//Scene_Dots_and_Crits.createWeldJoint(%this,%Colliding_Object,"0 0","0 0",0,1,false);

if (%this.Char_Character$=%this.Char_Mounted_Character)
{

%this.setFillColor("0.0 0.5 0.5 1");

}

%this.Module_ID_Parent.Check_Solution();

}

}
