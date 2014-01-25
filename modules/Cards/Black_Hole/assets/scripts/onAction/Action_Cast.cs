function Module_Card_Black_Hole::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Black_Hole=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Black_Hole);
Image="Module_Card_Black_Hole:Image_Black_Hole";
Animation="Module_Card_Black_Hole:Animation_Black_Hole";
class="Class_Black_Hole";
CollisionCallback="true";
SceneLayer=16;
DefaultRestitution=1.0;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Controller_Point=0;

};

%Sprite_Black_Hole.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Sprite.getSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Black_Hole);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Black_Hole.createCircleCollisionShape(%Radius);

//%Sprite_Black_Hole.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Black_Hole);

%Sprite_Black_Hole.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Black_Hole.dismount();

%Sprite_Black_Hole.Position=%Sprite_Black_Hole.Position;

%this.Simset_Objects.add(%Sprite_Black_Hole);

%Sprite_Black_Hole.Controller_Point=new PointForceController();

%Sprite_Black_Hole.Controller_Point.Radius=%Radius*4;

%Sprite_Black_Hole.Controller_Point.Force=600;

%Sprite_Black_Hole.Controller_Point.NonLinear=true;

%Sprite_Black_Hole.Controller_Point.LinearDrag=0.1;

%Sprite_Black_Hole.Controller_Point.AngularDrag=0;

Scene_Dots_and_Crits.Controllers.add(%Sprite_Black_Hole.Controller_Point);

%Sprite_Black_Hole.Controller_Point.setTrackedObject(%Sprite_Black_Hole);

}
