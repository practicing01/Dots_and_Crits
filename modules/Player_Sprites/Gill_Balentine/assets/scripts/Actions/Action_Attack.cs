function Module_Player_Sprite_Gill_Balentine::Action_Attack(%this,%Player_Information,%Object_Module_ID,%Object_Game_Connection_Handle,%Object_Index)
{

//Set attack animation.

if (%Player_Information.Bool_Is_Mobile)
{

if (%Player_Information.Vector_2D_Direction.X==0&&%Player_Information.Vector_2D_Direction.Y==0)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==0)
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==0)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Up.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Up_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Down_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Up_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Run_Melee_Down_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Melee_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}
else
{

if (%Player_Information.Vector_2D_Direction.X==0&&%Player_Information.Vector_2D_Direction.Y==0)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==0)
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==0)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Up.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Up_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Down_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Up_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Sprite.playAnimation
(
%Player_Information.Simset_Animation_Stand_Melee_Down_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Melee_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}

/*******************************************************************/

//Schedule a reset of animations so the attack animation doesn't loop.

//cancel(%Player_Information.Schedule_Animation_Reset);

//%Player_Information.Schedule_Animation_Reset=schedule(2000,0,"Module_Player_Sprite_Gill_Balentine::Animation_Reset",%this,%Player_Information);

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

%Object_Module_ID.Action_Update_Health(%Object,%Object.Game_Connection_Handle,1,%Player_Information.Current_Attack);

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

%Object_Module_ID.Action_Update_Health(%Player_Information,%Object.Game_Connection_Handle,%Object.Object_Index,1,%Player_Information.Current_Attack);

break;

}

}

}

}
