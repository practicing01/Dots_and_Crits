function Module_Card_Deathball::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Deathball=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Deathball_Run_Up);
Image="Module_Card_Deathball:Image_Deathball_Run_Up";
Animation="Module_Card_Deathball:Animation_Deathball_Run_Up";
class="Class_Deathball";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

};

%Sprite_Deathball.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Sprite.getSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Deathball_Run_Up);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Deathball.createCircleCollisionShape(%Radius);

//%Sprite_Deathball.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Deathball);

%Sprite_Deathball.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Deathball.dismount();

%Sprite_Deathball.Position=%Sprite_Deathball.Position;

%this.Simset_Objects.add(%Sprite_Deathball);

}
