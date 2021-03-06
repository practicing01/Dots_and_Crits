function Module_Card_Wall_Tile::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Wall_Tile=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall_Tile);
Image="Module_Card_Wall_Tile:Image_Wall_Tile";
Animation="Module_Card_Wall_Tile:Animation_Wall_Tile";
class="Class_Wall_Tile";
CollisionCallback="true";
SceneLayer=16;
BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

};

%Sprite_Wall_Tile.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Sprite.getSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall_Tile);

%Collision_Shape_Index=%Sprite_Wall_Tile.createPolygonBoxCollisionShape(%Square_Size);

//%Sprite_Wall_Tile.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Wall_Tile);

%Sprite_Wall_Tile.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Wall_Tile.dismount();

%Sprite_Wall_Tile.Position=%Sprite_Wall_Tile.Position;

%this.Simset_Objects.add(%Sprite_Wall_Tile);

}
