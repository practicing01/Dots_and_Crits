function Module_Card_Toggle_Projectile::Action_Shoot(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Projectile=new Sprite()
{

Position=%Target_Player.Player_Sprite_Data.Sprite.Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Toggle_Projectile);
Image="Module_Card_Toggle_Projectile:Image_Toggle_Projectile";
class="Class_Toggle_Projectile_Projectile";
CollisionCallback="true";
SceneLayer=16;
Angle=(Vector2AngleToPoint(%Target_Player.Player_Sprite_Data.Sprite.Position,%Vector_2D_Position)+270)%360;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Target_Player.Game_Connection_Handle;

Object_Index=%Object_Index;

Bullet=true;

Health=100;

};

%Projectile.setCollisionGroups(0,25,26,30);

%Square_Size=%Projectile.Size;

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Projectile.createCircleCollisionShape(%Radius);

%Projectile.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%this.Simset_Objects.add(%Projectile);

Scene_Dots_and_Crits.add(%Projectile);

%Projectile.moveTo(%Vector_2D_Position,100,false,false);

}
