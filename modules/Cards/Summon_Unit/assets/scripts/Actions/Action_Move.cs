function Module_Card_Summon_Unit::Action_Move(%this,%Player_Information,%Vector_2D_Position,%Unit_Object_Index)
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

if (%Sprite_Unit.Vector_2D_Direction.X==0&&%Sprite_Unit.Vector_2D_Direction.Y==0)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Down.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==0)
{

if (%Sprite_Unit.Vector_2D_Direction.X==1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.X==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Sprite_Unit.Vector_2D_Direction.X==0)
{

if (%Sprite_Unit.Vector_2D_Direction.Y==1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Up.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Down.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Sprite_Unit.Vector_2D_Direction.X==1)
{

if (%Sprite_Unit.Vector_2D_Direction.Y==1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Up_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Down_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Sprite_Unit.Vector_2D_Direction.X==-1)
{

if (%Sprite_Unit.Vector_2D_Direction.Y==1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Up_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Down_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

/*******************************************/

%Sprite_Unit.Bool_Is_Mobile=true;

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
