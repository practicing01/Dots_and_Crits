function Module_Card_Toggle_Triangle_Object::Action_Shoot(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Triangle=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Toggle_Triangle_Object);
Image="Module_Card_Toggle_Triangle_Object:Image_Toggle_Triangle_Object";
Animation="Module_Card_Toggle_Triangle_Object:Animation_Toggle_Triangle_Object";
class="Class_Toggle_Triangle_Object";
CollisionCallback="true";
SceneLayer=16;
BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Target_Player.Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

};

%Sprite_Triangle.setCollisionGroups(0,25,26,30);

/************************************************************/
/*
%Vector_2D_A=Scale_Vector_To_Camera_By_Resolution("30 0","1280 800");

%Vector_2D_A.X-=%Sprite_Triangle.Size.X/2;

%Vector_2D_A.Y-=%Sprite_Triangle.Size.Y/2;

%Vector_2D_A.Y=-%Vector_2D_A.Y;
*/
/************************************************************/
/*
%Vector_2D_B=Scale_Vector_To_Camera_By_Resolution("63 63","1280 800");

%Vector_2D_B.X-=%Sprite_Triangle.Size.X/2;

%Vector_2D_B.Y-=%Sprite_Triangle.Size.Y/2;

%Vector_2D_B.Y=-%Vector_2D_B.Y;
*/
/************************************************************/
/*
%Vector_2D_C=Scale_Vector_To_Camera_By_Resolution("0 63","1280 800");

%Vector_2D_C.X-=%Sprite_Triangle.Size.X/2;

%Vector_2D_C.Y-=%Sprite_Triangle.Size.Y/2;

%Vector_2D_C.Y=-%Vector_2D_C.Y;
*/
/************************************************************/

/*
%Collision_Shape_Index=%Sprite_Triangle.createPolygonCollisionShape
(
%Vector_2D_A.X SPC %Vector_2D_A.Y SPC
%Vector_2D_B.X SPC %Vector_2D_B.Y SPC
%Vector_2D_C.X SPC %Vector_2D_C.Y
);
*/

%Sprite_Triangle.createPolygonCollisionShape
(
"0" SPC %Sprite_Triangle.Size.Y/2 SPC
%Sprite_Triangle.Size.X/2 SPC -(%Sprite_Triangle.Size.Y/2) SPC
(-(%Sprite_Triangle.Size.X/2)) SPC -(%Sprite_Triangle.Size.Y/2)
);

%this.Simset_Objects.add(%Sprite_Triangle);

Scene_Dots_and_Crits.add(%Sprite_Triangle);

}
