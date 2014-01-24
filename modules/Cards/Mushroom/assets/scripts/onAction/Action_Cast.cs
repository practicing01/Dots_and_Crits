function Module_Card_Mushroom::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Mushroom=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Mushroom);
Image="Module_Card_Mushroom:Image_Mushroom";
class="Class_Mushroom";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Mounted_Rain_Drops=0;

};

%Sprite_Mushroom.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Sprite.getSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Mushroom);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Mushroom.createCircleCollisionShape(%Radius);

//%Sprite_Mushroom.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Mushroom);

%Sprite_Mushroom.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Mushroom.dismount();

%Sprite_Mushroom.Position=%Sprite_Mushroom.Position;

%this.Simset_Objects.add(%Sprite_Mushroom);

/*******************************************************/

%Sprite_Rain_Drops=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Rain_Drops);
Image="Module_Card_Mushroom:Image_Rain_Drops";
Animation="Module_Card_Mushroom:Animation_Rain_Drops";
class="Class_Mushroom";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index-1;

Health=100;

};

%Sprite_Rain_Drops.setCollisionGroups(0,25,26,30);

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Rain_Drops);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Rain_Drops.createCircleCollisionShape(%Radius);

%Sprite_Rain_Drops.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

Scene_Dots_and_Crits.add(%Sprite_Rain_Drops);

%Sprite_Rain_Drops.mount(%Sprite_Mushroom,"0 0",0,true,mDegToRad(0));

%Sprite_Mushroom.Mounted_Rain_Drops=%Sprite_Rain_Drops;

%this.Simset_Objects.add(%Sprite_Rain_Drops);

}
