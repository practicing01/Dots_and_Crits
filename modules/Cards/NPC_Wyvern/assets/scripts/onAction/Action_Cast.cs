function Module_Card_NPC_Wyvern::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_NPC_Wyvern=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_NPC_Wyvern_Hover_Down);
Image="Module_Card_NPC_Wyvern:Image_NPC_Wyvern_Hover_Down";
Animation="Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Down";
class="Class_NPC_Wyvern";
CollisionCallback="true";
SceneLayer=14;
FixedAngle=true;
LinearDamping=1;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=9001;

Previous_Health=9001;

Simset_Colliding_Objects=0;

Vector_2D_Direction="0 -1";//0=neutral, x=1=right x=-1=left, y=1=up y=-1=down

Bool_Is_Mobile=false;

Schedule_AI=0;

Linear_Damping=1;

Base_Speed=20;

Current_Speed=20;

Base_Attack=20;

Current_Attack=20;

};

%Sprite_NPC_Wyvern.Simset_Colliding_Objects=new SimSet();

%Sprite_NPC_Wyvern.Size.X*=10;

%Sprite_NPC_Wyvern.Size.Y*=10;

%Sprite_NPC_Wyvern.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Sprite.getSize();

%Square_Size=%Sprite_NPC_Wyvern.Size;

%Square_Size.X/=3;

%Square_Size.Y/=3;

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_NPC_Wyvern.createCircleCollisionShape(%Radius);

//%Sprite_NPC_Wyvern.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Square_Size.X*=6;

%Square_Size.Y*=6;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_NPC_Wyvern.createCircleCollisionShape(%Radius);

%Sprite_NPC_Wyvern.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_NPC_Wyvern);

%Sprite_NPC_Wyvern.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_NPC_Wyvern.dismount();

%Sprite_NPC_Wyvern.Position=%Sprite_NPC_Wyvern.Position;

%this.Simset_Objects.add(%Sprite_NPC_Wyvern);

%Sprite_NPC_Wyvern.Schedule_AI=schedule(4000,0,"Class_NPC_Wyvern::Schedule_AI",%Sprite_NPC_Wyvern);

}
