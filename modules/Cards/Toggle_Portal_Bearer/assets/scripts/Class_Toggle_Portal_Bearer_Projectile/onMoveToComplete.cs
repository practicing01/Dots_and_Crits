function Class_Toggle_Portal_Bearer_Projectile::onMoveToComplete(%this)
{

//Spawn portal.

%Player_Object=0;

for (%x=0;%x<%this.Module_ID_Parent.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Module_ID_Parent.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%this.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

/********************************************************/

%Sprite_Portal=new Sprite()
{

class="Class_Toggle_Portal_Bearer_Portal";
BodyType="static";
size=Scale_Ass_Size_Vector_To_Camera(%this.Module_ID_Parent.Ass_Image_Toggle_Portal_Bearer_Portal);
Image="Module_Card_Toggle_Portal_Bearer:Image_Toggle_Portal_Bearer_Portal";
Animation="Module_Card_Toggle_Portal_Bearer:Animation_Toggle_Portal_Bearer_Portal";
Position=%this.Position;
CollisionCallback="true";
Angle=%this.Angle-90;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this.Module_ID_Parent;

Game_Connection_Handle=%this.Game_Connection_Handle;

Health=100;

Object_Index=%this.Object_Index-1;

Vector_2D_Position_Offset=%this.Position;

Sprite_Connected_Portal=0;

};

%Sprite_Portal.setBlendColor(%this.getBlendColor());

%Previous_Portal=-1;

if (%Player_Object.Simset_Previous_Portal.getCount()>0)
{

%Previous_Portal=%Player_Object.Simset_Previous_Portal.getObject(0);

}

if (!isObject(%Previous_Portal))
{

%Sprite_Portal.Sprite_Connected_Portal=%Sprite_Portal;

%Player_Object.Simset_Previous_Portal.add(%Sprite_Portal);

}
else
{

%Sprite_Portal.Sprite_Connected_Portal=%Previous_Portal;

%Previous_Portal.Sprite_Connected_Portal=%Sprite_Portal;

%Player_Object.Simset_Previous_Portal.remove(%Previous_Portal);

}

Scene_Dots_and_Crits.add(%Sprite_Portal);

%Sprite_Portal.setCollisionGroups(0,25,26,30);

%Square_Size=%Sprite_Portal.size;

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Portal.createCircleCollisionShape(%Radius);

%Sprite_Portal.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_To_Direction=Vector2Direction(%Sprite_Portal.Angle,%Radius*1.25);

%Sprite_Portal.Vector_2D_Position_Offset=Vector2Add(%Sprite_Portal.Vector_2D_Position_Offset,%Vector_2D_To_Direction);

%this.Module_ID_Parent.Simset_Objects.add(%Sprite_Portal);

/********************************************************/

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}
