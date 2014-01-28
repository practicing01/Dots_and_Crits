function Module_Card_Toggle_Wall_Tile::Action_Shoot(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Toggle_Wall_Tile);
Image="Module_Card_Toggle_Wall_Tile:Image_Toggle_Wall_Tile";
Animation="Module_Card_Toggle_Wall_Tile:Animation_Toggle_Wall_Tile";
class="Class_Toggle_Wall_Tile_Wall";
CollisionCallback="true";
SceneLayer=16;
BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Target_Player.Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

%this.Simset_Objects.add(%Sprite_Wall);

Scene_Dots_and_Crits.add(%Sprite_Wall);

}
