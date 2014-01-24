function Class_Summon_Unit::Animation_Reset(%this)
{

if (!isObject(%this)){return;}

if (%this.Bool_Is_Mobile)
{

if (%this.Vector_2D_Direction.X==0&&%this.Vector_2D_Direction.Y==0)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Down.getObject
(
getRandom(0,%this.Simset_Animation_Run_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==0)
{

if (%this.Vector_2D_Direction.X==1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Right.getObject
(
getRandom(0,%this.Simset_Animation_Run_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.X==-1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Left.getObject
(
getRandom(0,%this.Simset_Animation_Run_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%this.Vector_2D_Direction.X==0)
{

if (%this.Vector_2D_Direction.Y==1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Up.getObject
(
getRandom(0,%this.Simset_Animation_Run_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==-1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Down.getObject
(
getRandom(0,%this.Simset_Animation_Run_Down.getCount()-1)
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

%this.playAnimation
(
%this.Simset_Animation_Run_Up_Right.getObject
(
getRandom(0,%this.Simset_Animation_Run_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==-1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Down_Right.getObject
(
getRandom(0,%this.Simset_Animation_Run_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%this.Vector_2D_Direction.X==-1)
{

if (%this.Vector_2D_Direction.Y==1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Up_Left.getObject
(
getRandom(0,%this.Simset_Animation_Run_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%this.Vector_2D_Direction.Y==-1)
{

%this.playAnimation
(
%this.Simset_Animation_Run_Down_Left.getObject
(
getRandom(0,%this.Simset_Animation_Run_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}
else
{

if (%this.Vector_2D_Direction.X==0&&%this.Vector_2D_Direction.Y==0)
{

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

%this.playAnimation
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

}
