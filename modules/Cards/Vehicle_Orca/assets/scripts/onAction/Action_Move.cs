function Module_Card_Vehicle_Orca::Action_Move(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position)
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

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Target_Player.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0){return;}

%Angle=(Vector2AngleToPoint(%Player_Object.Player_Information.Player_Sprite_Data.Composite_Sprite.Position,%Vector_2D_Position)+180)%360;

if ((%Angle>=337.5&&%Angle<=360)||(%Angle>=0&&%Angle<22.5))//Left
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(270));

%Player_Object.Sprite_Vehicle_Orca.Frame=6;

}
else if ((%Angle>=22.5&&%Angle<67.5))//Down-Left
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(225));

%Player_Object.Sprite_Vehicle_Orca.Frame=5;

}
else if ((%Angle>=67.5&&%Angle<112.5))//Down
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(180));

%Player_Object.Sprite_Vehicle_Orca.Frame=4;

}
else if ((%Angle>=112.5&&%Angle<157.5))//Down-Right
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(135));

%Player_Object.Sprite_Vehicle_Orca.Frame=3;

}
else if ((%Angle>=157.5&&%Angle<202.5))//Right
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(90));

%Player_Object.Sprite_Vehicle_Orca.Frame=2;

}
else if ((%Angle>=202.5&&%Angle<247.5))//Up-Right
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(45));

%Player_Object.Sprite_Vehicle_Orca.Frame=1;

}
else if ((%Angle>=247.5&&%Angle<292.5))//Up
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(0));

%Player_Object.Sprite_Vehicle_Orca.Frame=0;

}
else if ((%Angle>=292.5&&%Angle<337.5))//Up-Left
{

%Player_Object.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(315));

%Player_Object.Sprite_Vehicle_Orca.Frame=7;

}

commandToServer('Relay_Module_Function',%Target_Player.Module_ID_Player_Sprite,"Action_Move",%Vector_2D_Position);

}
