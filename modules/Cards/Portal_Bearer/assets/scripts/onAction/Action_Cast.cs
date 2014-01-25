function Module_Card_Portal_Bearer::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%World_Position,%Object_Index)
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

if (%Target_Player==0)
{

%Target_Player=new ScriptObject()
{

Game_Connection_Handle=0;

};

}

//Use player info to play animations.

//This skill only allows for the client who cast to have the mounted sprite.
//Targeting itself will toggle the sprite, any other target will be attacked.

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)//New Portal_Bearer user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Player_Information;

Sprite_Portal_Bearer=0;

Sprite_Portal_In=0;

Sprite_Portal_Out=0;

Bool_Portal_Type_To_Shoot=0;//0=In, 1=Out

};

%Vector_2D_Portal_Bearer_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Bearer);

%Script_Object_Player_Information.Sprite_Portal_Bearer=new Sprite()
{

BodyType="static";
size=%Vector_2D_Portal_Bearer_Size;
Image="Module_Card_Portal_Bearer:Image_Portal_Bearer";
Animation="Module_Card_Portal_Bearer:Animation_Portal_Bearer";
Position="0 0";

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Portal_Bearer);

%Vector_2D_Player_Size=%Player_Information.Player_Sprite_Data.Sprite.getSize();

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Player_Size.Y/2)+(%Vector_2D_Portal_Bearer_Size.Y/2);

%Script_Object_Player_Information.Sprite_Portal_Bearer.mount(%Player_Information.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(180));

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Script_Object_Player_Information.Sprite_Portal_Bearer)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Script_Object_Player_Information.Sprite_Portal_Bearer);

}

/********************************************************/

%Script_Object_Player_Information.Sprite_Portal_In=new Sprite()
{

class="Class_Portal_Bearer_Portal";
BodyType="static";
size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_In);
Image="Module_Card_Portal_Bearer:Image_Portal_In";
Animation="Module_Card_Portal_Bearer:Animation_Portal_In";
Position="0 0";
Visible=false;
CollisionCallback="true";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;

Health=100;

Bool_Portal_Projectile_Type=0;

};

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Portal_In);

%Script_Object_Player_Information.Sprite_Portal_In.setCollisionGroups(0,25,26,30);

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_In);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Script_Object_Player_Information.Sprite_Portal_In.createCircleCollisionShape(%Radius);

%Script_Object_Player_Information.Sprite_Portal_In.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Script_Object_Player_Information.Sprite_Portal_Out=new Sprite()
{

class="Class_Portal_Bearer_Portal";
BodyType="static";
size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Out);
Image="Module_Card_Portal_Bearer:Image_Portal_Out";
Animation="Module_Card_Portal_Bearer:Animation_Portal_Out";
Position="0 0";
Visible=false;
CollisionCallback="true";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;

Health=100;

Bool_Portal_Projectile_Type=1;

};

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Portal_Out);

%Script_Object_Player_Information.Sprite_Portal_Out.setCollisionGroups(0,25,26,30);

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Out);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Script_Object_Player_Information.Sprite_Portal_Out.createCircleCollisionShape(%Radius);

%Script_Object_Player_Information.Sprite_Portal_Out.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

/********************************************************/

}
else
{

if (%Player_Object.Sprite_Portal_Bearer.Visible)
{

if (%Target_Player.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

%Player_Object.Sprite_Portal_Bearer.Visible=false;

}
else
{

/******************************************************************************************/

%Sprite_Projectile=new Sprite()
{

BlendColor="1 1 1 0.75";
Angle=(Vector2AngleToPoint(%Player_Object.Sprite_Portal_Bearer.Position,%World_Position)+270)%360;
class="Class_Portal_Bearer_Projectile";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;

Health=100;

Bool_Portal_Projectile_Type=%Player_Object.Bool_Portal_Type_To_Shoot;

Object_Index=%Object_Index;

};

%Square_Size=0;

if (!%Player_Object.Bool_Portal_Type_To_Shoot)
{

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_In_Projectile);
%Sprite_Projectile.Size=%Square_Size;
%Sprite_Projectile.Image="Module_Card_Portal_Bearer:Image_Portal_In_Projectile";
%Sprite_Projectile.Animation="Module_Card_Portal_Bearer:Animation_Portal_In_Projectile";
%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_In_Projectile);

}
else
{

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Out_Projectile);
%Sprite_Projectile.Size=%Square_Size;
%Sprite_Projectile.Image="Module_Card_Portal_Bearer:Image_Portal_Out_Projectile";
%Sprite_Projectile.Animation="Module_Card_Portal_Bearer:Animation_Portal_Out_Projectile";
%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Out_Projectile);

}

%Player_Object.Bool_Portal_Type_To_Shoot=!%Player_Object.Bool_Portal_Type_To_Shoot;

%Sprite_Projectile.setCollisionGroups(0,25,26,30);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Projectile.createCircleCollisionShape(%Radius);

%Sprite_Projectile.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

Scene_Dots_and_Crits.add(%Sprite_Projectile);

%Sprite_Projectile.mount(%Player_Object.Sprite_Portal_Bearer,"0 0",0,true,mDegToRad(0));

%Sprite_Projectile.dismount();

%Sprite_Projectile.Position=%Sprite_Projectile.Position;

%this.Simset_Objects.add(%Sprite_Projectile);

%Sprite_Projectile.moveTo(%World_Position,20,false,false);

/******************************************************************************************/

}

}
else
{

%Player_Object.Sprite_Portal_Bearer.Visible=true;

/******************************************************************************************/
/*
%Sprite_Projectile=new Sprite()
{

BlendColor="1 1 1 0.75";
Angle=(Vector2AngleToPoint(%Player_Object.Sprite_Portal_Bearer.Position,%World_Position)+270)%360;
class="Class_Portal_Bearer_Projectile";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;

Health=100;

Bool_Portal_Projectile_Type=%Player_Object.Bool_Portal_Type_To_Shoot;

Object_Index=%Object_Index;

};

%Square_Size=0;

if (!%Player_Object.Bool_Portal_Type_To_Shoot)
{

%Sprite_Projectile.Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_In_Projectile);
%Sprite_Projectile.Image="Module_Card_Portal_Bearer:Image_Portal_In_Projectile";
%Sprite_Projectile.Animation="Module_Card_Portal_Bearer:Animation_Portal_In_Projectile";
%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_In_Projectile);

}
else
{

%Sprite_Projectile.Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Out_Projectile);
%Sprite_Projectile.Image="Module_Card_Portal_Bearer:Image_Portal_Out_Projectile";
%Sprite_Projectile.Animation="Module_Card_Portal_Bearer:Animation_Portal_Out_Projectile";
%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Portal_Out_Projectile);

}

%Player_Object.Bool_Portal_Type_To_Shoot=!%Player_Object.Bool_Portal_Type_To_Shoot;

%Sprite_Projectile.setCollisionGroups(0,25,26,30);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Projectile.createCircleCollisionShape(%Radius);

%Sprite_Projectile.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

Scene_Dots_and_Crits.add(%Sprite_Projectile);

%Sprite_Projectile.mount(%Player_Object.Sprite_Portal_Bearer,"0 0",0,true,mDegToRad(0));

%Sprite_Projectile.dismount();

%Sprite_Projectile.Position=%Sprite_Projectile.Position;

%this.Simset_Objects.add(%Sprite_Projectile);

%Sprite_Projectile.moveTo(%World_Position,20,false,false);
*/
/******************************************************************************************/

}

}

}
