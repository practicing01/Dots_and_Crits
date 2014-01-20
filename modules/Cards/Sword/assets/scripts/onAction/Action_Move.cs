function Module_Card_Sword::Action_Move(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position)
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

%Player_Object.Sprite_Sword.rotateTo((Vector2AngleToPoint(%Player_Object.Sprite_Sword.Position,%Vector_2D_Position)+270)%360,360,true,false);

}
