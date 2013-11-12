function Dots_and_Crits::Load_Player_Data(%this)
{

for (%x=0;%x<$Simset_Players_Information.getCount();%x++)
{

%Player_To_Load=$Simset_Players_Information.getObject(%x);

%Bool_Found_Sprite=false;

for (%y=0;%y<$Simset_ModuleID_Player_Sprites.getCount();%y++)
{

%Module_ID_Player_Sprite=$Simset_ModuleID_Player_Sprites.getObject(%y);

if (%Module_ID_Player_Sprite.String_Description$=%Player_To_Load.String_Player_Sprite_Description)
{

%Bool_Sprite_Already_Loaded=false;

for (%z=0;%z<$Simset_Module_ID_Loaded_Player_Sprites.getCount();%z++)
{

%Module_ID_Loaded_Sprite=$Simset_Module_ID_Loaded_Player_Sprites.getObject(%z);

if (%Module_ID_Loaded_Sprite.Module_ID_Player_Sprite$=%Module_ID_Player_Sprite.Module_ID_Player_Sprite)
{

%Bool_Sprite_Already_Loaded=true;

break;

}

}

if (!%Bool_Sprite_Already_Loaded)
{

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite.Module_ID_Player_Sprite);

%Module_ID_Player_Sprite.Module_ID_Player_Sprite.Player_Sprite_Load();

%Module_ID_Loaded_Sprite=new ScriptObject()
{

Module_ID_Player_Sprite=%Module_ID_Player_Sprite.Module_ID_Player_Sprite;

};

$Simset_Module_ID_Loaded_Player_Sprites.add(%Module_ID_Loaded_Sprite);

}

if (%Player_To_Load.Is_Playing)
{

Module_Player_Class.Player_Data_Add(%Player_To_Load);

}

%Bool_Found_Sprite=true;

break;

}

}

if (!%Bool_Found_Sprite)
{
//need to fix this by checking for already loaded sprites//banana
//Set random sprite.
%Module_ID_Player_Sprite=$Simset_ModuleID_Player_Sprites.getObject(getRandom(0,$Simset_ModuleID_Player_Sprites.getCount()-1));

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite.Module_ID_Player_Sprite);

%Module_ID_Player_Sprite.Module_ID_Player_Sprite.Player_Sprite_Load();

if (%Player_To_Load.Is_Playing)
{

Module_Player_Class.Player_Data_Add(%Player_To_Load);

}

}

}

}
