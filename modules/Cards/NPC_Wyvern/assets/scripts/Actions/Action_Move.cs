function Module_Card_NPC_Wyvern::Action_Move(%this,%Player_Information,%Vector_2D_Position,%Unit_Object_Index)
{

%Script_Object_Player=%Player_Information.Player_Sprite_Data.Sprite.Script_Object_Parent;

%Sprite_Unit=-1;

for (%x=0;%x<%this.Simset_Objects.getCount();%x++)
{

%Object=%this.Simset_Objects.getObject(%x);

if (%Object.Object_Index==%Unit_Object_Index&&%Object.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

%Sprite_Unit=%Object;

break;

}

}

if (!isObject(%Sprite_Unit)){return;}

%Angle=(Vector2AngleToPoint(%Sprite_Unit.Position,%Vector_2D_Position)+180)%360;

if ((%Angle>=337.5&&%Angle<=360)||(%Angle>=0&&%Angle<22.5))//Left
{

%Sprite_Unit.Vector_2D_Direction.X=-1;

%Sprite_Unit.Vector_2D_Direction.Y=0;

}
else if ((%Angle>=22.5&&%Angle<67.5))//Down-Left
{

%Sprite_Unit.Vector_2D_Direction.X=-1;

%Sprite_Unit.Vector_2D_Direction.Y=-1;

}
else if ((%Angle>=67.5&&%Angle<112.5))//Down
{

%Sprite_Unit.Vector_2D_Direction.X=0;

%Sprite_Unit.Vector_2D_Direction.Y=-1;

}
else if ((%Angle>=112.5&&%Angle<157.5))//Down-Right
{

%Sprite_Unit.Vector_2D_Direction.X=1;

%Sprite_Unit.Vector_2D_Direction.Y=-1;

}
else if ((%Angle>=157.5&&%Angle<202.5))//Right
{

%Sprite_Unit.Vector_2D_Direction.X=1;

%Sprite_Unit.Vector_2D_Direction.Y=0;

}
else if ((%Angle>=202.5&&%Angle<247.5))//Up-Right
{

%Sprite_Unit.Vector_2D_Direction.X=1;

%Sprite_Unit.Vector_2D_Direction.Y=1;

}
else if ((%Angle>=247.5&&%Angle<292.5))//Up
{

%Sprite_Unit.Vector_2D_Direction.X=0;

%Sprite_Unit.Vector_2D_Direction.Y=1;

}
else if ((%Angle>=292.5&&%Angle<337.5))//Up-Left
{

%Sprite_Unit.Vector_2D_Direction.X=-1;

%Sprite_Unit.Vector_2D_Direction.Y=1;

}

%Sprite_Unit.Bool_Is_Mobile=true;

%Sprite_Unit.Animation_Set("Fly");

if (%Sprite_Unit.Current_Speed>0)
{

%Sprite_Unit.setLinearDamping(0);

%Sprite_Unit.moveTo(%Vector_2D_Position,%Sprite_Unit.Current_Speed,true,false);

}
else
{

%Sprite_Unit.onMoveToComplete();

}

}
