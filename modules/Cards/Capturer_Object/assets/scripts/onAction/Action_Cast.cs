function Module_Card_Capturer_Object::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Capturer_Object=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Capturer_Object);
Image="Module_Card_Capturer_Object:Image_Capturer_Object";
Animation="Module_Card_Capturer_Object:Animation_Capturer_Object_Idle";
class="Class_Capturer_Object";
CollisionCallback="true";
SceneLayer=16;

BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Score=0;

Text_Score=0;

};

%Sprite_Capturer_Object.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Capturer_Object);

%Collision_Shape_Index=%Sprite_Capturer_Object.createPolygonBoxCollisionShape(%Square_Size);

%Sprite_Capturer_Object.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Capturer_Object);

%Sprite_Capturer_Object.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Capturer_Object.dismount();

%Sprite_Capturer_Object.Position=%Sprite_Capturer_Object.Position;

%this.Simset_Objects.add(%Sprite_Capturer_Object);

%Sprite_Capturer_Object.Text_Score=new ImageFont()
{

Image="Module_Card_Capturer_Object:Image_Font";

fontSize="2 2";

textAlignment="Center";

text=%Sprite_Capturer_Object.Score;

};

Scene_Dots_and_Crits.add(%Sprite_Capturer_Object.Text_Score);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y+=%Sprite_Capturer_Object.Size.Y/2;

%Sprite_Capturer_Object.Text_Score.mount(%Sprite_Capturer_Object,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Capturer_Object.Position=%Sprite_Capturer_Object.Position;

}
