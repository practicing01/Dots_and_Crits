function Scene_Object_Module_Card_Teleport_Input_Capture::onTouchDown(%this,%Touch_ID,%World_Position,%Mouse_Clicks)
{
/**************************************************/

if (%this.Module_ID_Parent.Bool_Waiting_For_Target)
{

%this.Module_ID_Parent.Bool_Waiting_For_Target=false;

%this.Module_ID_Parent.Card_Target=0;

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%World_Position,bit(0),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object.class$="Class_Composite_Sprite_Player")
{

%this.Module_ID_Parent.Card_Target=%Object;

break;

}

}

if (%this.Module_ID_Parent.Card_Target==0){return;}

%this.Module_ID_Parent.Bool_Waiting_For_Cast=true;

/*******************************************************/
//Set casting animation.
%Player_Information=%this.Module_ID_Parent.Card_Target.Script_Object_Parent;

if (%Player_Information.Bool_Is_Mobile)
{

if (%Player_Information.Vector_2D_Direction.X==0&&%Player_Information.Vector_2D_Direction.Y==0)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==0)
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==0)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Up.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Down.getCount()-1)
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

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Up_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Down_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Up_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Cast_Self_Down_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Cast_Self_Down_Left.getCount()-1)
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

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==0)
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==0)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Up.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Down.getCount()-1)
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

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Up_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Down_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Up_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Cast_Self_Down_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Cast_Self_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}

/*******************************************************/

}
else if (%this.Module_ID_Parent.Bool_Waiting_For_Cast)
{

%this.Module_ID_Parent.Bool_Waiting_For_Cast=false;

%this.Module_ID_Parent.Card_Cast(%this.Module_ID_Parent.Card_Target.Script_Object_Parent,%World_Position);

}

}
