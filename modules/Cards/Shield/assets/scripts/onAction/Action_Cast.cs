function Module_Card_Shield::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Shield=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);
Image="Module_Card_Shield:Image_Shield";
Animation="Module_Card_Shield:Animation_Shield";
class="Class_Shield";
CollisionCallback="true";
SceneLayer=16;

SleepingAllowed=false;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

};

%Sprite_Shield.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);

%Collision_Shape_Index=%Sprite_Shield.createPolygonBoxCollisionShape(%Square_Size);

//%Sprite_Shield.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Shield);

%Sprite_Shield.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(315));

%this.Simset_Objects.add(%Sprite_Shield);

/********/

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Sprite_Shield)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Sprite_Shield);

}

/********/

/***********************************************************************************************/

%Sprite_Shield=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);
Image="Module_Card_Shield:Image_Shield";
Animation="Module_Card_Shield:Animation_Shield";
class="Class_Shield";
CollisionCallback="true";
SceneLayer=16;

SleepingAllowed=false;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index-1;

Health=100;

};

%Sprite_Shield.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);

%Collision_Shape_Index=%Sprite_Shield.createPolygonBoxCollisionShape(%Square_Size);

//%Sprite_Shield.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y-=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y-=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Shield);

%Sprite_Shield.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(135));

%this.Simset_Objects.add(%Sprite_Shield);

/********/

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Sprite_Shield)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Sprite_Shield);

}

/********/

/***********************************************************************************************/

%Sprite_Shield=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);
Image="Module_Card_Shield:Image_Shield";
Animation="Module_Card_Shield:Animation_Shield";
class="Class_Shield";
CollisionCallback="true";
SceneLayer=16;

SleepingAllowed=false;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index-2;

Health=100;

};

%Sprite_Shield.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);

%Collision_Shape_Index=%Sprite_Shield.createPolygonBoxCollisionShape(%Square_Size);

//%Sprite_Shield.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.X=(%Vector_2D_Target_Player_Sprite_Size.X/2)+(%Square_Size.X/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.X=%Vector_2D_Rotated_Square_Offset.X/3;

%Vector_2D_Mount_Offset.X+=%Vector_2D_Rotated_Square_Offset.X;

Scene_Dots_and_Crits.add(%Sprite_Shield);

%Sprite_Shield.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(225));

%this.Simset_Objects.add(%Sprite_Shield);

/********/

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Sprite_Shield)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Sprite_Shield);

}

/********/

/***********************************************************************************************/

%Sprite_Shield=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);
Image="Module_Card_Shield:Image_Shield";
Animation="Module_Card_Shield:Animation_Shield";
class="Class_Shield";
CollisionCallback="true";
SceneLayer=16;

SleepingAllowed=false;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index-3;

Health=100;

};

%Sprite_Shield.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Shield);

%Collision_Shape_Index=%Sprite_Shield.createPolygonBoxCollisionShape(%Square_Size);

//%Sprite_Shield.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.X-=(%Vector_2D_Target_Player_Sprite_Size.X/2)+(%Square_Size.X/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.X=%Vector_2D_Rotated_Square_Offset.X/3;

%Vector_2D_Mount_Offset.X-=%Vector_2D_Rotated_Square_Offset.X;

Scene_Dots_and_Crits.add(%Sprite_Shield);

%Sprite_Shield.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(45));

%this.Simset_Objects.add(%Sprite_Shield);

/********/

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Sprite_Shield)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Sprite_Shield);

}

/********/

}
