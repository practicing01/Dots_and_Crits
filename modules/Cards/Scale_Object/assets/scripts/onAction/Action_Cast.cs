function Module_Card_Scale_Object::Action_Cast(%this,%Player_Information,
%Bool_Type_Of_Object,
%Player_Game_Connection_Or_Object_Module_ID,
%Object_Game_Connection,
%Object_Index,
%Vector_2D_Position)
{

%Target_Player=0;

if (!%Bool_Type_Of_Object)//Player
{

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Game_Connection_Or_Object_Module_ID)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

%Vector_2D_New_Size="0 0";

%Vector_2D_New_Size.X=mAbs(%Target_Player.Player_Sprite_Data.Sprite.Position.X-%Vector_2D_Position.X)*2;

%Vector_2D_New_Size.Y=mAbs(%Target_Player.Player_Sprite_Data.Sprite.Position.Y-%Vector_2D_Position.Y)*2;

%Target_Player.Player_Sprite_Data.Sprite.setSize(%Vector_2D_New_Size);

%Target_Player.Player_Sprite_Data.Sprite.clearCollisionShapes();

%Collision_Shape_Index=%Target_Player.Player_Sprite_Data.Sprite.createPolygonBoxCollisionShape(%Vector_2D_New_Size);

//%Target_Player.Player_Sprite_Data.Sprite.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Target_Player.Player_Sprite_Data.Sprite.Position=%Target_Player.Player_Sprite_Data.Sprite.Position;

}
else
{

/*Find object to grab*/
%Scene_Object=0;

for (%x=0;%x<%Player_Game_Connection_Or_Object_Module_ID.Simset_Objects.getCount();%x++)
{

%Object=%Player_Game_Connection_Or_Object_Module_ID.Simset_Objects.getObject(%x);

if ((%Object.Game_Connection_Handle==%Object_Game_Connection)&&(%Object.Object_Index==%Object_Index))
{

%Scene_Object=%Object;

break;

}

}

if (%Scene_Object==0){return;}

%Vector_2D_New_Size="0 0";

%Vector_2D_New_Size.X=mAbs(%Scene_Object.Position.X-%Vector_2D_Position.X)*2;

%Vector_2D_New_Size.Y=mAbs(%Scene_Object.Position.Y-%Vector_2D_Position.Y)*2;

%Scene_Object.setSize(%Vector_2D_New_Size);

//The following assumes only 1 collision shape, very bad :<

%Bool_Is_Sensor=%Scene_Object.getCollisionShapeIsSensor(0);

%Scene_Object.clearCollisionShapes();

%Collision_Shape_Index=%Scene_Object.createPolygonBoxCollisionShape(%Vector_2D_New_Size);

%Scene_Object.setCollisionShapeIsSensor(%Collision_Shape_Index,%Bool_Is_Sensor);

%Scene_Object.Position=%Scene_Object.Position;

}

}
