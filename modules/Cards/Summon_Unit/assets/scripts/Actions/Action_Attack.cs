function Module_Card_Summon_Unit::Action_Attack(%this,%Player_Information,%Object_Module_ID,%Object_Game_Connection_Handle,%Object_Index,%Unit_Object_Index)
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

//Set command animation.

if (%Script_Object_Player.Bool_Is_Mobile)
{

if (%Script_Object_Player.Vector_2D_Direction.X==0&&%Script_Object_Player.Vector_2D_Direction.Y==0)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Down.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==0)
{

if (%Script_Object_Player.Vector_2D_Direction.X==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Right.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.X==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Left.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Script_Object_Player.Vector_2D_Direction.X==0)
{

if (%Script_Object_Player.Vector_2D_Direction.Y==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Up.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Down.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Script_Object_Player.Vector_2D_Direction.X==1)
{

if (%Script_Object_Player.Vector_2D_Direction.Y==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Up_Right.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Down_Right.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Script_Object_Player.Vector_2D_Direction.X==-1)
{

if (%Script_Object_Player.Vector_2D_Direction.Y==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Up_Left.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Run_Melee_Down_Left.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Run_Melee_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}
else
{

if (%Script_Object_Player.Vector_2D_Direction.X==0&&%Script_Object_Player.Vector_2D_Direction.Y==0)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Down.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==0)
{

if (%Script_Object_Player.Vector_2D_Direction.X==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Right.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.X==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Left.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Script_Object_Player.Vector_2D_Direction.X==0)
{

if (%Script_Object_Player.Vector_2D_Direction.Y==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Up.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Down.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Script_Object_Player.Vector_2D_Direction.X==1)
{

if (%Script_Object_Player.Vector_2D_Direction.Y==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Up_Right.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Down_Right.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Script_Object_Player.Vector_2D_Direction.X==-1)
{

if (%Script_Object_Player.Vector_2D_Direction.Y==1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Up_Left.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Script_Object_Player.Vector_2D_Direction.Y==-1)
{

%Script_Object_Player.Sprite.playAnimation
(
%Script_Object_Player.Simset_Animation_Stand_Melee_Down_Left.getObject
(
getRandom(0,%Script_Object_Player.Simset_Animation_Stand_Melee_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}

/*******************************************************************/

//Schedule a reset of animations so the attack animation doesn't loop.

//cancel(%Script_Object_Player.Sprite.Schedule_Animation_Reset);

//%Script_Object_Player.Sprite.Schedule_Animation_Reset=schedule(2000,0,%Script_Object_Player.Sprite.Module_ID_Parent @ "::Animation_Reset",%Script_Object_Player.Sprite.Module_ID_Parent,%Script_Object_Player);

/*******************************************************************/

//Animate Unit

if (%Sprite_Unit.Bool_Is_Mobile)
{

if (%Sprite_Unit.Vector_2D_Direction.X==0&&%Sprite_Unit.Vector_2D_Direction.Y==0)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Melee_Down.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Down.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Run_Melee_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.X==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Melee_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Left.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Run_Melee_Up.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Melee_Down.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Down.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Run_Melee_Up_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Melee_Down_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Down_Right.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Run_Melee_Up_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Run_Melee_Down_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Run_Melee_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}
else
{

if (%Sprite_Unit.Vector_2D_Direction.X==0&&%Sprite_Unit.Vector_2D_Direction.Y==0)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Stand_Melee_Down.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Down.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Stand_Melee_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.X==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Stand_Melee_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Left.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Stand_Melee_Up.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Stand_Melee_Down.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Down.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Stand_Melee_Up_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Stand_Melee_Down_Right.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Down_Right.getCount()-1)
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
%Sprite_Unit.Simset_Animation_Stand_Melee_Up_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)
{

%Sprite_Unit.playAnimation
(
%Sprite_Unit.Simset_Animation_Stand_Melee_Down_Left.getObject
(
getRandom(0,%Sprite_Unit.Simset_Animation_Stand_Melee_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}

/*******************************************************************/

//Schedule a reset of animations so the attack animation doesn't loop.

//cancel(%Sprite_Unit.Schedule_Animation_Reset);

//%Sprite_Unit.Schedule_Animation_Reset=schedule(2000,0,"Class_Summon_Unit::Animation_Reset",%Sprite_Unit);

/*******************************************************************/

//Go through object's module if the object exists based on game connection handle.

if (!isObject(%Object_Module_ID)){return;}

if (%Object_Index==-1)//Player being attacked.
{

for (%x=0;%x<%Object_Module_ID.Simset_Player_Information.getCount();%x++)
{

%Object=%Object_Module_ID.Simset_Player_Information.getObject(%x);

if (%Object.Game_Connection_Handle==%Object_Game_Connection_Handle)
{

%Object_Module_ID.Action_Update_Health(%Object,%Object.Game_Connection_Handle,1,%Sprite_Unit.Current_Attack);

break;

}

}

}
else
{

for (%x=0;%x<%Object_Module_ID.Simset_Objects.getCount();%x++)
{

%Object=%Object_Module_ID.Simset_Objects.getObject(%x);

if (%Object.Game_Connection_Handle==%Object_Game_Connection_Handle&&%Object.Object_Index==%Object_Index)
{

%Object_Module_ID.Action_Update_Health(%Player_Information,%Object.Game_Connection_Handle,%Object.Object_Index,1,%Sprite_Unit.Current_Attack);

break;

}

}

}

}
