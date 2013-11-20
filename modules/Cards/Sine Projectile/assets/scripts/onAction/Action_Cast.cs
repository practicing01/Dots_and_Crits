function Module_Card_Sine_Projectile::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position)
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

%Angle=mRound((Vector2AngleToPoint(%Target_Player.Player_Sprite_Data.Composite_Sprite.Position,%Vector_2D_Position)+180)/*%360*/);

if (%Angle>=360){%Angle=%Angle%360;}

for (%x=0;%x<7;%x++)
{

%Sprite_Sine_Projectile=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Sine_Projectile);
Image="Module_Card_Sine_Projectile:Image_Sine_Projectile";
Animation="Module_Card_Sine_Projectile:Animation_Sine_Projectile";
class="Class_Sine_Projectile";
CollisionCallback="true";
SceneLayer=16;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index-%x;

Health=100;

Simset_Vector_2D_Wave_Nodes=0;

};

%Sprite_Sine_Projectile.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Square_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Sine_Projectile);

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Sine_Projectile.createCircleCollisionShape(%Radius);

%Sprite_Sine_Projectile.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Sprite_Sine_Projectile);

%Sprite_Sine_Projectile.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Sprite_Sine_Projectile.dismount();

%Sprite_Sine_Projectile.Position=%Sprite_Sine_Projectile.Position;

%this.Simset_Objects.add(%Sprite_Sine_Projectile);

/**********************************************************************/

%Simset_Vector_2D_Wave_Nodes=new SimSet();

%Vector_2D_Destination="0 0";

%New_Angle=%Angle+(%x*30);

if (%New_Angle>=360){%New_Angle=%New_Angle%360;}

%Simset_Vector_2D_Sine_Nodes=%this.Vector_2D_Table.getObject(%New_Angle);

for (%y=0;%y<%Simset_Vector_2D_Sine_Nodes.getCount();%y++)
{

%Vector_2D_Node=%Simset_Vector_2D_Sine_Nodes.getObject(%y);

%Vector_2D_Destination.X=%Vector_2D_Node.X;
%Vector_2D_Destination.Y=%Vector_2D_Node.Y;

%Vector_2D_Destination.X+=%Sprite_Sine_Projectile.Position.X;
%Vector_2D_Destination.Y+=%Sprite_Sine_Projectile.Position.Y;

%Vector_2D_Vector=new ScriptObject()
{

X=%Vector_2D_Destination.X;
Y=%Vector_2D_Destination.Y;

};

%Simset_Vector_2D_Wave_Nodes.add(%Vector_2D_Vector);

}

%Sprite_Sine_Projectile.Simset_Vector_2D_Wave_Nodes=%Simset_Vector_2D_Wave_Nodes;

%Vector_2D_Vector=%Sprite_Sine_Projectile.Simset_Vector_2D_Wave_Nodes.getObject(0);

%Vector_2D_Destination.X=%Vector_2D_Vector.X;
%Vector_2D_Destination.Y=%Vector_2D_Vector.Y;

%Sprite_Sine_Projectile.Simset_Vector_2D_Wave_Nodes.remove(%Vector_2D_Vector);

%Vector_2D_Vector.delete();

%Sprite_Sine_Projectile.moveTo(%Vector_2D_Destination,20,false,false);

}

}
