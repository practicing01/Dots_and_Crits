function Module_Player_Sprite_Lelur::Action_Position(%this,%Player_Information,%Target_Player_Game_Connection_Handle,%Vector_2D_Position)
{

%Target_Player=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Target_Player=%this.Simset_Player_Information.getObject(%x);

if (%Target_Player.Game_Connection_Handle==%Target_Player_Game_Connection_Handle)
{

break;

}

%Target_Player=0;

}

if (!%Target_Player){return;}

%Target_Player.Sprite.Position=%Vector_2D_Position;

}
