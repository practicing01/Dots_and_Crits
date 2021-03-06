function Module_Player_Class::Player_Data_Add(%this,%Player_Information)
{

%Script_Object_Player_Data=new ScriptObject()
{

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;
Connector_Name=%Player_Information.Connector_Name;
String_Player_Sprite_Description=%Player_Information.String_Player_Sprite_Description;
Player_Sprite_Data=0;
Module_ID_Player_Sprite=0;

};

%this.Simset_Player_Data.add(%Script_Object_Player_Data);

if (%Player_Information.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

$ScriptObject_Player_Information_This=%Script_Object_Player_Data;

}

for (%x=0;%x<$Simset_ModuleID_Player_Sprites.getCount();%x++)
{

%Module_ID_Player_Sprite=$Simset_ModuleID_Player_Sprites.getObject(%x);

if (%Module_ID_Player_Sprite.String_Description$=%Player_Information.String_Player_Sprite_Description)
{

%Script_Object_Player_Data.Module_ID_Player_Sprite=%Module_ID_Player_Sprite.Module_ID_Player_Sprite;

/*Load the player sprite module if it hasn't already been.*/

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

break;

}

}

%Script_Object_Player_Data.Player_Sprite_Data=%Script_Object_Player_Data.Module_ID_Player_Sprite.Player_Sprite_Spawn(%Script_Object_Player_Data.Game_Connection_Handle);

Scene_Dots_and_Crits.add(%Script_Object_Player_Data.Player_Sprite_Data.Sprite);

Scene_Dots_and_Crits.add(%Script_Object_Player_Data.Player_Sprite_Data.Scene_Object_Mount);

%Script_Object_Player_Data.Player_Sprite_Data.Scene_Object_Mount.mount(%Script_Object_Player_Data.Player_Sprite_Data.Sprite,"0 0",0,true,-1);

$Module_ID_Map_Loaded.Player_Spawn(%Script_Object_Player_Data.Player_Sprite_Data.Sprite);

}
