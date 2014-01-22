function Module_Card_Scale::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position)
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

%Vector_2D_New_Size="0 0";

%Vector_2D_New_Size.X=mAbs(%Target_Player.Player_Sprite_Data.Composite_Sprite.Position.X-%Vector_2D_Position.X)*2;

%Vector_2D_New_Size.Y=mAbs(%Target_Player.Player_Sprite_Data.Composite_Sprite.Position.Y-%Vector_2D_Position.Y)*2;

%Target_Player.Player_Sprite_Data.Composite_Sprite.setSpriteSize(%Vector_2D_New_Size);

%Target_Player.Player_Sprite_Data.Composite_Sprite.clearCollisionShapes();

%Collision_Shape_Index=%Target_Player.Player_Sprite_Data.Composite_Sprite.createPolygonBoxCollisionShape(%Vector_2D_New_Size);

//%Target_Player.Player_Sprite_Data.Composite_Sprite.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Target_Player.Player_Sprite_Data.Composite_Sprite.Position=%Target_Player.Player_Sprite_Data.Composite_Sprite.Position;

}
