function Class_Summon_Unit::onMoveToComplete(%this)
{

%this.Bool_Is_Mobile=false;

%this.setLinearDamping(%this.Linear_Damping);

if (%this.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

commandToServer('Relay_Module_Function',%this.Module_ID_Parent,"Action_Position",
%this.Game_Connection_Handle,%this.Object_Index,%this.Position);

}

if (%this.Vector_2D_Direction.X==0&&%this.Vector_2D_Direction.Y==0)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Down.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==0)
{

if (%this.Vector_2D_Direction.X==1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Right.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.X==-1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Left.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%this.Vector_2D_Direction.X==0)
{

if (%this.Vector_2D_Direction.Y==1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Up.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==-1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Down.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%this.Vector_2D_Direction.X==1)
{

if (%this.Vector_2D_Direction.Y==1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Up_Right.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==-1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Down_Right.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%this.Vector_2D_Direction.X==-1)
{

if (%this.Vector_2D_Direction.Y==1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Up_Left.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==-1)
{

%this.setSpriteAnimation
(
%this.Simset_Animation_Stand_Down_Left.getObject
(
getRandom(0,%this.Simset_Animation_Stand_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}
