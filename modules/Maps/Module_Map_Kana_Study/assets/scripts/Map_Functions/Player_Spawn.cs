function Module_Map_Kana_Study::Player_Spawn(%this,%Sprite_Player)
{

%Portal_Spawn=%this.Simset_Portal_Spawn.getObject(getRandom(0,%this.Simset_Portal_Spawn.getCount()-1));

%Sprite_Player.Position=%Portal_Spawn.Position;

%Player_Information=%Sprite_Player.Script_Object_Parent;

if (%Player_Information.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

commandToServer('Relay_Module_Function',%Player_Information.Sprite.Module_ID_Parent,"Action_Position",%Player_Information.Game_Connection_Handle,%Player_Information.Sprite.Position);

if (!Window_Dots_and_Crits.getIsCameraMounted())
{

Window_Dots_and_Crits.setCameraPosition(%Portal_Spawn.Position.X,%Portal_Spawn.Position.Y);

}

}
else
{

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

commandToServer('Relay_Module_Function',%Player_Object.Player_Sprite_Data.Sprite.Module_ID_Parent,"Action_Position",%Player_Object.Game_Connection_Handle,%Player_Object.Player_Sprite_Data.Sprite.Position);

break;

}

}

}

}
