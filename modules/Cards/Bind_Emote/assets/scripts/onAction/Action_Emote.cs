function Module_Card_Bind_Emote::Action_Emote(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%String_Animation)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

//Use player info to play animations.

%Target_Player.Player_Sprite_Data.Sprite.playAnimation(%String_Animation);

}
