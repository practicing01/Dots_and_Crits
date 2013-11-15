function Module_Card_Capture_Object::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Capture_Object_Spawner=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Capture_Object_Spawner);
Image="Module_Card_Capture_Object:Image_Capture_Object_Spawner";
Animation="Module_Card_Capture_Object:Animation_Spawner_Idle";
class="Class_Capture_Object_Spawner";
CollisionCallback="true";
SceneLayer=16;
//DefaultDensity=0;
//DefaultRestitution=1;

BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

GameConnection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index-1;

Health=100;

};

%Sprite_Capture_Object_Spawner.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Capture_Object_Spawner);

%Collision_Shape_Index=%Sprite_Capture_Object_Spawner.createPolygonBoxCollisionShape(%Square_Size);

%Sprite_Capture_Object_Spawner.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Capture_Object_Spawner);

%Sprite_Capture_Object_Spawner.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Capture_Object_Spawner.dismount();

%Sprite_Capture_Object_Spawner.Position=%Sprite_Capture_Object_Spawner.Position;

%this.Simset_Objects.add(%Sprite_Capture_Object_Spawner);

/********************************/

%Sprite_Capture_Object_Capture_Object=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Capture_Object_Capture_Object);
Image="Module_Card_Capture_Object:Image_Capture_Object_Capture_Object";
Animation="Module_Card_Capture_Object:Animation_Capture_Object_Idle";
class="Class_Capture_Object";
CollisionCallback="true";
SceneLayer=16;
//DefaultDensity=0;
//DefaultRestitution=1;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

GameConnection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Parent_Spawner=%Sprite_Capture_Object_Spawner;

};

%Sprite_Capture_Object_Capture_Object.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Sprite_Capture_Object_Spawner.Size;

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Capture_Object_Capture_Object);

%Collision_Shape_Index=%Sprite_Capture_Object_Capture_Object.createPolygonBoxCollisionShape(%Square_Size);

//%Sprite_Capture_Object_Capture_Object.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

%Sprite_Capture_Object_Capture_Object.Vector_2D_Mount_Offset=%Vector_2D_Mount_Offset;

Scene_Dots_and_Crits.add(%Sprite_Capture_Object_Capture_Object);

%Sprite_Capture_Object_Capture_Object.mount(%Sprite_Capture_Object_Spawner,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Capture_Object_Capture_Object.dismount();

%Sprite_Capture_Object_Capture_Object.Position=%Sprite_Capture_Object_Capture_Object.Position;

%this.Simset_Objects.add(%Sprite_Capture_Object_Capture_Object);

}
